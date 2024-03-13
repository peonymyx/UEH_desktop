using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    internal class Query
    {
        private readonly DBConnect _context;
        public Query(DBConnect context)
        {
            _context = context;
        }
        public List<DTOGiangVien> GetAll()
        {
            try
            {
                List<DTOGiangVien> result = _context.GiangVien
                .Select(p => new DTOGiangVien
                {
                     MaGV = p.MaGV,
                     HoTen = p.HoTen,
                     Password = p.Password,
                     Email = p.Email,
                     Role = p.Role,
                     Status = p.Status,
                     Birth = p.Birth,
                     Online = p.Online
                })
                 .ToList();

                Console.WriteLine(result.Count);
                return result;

            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
                Console.WriteLine("Inner exception: " + ex.InnerException?.Message);
                return null;
            }
        }
    }
}
