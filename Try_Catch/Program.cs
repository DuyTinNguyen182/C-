using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try_Catch
{
    class Program
    {
        static void ptb1(int a, int b)
        {
            if (a == 0)
            {
                if (b == 0)
                    Console.Write("\nPhuong trinh co vo so nghiem");
                else
                    Console.Write("\nPhuong trinh vo nghiem");
            }
            else
            {
                double x = -b * 1.0 / a;
                Console.Write("\nPhuong trinh co nghiem X = {0:F2}", x);
            }
        }
        static void Main(string[] args)
        {
            try
            {
                int a, b;
                Console.Write("Nhap a: ");
                a = int.Parse(Console.ReadLine());
                Console.Write("Nhap b: ");
                b = int.Parse(Console.ReadLine());
                ptb1(a, b);
            }
            catch
            {
                Console.Write("Sai dinh dang");
            }
            Console.ReadKey();
        }
    }
}
