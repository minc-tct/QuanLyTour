
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
using TransferObject;
using BusinessLayer;

namespace PresentationLayer
{
    public partial class QuanLyTour: Form
    {
        private QuanLyTourBL tourbl = new QuanLyTourBL();
        public QuanLyTour()
        {
            InitializeComponent();
        }

        private void QuanLyTour_Load(object sender, EventArgs e)
        {
            try
            {
                dgvThongtinTour.DataSource = tourbl.GetTours();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách tour  : " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvThongtinTour_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;

            if (i >= 0)
            {
                txtMaTour.Text = dgvThongtinTour.Rows[i].Cells[0].Value.ToString();
                txtTenTour.Text = dgvThongtinTour.Rows[i].Cells[1].Value.ToString();
                txtMoTa.Text = dgvThongtinTour.Rows[i].Cells[2].Value.ToString();
                txtHinhAnh.Text = dgvThongtinTour.Rows[i].Cells[3].Value.ToString();
                txtGiaTour.Text = dgvThongtinTour.Rows[i].Cells[4].Value.ToString();

                dptNgayBD.Value = Convert.ToDateTime(dgvThongtinTour.Rows[i].Cells[5].Value);
                dptNgayKT.Value = Convert.ToDateTime(dgvThongtinTour.Rows[i].Cells[6].Value);

                txtMaLoaiTour.Text = dgvThongtinTour.Rows[i].Cells[7].Value.ToString();
                txtMaPT.Text = dgvThongtinTour.Rows[i].Cells[8].Value.ToString();
                txtMaXP.Text = dgvThongtinTour.Rows[i].Cells[9].Value.ToString();
                txtMaDDL.Text = dgvThongtinTour.Rows[i].Cells[10].Value.ToString();
            }
        }

        //private void btnTaoMa_Click(object sender, EventArgs e)
        //{
        //    string maMoi = tourbl.TaoMaTourMoi();
        //    txtMaTour.Text = maMoi;
        //}

        private void btnThemTour_Click(object sender, EventArgs e)
        {
            try
            {
                Tour tour = new Tour
                {
                    MaTour = txtMaTour.Text.Trim(),
                    TenTour = txtTenTour.Text.Trim(),
                    MoTaTour = txtMoTa.Text.Trim(),
                    AnhTour = txtHinhAnh.Text.Trim(),
                    GiaTour = decimal.Parse(txtGiaTour.Text.Trim()),
                    TGBatDau = dptNgayBD.Value,
                    TGKetThuc = dptNgayKT.Value,
                    MaLoaiTour = txtMaLoaiTour.Text.Trim(),
                    MaPhuongTien = txtMaPT.Text.Trim(),
                    MaXP = txtMaXP.Text.Trim(),
                    MaDDL = txtMaDDL.Text.Trim()
                };

                if (tourbl.GetTours().Any(t => t.MaTour == tour.MaTour))
                {
                    MessageBox.Show("Mã tour đã tồn tại. Vui lòng chọn mã khác.", "Cảnh báo");
                    return;
                }
                if (tourbl.ThemTour(tour)>0)
                {
                    MessageBox.Show("Thêm tour thành công!");
                    dgvThongtinTour.DataSource = tourbl.GetTours();
                }
                else
                {
                    MessageBox.Show("Thêm tour thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm tour: " + ex.Message);
            }
        }

        private void btnXoaTour_Click(object sender, EventArgs e)
        {
            try
            {
                string maTour = txtMaTour.Text.Trim();
                if (string.IsNullOrEmpty(maTour))
                {
                    MessageBox.Show("Vui lòng chọn tour để xóa.");
                    return;
                }

                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa tour này?", "Xác nhận", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if (tourbl.XoaTour(maTour) > 0)
                    {
                        MessageBox.Show("Xóa tour thành công!");
                        dgvThongtinTour.DataSource = tourbl.GetTours();
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa tour!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa tour: " + ex.Message);
            }
        }

        private void btnSuaTour_Click(object sender, EventArgs e)
        {
            try
            {
                string maTour = txtMaTour.Text.Trim();
                if (string.IsNullOrEmpty(maTour))
                {
                    MessageBox.Show("Vui lòng chọn tour cần sửa.");
                    return;
                }

                Tour tour = new Tour
                {
                    MaTour = maTour,
                    TenTour = txtTenTour.Text.Trim(),
                    MoTaTour = txtMoTa.Text.Trim(),
                    AnhTour = txtHinhAnh.Text.Trim(),
                    GiaTour = decimal.Parse(txtGiaTour.Text.Trim()),
                    TGBatDau = dptNgayBD.Value,
                    TGKetThuc = dptNgayKT.Value,
                    MaLoaiTour = txtMaLoaiTour.Text.Trim(),
                    MaPhuongTien = txtMaPT.Text.Trim(),
                    MaXP = txtMaXP.Text.Trim(),
                    MaDDL = txtMaDDL.Text.Trim()
                };
                if (tourbl.SuaTour(tour)>0)
                {
                    MessageBox.Show("Cập nhật tour thành công!");
                    dgvThongtinTour.DataSource = tourbl.GetTours();
                }
                else
                {
                    MessageBox.Show("Không thể cập nhật tour!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa tour: " + ex.Message);
            }
        }

    }
}
