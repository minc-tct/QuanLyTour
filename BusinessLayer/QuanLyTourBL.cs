using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DataLayer;
using TransferObject;

namespace BusinessLayer
{
    public class QuanLyTourBL
    {
        private QuanLyTourDL tourdl;

        public QuanLyTourBL()
        {
            tourdl = new QuanLyTourDL();
        }

        public List<Tour> GetTours()
        {
            try
            {
                return tourdl.GetTour();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public int SuaTour(Tour tour)
        {
            return tourdl.UpdateTour(tour);

        }
        public int ThemTour(Tour tour)
        {
            tour.MaTour = tourdl.GenerateMaTour();
            if (string.IsNullOrWhiteSpace(tour.TenTour))
                throw new ArgumentException("Tên tour không được để trống.");

            return tourdl.InsertTour(tour);
        }
        public bool KiemTraTourDaDat(string maTour)
        {
            return tourdl.IsCheckKH_Tour(maTour); // gọi xuống DL kiểm tra
        }
        public int XoaTour(string maTour)
        {
            return tourdl.DeleteTour(maTour);
        }
    }
}
