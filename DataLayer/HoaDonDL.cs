using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using TransferObject;

namespace DataLayer
{
    public class HoaDonDL : DataProvider
    {

        public List<HoaDon> GetHoaDon()
        {
            List<HoaDon> lHoaDon = new List<HoaDon>();

            string sql = "SELECT * FROM HOADON";
            try
            {
                Connect();
                SqlDataReader reader = MyExcuteReader(sql, CommandType.Text);
                while (reader.Read())
                {
                    string soHD = reader["SoHD"].ToString();
                    string maNV = reader["MaNV"].ToString();
                    string maKH = reader["MaKH"].ToString();
                    string maTour = reader["MaTour"].ToString();
                    int soLuongVe = reader["SoLuongVe"] != DBNull.Value?Convert.ToInt32(reader["SoLuongVe"]): 0;
                    DateTime ngayDangKy = reader["NgayDangKy"] != DBNull.Value?Convert.ToDateTime(reader["NgayDangKy"]): DateTime.MinValue;
                    DateTime ngayLap = reader["NgayLapHD"] != DBNull.Value? Convert.ToDateTime(reader["NgayLapHD"]): DateTime.MinValue;
                    decimal thanhTien = reader["ThanhTien"] != DBNull.Value? Convert.ToDecimal(reader["ThanhTien"]): 0;
                    HoaDon hd = new HoaDon(soHD, maNV, maKH, maTour, soLuongVe, ngayDangKy, ngayLap, thanhTien);
                    lHoaDon.Add(hd);
                }
                reader.Close();
                return lHoaDon;
            }
            catch (SqlException ex)
            {
                throw new Exception("Lỗi SQL khi lấy danh sách hóa đơn: " + ex.Message);
            }
            finally
            {
                Disconnect();
            }

        }
        public int DeleteHoaDon(string soHD)
        {
            string sql = "DELETE FROM HOADON WHERE SoHD = '"+soHD+"'";
            try
            {
                return MyExecuteNonQuery(sql, CommandType.Text);
            }
            catch(SqlException ex)
            {
                throw ex;
            }
        }
        //public bool LuuHoaDon(HoaDon hoaDon)
        //{
        //    string sql = "INSERT INTO HOADON (SoHD, MaNV, MaKH, MaTour, SoLuongVe,NgayLapHD, ThanhTien) " +
        //        "VALUES ('"+hoaDon.SoHD+"', '"+hoaDon.MaNV+"', '"+hoaDon.MaKH+"', '"+hoaDon.MaTour+"', '"+hoaDon.NgayLapHD+"', '"+hoaDon.ThanhTien+"', '"+hoaDon.SoLuongVe+"')";
        //        try
        //        {
        //            int result = MyExecuteNonQuery(query, CommandType.Text);
        //            return result > 0; // Trả về true nếu thêm thành công
        //        }
        //        catch(SqlException ex)
        //        {
        //            throw ex;
        //        }
        //        catch (Exception)
        //        {
        //            return false; // Trả về false nếu có lỗi
        //        }
        //}
        public string GenerateMaHD()
        {
            string sql = "SELECT TOP 1 SoHD FROM HOADON WHERE SoHD LIKE 'HD%' ORDER BY SoHD DESC";
            try
            {
                Connect(); 
                object result = MyExcuteScalar(sql, CommandType.Text);
                if (result != null && result != DBNull.Value)
                {
                    string lastSoHD = result.ToString();
                    int number = int.Parse(lastSoHD.Substring(2)); 
                    return "HD" + (number + 1).ToString("D3");    
                }
                else
                {
                    return "HD000"; 
                }
            }
            catch (SqlException ex)
            {
                throw ex; 
            }
            catch (FormatException ex)
            {
                throw ex; 
            }
            finally
            {
                Disconnect(); 
            }
        }
        public string ThemHoaDon(HoaDon hoaDon)
        {
                string query = @"
        INSERT INTO HOADON (SoHD,MaNV, MaKH, MaTour,SoLuongVe, NgayLapHD, ThanhTien )
        VALUES ('"+hoaDon.SoHD+"','"+hoaDon.MaNV+"', '"+hoaDon.MaKH+"', '"+hoaDon.MaTour+"', '"+hoaDon.NgayLapHD+"', '"+hoaDon.ThanhTien+"', '"+hoaDon.SoLuongVe+"')";
            try
            {
                object result = MyExecuteNonQuery(query, CommandType.Text);

                return result?.ToString();
            }
            catch(SqlException ex)
            {
                throw ex;
            }      
        }
    }
}
