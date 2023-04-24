using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Hotel
    {
        private string maKhachSan, tenKhachSan, diaChiKS, dienThoaiKS, emailKS, ghiChuKS;
        public string MaKhachSan { get => maKhachSan; set => maKhachSan = value; }
        public string TenKhachSan { get => tenKhachSan; set => tenKhachSan = value; }
        public string DiaChiKS { get => diaChiKS; set => diaChiKS = value; }
        public string DienThoaiKS { get => dienThoaiKS; set => dienThoaiKS = value; }
        public string EmailKS { get => emailKS; set => emailKS = value; }
        public string GhiChuKS { get => ghiChuKS; set => ghiChuKS = value; }
    }
}
