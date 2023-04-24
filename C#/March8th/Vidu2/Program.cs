using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vidu2
{
    class TienDien
    {
        public double DienDau { get; set; }
        public double DienCuoi { get; set; }

        public TienDien()
        {
            DienDau = 0;
            DienCuoi = 0;
        }

        public TienDien(double a, double b)
        {
            DienDau = a;
            DienCuoi = b;
        }

        public void NhapSoDien(double a, double b)
        {
            Console.WriteLine("So dien dau la: " + a);
            Console.WriteLine("So dien cuoi la: " + b);
        }

        public void TinhTien(double DienDau, double DienCuoi)
        {
            if (DienCuoi - DienDau >= 0 && DienCuoi - DienDau <= 100)
            {
                Console.WriteLine("Tien dien ban phai tra la: {0} VND!", (DienCuoi - DienDau) * 2000);
            }
            else if (DienCuoi - DienDau > 100 && DienCuoi - DienDau <= 150)
            {
                Console.WriteLine("Tien dien ban phai tra la: {0} VND!", (DienCuoi - DienDau) * 2500);
            }
            else if (DienCuoi - DienDau > 150 && DienCuoi - DienDau <= 200)
            {
                Console.WriteLine("Tien dien ban phai tra la: {0} VND!", (DienCuoi - DienDau) * 2800);
            }
            else if (DienCuoi - DienDau > 200)
            {
                Console.WriteLine("Tien dien ban phai tra la: {0} VND!", (DienCuoi - DienDau) * 3500);
            }

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            TienDien td1 = new TienDien();
            td1.NhapSoDien(1, 100);
            td1.TinhTien(1, 100);
            Console.ReadLine();

            TienDien td2 = new TienDien(1, 100);
            td2.NhapSoDien(1, 100);
            td2.TinhTien(1, 100);
            Console.ReadLine();
        }
    }
}
