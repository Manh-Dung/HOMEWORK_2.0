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
            add(a);
            Console.WriteLine(a);
            Console.ReadLine();
        }

        static void add(int temp)
        {
            temp = temp + 1;
        }

    }
}
