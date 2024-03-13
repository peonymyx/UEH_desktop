namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _20 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Chats", "MaLopHoc", c => c.String(maxLength: 128, storeType: "nvarchar"));
            CreateIndex("dbo.Chats", "MaLopHoc");
            AddForeignKey("dbo.Chats", "MaLopHoc", "dbo.Courses", "MaLopHoc");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Chats", "MaLopHoc", "dbo.Courses");
            DropIndex("dbo.Chats", new[] { "MaLopHoc" });
            AlterColumn("dbo.Chats", "MaLopHoc", c => c.String(unicode: false));
        }
    }
}
