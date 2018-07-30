namespace Demo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addimage : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Fruits", "Image", c => c.Binary());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Fruits", "Image");
        }
    }
}
