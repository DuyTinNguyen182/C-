using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3_p54
{
    class HinhTru : HinhTron
    {
        private double h;
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap chieu cao: ");
            this.h = double.Parse(Console.ReadLine());
        }
        public override double DienTich()
        {
            return base.DienTich() * 2 + Math.PI * r * h;
        }
    }
}
