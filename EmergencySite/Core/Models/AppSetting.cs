using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmergencySite.Core.Models
{
    public class AppSetting 
    {
        public int AppSettingId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedAt { get; set; }
        public bool SFAuthentication { get; set; }

        public AppSetting()
        {
            CreatedAt = DateTime.Now;
        }
    }
}