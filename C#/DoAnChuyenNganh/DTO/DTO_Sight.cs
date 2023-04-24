using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Sight
    {
        private string maDiemThamQuan, tenDiemThamQuan, ghiChuDTQ;
        public string MaDiemThamQuan { get => maDiemThamQuan; set => maDiemThamQuan = value; }
        public string TenDiemThamQuan { get => tenDiemThamQuan; set => tenDiemThamQuan = value; }
        public string GhiChuDTQ { get => ghiChuDTQ; set => ghiChuDTQ = value; }
    }
}
