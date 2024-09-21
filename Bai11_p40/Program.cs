using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai11_p40
{
    internal class Program
    {
        /*static int uc(int a,  int b)
        {
            if (a == 0 || b == 0)
                return a + b;
            while (a != b)
            {
                if (a > b)
                    a = a - b;
                else
                    b = b - a;
            }
            return a;
        }*/
        static int dequy(int a, int b)
        {
            if(a==b)
                return a;
            else
            {
                if(a>b)
                    a=a - b;
                else
                    b=b - a;
            }
            return dequy(a, b);
        }
        static void Main(string[] args)
        {
            int a, b;
            Console.Write("Nhap vao so nguyen thu nhat: ");
            a=int.Parse(Console.ReadLine());
            Console.Write("Nhap vao so nguyen thu 2: ");
            b=int.Parse(Console.ReadLine());
            Console.Write("Uoc chung lon nhat cua {0} va {1} la: {2}", a, b, dequy(a, b));
            Console.ReadKey();
        }
    }
}
