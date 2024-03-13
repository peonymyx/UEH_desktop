namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.HDDRLs", "TieuDe", c => c.String(nullable: false, unicode: false));
            AddColumn("dbo.HDDRLs", "NoiDung", c => c.String(nullable: false, unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.HDDRLs", "NoiDung");
            DropColumn("dbo.HDDRLs", "TieuDe");
        }
    }
}
