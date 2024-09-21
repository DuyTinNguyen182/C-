using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai7_p40
{
    internal class Program
    {
        static void doc(int n)
        {
            int c, dv;
            c = n / 10;
            dv = n % 10;
            switch (c)
            {
                case 1:
                    Console.Write("Muoi");
                    break;
                case 2:
                    Console.Write("Hai muoi");
                    break;
                case 3:
                    Console.Write("Ba muoi");
                    break;
                case 4:
                    Console.Write("Bon muoi");
                    break;
                case 5:
                    Console.Write("Nam muoi");
                    break;
                case 6:
                    Console.Write("Sau muoi");
                    break;
                case 7:
                    Console.Write("Bay muoi");
                    break;
                case 8:
                    Console.Write("Tam muoi");
                    break;
                case 9:
                    Console.Write("Chin muoi");
                    break;
            }
            switch (dv)
            {
                case 1:
                    if (c == 1)
                    {
                        Console.Write(" mootj");
                        break;
                    }
                    else
                    {
                        Console.Write(" moots");
                        break;
                    }
                case 2:
                    Console.Write(" hai");
                    break;
                case 3:
                    Console.Write(" ba");
                    break;
                case 4:
                    Console.Write(" bon");
                    break;
                case 5:
                    Console.Write(" lam");
                    break;
                case 6:
                    Console.Write(" sau");
                    break;
                case 7:
                    Console.Write(" bay");
                    break;
                case 8:
                    Console.Write(" tam");
                    break;
                case 9:
                    Console.Write(" chin");
                    break;
                default:
                    break;
            }
        }
        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.Write("Nhap vao 1 so co 2 chu so: ");
                n=int.Parse(Console.ReadLine());
            }while(n>99||n<10);
            Console.Write("So {0} doc la: ", n);
            doc(n);
            Console.ReadKey();
        }
    }
}
