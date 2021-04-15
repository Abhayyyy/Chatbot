using System;
using System.Web.UI;
using System.IO;
using EmergencySite.Core;
using EmergencySite.Core.Models;
using EmergencySite.Core.Functions;
using EmergencySite.ClassLibraries.Models.Email;
using System.Collections;
using EmergencySite.ClassLibraries.BusinessLayer.EmailBal;

namespace EmergencySite.Authenticate
{
    public partial class Message : Page
    {
        private readonly IUnitOfWork unitOfWork;
        public Message(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;

            if (Application["UserName"] == null)
            {
                Response.Redirect("~/Login.aspx", false);
                return;
            }
            txtEmail.Text = Application["UserName"].ToString().Trim();
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

        protected async void btnVerify_Click(object sender, EventArgs e)
        {
            var content = await unitOfWork.Messages.FindByOTP(txtOtp.Text.Trim());
            if (content == null)
            {
                ScriptManager.RegisterStartupScript(btnSendOTP, GetType(), "JSCR",
                                                    "alert('Invalid OTP.');", true);
                return;
            }

            var createdAt = content.CreatedAt.AddMinutes(10);
            if(DateTime.Now > createdAt)
            {
                ScriptManager.RegisterStartupScript(btnSendOTP, GetType(), "JSCR",
                                    "alert('OTP Verification Failed.');", true);
                return;
            }

            ScriptManager.RegisterStartupScript(btnSendOTP, GetType(), "JSCR",
                                                "alert('OTP Verified.');", true);

            Application["UserName"] = txtEmail.Text.Trim();
            Response.Redirect("ChangePassword.aspx");
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
            var userId = txtEmail.Text.Trim();
            var loginType = await unitOfWork.Logins.FindByUserName(userId);
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

            var message = new EmergencySite.Core.Models.Message
            {
                CreatedBy = loginrid,
                LoginRid = loginrid,
                Content = otp
            };

            unitOfWork.Messages.Add(message);

            await unitOfWork.CompleteAsync();

            var status = isSent ? "success" : "failure";
            var response = new { status, dateTime };

            ScriptManager.RegisterStartupScript(btnSendOTP, GetType(), "JSCR",
                                                    "alert('The OTP has been sent and will expire in 10 minutes.');", true);

            await unitOfWork.CompleteAsync();
        }
    }
}