using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3_p54
{
    public class HinhTru : HinhTron
    {
        private double h;
        public HinhTru()
        {

        }
        public void Nhap()
        {
            base.nhap();
            Console.Write("Nhap chieu cao: ");
            h=double.Parse(Console.ReadLine());
        }
        public override double DT()
        {
            return 2*Math.PI*r*(h+r);
        }
    }
}
