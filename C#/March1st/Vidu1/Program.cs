using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vidu1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so phan tu trong mang: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            Console.WriteLine("Nhap tung phan tu trong mang: ");
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());            
            }
            Console.Write("Xuat mang: ");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0} ", arr[i]);
            }

            int a = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (a < arr[i])
                {
                    a = arr[i];
                }
            }
            Console.WriteLine("\nPhan tu lon nhat la: {0}", a);
            Console.ReadLine();
        }
    }
}
