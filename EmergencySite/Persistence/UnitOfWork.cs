using EmergencySite.Core;
using EmergencySite.Core.Repository;
using EmergencySite.Persistence.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace EmergencySite.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly CoronaDbContext context;
        public UnitOfWork()
        {
        }
        public UnitOfWork(CoronaDbContext context)
        {
            this.context = context;
            Messages = new MessageRepository(context);
            //Logins = new AppSettingRepository(context);
            //AppSettings = new LoginRepository(context);
        }

        public ILoginRepository Logins { get; private set; }
        public IAppSettingRepository AppSettings { get; private set; }
        public IMessageRepository Messages { get; private set; }



        public async Task CompleteAsync()
        {
            await context.SaveChangesAsync();
        }

        public void Dispose()
        {
            context.Dispose();
        }

    }
}