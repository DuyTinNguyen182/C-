using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace De01_110122182_NguyenDuyTin
{
    class Program
    {
        static void nhap(int n, int[] a)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhap phan tu thu a[{0}]: ", i);
                a[i] = int.Parse(Console.ReadLine());
            }
        }
        static void xuat(int n, int[] a)
        {
            Console.Write("Mang vua nhap la:");
            for (int i = 0; i < n; i++)
            {
                Console.Write("  {0}", a[i]);
            }
        }
        static void inChan(int n, int[] a)
        {
            int t = 0;
            Console.Write("\nCac phan tu chan tai vi tri le trong mang la:");
            for(int i = 0; i < n; i++)
            {
                if (i % 2 != 0 && a[i] % 2 == 0)
                {
                    Console.Write("  " + a[i]);
                    t = t + a[i];
                }
            }
            Console.Write("\nTong cac phan tu chan tai vi tri le = {0}", t);
        }        
        static void Main(string[] args)
        {
            try
            {
                int n;
                do
                {
                    Console.Write("Nhap so luong phan tu N > 0: ");
                    n = int.Parse(Console.ReadLine());
                } while (n <= 0);
                int[] a = new int[n];
                nhap(n, a);
                xuat(n, a);
                inChan(n, a);
            }
            catch
            {
                Console.Write("Sai dinh dang!");
            }            
            Console.ReadKey();
        }
    }
}
