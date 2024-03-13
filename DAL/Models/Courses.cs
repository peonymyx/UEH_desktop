using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace DAL.Model
{
    public class Courses
    {
        [Key]
        public string MaLopHoc { get; set; }
        public string MonHoc { get; set; }
    }
}
