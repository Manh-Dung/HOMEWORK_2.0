using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sodiensecond = 0;
            int sdMoi = 0;
            nhap(ref sodiensecond, ref sdMoi);
            Tinhtien(ref sodiensecond, ref sdMoi);
            Console.ReadLine();
        }
        private static void nhap(ref int sodiensecond, ref int sdMoi)
        {
            try
            {
                do
                {
                    Console.Write("Moi ban nhap so dien cu: ");
                    sodiensecond = int.Parse(Console.ReadLine());
                    Console.Write("Moi ban nhap so dien moi: ");
                    sdMoi = int.Parse(Console.ReadLine());
                } while (sodiensecond > sdMoi);
            }
            catch (Exception x)
            {
                Console.WriteLine("Nhap sai dinh dang!!");

            }
        }
        private static double Tinhtien(ref int sodiensecond, ref int sdMoi)
        {
            int sodien = sdMoi - sodiensecond;
            double tiendien;
            if (sodien <= 100)
            {
                tiendien = sodien * 2000;
                Console.WriteLine("So dien thang nay la: {0}, Tong so tien dien can thanh toan la: {1} vnd", sodien, tiendien);
            }
            else if (sodien >= 100 && sodien <= 150)
            {
                tiendien = (sodien - 100) * 2500 + (100 * 2000);
                Console.WriteLine("So dien thang nay la: {0}, Tong so tien dien can thanh toan la: {1} vnd", sodien, tiendien);
            }
            else if (sodien >= 150 && sodien < 200)
            {
                tiendien = (sodien - 150) * 2800 + (sodien - 100) * 2500 + (100 * 2000);
                Console.WriteLine("So dien thang nay la: {0}, Tong so tien dien can thanh toan la: {1} vnd", sodien, tiendien);
            }
            else if (sodien >= 200)
            {
                tiendien = (sodien - 200) * 3500 + (sodien - 150) * 2800 + (sodien - 100) * 2500 + (100 * 2000);
                Console.WriteLine("So dien thang nay la: {0}, Tong so tien dien can thanh toan la: {1} vnd", sodien, tiendien);
            }
            return 0;
        }
    }
}

