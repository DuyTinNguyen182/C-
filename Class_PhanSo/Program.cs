using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_PhanSo
{
    class Program
    {
        static void Main(string[] args)
        {
            PhanSo a = new PhanSo();
            PhanSo b = new PhanSo();
            PhanSo t = new PhanSo();

            Console.WriteLine("Nhap phan so 1");
            a.Nhap();

            Console.WriteLine("Nhap phan so 2");
            b.Nhap();

            t = t.congPhanSo(a, b);
            Console.Write("Tong 2 phan so la: ");
            t.Xuat();

            PhanSo t1 = t.RutGon();
            Console.Write("\nPhan so sau khi rut gon: ");
            t1.Xuat();

            Console.ReadKey();
        }
    }
}
