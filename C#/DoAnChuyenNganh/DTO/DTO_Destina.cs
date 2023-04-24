using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Destina
    {
        private string maDiemDen, tenDiemDen, ghiChuDiemDen;
        public string MaDiemDen { get => maDiemDen; set => maDiemDen = value; }
        public string TenDiemDen { get => tenDiemDen; set => tenDiemDen = value; }
        public string GhiChuDiemDen { get => ghiChuDiemDen; set => ghiChuDiemDen = value; }
    }
}
