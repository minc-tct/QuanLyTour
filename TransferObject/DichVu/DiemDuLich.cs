using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObject.DichVu
{
    public class DiemDuLich
    {
        public string MaDDL { get; set; }
        public string TenDDL { get; set; }
        public string MaLoaiTour { get; set; }

        public DiemDuLich(string maDDL, string tenDDL, string maLoaiTour)
        {
            this.MaDDL = maDDL;
            this.TenDDL = tenDDL;
            this.MaLoaiTour = maLoaiTour;
        }

        public DiemDuLich() { }
    }
}
