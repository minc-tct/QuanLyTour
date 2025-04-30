using DataLayer;
using System;
using System.Data;
using System.Data.SqlClient;
using TransferObject;

namespace DataLayer
{
    public class QuanLyVeDL : DataProvider
    {
        public Ve LayThongTinVe(string maTour)
        {
            string query = @"
SELECT tt.MaTour, tt.TenTour, xp.DiaDiemXP, pt.TenPhuongTien,
       tt.TGBatDau, tt.TGKetThuc, tt.GiaTour
FROM TOUR tt
JOIN DiemXuatPhat xp ON tt.MaXP = xp.MaXP
JOIN PhuongTien pt ON tt.MaPhuongTien = pt.MaPhuongTien
WHERE tt.MaTour = '"+maTour+"'";

            try
            {
                Connect();
                SqlDataReader reader = MyExcuteReader(query, CommandType.Text);

                if (reader != null && reader.Read())
                {
                    var ve = new Ve
                    {
                        MaTour = reader["MaTour"].ToString(),
                        TenTour = reader["TenTour"].ToString(),
                        DiaDiemXP = reader["DiaDiemXP"].ToString(),
                        TenPhuongTien = reader["TenPhuongTien"].ToString(),
                        TGBatDau = (DateTime)reader["TGBatDau"],
                        TGKetThuc = (DateTime)reader["TGKetThuc"],
                        Gia = reader["GiaTour"] != DBNull.Value ? Convert.ToDecimal(reader["GiaTour"]) : 0,
                        ThanhTien = reader["GiaTour"] != DBNull.Value ? Convert.ToDecimal(reader["GiaTour"]) : 0
                    };

                    reader.Close();
                    return ve;
                }

                reader?.Close();
                return null;
            }
            catch(SqlException ex)
            {
                throw ex;
            }
            finally
            {
                Disconnect();
            }
        }
        public KhachHang TimKhachHangTheoSDT(string sdt)
        {
            string query = "SELECT * FROM KHACHHANG WHERE Sdt = @Sdt";
            SqlParameter[] parameters = {
                new SqlParameter("@Sdt", sdt)
            };

            try
            {
                using (SqlDataReader reader = MyExcuteReader(query, CommandType.Text))
                {
                    if (reader != null && reader.Read())
                    {
                        KhachHang kh = new KhachHang
                        {
                            MaKH = reader["MaKH"].ToString(),
                            HoTen = reader["HoTen"].ToString(),
                            SDT = reader["Sdt"].ToString(),
                            Email = reader["Email"].ToString(),
                            GioiTinh = reader["GioiTinh"].ToString()
                        };
                        return kh;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi tìm khách hàng theo SDT: " + ex.Message);
            }
        }
    }
}
