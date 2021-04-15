using EmergencySite.Core.Repository;
using EmergencySite.Core.Types;
using EmergencySite.Persistence.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace EmergencySite.Persistence.Repositories
{
    public class LoginRepository : Repository<Core.Models.Login>, ILoginRepository
    {
        public LoginRepository(CoronaDbContext context)
            : base(context)
        {
        }

        public CoronaDbContext CoronaDbContext
        {
            get { return (CoronaDbContext)context; }
        }

        //public async Task<Core.Models.Login> GetLoginWithRelatedById(int loginRid)
        //{
        //    return await CoronaDbContext.Logins
        //        .Include(l => l.UserInfo)
        //        .Include(l => l.UserBankDetail)
        //        .FirstOrDefaultAsync(l => l.LoginRid == loginRid);
        //}
        public async Task<LoginType> FindByUserName(string userId)
            => await CoronaDbContext.Logins
                .Select(l => new LoginType
                {
                    LoginId = l.LoginId,
                    UserName = l.Username,
                    EncryptedPassword = l.Password
                })
                .SingleOrDefaultAsync(l => l.UserName == userId);
        }
    }