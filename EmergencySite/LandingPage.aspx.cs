using EmergencySite.Persistence.AddContextRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmergencySite
{
    public partial class LandingPage : System.Web.UI.Page
    {
        private readonly ContextAppSettingRepository appSettingRepository;
        private readonly ContextLoginRepository loginRepository;
        private readonly ContextMessageRepository messageRepository;

        public LandingPage()
        {
            appSettingRepository = new ContextAppSettingRepository();
            loginRepository = new ContextLoginRepository();
            messageRepository = new ContextMessageRepository();
        }
        protected async void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;

            //if (Session["Username"] == null) return;

            if (!Convert.ToBoolean(Session["IsVerified"]))
            {
                var appsetting = await appSettingRepository.GetAppSetting();
                if (appsetting == null)
                {
                    //System.Threading.Thread.Sleep(2000);
                    RedirectToPage();
                    return;
                }

                if (appsetting.SFAuthentication)
                {
                    //System.Threading.Thread.Sleep(2000);
                    RedirectToPage();
                    return;
                }
            }

        }
        public void RedirectToPage()
        {
            //Response.Redirect("~/Authenticate/OtpSender.aspx");
            Response.Redirect("~/Authenticate/2FactorAuthentication.aspx");
        }
    }
}