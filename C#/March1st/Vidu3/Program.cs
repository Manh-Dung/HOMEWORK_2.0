using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vidu3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap x: ");
            string temp = Console.ReadLine();
            int x = 0;
            try
            {
                x = int.Parse(temp);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Console.ReadLine();
        }
    }
}
