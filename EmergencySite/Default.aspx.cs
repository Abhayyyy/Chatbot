using EmergencySite.Core;
using EmergencySite.Core.Functions;
using EmergencySite.Persistence.AddContextRepositories;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmergencySite
{
    public partial class _Default : Page
    {
        private readonly ContextLoginRepository loginRepository;
        public _Default()
        {
            loginRepository = new ContextLoginRepository();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
        }


        protected async void btnLogin_Click(object sender, EventArgs e)
        {
            var username = txtUsernameId.Text.Trim();
            var password = txtPasswordId.Text.Trim();

            if (string.IsNullOrEmpty(txtUsernameId.Text.Trim()) || string.IsNullOrEmpty(txtPasswordId.Text.Trim()))
            {
                ScriptManager.RegisterStartupScript(btnLogin, GetType(), "JSCR",
                                      "alert('Please Enter Username and Password.');", true);
                return;
            }

            var userInDb = await loginRepository.FindByUserName(username);
            if (userInDb != null)
            {
                if (password != GeneralFunctions.DecryptPassword(userInDb.EncryptedPassword))
                    ScriptManager.RegisterStartupScript(btnLogin, GetType(), "JSCR", "alert('Oops! wrong password., Try again');", true);
                else {
                    Session.Add("Username", txtUsernameId.Text.Trim());
                    Session.Add("Password", txtPasswordId.Text.Trim());
                    Response.Redirect("LandingPage.aspx");
                }
                
            }

            //var login = new Login
            //{
            //    Username = username,
            //    Password = password,
            //    EncryptedPassword = GeneralFunctions.EncryptPassword(password.ToString()),
            //    ModifiedBy = username
            //}; 

            Session.Add("Username", txtUsernameId.Text.Trim());
            Session.Add("Password", txtPasswordId.Text.Trim());
        }
        protected void lnkForgotPassword_Click(object sender, EventArgs e)
        {
            if (txtUsernameId.Text.ToString() == "")
            {
                ScriptManager.RegisterStartupScript(lnkForgotPassword, GetType(), "JSCR", "alert('Username is required.');", true);
                return;
            }
            Application["UserName"] = txtUsernameId.Text.Trim();
            Response.Redirect("~/Authentication/Sendotp.aspx");
        }
    }
}