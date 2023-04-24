using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vidu6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            Nhap(ref a, ref b);
            TinhTong(a, b);
            Console.ReadLine();
        }

        static void Nhap(ref int a, ref int b)
        {
            Console.Write("Nhap a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Nhap b: ");
            b = int.Parse(Console.ReadLine());
        }

        static void TinhTong(int a, int b)
        {
            Console.WriteLine("Tong 2 so la: {0}", a + b);
        }
    }
}
