using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace DAL.Model
{
    public class GiangVien
    {
        [Key]
        public string MaGV { get; set; }
        [Required]
        public string HoTen { get; set; }
        [Required]
        public string Password { get; set; } = "123";
        [Required]
        public string Email { get; set; }
        public bool Role { get; set; } = false;
        public bool Status { get; set; } = false;
        public DateTime Birth { get; set; }
        public bool Online { get; set; } = false;
    }
}
