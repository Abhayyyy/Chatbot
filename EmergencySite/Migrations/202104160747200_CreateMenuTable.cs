namespace EmergencySite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateMenuTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Menus",
                c => new
                    {
                        MenuId = c.Int(nullable: false, identity: true),
                        MenuName = c.String(nullable: false, maxLength: 255),
                        ParentId = c.Int(),
                        MenuLink = c.String(maxLength: 255),
                        MenuOrder = c.Int(nullable: false),
                        CreatedAt = c.DateTime(nullable: false, defaultValueSql: "GETDATE()"),
                    })
                .PrimaryKey(t => t.MenuId);
        }
        
        public override void Down()
        {
            DropTable("dbo.Menus");
        }
    }
}
