using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class Course_member
    {
        [Key]
        public string ID { get; set; }

        [ForeignKey("Courses")]
        public string MaLopHoc { get; set; }
        public Courses Courses { get; set; }

        [ForeignKey("GiangVien")]
        public string MaGV { get; set; }
        public GiangVien GiangVien { get; set; }

        [ForeignKey("SinhVien")]
        public string MSSV { get; set; }
        public SinhVien SinhVien { get; set;}
    }
}
