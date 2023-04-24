using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LopDTO
    {
        // TABLE ACCOUNT
        private string userName, passWord, newPass;
        private int quyenHan;
        public string UserName { get => userName; set => userName = value; }
        public string PassWord { get => passWord; set => passWord = value; }
        public string NewPass { get => newPass; set => newPass = value; }
        public int QuyenHan { get => quyenHan; set => quyenHan = value; }

        // TABLE GIANG VIEN
        private string maGV, tenGV, ngaySinhGiangVien, queQuanGV, maKhoa, maMonHoc, maLop, sdt, email;
        public string MaGV { get => maGV; set => maGV = value; }
        public string TenGV { get => tenGV; set => tenGV = value; }
        public string NgaySinhGiangVien { get => ngaySinhGiangVien; set => ngaySinhGiangVien = value; }
        public string QueQuanGV { get => queQuanGV; set => queQuanGV = value; }
        public string MaKhoa { get => maKhoa; set => maKhoa = value; }
        public string MaMonHoc { get => maMonHoc; set => maMonHoc = value; }
        public string MaLop { get => maLop; set => maLop = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Email { get => email; set => email = value; }

        // TABLE KHOA
        private string tenKhoa;
        public string TenKhoa { get => tenKhoa; set => tenKhoa = value; }

        // TABLE LOP
        private string tenLop, siSo;
        public string TenLop { get => tenLop; set => tenLop = value; }
        public string SiSo { get => siSo; set => siSo = value; }

        // TABLE MON HOC
        private string tenMonHoc;
        public string TenMonHoc { get => tenMonHoc; set => tenMonHoc = value; }
    }
}
