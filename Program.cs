using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ptb2
{
    internal class Program
    {
        static void ptb1(int a, int b)
        {
            if (a == 0)
                if (b == 0)
                    Console.WriteLine("Vo so nghiem");
                else
                    Console.WriteLine("Vo nghiem");
            else
            {
                double x = -b * 1.0 / a;
                Console.WriteLine("Pt co nghiem x = {0:F2}", x);
            }
        }
        static void ptb2(int a, int b, int c)
        {
            if (a == 0)
            {
                Console.WriteLine("Pt co dang bac 1");
                ptb1(b, c);
            }
            else
            {
                double d = b * b - 4 * a * c;
                if (d < 0)
                {
                    Console.WriteLine("Pt vo nghiem");
                }
                else if (d == 0)
                {
                    double x = -b * 1.0 / 2 * a;
                    Console.WriteLine("Pt co nghiem kep x1 = x2 = {0:F2}", x);
                }
                else
                {
                    double x1, x2;
                    x1 = (-b + Math.Sqrt(d)) / (2 * a);
                    x2 = (-b - Math.Sqrt(d)) / (2 * a);
                    Console.WriteLine("Pt co 2 nghiem phan biet x1 = {0:F2}, x2 = {1:F2}", x1, x2);
                }
            }
        }
        static void Main(string[] args)
        {
            int a, b, c;
            try
            {
                Console.Write("Nhap a: ");
                a = int.Parse(Console.ReadLine());
                Console.Write("Nhap b: ");
                b = int.Parse(Console.ReadLine());
                Console.Write("Nhap c: ");
                c = int.Parse(Console.ReadLine());
                ptb2(a, b, c);
            }
            catch
            {
                Console.Write("So vua nhap khong phai so nguyen hoac la ki tu");
            }
            //ptb2(a, b, c);
            Console.ReadKey();
        }
    }
}
