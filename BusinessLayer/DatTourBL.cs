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
    public class DatTourBL
    {
        private DatTourDL tourdl;

        public DatTourBL()
        {
            tourdl = new DatTourDL();
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
        public List<Tour> SearchTourByName(string keyword)
        {
            try
            {
                return tourdl.SearchTourByName(keyword);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public List<Tour> GetTourByType(string tourType)
        {
            return tourdl.GetTourByType(tourType); // Trả về danh sách tour theo loại
        }
    }
}
