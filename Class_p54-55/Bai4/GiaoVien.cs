using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4_54
{
    class GiaoVien : ConNguoi
    {
        private int MaGV;
        private double LuongCB;
        private double PhuCap;
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap ma giao vien: ");
            this.MaGV = int.Parse(Console.ReadLine());
            Console.Write("Nhap luong co ban: ");
            this.LuongCB = double.Parse(Console.ReadLine());
            Console.Write("Nhap phu cap: ");
            this.PhuCap = double.Parse(Console.ReadLine());
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("Ma giao vien: " + MaGV);
            Console.WriteLine("Luong co ban: " + LuongCB);
            Console.WriteLine("Phu cap: " + PhuCap);
        }
        public override double Tinh()
        {
            return base.Tinh() * LuongCB * 650 + PhuCap;
        }
    }
}
