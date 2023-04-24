using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LopDTO
    {
        string maLop, tenLop;
        int soSV;
        public string MaLop { get { return maLop; } set { maLop = value; } }
        public string TenLop { get { return tenLop; } set { tenLop = value; } }
        public int SoSV { get { return soSV; } set { soSV = value; } }
    }
}
