using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EmergencySite.Core.Models
{
    public class Login
    {
        public int LoginId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }

        [Required]
        [StringLength(255)]
        public string Username { get; set; }

        [Required]
        [StringLength(255)]
        public string Password { get; set; }

        [Required]
        [StringLength(255)]
        public string EncryptedPassword { get; set; }

        
        //constructor
        public Login()
        {
            CreatedAt = DateTime.Now;
        }
    }
}