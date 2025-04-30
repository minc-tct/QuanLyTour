using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObject;

namespace BusinessLayer
{
    public class DangKyBL
    {
        private NhanVienDL nvDL = new NhanVienDL();
        private DangKyTKDL tkDL = new DangKyTKDL();

        public bool DangKy(NhanVien nv, Account acc)
        {
            if (tkDL.IsUsernameTaken(acc.TenDangNhap))
                throw new Exception("Tên đăng nhập đã tồn tại!");

            string maNV = nvDL.Insert(nv);
            if (!string.IsNullOrEmpty(maNV))
            {
                acc.MaNV = maNV; 
                return tkDL.Insert(acc) > 0;
            }
            return false;
        }
    }
}
