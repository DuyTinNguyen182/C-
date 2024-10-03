using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3_p54
{
    class HinhTron
    {
        protected double r;
        public virtual void Nhap()
        {
            Console.Write("Nhap ban kinh: ");
            this.r = double.Parse(Console.ReadLine());
        }
        public virtual double DienTich()
        {
            return Math.PI * r * r;
        }
    }
}
