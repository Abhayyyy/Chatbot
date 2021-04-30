using EmergencySite.Core.Models;
using EmergencySite.Core.Repository;
using EmergencySite.Core.Types;
using EmergencySite.Persistence.Repositories;
using EmergencySite.Persistence.Repository;
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
        public readonly CoronaDbContext context;

        public ContextLoginRepository()
        {
            this.context = new CoronaDbContext();
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
        
        public async Task<Login> FindByLoginId(int loginId)
            => await context.Logins
                .SingleOrDefaultAsync(l => l.LoginId == loginId);
    }
}