using EmergencySite.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmergencySite.Core
{
    public interface IUnitOfWork : IDisposable
    {
        ILoginRepository Logins { get; }
        IAppSettingRepository AppSettings { get; }
        IMessageRepository Messages { get; }

        Task CompleteAsync();
    }
}
