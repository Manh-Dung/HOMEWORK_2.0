using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Service
    {
        private string maDichVu, tenDichVu, diaChiDV, dienThoaiDV, emailDV, ghiChuDV;
        public string MaDichVu { get => maDichVu; set => maDichVu = value; }
        public string TenDichVu { get => tenDichVu; set => tenDichVu = value; }
        public string DiaChiDV { get => diaChiDV; set => diaChiDV = value; }
        public string DienThoaiDV { get => dienThoaiDV; set => dienThoaiDV = value; }
        public string EmailDV { get => emailDV; set => emailDV = value; }
        public string GhiChuDV { get => ghiChuDV; set => ghiChuDV = value; }
    }
}
