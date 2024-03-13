using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class SvDaDangKy
    {
        [Key]
        public string ID { get; set; }

        [ForeignKey("HDDRL")]
        public string MaHD { get; set; }
        public HDDRL HDDRL { get; set; }

        [ForeignKey("SinhVien")]
        public string MSSV { get; set; }
        public SinhVien SinhVien { get; set; }
        public DateTime CreateAt { get; set; }
        public bool Status { get; set; } = true;

        
    }
}
