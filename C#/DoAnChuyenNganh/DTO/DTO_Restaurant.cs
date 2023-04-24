using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Restaurant
    {
        private string maNhaHang, tenNhaHang, diaChiNH, dienThoaiNH, emailNH, ghiChuNH;
        public string MaNhaHang { get => maNhaHang; set => maNhaHang = value; }
        public string TenNhaHang { get => tenNhaHang; set => tenNhaHang = value; }
        public string DiaChiNH { get => diaChiNH; set => diaChiNH = value; }
        public string DienThoaiNH { get => dienThoaiNH; set => dienThoaiNH = value; }
        public string EmailNH { get => emailNH; set => emailNH = value; }
        public string GhiChuNH { get => ghiChuNH; set => ghiChuNH = value; }
    }
}
