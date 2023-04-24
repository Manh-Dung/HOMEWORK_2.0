using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vidu1
{
    internal class Program
    {
        class Nguoi
        {
            public string hoTen { get; set; }
            public string diaChi { get; set; }
            public int tuoi { get; set; }

            // Constructor khong tham so
            public Nguoi()
            {
                hoTen = "";
                diaChi = "";
                tuoi = 0;
            }

            // Contructor co tham so
            public Nguoi(string a, string b, int c)
            {
                hoTen = a;
                diaChi = b;
                tuoi = c;
            }

            // Phuong thuc input
            public virtual void input()
            {
                Console.Write("Nhap ho ten: ");
                hoTen = Console.ReadLine();
                Console.Write("Nhap dia chi: ");
                diaChi = Console.ReadLine();
                Console.Write("Nhap tuoi: ");
                tuoi = int.Parse(Console.ReadLine());
            }

            // Phuong thuc show
            public virtual void show()
            {
                Console.WriteLine("\nHo ten: " + hoTen);
                Console.WriteLine("Dia chi: " + diaChi);
                Console.WriteLine("Tuoi: " + tuoi);
            }
        }

        class SinhVien : Nguoi
        {
            public double diemTB { get; set; }

            // Constructor khong tham so o lop SinhVien goi den contructor khong tham so o lop Nguoi 
            public SinhVien() : base()
            {
                diemTB = 0;
            }

            // Constructor co tham so o lop SinhVien goi den contructor co tham so o lop Nguoi 
            public SinhVien(string a, string b, int c, double d) : base(a, b, c)
            {
                diemTB = d;
            }

            // Phuong thuc input o lop SinhVien ghi de phuong thuc input o lop Nguoi
            public override void input()
            {
                base.input();
                Console.Write("Nhap diem trung binh: ");
                diemTB = double.Parse(Console.ReadLine());
            }

            // Phuong thuc show o lop SinhVien ghi de phuong thuc show o lop Nguoi
            public override void show()
            {
                base.show();
                Console.WriteLine("Diem trung binh: " + diemTB);
            }
        }

        static void Main(string[] args)
        {
            // Khong tham so
            /*SinhVien sv = new SinhVien();
            sv.input();
            sv.show();
            Console.ReadLine();*/

            // Co tham so
            /*SinhVien sv = new SinhVien("Dung", "Thai Binh", 19, 10);
            sv.show();
            Console.ReadLine();*/

            // Nhap va in danh sach sinh vien
            int n;
            Console.Write("Nhap do dai danh sach sinh vien: ");
            n = int.Parse(Console.ReadLine());
            List<SinhVien> list = new List<SinhVien>();

            Console.Write("Nhap sinh vien: \n");
            for (int i = 0; i < n; i++)
            {
                SinhVien sv = new SinhVien();
                Console.WriteLine("\nNhap sinh vien thu: {0}", i + 1);
                sv.input();
                list.Insert(i, sv);
            }

            Console.Write("Danh sach sinh vien: \n");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\nSinh vien thu: {0}", i + 1);
                list[i].show();
            }
            Console.ReadLine();
        }
    }
}
