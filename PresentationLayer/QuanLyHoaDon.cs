using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using BusinessLayer;
using TransferObject;
using System.Data.SqlClient;

namespace PresentationLayer
{
    public partial class QuanLyHoaDon : Form
    {
        private HoaDonBL hdBL = new HoaDonBL();

        public QuanLyHoaDon()
        {
            InitializeComponent();
        }
        private void dgvHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i >= 0)
            {
                lbSoHD.Text = dgvHD.Rows[i].Cells[0].Value.ToString();
                lbMaTour.Text = dgvHD.Rows[i].Cells[3].Value.ToString();

                dptNgayLapHD.Text = dgvHD.Rows[i].Cells[6].Value.ToString();
                lbThanhTien.Text = dgvHD.Rows[i].Cells[7].Value.ToString();
            }
        }
        private void QuanLyHoaDon_Load(object sender, EventArgs e)
        {
            try
            {
                dgvHD.AutoGenerateColumns = true;
                dgvHD.DataSource = hdBL.GetHoaDons();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách hóa đơn: " + ex.Message);
            }

        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string soHD = lbSoHD.Text.Trim(); // Lấy từ label đang hiển thị mã hóa đơn

                if (string.IsNullOrEmpty(soHD))
                {
                    MessageBox.Show("Vui lòng chọn hóa đơn để xóa.");
                    return;
                }

                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa hóa đơn này?", "Xác nhận", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if (hdBL.XoaHoaDon(soHD)>0)
                    {
                        MessageBox.Show("Xóa hóa đơn thành công!");
                        dgvHD.DataSource = hdBL.GetHoaDons(); // Load lại danh sách
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa hóa đơn!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa hóa đơn: " + ex.Message);
            }

        }

        private void btnChiTietHD_Click(object sender, EventArgs e)
        {
 // Kiểm tra nếu không có dòng nào được chọn hoặc dòng đang chọn không có thông tin hợp lệ
    if (dgvHD.SelectedRows.Count == 0 || dgvHD.CurrentRow == null || dgvHD.CurrentRow.Cells[0].Value == null || string.IsNullOrEmpty(dgvHD.CurrentRow.Cells[0].Value.ToString()))
    {
        MessageBox.Show("Vui lòng chọn một hóa đơn để xem chi tiết!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
    }

    string soHD = dgvHD.CurrentRow.Cells[0].Value.ToString();

    // Mở form chi tiết với mã hóa đơn đã chọn
    ChiTietHD frm = new ChiTietHD(soHD);
    frm.ShowDialog();
        }
    }
}

