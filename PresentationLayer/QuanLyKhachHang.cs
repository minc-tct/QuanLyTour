using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using BusinessLayer;
using TransferObject;

namespace PresentationLayer
{
    public partial class QuanLyKhachHang : Form
    {
        private KhachHangBL khbl = new KhachHangBL();

        public QuanLyKhachHang()
        {
            InitializeComponent();
        }

        private void QuanLyKhachHang_Load(object sender, EventArgs e)
        {
            try
            {
                dgvKH.DataSource = khbl.GetKhachHangs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách khách  : " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;

            if (i >= 0)
            {
                txtMaKH.Text = dgvKH.Rows[i].Cells["MaKH"].Value.ToString();
                txtTenKH.Text = dgvKH.Rows[i].Cells["HoTen"].Value.ToString();
                txtSdt.Text = dgvKH.Rows[i].Cells["Sdt"].Value.ToString();
                txtEmail.Text = dgvKH.Rows[i].Cells["Email"].Value.ToString();

                string gioiTinh = dgvKH.Rows[i].Cells["GioiTinh"].Value.ToString();
                if (gioiTinh == "Nam") rdoNam.Checked = true;
                else if (gioiTinh == "Nữ") rdoNu.Checked = true;

            }
        }
        private void btnTimKH_Click_1(object sender, EventArgs e)
        {
            string keyword = txtTimKH.Text.Trim();
            dgvKH.DataSource = khbl.SearchByName(keyword);
        }

        private void btnLamMoi_Click_1(object sender, EventArgs e)
        {
            txtMaKH.Clear();
            txtTenKH.Clear();
            txtSdt.Clear();
            txtEmail.Clear();
            rdoNam.Checked = false;
            rdoNu.Checked = false;

            // Load lại danh sách KH nếu cần
            dgvKH.DataSource = khbl.GetKhachHangs();
        }

        private void btnTaoMaKH_Click_1(object sender, EventArgs e)
        {
            string maMoi = khbl.TaoMaKhachHangMoi();
            txtMaKH.Text = maMoi;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maKH = txtMaKH.Text.Trim();
            if (string.IsNullOrEmpty(maKH))
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần sửa.");
                return;
            }

            string gioiTinh = rdoNam.Checked ? "Nam" : "Nữ";

            KhachHang kh = new KhachHang(
                maKH,
                txtTenKH.Text.Trim(),
                gioiTinh,
                txtSdt.Text.Trim(),
                txtEmail.Text.Trim()
            );
            if (khbl.Sua(kh)>0)
            {
                MessageBox.Show("Cập nhật thành công");
                dgvKH.DataSource = khbl.GetKhachHangs();
            }
            else
            {
                MessageBox.Show("Không được đổi mã khách hàng ");
                btnLamMoi_Click_1(sender, e);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string gioiTinh = rdoNam.Checked ? "Nam" : (rdoNu.Checked ? "Nữ" : null);

                KhachHang kh = new KhachHang
                {
                    HoTen = txtTenKH.Text.Trim(),
                    SDT = txtSdt.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    GioiTinh = gioiTinh
                };
                if (khbl.GetKhachHangs().Any(k => k.MaKH == txtMaKH.Text.Trim()))
                {
                    MessageBox.Show("Mã khách hàng đã tồn tại. Vui lòng tạo mã mới.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (khbl.Them(kh)>0)
                {
                    MessageBox.Show("Thêm khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnLamMoi_Click_1(sender, e);
                }
                else
                {
                    MessageBox.Show("Thêm thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maKH = txtMaKH.Text.Trim();

            if (string.IsNullOrEmpty(maKH))
            {
                MessageBox.Show("Vui lòng chọn khách hàng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra ràng buộc HOÁ ĐƠN (gọi BL)
            if (khbl.KiemTraKhachHangCoHoaDon(maKH))
            {
                MessageBox.Show("Không thể xóa khách hàng vì đang có hóa đơn.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Xác nhận xóa
            var confirm = MessageBox.Show("Bạn có chắc muốn xóa khách hàng này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                int ketQua = khbl.XoaKhachHang(maKH); // gọi BL xử lý xóa
                if (ketQua>0)
                {
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvKH.DataSource = khbl.GetKhachHangs();
                    btnLamMoi_Click_1(sender, e);
                }
                else
                {
                    MessageBox.Show("Xóa không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

       
    }
}
        