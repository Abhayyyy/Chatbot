using System;
using System.Web.UI;
using System.Drawing;
using EmergencySite.Core.Functions;
using EmergencySite.Core;

namespace EmergencySite.Authenticate
{
    public partial class ChangePassword : Page
    {
        private readonly IUnitOfWork unitOfWork;
        public ChangePassword(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Application["UserName"] == null)
            {
                Response.Redirect("~/Login.aspx", false);
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
            var loginType = await unitOfWork.Logins.FindByUserName(userId);
            if (loginType == null)
            {
                ScriptManager.RegisterStartupScript(btnUpdate, GetType(), "JSCR",
                                                    "alert('Invalid userId.');", true);
                return;
            }
            hdnLoginRid.Value = loginType.LoginId.ToString();
            var loginrid = Convert.ToInt32(hdnLoginRid.Value);

            var login = await unitOfWork.Logins.Get(Convert.ToInt32(loginrid));

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
            await unitOfWork.CompleteAsync();
            ScriptManager.RegisterStartupScript(btnUpdate, GetType(), "JSCR",
                                                    "alert('Password updated successfully.');", true);
            Response.Redirect("~/Default.aspx");
        }
    }
}