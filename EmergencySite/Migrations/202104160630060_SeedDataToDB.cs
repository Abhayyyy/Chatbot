namespace EmergencySite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedDataToDB : DbMigration
    {
        public override void Up()
        {
            //Sql("INSERT INTO [dbo].[Logins] ([CreatedAt],[Username],[Password],[EncryptedPassword])VALUES('2021-04-16 10:00:45.667', 'abhay.gupta@sisrtd.com', '12345', 'LKAekHU9EtweB49HAaTRfg==')");
            //Sql("INSERT INTO [dbo].[Logins] ([CreatedAt],[Username],[Password],[EncryptedPassword])VALUES('2021-04-28 16:02:45.667', 'vineetshukla14u@gmail.com', 'vineet14u', '0qYedLcUB9O6lAXr9Z6egg====')");
        }

        public override void Down()
        {
        }
    }
}
