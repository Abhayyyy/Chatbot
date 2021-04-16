using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EmergencySite.Core.Models
{
    public class Menu
    {
        public int MenuId { get; set; }

        [Required]
        [StringLength(255)]
        public string MenuName { get; set; }

        public int? ParentId { get; set; }

        [StringLength(255)]
        public string MenuLink { get; set; }

        public int MenuOrder { get; set; }

        public DateTime CreatedAt { get; set; }

        public Menu()
        {
            CreatedAt = DateTime.Now;
        }
    }
}