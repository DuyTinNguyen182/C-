using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Phanso
{
    class PhanSo
    {
        private int tu;
        private int mau;
        public void nhap()
        {
            Console.Write("Nhap tu so: ");
            this.tu=int.Parse(Console.ReadLine());
            do
            {
                Console.Write("Nhap mau so: ");
                this.mau=int.Parse(Console.ReadLine());
            }while(mau == 0);
        }
        public void xuat()
        {
            if (this.tu == this.mau || this.tu == 0)
                Console.WriteLine("So nguyen: " + this.tu);
            else
                Console.WriteLine("Phan so: " + this.tu + "/" + this.mau);
        }
        public PhanSo Cong(PhanSo a, PhanSo b)
        {
            PhanSo t = new PhanSo();
            if(a.mau == b.mau)
            {
                t.tu = a.tu + b.tu;
                t.mau = a.mau;
                return t;
            }
            else
            {
                t.tu = a.tu * b.mau + b.tu * a.mau;
                t.mau = a.mau * b.mau;
                return t;
            }
            
        }
        public PhanSo Tru(PhanSo a, PhanSo b)
        {
            PhanSo t = new PhanSo();
            if (a.mau == b.mau)
            {
                t.tu = a.tu - b.tu;
                t.mau = a.mau;
                return t;
            }
            else
            {
                t.tu = a.tu * b.mau - b.tu * a.mau;
                t.mau = a.mau * b.mau;
                return t;
            }

        }
        public PhanSo Nhan(PhanSo a, PhanSo b)
        {
            PhanSo t = new PhanSo();
            t.tu = a.tu * b.tu;
            t.mau = a.mau * b.mau;
            return t;
        }
        public PhanSo Chia(PhanSo a, PhanSo b)
        {
            PhanSo t = new PhanSo();
            t.tu = a.tu * b.mau;
            t.mau= a.mau * b.tu;
            return t;
        }

        //Nap chong
        public static PhanSo operator +(PhanSo a, PhanSo b)
        {
            PhanSo t= new PhanSo();
            t = t.Cong(a, b);
            return t;
        }

        private int uc(int a, int b)
        {
            if (a == 0 || b == 0)
                return a + b;
            else
            {
                while (a != b)
                {
                    if (a > b)
                        a = a - b;
                    else
                        b = b - a;
                }
                return a;
            }
        }
        public void RutGon()
        {
            int s = uc(this.tu, this.mau);
            this.tu /= s;
            this.mau /= s;
        }
    }
}
