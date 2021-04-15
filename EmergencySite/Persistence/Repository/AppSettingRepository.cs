using EmergencySite.Core.Models;
using EmergencySite.Core.Repository;
using EmergencySite.Core.Types;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace EmergencySite.Persistence.Repository
{
    public class AppSettingRepository : Repository<AppSetting>, IAppSettingRepository
    {
        public AppSettingRepository(CoronaDbContext context) : base(context)
        {
        }
        public CoronaDbContext CoronaDbContext
        {
            get { return (CoronaDbContext)context; }
        }

        public async Task<int> Count()
           => await CoronaDbContext.AppSettings
           .CountAsync(a => a.SFAuthentication == true);

        public async Task<int> GetAppSettingCount()
            => await CoronaDbContext.AppSettings
            .CountAsync(a => a.AppSettingId != 0);

        public async Task<AppSettingType> GetAppSetting()
            => await CoronaDbContext.AppSettings
            .Select(a => new AppSettingType
            {
                AppSettingId = a.AppSettingId,
                SFAuthentication = a.SFAuthentication,
            })
            .FirstOrDefaultAsync();
    }
}