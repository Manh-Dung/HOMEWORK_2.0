using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vidu2
{
    internal class Program
    {
        class Person
        {
            public string hoTen { get; set; }
            public string gioiTinh { get; set; }
            public int namSinh { get; set; }

            // Constructor khong tham so
            public Person()
            {
                hoTen = "";
                gioiTinh = "";
                namSinh = 0;
            }

            // Contructor co tham so
            public Person(string a, string b, int c)
            {
                hoTen = a;
                gioiTinh = b;
                namSinh = c;
            }

            // Phuong thuc input
            public virtual void input()
            {
                Console.Write("Nhap ho ten: ");
                hoTen = Console.ReadLine();
                Console.Write("Nhap gioi tinh: ");
                gioiTinh = Console.ReadLine();
                Console.Write("Nhap nam sinh: ");
                namSinh = int.Parse(Console.ReadLine());
            }

            // Phuong thuc output
            public virtual void output()
            {
                Console.WriteLine("\nHo ten: " + hoTen);
                Console.WriteLine("Gioi tinh: " + gioiTinh);
                Console.WriteLine("Nam sinh: " + namSinh);
            }
        }

        class CongNhan : Person
        {
            public string congTy { get; set; }
            public double heSoLuong { get; set; }

            // Constructor khong tham so o lop CongNhan goi den contructor khong tham so o lop Person 
            public CongNhan() : base()
            {
                congTy = "";
                heSoLuong = 0;
            }

            // Constructor co tham so o lop CongNhan goi den contructor co tham so o lop Person 
            public CongNhan(string a, string b, int c, string d, double e) : base(a, b, c)
            {
                congTy = d;
                heSoLuong = e;
            }

            // Phuong thuc input o lop CongNhan ghi de phuong thuc input o lop Person
            public override void input()
            {
                base.input();
                Console.Write("Nhap ten cong ty: ");
                congTy = Console.ReadLine();
                Console.Write("Nhap he so luong: ");
                heSoLuong = double.Parse(Console.ReadLine());
            }

            // Phuong thuc show o lop CongNhan ghi de phuong thuc output o lop Person
            public override void output()
            {
                base.output();
                Console.WriteLine("Cong ty: " + congTy);
                Console.WriteLine("He so luong: " + heSoLuong);
                Console.WriteLine("Thu nhap cua cong nhan la: " + thuNhap());
            }

            // Phuong thuc thu nhap
            public double thuNhap()
            {
                return (heSoLuong * 850000);
            }
        }

        static void Main(string[] args)
        {
            // Khong tham so
            /*CongNhan cn = new CongNhan();
            cn.input();
            cn.output();
            Console.ReadLine();*/

            // Co tham so
            /*CongNhan cn = new CongNhan("Dung", "Nam", 2002, "Van chuyen da quoc gia", 3);
            cn.output();
            Console.ReadLine();*/

            // Nhap va in danh sach cong nhan
            int n;
            Console.Write("Nhap do dai danh sach cong nhan: ");
            n = int.Parse(Console.ReadLine());
            List<CongNhan> list = new List<CongNhan>();

            Console.Write("Nhap cong nhan: \n");
            for (int i = 0; i < n; i++)
            {
                CongNhan cn = new CongNhan();
                Console.WriteLine("\nNhap cong nhan thu: {0}", i + 1);
                cn.input();
                list.Insert(i, cn);
            }

            Console.Write("Danh sach cong nhan: \n");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\nCong nhan thu: {0}", i + 1);
                list[i].output();
            }
            Console.ReadLine();

            double max = list[0].heSoLuong;
            CongNhan cnMax = new CongNhan();
            cnMax.hoTen = list[0].hoTen;
            cnMax.gioiTinh = list[0].gioiTinh;
            cnMax.namSinh = list[0].namSinh;
            cnMax.heSoLuong = list[0].heSoLuong;
            for (int i = 1; i < n; i++)
            {
                if (list[i].heSoLuong > max)
                {
                    max = list[i].heSoLuong;
                    cnMax.hoTen = list[i].hoTen;
                    cnMax.gioiTinh = list[i].gioiTinh;
                    cnMax.namSinh = list[i].namSinh;
                    cnMax.heSoLuong = list[i].heSoLuong;
                }
            }
            Console.WriteLine("Cong nhan co he so luong lon nhat la: ");
            cnMax.output();
            Console.ReadLine();
        }
    }
}
