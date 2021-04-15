using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmergencySite.Core.Types
{
    public class MessageType
    {
        public int MessageId { get; set; }

        public DateTime CreatedAt { get; set; }

        public string Content { get; set; }
    }
}