using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Lop_DTO
    {
        private string maBN, hoTen, ngayNV, maKhoa;
        public string MaBN { get { return maBN; } set { maBN = value; } }
        public string HoTen { get { return hoTen; } set { hoTen = value; } }
        public string NgayNV { get { return ngayNV; } set { ngayNV = value; } }
        public string MaKhoa { get { return maKhoa; } set { maKhoa = value; } }
    }
}
