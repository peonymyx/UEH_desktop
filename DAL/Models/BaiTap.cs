using Org.BouncyCastle.Bcpg.OpenPgp;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class BaiTap
    {
        [Key]
        public string MaBT { get; set; }
        [ForeignKey("GiangVien")]
        public string MaGV { get; set; }

        public GiangVien GiangVien { get; set; }
        [ForeignKey("Courses")]
        public string MaLopHoc { get; set; }
        public Courses Courses { get; set; }
        [Required]
        public byte[] _NoiDung { get; set; }
        public DateTime CreateAt { get; set; }
        public bool Status { get; set; } = false;
    }
}
