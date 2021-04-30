using System;
using System.Web.UI;
using System.Drawing;
using System.Data.Entity.Infrastructure;
using System.Data.Entity;
using EmergencySite.Core.Functions;
using EmergencySite.Core;
using EmergencySite.Persistence.AddContextRepositories;
using EmergencySite.Persistence;

namespace EmergencySite.Authenticate
{
    public partial class ChangePassword : Page
    {
        CoronaDbContext context = new CoronaDbContext();
        private readonly ContextAppSettingRepository appSettingRepository;
        private readonly ContextLoginRepository loginRepository;
        private readonly ContextMessageRepository messageRepository;
        public ChangePassword()
        {
            appSettingRepository = new ContextAppSettingRepository();
            loginRepository = new ContextLoginRepository();
            messageRepository = new ContextMessageRepository();
        }

    protected void Page_Load(object sender, EventArgs e)
        {
            if (Application["UserName"] == null)
            {
                Response.Redirect("~/Default.aspx", false);
                return;
            }
            txtEmail.Text = Application["UserName"].ToString().Trim();
        }

        protected async void btnUpdate_Click(object sender, EventArgs e)
        {
            bool validity = CaptchaId.Validate(txtCaptcha.Text.Trim());
            if (!validity)
            {
                ScriptManager.RegisterStartupScript(btnUpdate, GetType(), "JSCR", "alert('Enter valid security code.')", true);
                return;
            }

            //Code for checking user existence.
            var userId = txtEmail.Text.Trim();
            var loginType = await loginRepository.FindByUserName(userId);
            if (loginType == null)
            {
                ScriptManager.RegisterStartupScript(btnUpdate, GetType(), "JSCR",
                                                    "alert('Invalid userId.');", true);
                return;
            }
            hdnLoginRid.Value = loginType.LoginId.ToString();
            var loginrid = Convert.ToInt32(hdnLoginRid.Value);

            var login = await loginRepository.FindByLoginId(Convert.ToInt32(loginrid));

            var newPassword = txtNewPassword.Text.Trim();
            var confirmPassword = txtConfirmPassword.Text.Trim();

            if (newPassword != confirmPassword)
            {
                ScriptManager.RegisterStartupScript(btnUpdate, GetType(), "JSCR",
                                                    "alert('Password do not matched.');", true);
                return;
            }

            login.Password = newPassword;
            login.EncryptedPassword = GeneralFunctions.EncryptPassword(newPassword);
            //loginRepository.context.Entry(login).State = EntityState.Modified;
            await loginRepository.context.SaveChangesAsync();
            ScriptManager.RegisterStartupScript(btnUpdate, GetType(), "JSCR",
                                                    "alert('Password updated successfully.');", true);
            Response.Redirect("~/Default.aspx");
        }
    }
}