namespace Demo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dropimage : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Fruits", "Image");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Fruits", "Image", c => c.String());
        }
    }
}
