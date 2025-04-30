using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransferObject;

namespace PresentationLayer
{
    public partial class QuanLyVe : Form
    {
        private string maTour;
        private QuanLyVeBL vebl = new QuanLyVeBL();
        private KhachHangBL khbl = new KhachHangBL();
        private QuanLyHoaDon hdbl = new QuanLyHoaDon();
        private Ve ve;
        public QuanLyVe()
        {
            InitializeComponent();
        }
        public QuanLyVe(string maTour)
        {
            InitializeComponent();
            this.maTour = maTour;

        }


        private void QuanLyVe_Load(object sender, EventArgs e)
        {
            ve = vebl.LayThongTinVeTheoMaTour(maTour);

            if (ve != null)
            {
                lbMaTour.Text = ve.MaTour;
                lbTenTour.Text = ve.TenTour;
                lbGiaTour.Text = ve.Gia.ToString("N0");
                lbXuatPhat.Text = ve.DiaDiemXP;
                lbPhuongTien.Text = ve.TenPhuongTien;
                lbTGBatDau.Text = ve.TGBatDau.ToString("dd/MM/yyyy");
                lbTGKetThuc.Text = ve.TGKetThuc.ToString("dd/MM/yyyy");
                lbThoiGian.Text = (ve.TGKetThuc - ve.TGBatDau).Days.ToString();

                lbThanhTien.Text = "0";
            }
            else
            {
                MessageBox.Show("Không tìm thấy Tour!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            string sdt = txtSDT.Text.Trim();

            if (string.IsNullOrEmpty(sdt))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại khách hàng.");
                return;
            }

            KhachHang kh = khbl.TimKhachHangTheoSDT(sdt);

            if (kh != null)
            {
                lbMaKH.Text = kh.MaKH;          // <-- Cập nhật thêm dòng này
                lbHoTen.Text = kh.HoTen;
                lbGioiTinh.Text = kh.GioiTinh;
                lbEmail.Text = kh.Email;
                lbSoDienThoai.Text = kh.SDT;            // Nếu vẫn muốn hiện SDT
            }
            else
            {
                MessageBox.Show("Không tìm thấy khách hàng có số điện thoại này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lbMaKH.Text = lbHoTen.Text = lbGioiTinh.Text = lbEmail.Text = lbSDT.Text = "";
            }
        }

        private void txtSLVe_TextChanged(object sender, EventArgs e)
        {

            Control ctr = (Control)sender;

            if ((txtSLVe.Text == "") || ctr.Text.Length > 0 && !Char.IsDigit(ctr.Text[ctr.Text.Length - 1]))
            {
                this.errorProvider1.SetError(ctr, "Hãy nhập đúng số lượng vé");
            }
            else
            {
                int slg;
                if (int.TryParse(txtSLVe.Text.Trim(), out slg) && slg > 0)
                {
                    // Gọi BusinessLayer để tính thành tiền
                    decimal thanhtien = vebl.TinhThanhTien(ve, slg);

                    // Hiển thị thành tiền lên giao diện
                    lbThanhTien.Text = thanhtien.ToString("N0");
                    lbThanhTien.Visible = true;
                    this.errorProvider1.Clear();
                }
                else
                {
                    this.errorProvider1.SetError(ctr, "Số lượng vé phải là một số dương hợp lệ.");
                }
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra thông tin khách hàng và số lượng vé
                if (grTTKH.Visible == false)
                {
                    MessageBox.Show("Mời nhập thông tin KH", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else if (txtSLVe.Text.Trim() == "")
                {
                    MessageBox.Show("Mời nhập số lượng vé", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                int slg;
                if (!int.TryParse(txtSLVe.Text.Trim(), out slg) || slg <= 0)
                {
                    MessageBox.Show("Số lượng vé phải là một số dương hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Tính thành tiền
                decimal thanhTien = decimal.Parse(lbThanhTien.Text.Trim().Replace(",", "").Replace("VND", "").Trim());

                // Tạo đối tượng hóa đơn từ thông tin form
                HoaDon hoaDon = new HoaDon
                {
                    MaKH = lbMaKH.Text.Trim(),
                    MaTour = lbMaTour.Text.Trim(),
                    SoLuongVe = slg,
                    ThanhTien = thanhTien,
                    NgayLapHD = DateTime.Now
                };

                // Gọi BusinessLayer để xử lý thanh toán
                HoaDonBL hoaDonBL = new HoaDonBL();
                bool ketQuaThanhToan = hoaDonBL.XuLyThanhToan(hoaDon);

                if (ketQuaThanhToan)
                {
                    MessageBox.Show("Thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Sau khi thanh toán thành công, mở form ChiTietHD với số hóa đơn đã tạo
                    ChiTietHD chiTietHDForm = new ChiTietHD(hoaDon.SoHD);
                    chiTietHDForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Thanh toán không thành công. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}