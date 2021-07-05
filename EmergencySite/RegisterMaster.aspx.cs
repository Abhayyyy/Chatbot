using EmergencySite.Core.Functions;
using EmergencySite.Core.Models;
using EmergencySite.Persistence.AddContextRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace EmergencySite
{
    public partial class RegisterMaster : Page
    {
        private readonly ContextAppSettingRepository appSettingRepository;
        private readonly ContextLoginRepository loginRepository;
        private readonly ContextMessageRepository messageRepository;

        public RegisterMaster()
        {
            appSettingRepository = new ContextAppSettingRepository();
            loginRepository = new ContextLoginRepository();
            messageRepository = new ContextMessageRepository();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Default.aspx", false);
        }

        protected async void btnRegister_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtFirstPass.Text.Trim())|| string.IsNullOrEmpty(txtSecondPass.Text.Trim()))
            {
                ScriptManager.RegisterStartupScript(btnLogin, GetType(), "JSCR", "alert('Password Fields cannot be empty.');", true);
                return;
            }
            if(txtFirstPass.Text.Trim() != txtSecondPass.Text.Trim())
            {
                ScriptManager.RegisterStartupScript(btnLogin, GetType(), "JSCR", "alert('Passwords do not match.');", true);
                return;
            }

            var username = txtUsernameId.Text.Trim();
            var pass = txtSecondPass.Text.Trim();

            var userInDb = await loginRepository.FindByUserName(username);
            if(userInDb != null)
            {
                ScriptManager.RegisterStartupScript(btnLogin, GetType(), "JSCR", "alert('User already exists with same email.');", true);
                return;
            }

            var executedBy = Convert.ToInt32(Session["LoginRid"]);

            var user = new Login
            {
                Username = username,
                Password = pass,
                EncryptedPassword = GeneralFunctions.EncryptPassword(pass),
                LoginId = executedBy,
            };

            loginRepository.context.Logins.Add(user);
            loginRepository.context.SaveChanges();

            ScriptManager.RegisterStartupScript(btnLogin, GetType(), "JSCR", "alert('User created successfully.');window.location='Default.aspx';", true);
            return;

        }

        protected void lnkForgotPassword_Click(object sender, EventArgs e)
        {

        }
    }
}