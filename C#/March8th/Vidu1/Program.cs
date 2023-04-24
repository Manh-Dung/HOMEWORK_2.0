using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vidu1
{
    class GiaiPTB1
    {
        public double a { get; set; }
        public double b { get; set; }

        public GiaiPTB1(double a, double b)
        {
            this.a = a;
            this.b = b;  
        }

        public void NhapHeSo(double a, double b)
        {
            Console.WriteLine("He so a = " + a);
            Console.WriteLine("He so b = " + b);
        }

        public void GiaiPT(double a, double b)
        {
            if (a != 0)
            {
                Console.WriteLine("Nghiem cua phuong trinh la: x = " + -b / a);
            }
            else if (b == 0)
                Console.WriteLine("Phuong trinh vo nghiem!");
            else
                Console.WriteLine("Phuong trinh vo so nghiem!");
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            GiaiPTB1 pt1 = new GiaiPTB1(1, 2);
            pt1.NhapHeSo(1, 2);
            pt1.GiaiPT(1, 2);
            Console.ReadLine();
        }
        
    }

}
