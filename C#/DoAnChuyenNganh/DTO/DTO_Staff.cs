using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Staff
    {
        private string maNhanVien, tenNhanVien, diaChiNV, ghiChuNV;
        public string MaNhanVien { get => maNhanVien; set => maNhanVien = value; }
        public string TenNhanVien { get => tenNhanVien; set => tenNhanVien = value; }
        public string DiaChiNV { get => diaChiNV; set => diaChiNV = value; }
        public string GhiChuNV { get => ghiChuNV; set => ghiChuNV = value; }
    }
}
