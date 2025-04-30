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
    public class DatTourDL : DataProvider
    {
        public List<Tour> GetTour()
        {
            List<Tour> lTour = new List<Tour>();
            string sql = "SELECT * FROM THONGTINTOUR";

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

        // Tìm kiếm tour theo tên
        public List<Tour> SearchTourByName(string ten)
        {
            List<Tour> list = new List<Tour>();
            string sql = "SELECT * FROM THONGTINTOUR WHERE TenTour COLLATE SQL_Latin1_General_CP1_CI_AI LIKE '"+ten+"'";
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
                    list.Add(tour);
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

        public List<Tour> GetTourByType(string tourType)
        {
            List<Tour> lTour = new List<Tour>();
            string sql = "";

            if (tourType == "Trong Nước")
            {
                sql = "SELECT * FROM THONGTINTOUR WHERE MaLoaiTour = 'TN'"; 
            }
            else if (tourType == "Ngoài Nước")
            {
                sql = "SELECT * FROM THONGTINTOUR WHERE MaLoaiTour = 'NN'"; 
            }
            else
            {
                sql = "SELECT * FROM THONGTINTOUR";
            }
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
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                Disconnect();
            }
            return lTour;
        }
    }
}
