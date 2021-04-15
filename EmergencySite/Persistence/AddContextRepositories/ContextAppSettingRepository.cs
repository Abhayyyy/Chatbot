using EmergencySite.Core.Types;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace EmergencySite.Persistence.AddContextRepositories
{
    public class ContextAppSettingRepository
    {
        private readonly CoronaDbContext context;

        public ContextAppSettingRepository()
        {
            context = new CoronaDbContext();
        }

        public async Task<int> Count()
           => await context.AppSettings
           .CountAsync(a => a.SFAuthentication == true);

        public async Task<int> GetAppSettingCount()
            => await context.AppSettings
            .CountAsync(a => a.AppSettingId != 0);

        public async Task<AppSettingType> GetAppSetting()
            => await context.AppSettings
            .Select(a => new AppSettingType
            {
                AppSettingId = a.AppSettingId,
                SFAuthentication = a.SFAuthentication,
            })
            .FirstOrDefaultAsync();
    }
}