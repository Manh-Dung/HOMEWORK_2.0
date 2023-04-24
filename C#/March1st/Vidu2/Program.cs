using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Vidu2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter(@"C:\Users\Acer\OneDrive\Documents\HOMEWORK\CSharp\March1st\Vidu2\input.txt", false);
            sw.WriteLine("Cak");
            Console.WriteLine("Ghi duoc r.");
            sw.Close();
            Console.ReadLine();
        }       
    }
}
