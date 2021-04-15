using AutoMapper;
using EmergencySite.Core.Models;
using EmergencySite.Persistence.AddContextRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmergencySite.Master
{
    public partial class AppSettingMaster : Page
    {
        //private readonly IUnitOfWork unitOfWork;
        private readonly ContextAppSettingRepository appSettingRepository;

        public AppSettingMaster()
        {
            appSettingRepository = new ContextAppSettingRepository();
            //this.unitOfWork = unitOfWork;
        }
        protected async void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;
            await PopulateAppSetting();
        }

        public async Task PopulateAppSetting()
        {
            var appSetting = await appSettingRepository.GetAppSetting();

            if (appSetting == null) return;

            hdnAppSettingId.Value = appSetting.AppSettingId.ToString();

            cbSFAuthentication.Checked = appSetting.SFAuthentication;
        }

        protected async void btnSubmit_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(hdnAppSettingId.Value))
            {
                //create..
                var appSetting = new AppSetting
                {
                    SFAuthentication = cbSFAuthentication.Checked,
                    CreatedBy = Convert.ToInt32(Session["LoginRid"])
                };

                appSettingRepository.context.AppSettings.Add(appSetting);

                appSettingRepository.context.SaveChanges();
             
            
                ScriptManager.RegisterStartupScript(cbSFAuthentication, GetType(), "JSCR", "alert('App Setting Created Successfully.');", true);

                hdnAppSettingId.Value = appSetting.AppSettingId.ToString();
            } 
            else
            {
                var appSettingId = Convert.ToInt32(hdnAppSettingId.Value);
                var appSettingInDb = await appSettingRepository.context.AppSettings.FindAsync(appSettingId);

                //update..
                appSettingInDb.SFAuthentication = cbSFAuthentication.Checked;
                appSettingInDb.ModifiedBy = Convert.ToInt32(Session["LoginRid"]);
                appSettingInDb.ModifiedAt = DateTime.Now;

                appSettingRepository.context.SaveChanges();

                ScriptManager.RegisterStartupScript(cbSFAuthentication, GetType(), "JSCR", "alert('App Setting Updated Successfully.');", true);

            }


        }
    }
}