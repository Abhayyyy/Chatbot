using EmergencySite.Core.Models;
using EmergencySite.Core.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmergencySite.Core.Repository
{
    public interface IAppSettingRepository : IRepository<AppSetting>
    {
        Task<int> Count();
        Task<AppSettingType> GetAppSetting();
        Task<int> GetAppSettingCount();
    }

}
