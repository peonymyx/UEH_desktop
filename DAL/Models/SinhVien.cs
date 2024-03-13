using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class SinhVien
    {
        [Key]
        public string MSSV { get; set; }
        [Required]
        public string HoTen { get; set; }
        [Required]
        public string Password { get; set; } = "123";
        [Required]
        public string Email { get; set; }
        public bool Status { get; set; } = false;
        public DateTime Birth { get; set; }
        public bool Online { get; set; } = false;

    }
}
