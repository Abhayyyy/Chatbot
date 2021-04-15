namespace EmergencySite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAppSettingAndMessageTableToDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AppSettings",
                c => new
                    {
                        AppSettingId = c.Int(nullable: false, identity: true),
                        CreatedBy = c.Int(nullable: false),
                        CreatedAt = c.DateTime(nullable: false, defaultValueSql: "GETDATE()"),
                        ModifiedBy = c.Int(),
                        ModifiedAt = c.DateTime(),
                        SFAuthentication = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.AppSettingId);
            
            CreateTable(
                "dbo.Messages",
                c => new
                    {
                        MessageId = c.Int(nullable: false, identity: true),
                        CreatedBy = c.Int(nullable: false),
                        CreatedAt = c.DateTime(nullable: false, defaultValueSql: "GETDATE()"),
                        ModifiedBy = c.Int(),
                        ModifiedAt = c.DateTime(),
                        LoginRid = c.Int(nullable: false),
                        Content = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.MessageId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Messages");
            DropTable("dbo.AppSettings");
        }
    }
}
