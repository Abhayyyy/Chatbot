using System.Net.Mail;
using System.Runtime.Serialization;

namespace EmergencySite.ClassLibraries.Models.Email
{
    [DataContract]
    public class EmailERP
    {
        [DataMember]
        public string FromAddress { get; set; }

        [DataMember]
        public string FromName { get; set; }

        [DataMember]
        public string Password { get; set; }

        [DataMember]
        public string ToAddress { get; set; }

        [DataMember]
        public string CCAddress { get; set; }

        [DataMember]
        public string Subject { get; set; }

        [DataMember]
        public Attachment Attachment { get; set; }

        [DataMember]
        public string MailBody { get; set; }
        
        [DataMember]
        public AlternateView AlternateView { get; set; }
    }

   
}
