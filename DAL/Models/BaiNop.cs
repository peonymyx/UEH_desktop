using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class BaiNop
    {
        [Key]
        public string MaBaiNop { get; set; }

        [ForeignKey("SinhVien")]
        public string MSSV { get; set; }
        public SinhVien SinhVien { get; set; }

        [ForeignKey("BaiTap")]
        public string MaBT { get; set; }
        public BaiTap BaiTap { get; set; }

        [ForeignKey("Courses")]
        public string MaLopHoc { get; set; }
        public Courses Courses { get; set; }

        [Required]
        public byte[] NoiDung { get; set; }
        public DateTime CreateAt { get; set; }
        public float Diem { get; set; }
    }
}
