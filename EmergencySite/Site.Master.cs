﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmergencySite
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;
            //if (Session["UserName"] == null)
            //{
            //    Response.Redirect("~/Default.aspx", false);
            //}
        }

        protected void lnkChangePassword_Click(object sender, EventArgs e)
        {

        }

        protected void HeadLoginView_ViewChanged(object sender, EventArgs e)
        {

        }
    }
}