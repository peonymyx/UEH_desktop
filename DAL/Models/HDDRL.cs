using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class HDDRL
    {
        [Key]
        public string MaHD { get; set; }
        [Required]
        public string TieuDe {get; set; }
        public DateTime Timeline { get; set; }
        [Required]
        public string NoiDung { get; set; }
        public bool Status { get; set; } = false;
        public DateTime CreateAt { get; set; }
    }
}
