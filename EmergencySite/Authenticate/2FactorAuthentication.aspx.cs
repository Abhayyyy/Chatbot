using EmergencySite.ClassLibraries.BusinessLayer.EmailBal;
using EmergencySite.ClassLibraries.Models.Email;
using EmergencySite.Core;
using EmergencySite.Core.Functions;
using EmergencySite.Persistence.AddContextRepositories;
using System;
using System.Collections;
using System.IO;
using System.Web.UI;

namespace EmergencySite.Authenticate
{
    public partial class _2FactorAuthentication : Page
    {
        //private readonly IUnitOfWork unitOfWork;
        private readonly ContextAppSettingRepository appSettingRepository;
        private readonly ContextLoginRepository loginRepository;
        private readonly ContextMessageRepository messageRepository;

        public _2FactorAuthentication()
        {
            appSettingRepository = new ContextAppSettingRepository();
            loginRepository = new ContextLoginRepository();
            messageRepository = new ContextMessageRepository();
        }

        protected async void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;

            if (Session["UserName"] == null)
            {
                Response.Redirect("~/Default.aspx", false);
                return;
            }

            txtUsername.Text = Session["UserId"].ToString().Trim();

            if (Convert.ToBoolean(Session["IsVerified"]))
            {
                Response.Redirect("~/LandingPage.aspx", false);
                return;
            }

            var appsetting = await appSettingRepository.GetAppSetting();
            if (appsetting == null) return;

            if (!appsetting.SFAuthentication)
            {
                Response.Redirect("~/LandingPage.aspx", false);
                return;
            }
        }

        private string createEmailBody(string otp)
        {
            string body = string.Empty;
            //using streamreader for reading my htmltemplate  
            using (StreamReader reader = new StreamReader(Server.MapPath("~/CustomOTPMailPage.html")))
            {
                body = reader.ReadToEnd();
            }
            body = body.Replace("{code}", otp); //replacing the required things  
            return body;
        }

        protected async void btnAuthVerify_Click(object sender, EventArgs e)
        {
            var content = await messageRepository.FindByOTP(txtTwoFactorAuth.Text.Trim());
            if (content == null)
            {
                ScriptManager.RegisterStartupScript(btnSendOTP, GetType(), "JSCR",
                                                    "alert('Invalid OTP.');", true);
                return;
            }

            var createdAt = content.CreatedAt.AddMinutes(10);
            if (DateTime.Now > createdAt)
            {
                ScriptManager.RegisterStartupScript(btnSendOTP, GetType(), "JSCR",
                                    "alert('OTP Verification Failed.');", true);
                return;
            }

            Session["IsVerified"] = true;
            Response.Redirect("~/Default.aspx", false);
        }


        protected async void btnSendOTP_Click(object sender, EventArgs e)
        {
            var dateTime = DateTime.Now;
            string otp = GeneralFunctions.GenerateRandomOTP().ToString();
            string OTP = createEmailBody(otp);

            EmailERP emailERP = new EmailERP
            {
                FromAddress = "erp.support@sisrtd.com",
                Password = "6I$12xbq",
                FromName = "WE-SIS",
                Subject = "One-Time Security Code",
                MailBody = OTP
            };

            var toAddressList = new ArrayList();
            var ccAddressList = new ArrayList();

            // Code for checking user existence.
            var userId = txtUsername.Text.Trim();
            var loginType = await loginRepository.FindByUserName(userId);
            if (loginType == null)
            {
                ScriptManager.RegisterStartupScript(btnSendOTP, GetType(), "JSCR",
                                                    "alert('Invalid userId.');", true);
                return;
            }

            toAddressList.Add(userId);
            var isSent = await EmailBal.SendMailAsync(emailERP, toAddressList, ccAddressList);
            if (!isSent)
            {
                ScriptManager.RegisterStartupScript(btnSendOTP, GetType(), "JSCR",
                                                    "alert('Email could not be sent.');", true);
                return;
            }

            btnSendOTP.Enabled = !isSent;

            hdnLoginRid.Value = loginType.LoginId.ToString();
            var loginrid = Convert.ToInt32(hdnLoginRid.Value);

            var message = new Core.Models.Message
            {
                CreatedBy = loginrid,
                LoginRid = loginrid,
                Content = otp
            };

            messageRepository.context.Messages.Add(message);

            messageRepository.context.SaveChanges();

            var status = isSent ? "success" : "failure";
            var response = new { status, dateTime };

            ScriptManager.RegisterStartupScript(btnSendOTP, GetType(), "JSCR",
                                                    "alert('The OTP has been sent and will expire in 10 minutes.');", true);

            messageRepository.context.SaveChanges();
        }
    }
}