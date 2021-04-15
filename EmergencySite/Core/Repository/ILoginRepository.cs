using EmergencySite.Core.Models;
using EmergencySite.Core.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmergencySite.Core.Repository
{
    public interface ILoginRepository : IRepository<Login>
    {
        //Task<Models.Login> GetLoginWithRelatedById(int loginRid);
        Task<LoginType> FindByUserName(string userId);
    }
}
