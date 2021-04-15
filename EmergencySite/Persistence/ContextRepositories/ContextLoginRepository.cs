using EmergencySite.Core.Types;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace EmergencySite.Persistence.AddContextRepositories
{
    public class ContextLoginRepository
    {
        private readonly CoronaDbContext context;

        public ContextLoginRepository()
        {
            context = new CoronaDbContext();
        }
        public async Task<LoginType> FindByUserName(string userId)
            => await context.Logins
                .Select(l => new LoginType
                {
                    LoginId = l.LoginId,
                    UserName = l.Username,
                    EncryptedPassword = l.EncryptedPassword
                })
                .SingleOrDefaultAsync(l => l.UserName == userId);
    }
}