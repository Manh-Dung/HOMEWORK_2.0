using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Class
    {
        // Account
        private string username, password, newPassword;
        private int permission;

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string NewPassword { get => newPassword; set => newPassword = value; }
        public int Permission { get => permission; set => permission = value; }

        // Khoa
        private string maKhoa, tenKhoa;
        public string MaKhoa { get => maKhoa; set => maKhoa = value; }
        public string TenKhoa { get => tenKhoa; set => tenKhoa = value; }

        // Lop
        private string maLop, tenLop;
        public string MaLop { get => maLop; set => maLop = value; }
        public string TenLop { get => tenLop; set => tenLop = value; }

        // Giang vien
        private string maGV, tenGV, sdtGV, emailGV;
        public string MaGV { get => maGV; set => maGV = value; }
        public string TenGV { get => tenGV; set => tenGV = value; }
        public string SdtGV { get => sdtGV; set => sdtGV = value; }
        public string EmailGV { get => emailGV; set => emailGV = value; }

        // Sinh vien
        private string maSV, tenSV, sdtSV, emailSV, ngaySinhSV, queQuan; 
        public string MaSV { get => maSV; set => maSV = value; }
        public string TenSV { get => tenSV; set => tenSV = value; }
        public string SdtSV { get => sdtSV; set => sdtSV = value; }
        public string EmailSV { get => emailSV; set => emailSV = value; }
        public string NgaySinhSV { get => ngaySinhSV; set => ngaySinhSV = value; }
        public string QueQuan { get => queQuan; set => queQuan = value; }

        // De tai
        private string maDT, tenDT;
        public string MaDT { get => maDT; set => maDT = value; }
        public string TenDT { get => tenDT; set => tenDT = value; }
    }
}
