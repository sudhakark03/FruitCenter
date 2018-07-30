namespace Demo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dpttable : DbMigration
    {
        public override void Up()
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
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Dtps");
        }
    }
}
