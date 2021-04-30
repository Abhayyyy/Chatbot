using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmergencySite.Core.Types
{
    public class LoginType
    {
        public int LoginId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public string EncryptedPassword { get; set; }
    }
}