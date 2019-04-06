namespace AvengersMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Güncelle : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Characters", "Description", c => c.String());
            AddColumn("dbo.Movies", "Description", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "Description");
            DropColumn("dbo.Characters", "Description");
        }
    }
}
