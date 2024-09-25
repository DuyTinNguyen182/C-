using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai16_p41
{
    internal class Program
    {
        static void nhap(int n, int[]a)
        {
            for(int i=0; i<n; i++)
            {
                Console.Write("Nhap phan tu thu {0}: ", i + 1);
                a[i] = int.Parse(Console.ReadLine());
            }
        }
        static void xuat(int n, int[] a)
        {
            Console.Write("Mang vua nhap la:");
            for (int i = 0; i < n; i++)
            {
                Console.Write("\t{0}", a[i]);
            }
        }
        static int max(int n, int[] a)
        {
            int t = a[0];
            for(int i = 1; i < n; i++)
            {
                if(t < a[i])
                    t= a[i];
            }
            return t;
        }
        static int min(int n, int[] a)
        {
            int t = a[0];
            for (int i = 1; i < n; i++)
            {
                if (t > a[i])
                    t = a[i];
            }
            return t;
        }
        static void Main(string[] args)
        {
            int n;
            Console.Write("Nhap so luong phan tu: ");
            n=int.Parse(Console.ReadLine());
            int []a=new int[n];
            nhap(n, a);
            xuat(n, a);
            Console.Write("\nMax = {0}", max(n, a));
            Console.Write("\nMin = {0}", min(n, a));
            Console.ReadKey();
        }
    }
}
