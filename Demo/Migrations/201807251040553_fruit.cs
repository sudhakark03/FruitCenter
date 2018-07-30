namespace Demo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fruit : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Fruits",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        F_Name = c.String(),
                        Image = c.String(),
                        Price = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            DropTable("dbo.Dtps");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Dtps",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            DropTable("dbo.Fruits");
        }
    }
}
