using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using TransferObject;

namespace DataLayer
{
    public class KhachHangDL : DataProvider
    {
        public List<KhachHang> GetKhachHang()
        {

            string maKH, hoTen, email, sdt, gioiTinh;
            List<KhachHang> lKhachHang = new List<KhachHang>();

            string sql = "SELECT * FROM KHACHHANG";
            try
            {
                Connect();
                SqlDataReader reader = MyExcuteReader(sql, CommandType.Text);
                while (reader.Read())
                {
                    maKH = reader[0].ToString();
                    hoTen = reader[1].ToString();
                    gioiTinh = reader[2].ToString();
                    sdt = reader[3].ToString();
                    email = reader[4].ToString();

                    KhachHang kh = new KhachHang(maKH, hoTen, gioiTinh,sdt, email);
                    lKhachHang.Add(kh);
                }
                reader.Close();
                return lKhachHang;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                Disconnect();
            }
        }
        public List<KhachHang> SearchKhachHangByName(string ten)
        {
            List<KhachHang> list = new List<KhachHang>();
            string sql = "SELECT * FROM KHACHHANG WHERE HoTen COLLATE SQL_Latin1_General_CP1_CI_AI LIKE '%" + ten + "%'";

            try
            {
                Connect();
                SqlDataReader reader = MyExcuteReader(sql, CommandType.Text);
                while (reader.Read())
                {
                    string maKH = reader["MaKH"].ToString();
                    string hoTen = reader["HoTen"].ToString();
                    string gioiTinh = reader["GioiTinh"].ToString();
                    string sdt = reader["SDT"].ToString();
                    string email = reader["Email"].ToString();

                    KhachHang kh = new KhachHang(maKH, hoTen, gioiTinh, sdt, email);
                    list.Add(kh);
                }
                reader.Close();
                
            }
            catch (SqlException ex)
            {
                throw ex; 
            }
            finally
            {
                Disconnect();
            }
            return list;
        }
        public KhachHang TimKhachHangTheoSDT(string sdt)
        {
            string sql = "SELECT * FROM KHACHHANG WHERE Sdt = '"+sdt+"'";
            try
            {
                Connect();
                SqlDataReader reader = MyExcuteReader(sql, CommandType.Text);
                if (reader.Read())
                {
                    string maKH = reader["MaKH"].ToString();
                    string hoTen = reader["HoTen"].ToString();
                    string gioiTinh = reader["GioiTinh"].ToString();
                    string email = reader["Email"].ToString();

                    reader.Close();
                    return new KhachHang(maKH, hoTen, gioiTinh, sdt, email);
                }
                reader.Close();
                return null;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                Disconnect();
            }
        }
        public string GenerateMaKH()
        {
            string sql = "SELECT TOP 1 MaKH FROM KHACHHANG WHERE MaKH LIKE 'KH%' ORDER BY MaKH DESC";
            object result = MyExcuteScalar(sql, CommandType.Text);
            if (result != null)
            {
                string lastMaKH = result.ToString();
                int number = int.Parse(lastMaKH.Substring(2));
                return "KH" + (number + 1).ToString("D3");
            }
            return "KH000";
        }

        public int Update(KhachHang kh)
        {
            string sql = "uspUpdateKH";
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@maKH", kh.MaKH));
            parameters.Add(new SqlParameter("@hoTen", kh.HoTen));
            parameters.Add(new SqlParameter("@sdt", kh.SDT));
            parameters.Add(new SqlParameter("@email", kh.Email));
            parameters.Add(new SqlParameter("@gioiTinh", kh.GioiTinh));
            try
            {
                return MyExecuteNonQuery(sql, CommandType.StoredProcedure, parameters);
            }
            catch(SqlException ex)
            {
                throw ex;
            }
        }
        public int Insert(KhachHang kh)
        {
            string sql = @"INSERT INTO KHACHHANG (MaKH, HoTen, GioiTinh, Sdt, Email)
                   VALUES ('"+kh.MaKH+"', '"+kh.HoTen+"','"+kh.GioiTinh+"', '"+kh.SDT+"', '"+kh.Email+"')";
            try
            {
                return MyExecuteNonQuery(sql, CommandType.Text);
            }
            catch(SqlException ex)
            {
                throw ex;
            }
        }
        public int DeleteKhachHang(string maKH)
        {
            string sql = "DELETE FROM KHACHHANG WHERE MaKH = '"+maKH+"'";
            try
            {
                return MyExecuteNonQuery(sql, CommandType.Text);
            }
            catch(SqlException ex)
            {
                throw ex;
            }
        }

        public bool KiemTraKhachHangCoHoaDon(string maKH)
        {
            string sql = "SELECT COUNT(*) FROM HOADON WHERE MaKH = '"+maKH+"'";
            try
            {
                object result = MyExcuteScalar(sql, CommandType.Text);
                int count = result != null ? Convert.ToInt32(result) : 0;

                return count > 0;
            }
            catch(SqlException ex)
            {
                throw ex;
            }
        }

    }
}
