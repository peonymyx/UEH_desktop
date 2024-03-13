using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class Chat
    {
        [Key]
        public string ID { get; set; }
        public string MSSVMaGV { get; set; }
        public DateTime CreateAt { get; set; }
        [Required]
        public string NoiDung { get; set; }
        [ForeignKey("Courses")]
        public string MaLopHoc { get; set; }
        public Courses Courses { get; set; }
    }
}
