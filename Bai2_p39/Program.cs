using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2_p39
{
    internal class Program
    {
        static void ptb1(int a,  int b)
        {
            if (a == 0)
            {
                if (b == 0)
                    Console.Write("\n Phuong trinh co vo so nghiem");
                else
                    Console.Write("\n Phuong trinh vo nghiem");
            }
            else
            {
                double n;
                n = - b * 1.0 / a;
                Console.Write("\n Phuong trinh co nghiem x = {0:F2}", n);
            }
        }
        static void ptb2(int a, int b, int c)
        {
            if (a == 0)
            {
                Console.Write("\n Phuong trinh co dang bac nhat");
                ptb1(b, c);
            }
            else
            {
                double d = b * b - 4 * a * c;
                if (d == 0)
                    Console.Write("\n Phuong trinh co nghiem kep x1 = x2 = {0:F2}", -b * 1.0 / (2 * a));
                else if (d < 0)
                    Console.Write("\n Phuong trinh vo nghiem");
                else
                    Console.Write("\n Phuong trinh co 2 nghiem phan biet x1 = {0:F2}, x2 = {1:F2}", ((-b * 1.0 + Math.Sqrt(d)) / (2 * a)), ((-b * 1.0 - Math.Sqrt(d)) / (2 * a)));
            }
        }
        static void Main(string[] args)
        {
            int a, b, c;
            Console.Write("Nhap vao a: ");
            a=int.Parse(Console.ReadLine());
            Console.Write("Nhap vao b: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Nhap vao c: ");
            c = int.Parse(Console.ReadLine());
            ptb2(a, b, c);
            Console.ReadKey();
        }
    }
}
