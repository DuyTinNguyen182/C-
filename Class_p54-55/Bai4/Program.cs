using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4_54
{
    class Program
    {
        static void Main(string[] args)
        {
            NhanVien nv = new NhanVien();
            GiaoVien gv = new GiaoVien();
            HocSinh hs = new HocSinh();

            Console.WriteLine("----Nhap thong tin nhan vien----");
            nv.Nhap();
            nv.Xuat();
            Console.WriteLine("Luong nhan vien: " + nv.Tinh());

            Console.WriteLine("----Nhap thong tin giao vien-----");
            gv.Nhap();
            gv.Xuat();
            Console.WriteLine("Luong giao vien: " + gv.Tinh());

            Console.WriteLine("----Nhap thong tin hoc sinh----");
            hs.Nhap();
            hs.Xuat();
            Console.WriteLine("Diem trung binh: " + hs.Tinh());

            Console.ReadKey();
        }
    }
}
