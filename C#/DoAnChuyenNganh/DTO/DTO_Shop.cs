using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Shop
    {
        private string maMuaSam, tenMuaSam, diaChiMS, dienThoaiMS, emailMS, ghiChuMS;
        public string MaMuaSam { get => maMuaSam; set => maMuaSam = value; }
        public string TenMuaSam { get => tenMuaSam; set => tenMuaSam = value; }
        public string DiaChiMS { get => diaChiMS; set => diaChiMS = value; }
        public string DienThoaiMS { get => dienThoaiMS; set => dienThoaiMS = value; }
        public string EmailMS { get => emailMS; set => emailMS = value; }
        public string GhiChuMS { get => ghiChuMS; set => ghiChuMS = value; }
    }
}
