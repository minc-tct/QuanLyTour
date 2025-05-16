using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObject.DichVu;

namespace DataLayer
{
    public class DiemDuLichDL:DataProvider
    {
        public List<DiemDuLich> GetDiemDuLich()
        {
            string ma, ten,maLoai;
            List<DiemDuLich> ddl = new List<DiemDuLich>();
            string sql = "SELECT * FROM DIEMDULICH";
            try
            {
                Connect();
                SqlDataReader reader = MyExcuteReader(sql, CommandType.Text);
                while (reader.Read())
                {
                    ma = reader[0].ToString();
                    ten = reader[1].ToString();
                    maLoai = reader[2].ToString();

                    DiemDuLich duLich = new DiemDuLich(ma, ten,maLoai);
                    ddl.Add(duLich);
                }
                reader.Close();
                return ddl;
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
        public string GenerateMaDiemDuLich()
        {
            string sql = "SELECT TOP 1 MaDDL FROM DIEMDULICH WHERE MaDDL LIKE 'DL%' ORDER BY MaDDL DESC";
            try
            {
                Connect(); 
                object result = MyExcuteScalar(sql, CommandType.Text);
                if (result != null && result != DBNull.Value)
                {
                    string lastMaDDL = result.ToString();
                    int number = int.Parse(lastMaDDL.Substring(2)); 
                    return "DL" + (number + 1).ToString("D3");    
                }
                else
                {
                    return "DL000"; 
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
        public int Insert(DiemDuLich d)
        {
            string sql = "INSERT INTO DIEMDULICH VALUES ('" + d.MaDDL + "',N'" + d.TenDDL +"','"+ d.MaLoaiTour +"')";
            try
            {
                return MyExecuteNonQuery(sql, CommandType.Text);
            }
            catch(SqlException ex)
            {
                throw ex;
            }
        }

        public int Update(DiemDuLich d)
        {
            string sql = "UPDATE DIEMDULICH SET TenDDL = N'" + d.TenDDL + "', MaLoaiTour='" + d.MaLoaiTour + "' WHERE MaDDL = '" + d.MaDDL + "'";
            try
            {
                return MyExecuteNonQuery(sql, CommandType.Text);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public int Delete(string maDDL)
        {
            string sql = "DELETE FROM DIEMDULICH WHERE MaDDL = '"+ maDDL +"'";
            try
            {
                return MyExecuteNonQuery(sql, CommandType.Text);
            }
            catch(SqlException ex)
            {
                throw ex;
            }
        }
    }
}
