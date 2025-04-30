using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using DataLayer;
using TransferObject;

namespace BusinessLayer
{
    public class HoaDonBL
    {

        private HoaDonDL hoaDonDL = new HoaDonDL();

        public List<HoaDon> GetHoaDons()
        {
            try
            {
                return hoaDonDL.GetHoaDon();
            }
            catch(SqlException ex)
            {
                throw ex;
            }
        }
        public int XoaHoaDon(string soHD)
        {
            return hoaDonDL.DeleteHoaDon(soHD);
        }
        public bool XuLyThanhToan(HoaDon hd)
        {
            hd.SoHD = hoaDonDL.GenerateMaHD();
            string soHD = hoaDonDL.ThemHoaDon(hd);
            if (!string.IsNullOrEmpty(soHD))
            {
                hd.SoHD = soHD;
                return true;
            }
            return false;
        }

    }
}
