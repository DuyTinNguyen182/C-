using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4_54
{
    class ConNguoi
    {
        protected string HoTen;
        protected int tuoi;
        protected string GT;
        protected string DiaChi;
        public virtual void Nhap()
        {
            Console.Write("Nhap ten: ");
            this.HoTen = string.Format(Console.ReadLine());
            Console.Write("Nhap tuoi: ");
            this.tuoi = int.Parse(Console.ReadLine());
            Console.Write("Nhap gioi tinh: ");
            this.GT = string.Format(Console.ReadLine());
            Console.Write("Dia chi: ");
            this.DiaChi = string.Format(Console.ReadLine());
        }
        public virtual void Xuat()
        {
            Console.WriteLine("-----Thong tin vua nhap-------");
            Console.WriteLine("Ho va ten: " + this.HoTen);
            Console.WriteLine("Tuoi: " + tuoi);
            Console.WriteLine("Gioi tinh: " + GT);
            Console.WriteLine("Dia chi: " + DiaChi);
        }
        public virtual double Tinh()
        {
            return 1;
        }
    }
}
