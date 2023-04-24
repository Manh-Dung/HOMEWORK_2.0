using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_SampleTour
    {
        private string maTourMau, tenTour, hanhTrinh;
        private float khoangCach, chiPhi;
        public string MaTourMau { get => maTourMau; set => maTourMau = value; }
        public string TenTour { get => tenTour; set => tenTour = value; }
        public string HanhTrinh { get => hanhTrinh; set => hanhTrinh = value; }
        public float KhoangCach { get => khoangCach; set => khoangCach = value; }
        public float ChiPhi { get => chiPhi; set => chiPhi = value; }
    }
}
