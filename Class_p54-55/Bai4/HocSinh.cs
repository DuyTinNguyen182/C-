using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4_54
{
    class HocSinh : ConNguoi
    {
        private int MaHS;
        private string Lop;
        private double DiemToan, DiemLy, DiemHoa;
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap ma hoc sinh: ");
            this.MaHS = int.Parse(Console.ReadLine());
            Console.Write("Nhap lop: ");
            this.Lop = string.Format(Console.ReadLine());
            Console.Write("Nhap diem mon toan: ");
            this.DiemToan = double.Parse(Console.ReadLine());
            Console.Write("Nhap diem mon ly: ");
            this.DiemLy = double.Parse(Console.ReadLine());
            Console.Write("Nhap diem mon hoa: ");
            this.DiemHoa = double.Parse(Console.ReadLine());
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("Ma hoc sinh: " + MaHS);
            Console.WriteLine("Lop: " + Lop);
            Console.WriteLine("Diem mon toan: " + DiemToan);
            Console.WriteLine("Diem mon ly: " + DiemLy);
            Console.WriteLine("Diem mon hoa: " + DiemHoa);
        }
        public override double Tinh()
        {
            return base.Tinh() * (DiemToan * 2 + DiemLy + DiemHoa) / 4;
        }
    }
}
