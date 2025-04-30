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
    public class QuanLyTourDL : DataProvider
    {
        public List<Tour> GetTour()
        {
            List<Tour> lTour = new List<Tour>();
            string sql = "SELECT * FROM TOUR";

            try
            {
                Connect();
                SqlDataReader reader = MyExcuteReader(sql, CommandType.Text);
                while (reader.Read())
                {
                    string maTour = reader[0].ToString();
                    string tenTour = reader[1].ToString();
                    string moTaTour = reader[2].ToString();
                    string anhTour = reader[3].ToString();
                    decimal giaTour = Convert.ToDecimal(reader[4]);
                    DateTime tgBatDau = Convert.ToDateTime(reader[5]);
                    DateTime tgKetThuc = Convert.ToDateTime(reader[6]);
                    string maLoaiTour = reader[7].ToString();
                    string maPhuongTien = reader[8].ToString();
                    string maXP = reader[9].ToString();
                    string maDDL = reader[10].ToString();

                    Tour tour = new Tour(maTour, tenTour, moTaTour, anhTour, giaTour, tgBatDau, tgKetThuc, maLoaiTour, maPhuongTien, maXP, maDDL);
                    lTour.Add(tour);
                }
                reader.Close();
                return lTour;
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
       
        public string GenerateMaTour()
        {
            string sql = "SELECT TOP 1 MaTour FROM THONGTINTOUR WHERE MaTour LIKE 'T%' ORDER BY MaPhuongTien DESC";
            try
            {
                Connect();
                object result = MyExcuteScalar(sql, CommandType.Text);
                if (result != null && result != DBNull.Value)
                {
                    string lastMaTour = result.ToString();
                    int number = int.Parse(lastMaTour.Substring(2));
                    return "T" + (number + 1).ToString("D3");
                }
                else
                {
                    return "T000";
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
        public int InsertTour(Tour t)
        {
            string sql = "uspAddTour";
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@MaTour", t.MaTour));
            parameters.Add(new SqlParameter("@TenTour", t.TenTour));
            parameters.Add(new SqlParameter("@MoTaTour", t.MoTaTour));
            parameters.Add(new SqlParameter("@AnhTour", t.AnhTour));
            parameters.Add(new SqlParameter("@GiaTour", t.GiaTour));
            parameters.Add(new SqlParameter("@TGBatDau", t.TGBatDau));
            parameters.Add(new SqlParameter("@TGKetThuc", t.TGKetThuc));
            parameters.Add(new SqlParameter("@MaLoaiTour", t.MaLoaiTour));
            parameters.Add(new SqlParameter("@MaPhuongTien", t.MaPhuongTien));
            parameters.Add(new SqlParameter("@MaXP", t.MaXP));
            parameters.Add(new SqlParameter("@MaDDL", t.MaDDL));
            try
            {
                return MyExecuteNonQuery(sql, CommandType.StoredProcedure, parameters);
            }
            catch(SqlException ex)
            {
                throw ex;
            }
        }
        public int UpdateTour(Tour t)
        {
            string sql = "uspUpdateTour";
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@MaTour", t.MaTour));
            parameters.Add(new SqlParameter("@TenTour", t.TenTour));
            parameters.Add(new SqlParameter("@MoTaTour", t.MoTaTour));
            parameters.Add(new SqlParameter("@AnhTour", t.AnhTour));
            parameters.Add(new SqlParameter("@GiaTour", t.GiaTour));
            parameters.Add(new SqlParameter("@TGBatDau", t.TGBatDau));
            parameters.Add(new SqlParameter("@TGKetThuc", t.TGKetThuc));
            parameters.Add(new SqlParameter("@MaLoaiTour", t.MaLoaiTour));
            parameters.Add(new SqlParameter("@MaPhuongTien", t.MaPhuongTien));
            parameters.Add(new SqlParameter("@MaXP", t.MaXP));
            parameters.Add(new SqlParameter("@MaDDL", t.MaDDL));
            try
            {
                return MyExecuteNonQuery(sql, CommandType.StoredProcedure,parameters);
            }
            catch(SqlException ex)
            {
                throw ex;
            }
        }

        public int DeleteTour(string maTour)
        {
            string sql = "DELETE FROM TOUR WHERE MaTour = '"+maTour+"'";
            try
            {
                return MyExecuteNonQuery(sql, CommandType.Text);
            }
            catch(SqlException ex)
            {
                throw ex;
            }
        }
        public bool IsCheckKH_Tour(string maTour)
        {
            string sql = "SELECT COUNT(*) FROM HOADON WHERE MaTour = '"+maTour+"'";
            try
            {
                object result = MyExcuteScalar(sql, CommandType.Text);
                int count = result != null ? Convert.ToInt32(result) : 0;
                return count > 0;
            }
            catch (SqlException ex)
            {
                throw ex;
            }   
        }
    }
}

