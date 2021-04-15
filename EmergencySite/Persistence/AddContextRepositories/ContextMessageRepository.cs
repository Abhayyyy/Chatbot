using EmergencySite.Core.Types;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace EmergencySite.Persistence.AddContextRepositories
{
    public class ContextMessageRepository
    {
        public readonly CoronaDbContext context;

        public ContextMessageRepository()
        {
            context = new CoronaDbContext();
        }
        public async Task<MessageType> FindByOTP(string otp)
        {
            return await context.Messages
                .Select(m => new MessageType
                {
                    MessageId = m.MessageId,
                    CreatedAt = m.CreatedAt,
                    Content = m.Content
                })
                .SingleOrDefaultAsync(m => m.Content == otp);
        }
    }
}