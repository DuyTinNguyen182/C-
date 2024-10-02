using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3_p54
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HinhTron tron =new HinhTron();
            HinhTru tru =new HinhTru();
            int n;

            Console.WriteLine("1. Hinh tron");
            Console.WriteLine("2. Hinh tru");
            Console.Write("Nhap: ");
            n=int.Parse(Console.ReadLine());
            if (n == 1)
            {
                tron.nhap();
                Console.Write("Dien tich hinh tron la: " + tron.DT());
            }
            else
            {
                tru.Nhap();
                Console.Write("Dien tich hinh tru la: " + tru.DT());
            }
            Console.ReadKey();
        }
    }
}
