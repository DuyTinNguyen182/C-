using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3_p54
{
    class Program
    {
        static void Main(string[] args)
        {
            HinhTron tron = new HinhTron();
            HinhTru tru = new HinhTru();

            Console.WriteLine("--------Hinh tron-----------");
            tron.Nhap();
            Console.WriteLine("Dien tich hinh tron: {0:F2}", tron.DienTich());

            Console.WriteLine("---------Hinh tru----------");
            tru.Nhap();
            Console.WriteLine("Dien tich hinh tru: {0:F2}", tru.DienTich());

            Console.ReadKey();
        }
    }
}
