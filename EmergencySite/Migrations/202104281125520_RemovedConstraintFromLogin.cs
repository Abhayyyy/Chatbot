namespace EmergencySite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovedConstraintFromLogin : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Logins", "EncryptedPassword", c => c.String(maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Logins", "EncryptedPassword", c => c.String(nullable: false, maxLength: 255));
        }
    }
}
