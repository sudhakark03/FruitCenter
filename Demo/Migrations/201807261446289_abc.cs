namespace Demo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class abc : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.USERs",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        Username = c.String(nullable: false),
                        Password = c.String(nullable: false, maxLength: 50),
                        ConfirmPassword = c.String(),
                        FullName = c.String(nullable: false),
                        EmailID = c.String(),
                    })
                .PrimaryKey(t => t.UserID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.USERs");
        }
    }
}
