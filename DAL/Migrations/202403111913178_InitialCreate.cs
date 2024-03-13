namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BaiNops",
                c => new
                    {
                        MaBaiNop = c.String(nullable: false, maxLength: 128, storeType: "nvarchar"),
                        MSSV = c.String(maxLength: 128, storeType: "nvarchar"),
                        MaBT = c.String(maxLength: 128, storeType: "nvarchar"),
                        MaLopHoc = c.String(maxLength: 128, storeType: "nvarchar"),
                        NoiDung = c.Binary(nullable: false),
                        CreateAt = c.DateTime(nullable: false, precision: 0),
                        Diem = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.MaBaiNop)
                .ForeignKey("dbo.BaiTaps", t => t.MaBT)
                .ForeignKey("dbo.Courses", t => t.MaLopHoc)
                .ForeignKey("dbo.SinhViens", t => t.MSSV)
                .Index(t => t.MSSV)
                .Index(t => t.MaBT)
                .Index(t => t.MaLopHoc);
            
            CreateTable(
                "dbo.BaiTaps",
                c => new
                    {
                        MaBT = c.String(nullable: false, maxLength: 128, storeType: "nvarchar"),
                        MaGV = c.String(maxLength: 128, storeType: "nvarchar"),
                        MaLopHoc = c.String(maxLength: 128, storeType: "nvarchar"),
                        _NoiDung = c.Binary(nullable: false),
                        CreateAt = c.DateTime(nullable: false, precision: 0),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.MaBT)
                .ForeignKey("dbo.Courses", t => t.MaLopHoc)
                .ForeignKey("dbo.GiangViens", t => t.MaGV)
                .Index(t => t.MaGV)
                .Index(t => t.MaLopHoc);
            
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        MaLopHoc = c.String(nullable: false, maxLength: 128, storeType: "nvarchar"),
                        MonHoc = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.MaLopHoc);
            
            CreateTable(
                "dbo.GiangViens",
                c => new
                    {
                        MaGV = c.String(nullable: false, maxLength: 128, storeType: "nvarchar"),
                        HoTen = c.String(nullable: false, unicode: false),
                        Password = c.String(nullable: false, unicode: false),
                        Email = c.String(nullable: false, unicode: false),
                        Role = c.Boolean(nullable: false),
                        Status = c.Boolean(nullable: false),
                        Birth = c.DateTime(nullable: false, precision: 0),
                        Online = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.MaGV);
            
            CreateTable(
                "dbo.SinhViens",
                c => new
                    {
                        MSSV = c.String(nullable: false, maxLength: 128, storeType: "nvarchar"),
                        HoTen = c.String(nullable: false, unicode: false),
                        Password = c.String(nullable: false, unicode: false),
                        Email = c.String(nullable: false, unicode: false),
                        Status = c.Boolean(nullable: false),
                        Birth = c.DateTime(nullable: false, precision: 0),
                        Online = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.MSSV);
            
            CreateTable(
                "dbo.Chats",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128, storeType: "nvarchar"),
                        MSSVMaGV = c.String(nullable: false, maxLength: 128, storeType: "nvarchar"),
                    CreateAt = c.DateTime(nullable: false, precision: 0),
                        NoiDung = c.Binary(nullable: false),
                        MaLopHoc = c.String(nullable: false, maxLength: 128, storeType: "nvarchar"),
                    
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Course_member",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128, storeType: "nvarchar"),
                        MaLopHoc = c.String(maxLength: 128, storeType: "nvarchar"),
                        MaGV = c.String(maxLength: 128, storeType: "nvarchar"),
                        MSSV = c.String(maxLength: 128, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Courses", t => t.MaLopHoc)
                .ForeignKey("dbo.GiangViens", t => t.MaGV)
                .ForeignKey("dbo.SinhViens", t => t.MSSV)
                .Index(t => t.MaLopHoc)
                .Index(t => t.MaGV)
                .Index(t => t.MSSV);
            
            CreateTable(
                "dbo.HDDRLs",
                c => new
                    {
                        MaHD = c.String(nullable: false, maxLength: 128, storeType: "nvarchar"),
                        Timeline = c.DateTime(nullable: false, precision: 0),
                        Status = c.Boolean(nullable: false),
                        CreateAt = c.DateTime(nullable: false, precision: 0),
                    })
                .PrimaryKey(t => t.MaHD);
            
            CreateTable(
                "dbo.SvDaDangKies",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128, storeType: "nvarchar"),
                        MaHD = c.String(maxLength: 128, storeType: "nvarchar"),
                        MSSV = c.String(maxLength: 128, storeType: "nvarchar"),
                        CreateAt = c.DateTime(nullable: false, precision: 0),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.HDDRLs", t => t.MaHD)
                .ForeignKey("dbo.SinhViens", t => t.MSSV)
                .Index(t => t.MaHD)
                .Index(t => t.MSSV);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SvDaDangKies", "MSSV", "dbo.SinhViens");
            DropForeignKey("dbo.SvDaDangKies", "MaHD", "dbo.HDDRLs");
            DropForeignKey("dbo.Course_member", "MSSV", "dbo.SinhViens");
            DropForeignKey("dbo.Course_member", "MaGV", "dbo.GiangViens");
            DropForeignKey("dbo.Course_member", "MaLopHoc", "dbo.Courses");
            DropForeignKey("dbo.BaiNops", "MSSV", "dbo.SinhViens");
            DropForeignKey("dbo.BaiNops", "MaLopHoc", "dbo.Courses");
            DropForeignKey("dbo.BaiNops", "MaBT", "dbo.BaiTaps");
            DropForeignKey("dbo.BaiTaps", "MaGV", "dbo.GiangViens");
            DropForeignKey("dbo.BaiTaps", "MaLopHoc", "dbo.Courses");
            DropIndex("dbo.SvDaDangKies", new[] { "MSSV" });
            DropIndex("dbo.SvDaDangKies", new[] { "MaHD" });
            DropIndex("dbo.Course_member", new[] { "MSSV" });
            DropIndex("dbo.Course_member", new[] { "MaGV" });
            DropIndex("dbo.Course_member", new[] { "MaLopHoc" });
            DropIndex("dbo.BaiTaps", new[] { "MaLopHoc" });
            DropIndex("dbo.BaiTaps", new[] { "MaGV" });
            DropIndex("dbo.BaiNops", new[] { "MaLopHoc" });
            DropIndex("dbo.BaiNops", new[] { "MaBT" });
            DropIndex("dbo.BaiNops", new[] { "MSSV" });
            DropTable("dbo.SvDaDangKies");
            DropTable("dbo.HDDRLs");
            DropTable("dbo.Course_member");
            DropTable("dbo.Chats");
            DropTable("dbo.SinhViens");
            DropTable("dbo.GiangViens");
            DropTable("dbo.Courses");
            DropTable("dbo.BaiTaps");
            DropTable("dbo.BaiNops");
        }
    }
}
