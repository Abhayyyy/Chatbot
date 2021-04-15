namespace EmergencySite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateLoginTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Logins",
                c => new
                    {
                        LoginId = c.Int(nullable: false, identity: true),
                        CreatedAt = c.DateTime(nullable: false, defaultValueSql: "GETDATE()"),
                        ModifiedAt = c.DateTime(),
                        Username = c.String(nullable: false, maxLength: 255),
                        Password = c.String(nullable: false, maxLength: 255),
                        EncryptedPassword = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.LoginId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Logins");
        }
    }
}
