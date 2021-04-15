using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EmergencySite.Core.Models
{
    public class Message
    {
        public int MessageId { get; set; }

        public int CreatedBy { get; set; }

        public DateTime CreatedAt { get; set; }

        public int? ModifiedBy { get; set; }

        public DateTime? ModifiedAt { get; set; }

        public int LoginRid { get; set; }

        [Required]
        [StringLength(255)]
        public string Content { get; set; }

        //constructor
        public Message()
        {
            CreatedAt = DateTime.Now;
        }
    }
}