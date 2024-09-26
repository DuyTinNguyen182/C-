using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_PhanSo
{
    class PhanSo
    {
        public int tuso;
        public int mauso;
        public void Nhap()
        {
            Console.Write("Nhap tu so: ");
            this.tuso = int.Parse(Console.ReadLine());
            Console.Write("Nhap mau so: ");
            do
            {
                this.mauso = int.Parse(Console.ReadLine());
            } while (mauso == 0);
        }
        public void Xuat()
        {
            if (mauso == 1)
                Console.Write("So nguyen " + tuso);
            else
                Console.Write("\nPhan so = " + tuso + "/" + mauso);
        }
        public int UC(int a, int b)
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
        }
        public PhanSo RutGon()
        {
            PhanSo t1 = new PhanSo();
            int t2 = UC(tuso, mauso);
            t1.tuso = tuso / t2;
            t1.mauso = mauso / t2;
            return t1;
        }
        public PhanSo congPhanSo(PhanSo a, PhanSo b)
        {
            PhanSo t = new PhanSo();
            t.tuso = a.tuso * b.mauso + b.tuso * a.mauso;
            t.mauso = a.mauso * b.mauso;
            return t;
        }
    }
}
