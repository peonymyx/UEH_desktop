namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _30 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Chats", "NoiDung", c => c.String(nullable: false, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Chats", "NoiDung", c => c.Binary(nullable: false));
        }
    }
}
