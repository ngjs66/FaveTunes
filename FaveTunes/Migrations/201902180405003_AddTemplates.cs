namespace FaveTunes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTemplates : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tunes", "Artist", c => c.String());
            AddColumn("dbo.Tunes", "Album", c => c.String());
            DropColumn("dbo.Tunes", "Rating");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Tunes", "Rating", c => c.String());
            DropColumn("dbo.Tunes", "Album");
            DropColumn("dbo.Tunes", "Artist");
        }
    }
}
