namespace Demo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adddatatype : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Fruits", "Image", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Fruits", "Image", c => c.Binary());
        }
    }
}
