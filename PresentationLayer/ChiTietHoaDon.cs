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
    public partial class ChiTietHD: Form
    {
        ChiTietHoaDonBL CTHDbl = new ChiTietHoaDonBL();
        private string maHD;
        private ChiTietHoaDon dtoHienTai;

        public ChiTietHD()
        {
            InitializeComponent();
        }
        public ChiTietHD(string soHD)
        {
            InitializeComponent();
            maHD = soHD;
        
        }
        private void ChiTietHD_Load(object sender, EventArgs e)
        {

            // Kiểm tra giá trị của maHD trước khi lấy thông tin chi tiết
            if (string.IsNullOrEmpty(maHD))
            {
                MessageBox.Show("Số hóa đơn không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Lấy thông tin chi tiết hóa đơn từ BusinessLayer
            dtoHienTai = CTHDbl.LayThongTinChiTiet(maHD);

            if (dtoHienTai != null)
            {
                lbSoHD.Text = dtoHienTai.SoHD;
                lbTenNV.Text = dtoHienTai.TenNV;
                lbTenKH.Text = dtoHienTai.TenKH;
                lbNgayLap.Text = dtoHienTai.NgayLapHD.ToString("dd/MM/yyyy");
                lbThanhTien.Text = dtoHienTai.ThanhTien.ToString("N0"); // Hiển thị thành tiền

                lbTenTour.Text = dtoHienTai.TenTour;
                lbDiemXP.Text = dtoHienTai.DiemXP;
                lbPTien.Text = dtoHienTai.TenPhuongTien;
                lbNgayDi.Text = dtoHienTai.TGBatDau.ToString("dd/MM/yyyy");
                lbNgayKT.Text = dtoHienTai.TGKetThuc.ToString("dd/MM/yyyy");
                lbSoVe.Text = dtoHienTai.SLVeConLai.ToString(); // Hiển thị số lượng vé
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin chi tiết hóa đơn.");
            }
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font fontTitle = new Font("Times New Roman", 18, FontStyle.Bold);
            Font fontContent = new Font("Arial", 12, FontStyle.Regular);
            Brush brush = Brushes.Black;

            float y = 100;

            e.Graphics.DrawString("HÓA ĐƠN DU LỊCH", fontTitle, Brushes.DarkRed, new PointF(250, y));
            y += 50;

            if (dtoHienTai != null)
            {
                e.Graphics.DrawString("Số HĐ: " + dtoHienTai.SoHD, fontContent, brush, new PointF(50, y)); y += 30;
                e.Graphics.DrawString("Khách hàng: " + dtoHienTai.TenKH, fontContent, brush, new PointF(50, y)); y += 30;
                e.Graphics.DrawString("Nhân viên: " + dtoHienTai.TenNV, fontContent, brush, new PointF(50, y)); y += 30;
                e.Graphics.DrawString("Ngày lập: " + dtoHienTai.NgayLapHD.ToString("dd/MM/yyyy"), fontContent, brush, new PointF(50, y)); y += 30;
                e.Graphics.DrawString("Tên tour: " + dtoHienTai.TenTour, fontContent, brush, new PointF(50, y)); y += 30;
                e.Graphics.DrawString("Điểm xuất phát: " + dtoHienTai.DiemXP, fontContent, brush, new PointF(50, y)); y += 30;
                e.Graphics.DrawString("Phương tiện: " + dtoHienTai.TenPhuongTien, fontContent, brush, new PointF(50, y)); y += 30;
                e.Graphics.DrawString("Ngày đi: " + dtoHienTai.TGBatDau.ToString("dd/MM/yyyy"), fontContent, brush, new PointF(50, y)); y += 30;
                e.Graphics.DrawString("Ngày kết thúc: " + dtoHienTai.TGKetThuc.ToString("dd/MM/yyyy"), fontContent, brush, new PointF(50, y)); y += 30;
                e.Graphics.DrawString("Số vé: " + dtoHienTai.SLVeConLai.ToString(), fontContent, brush, new PointF(50, y)); y += 30;
                e.Graphics.DrawString("Thành tiền: " + dtoHienTai.ThanhTien.ToString("N0") + " VND", fontContent, brush, new PointF(50, y)); y += 40;
            }
            else
            {
                e.Graphics.DrawString("Không có dữ liệu hóa đơn để in.", fontContent, Brushes.Red, new PointF(50, y));
            }

            e.Graphics.DrawString("Cảm ơn quý khách. Chúc chuyến đi vui vẻ!", fontContent, brush, new PointF(50, y));
        }
       

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
