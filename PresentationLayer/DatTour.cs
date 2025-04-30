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
    public partial class DatTour : Form
    {
        private DatTourBL tourbl = new DatTourBL();
      
        public DatTour()
        {
            InitializeComponent();
           
        }


        private void DatTour_Load(object sender, EventArgs e)
        {
            try
            {
                dgvTTTour.DataSource = tourbl.GetTours();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách tour  : " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dgvTTTour_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;

            if (i >= 0)
            {
                lbMaTour.Text = dgvTTTour.Rows[i].Cells[0].Value.ToString();
                lbTenTour.Text = dgvTTTour.Rows[i].Cells[1].Value.ToString();
                rbMoTa.Text = dgvTTTour.Rows[i].Cells[2].Value.ToString();
                ptbAnhTour.Text = dgvTTTour.Rows[i].Cells[3].Value.ToString();
                lbGiaTour.Text = dgvTTTour.Rows[i].Cells[4].Value.ToString();

                lbTGBatDau.Text = dgvTTTour.Rows[i].Cells[5].Value.ToString();
                lbTGKetThuc.Text = dgvTTTour.Rows[i].Cells[6].Value.ToString();

                lbTenLoaiTour.Text = dgvTTTour.Rows[i].Cells[7].Value.ToString();
                lbPT.Text = dgvTTTour.Rows[i].Cells[8].Value.ToString();
                lbDiemXP.Text = dgvTTTour.Rows[i].Cells[9].Value.ToString();
                lbMaDDL.Text = dgvTTTour.Rows[i].Cells[10].Value.ToString();
            }
        }
  

        private void btnTim_Click(object sender, EventArgs e)
        {
            string keyword = txtTimTour.Text.Trim();
            dgvTTTour.DataSource = tourbl.SearchTourByName(keyword);
        }

        private void cboLoaiTour_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedTourType = cboLoaiTour.SelectedItem.ToString();
            List<Tour> tours = tourbl.GetTourByType(selectedTourType);

            dgvTTTour.DataSource = tours;

        }

        private void btnAll_Click(object sender, EventArgs e)
        {

        }

        private void btnDatTour_Click_1(object sender, EventArgs e)
        {

            string maTour = dgvTTTour.CurrentRow.Cells[0].Value.ToString();
            QuanLyVe formVe = new QuanLyVe(maTour);
            formVe.ShowDialog();
        }
    }
}

