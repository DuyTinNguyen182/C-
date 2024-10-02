using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Phanso
{
    class Program
    {
        static void Main(string[] args)
        {
            PhanSo a = new PhanSo();
            PhanSo b = new PhanSo();
            PhanSo t = new PhanSo();
            PhanSo t1 = new PhanSo();
            PhanSo t2 = new PhanSo();
            PhanSo t3 = new PhanSo();

            Console.WriteLine("--------Phan so 1--------");
            a.nhap();
            a.xuat();

            Console.WriteLine("-------Phan so 2-----------");
            b.nhap();
            b.xuat();

            Console.Write("Tong 2 phan so la: ");
            //t = t.Cong(a, b);
            t = a + b;
            t.xuat();

            Console.Write("Hieu hai phan so la: ");
            t1=t1.Tru(a, b);
            t1.xuat();

            Console.Write("Tich hai phan so la: ");
            t2=t2.Nhan(a, b);
            t2.xuat();

            Console.Write("Thuong 2 phan so la: ");
            t3=t3.Chia(a, b);
            t3.xuat();

            t.RutGon();
            Console.Write("\nPhan so sau khi rut gon: ");
            t.xuat();
            
            Console.ReadKey();
        }
    }
}
