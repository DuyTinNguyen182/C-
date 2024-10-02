using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3_p54
{
    public class HinhTron
    {
        protected double r;
        public HinhTron()
        {

        }
        public void nhap()
        {
            Console.Write("Nhap ban kinh: ");
            r=double.Parse(Console.ReadLine());
        }
        public virtual double DT()
        {
            return Math.PI * r * r;
        }
    }
}
