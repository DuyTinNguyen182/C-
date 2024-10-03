using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4_54
{
    class NhanVien : ConNguoi
    {
        private int MaNV;
        private double LuongNgay;
        private int NgayCong;
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap ma nhan vien: ");
            this.MaNV = int.Parse(Console.ReadLine());
            Console.Write("Nhap luong tren ngay: ");
            this.LuongNgay = double.Parse(Console.ReadLine());
            Console.Write("Nhap so ngay cong: ");
            this.NgayCong = int.Parse(Console.ReadLine());
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("Ma nhan vien: " + MaNV);
            Console.WriteLine("Luong tren ngay: " + LuongNgay);
            Console.WriteLine("So ngay cong: " + NgayCong);
        }
        public override double Tinh()
        {
            return base.Tinh()*LuongNgay*NgayCong;
        }
    }
}
