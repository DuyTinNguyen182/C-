using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1_p39
{
    internal class Program
    {
        static double dtb(double t, double l, double h)
        {
            double tb = (t + l + h) / 3;
            return tb;
        }
        static void Main(string[] args)
        {
            double t, l, h;
            Console.Write("Nhap diem mon toan: ");
            t=double.Parse(Console.ReadLine());
            Console.Write("Nhap diem mon ly: ");
            l = double.Parse(Console.ReadLine());
            Console.Write("Nhap diem mon hoa: ");
            h = double.Parse(Console.ReadLine());
            Console.Write("Diem trung binh 3 mon la: {0:F2}", dtb(t, l, h));
            Console.ReadKey();
        }
    }
}
