using DAL.Model;
using MySql.Data.EntityFramework;
using System.Data.Entity;


namespace DAL
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    internal class DBConnect : DbContext
    {
        public DbSet<GiangVien> GiangVien { get; set; }
        public DbSet<SinhVien> SinhVien { get; set; }
        public DbSet<Courses> Course { get; set; }
        public DbSet<BaiNop> BaiNop { get; set; }
        public DbSet<BaiTap> BaiTap { get; set; }
        public DbSet<HDDRL> HDDRL { get; set; }
        public DbSet<Course_member> Course_Members { get; set; }
        public DbSet<SvDaDangKy> SvDaDangKy { get; set; }
        public DbSet<Chat> Chat { get; set; }

        public DBConnect() : base("name=MyContext")
        {
        }

    }
}
