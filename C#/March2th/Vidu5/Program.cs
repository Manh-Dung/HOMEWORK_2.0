using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace March2th
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            add(ref a);
            Console.WriteLine(a);
            Console.ReadLine();
        }

        static void add(ref int temp)
        {
            temp = temp + 1;
        }

    }
}
