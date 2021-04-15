using EmergencySite.Core.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EmergencySite.Persistence
{
    public class CoronaDbContext : DbContext
    {
        public CoronaDbContext() : base("name=CoronaDbContext")
        {
        }

        public DbSet<Login> Logins { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<AppSetting> AppSettings { get; set; }

    }
}