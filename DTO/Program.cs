using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DTO
{
    public class DTOGiangVien
    {
        public string MaGV { get; set; }
        public string HoTen { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public bool Role { get; set; }
        public bool Status { get; set; }
        public DateTime Birth { get; set; }
        public bool Online { get; set; }
        public DTOGiangVien() { }   
        public DTOGiangVien(string MaGV, string HoTen, string Password, string Email, bool Role, bool Status, DateTime Birth, bool Online)
        {
            this.MaGV = MaGV;
            this.HoTen = HoTen;
            this.Password = Password;
            this.Email = Email;
            this.Role = Role;
            this.Status = Status;
            this.Birth = Birth;
            this.Online = Online;
        }
    }
    public class DTOSinhVien
    {
        public string MSSV { get; set; }
        public string HoTen { get; set; }
        public string Password { get; set; }
        public string Email;
        public bool Status { get; set; }
        public DateTime Birth { get; set; }
        public bool Online { get; set; }
        public DTOSinhVien(string mSSV, string hoTen, string password, string email, bool status, DateTime birth, bool online)
        {
            MSSV = mSSV;
            HoTen = hoTen;
            Password = password;
            Email = email;
            Status = status;
            Birth = birth;
            Online = online;
        }
    }
    public class DTOCourses
    {
        public string MaLopHoc { get; set; }
        public string MonHoc { get; set; }
        public DTOCourses(string MaLopHoc, string MonHoc)
        {
            {
                this.MaLopHoc = MaLopHoc;
                this.MonHoc = MonHoc;
            }

        }
    }
    public class DTOBaiTap
    {
        public string MaBT { get; set; }

        public string MaGV { get; set; }

        public string MaLopHoc { get; set; }
        public byte[] NoiDung { get; set; }
        public DateTime CreateAt { get; set; }
        public bool Status { get; set; }

        public DTOBaiTap(string MaBT, string MaGV, string MaLopHoc, byte[] NoiDung, DateTime CreateAt, bool Status)
        {
            this.MaBT = MaBT;
            this.MaGV = MaGV;
            this.MaLopHoc = MaLopHoc;
            this.NoiDung = NoiDung;
            this.CreateAt = CreateAt;
            this.Status = Status;

        }
    }
    public class DTOBaiNop
    {
        public string MaBaiNop { get; set; }
        public string MSSV { get; set; }
        public string MaBT { get; set; }
        public string MaLopHoc { get; set; }
        public byte[] NoiDung { get; set; }
        public DateTime CreateAt { get; set; }
        public float Diem { get; set; }

        public DTOBaiNop(string MaBaiNop, string MSSV, string MaBT, string MaLopHoc, byte[] NoiDung, DateTime CreateAt, float Diem)
        {
            this.MaBaiNop = MaBaiNop;
            this.MSSV = MSSV;
            this.MaBT = MaBT;
            this.MaLopHoc = MaLopHoc;
            this.NoiDung = NoiDung;
            this.CreateAt = CreateAt;
            this.Diem = Diem;
        }
    }
    public class DTOCourses_member
        {
            public string ID { get; set; }
            public string MaLopHoc { get; set; }
            public string MaGV { get; set; }
            public string MSSV { get; set; }
            public DTOCourses_member(string ID, string MaLopHoc, string MaGV, string MSSV)
            {
                this.ID = ID;
                this.MaLopHoc = MaLopHoc;
                this.MaGV = MaGV;
                this.MSSV = MSSV;
            }

        }
    public class DTODRL
    {
        public string MaHD { get; set; }
        public DateTime Timeline { get; set; }
        public bool Status { get; set; }
        public DateTime CreateAt { get; set; }

        public DTODRL(string MaHD, DateTime Timeline, bool Status, DateTime CreateAt)
        {
            this.MaHD = MaHD;
            this.Timeline = Timeline;
            this.Status = Status;
            this.CreateAt = CreateAt;
        }
    }
    public class DTO_SvDaDangKy
    {
        public string ID { get; set; }
        public string MaHD { get; set; }
        public string MSSV { get; set; }
        public DateTime CreateAt { get; set; }
        public bool Status { get; set; }
        public DTO_SvDaDangKy(string ID, string MaHD, string MSSV, DateTime CreateAt, bool Status)
        {
            this.ID = ID;
            this.MaHD = MaHD;
            this.MSSV = MSSV;
            this.CreateAt = CreateAt;
            this.Status = Status;
        }
    }
    public class DTOChat
    {
        public string ID { get; set; }
        public string MSSVMaGV { get; set; }
        public DateTime CreateAt { get; set; }
        public byte[] NoiDung { get; set; }
        public string MaLopHoc { get; set; }

        public DTOChat(string ID, string MSSVMaGV, DateTime CreateAt, byte[] NoiDung, string MalopHoc)
        {
            this.ID = ID;
            this.MSSVMaGV = MSSVMaGV;
            this.CreateAt = CreateAt;
            this.NoiDung = NoiDung;
            this.MaLopHoc = MalopHoc;
        }
    }
    internal static class Program
    {

        static void Main()
        {
            
        }
    }
}
