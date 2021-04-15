using EmergencySite.Core.Models;
using EmergencySite.Core.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmergencySite.Core.Repository
{
    public interface IMessageRepository : IRepository<Message>
    {
        Task<MessageType> FindByOTP(string otp);
    }
}
