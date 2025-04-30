using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using DataLayer;
using TransferObject;

namespace BusinessLayer
{
    public class ChiTietHoaDonBL
    {

        ChiTietHoaDonDL CTHDdl = new ChiTietHoaDonDL();

        public ChiTietHoaDon LayThongTinChiTiet(string soHD)
        {
            return CTHDdl.LayChiTietHoaDon(soHD);
        }
    }
}

