using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;

namespace EmergencySite.Core.Executors
{
    public class MailAddressExecutor
    {
        public string To { get; set; }
        public string CC { get; set; }
        public string Bcc { get; set; }
        public MailMessage MailMessage { get; set; }

    }
}