using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using DataLayer;
using TransferObject;

namespace BusinessLayer
{
    public class QuanLyVeBL
    {
        private QuanLyVeDL vedl = new QuanLyVeDL();

        public Ve LayThongTinVeTheoMaTour(string maTour)
        {
            return vedl.LayThongTinVe(maTour);
        }
        public KhachHang TimKhachHangTheoSDT(string sdt)
        {
            return vedl.TimKhachHangTheoSDT(sdt);
        }
        public decimal TinhThanhTien(Ve ve, int soLuongVe)
        {
            // Gọi phương thức của đối tượng Ve để tính thành tiền
            ve.CapNhatThanhTien(soLuongVe);
            return ve.ThanhTien;
        }
    }
}
