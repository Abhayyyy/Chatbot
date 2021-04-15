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
    public class MessageRepository : Repository<Message>, IMessageRepository
    {
        public MessageRepository(CoronaDbContext context)
            : base(context)
        {
        }

        public CoronaDbContext CoronaDbContext
        {
            get { return (CoronaDbContext)context; }
        }

        public async Task<MessageType> FindByOTP(string otp)
        {
            return await CoronaDbContext.Messages
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