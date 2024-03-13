using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace DAL
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        static void Main()
        {
            using (var connect = new DBConnect())
            {
                try
                {
                    var query = new Query(connect);
                    List<DTOGiangVien> gv = query.GetAll();

                    // In ra thông tin sản phẩm
                    if (gv != null)
                    {
                        foreach (DTOGiangVien v in gv)
                            Console.WriteLine($"MaGV: {v.MaGV}; Họ Tên: {v.HoTen}");
                    }
                    else { Console.WriteLine("LOIIIIII!"); }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
