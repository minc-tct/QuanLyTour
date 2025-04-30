using System.Windows.Forms;

namespace PresentationLayer
{
    partial class DatTour
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnAll = new System.Windows.Forms.Button();
            this.cboLoaiTour = new System.Windows.Forms.ComboBox();
            this.lbTim = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbMaDDL = new System.Windows.Forms.Label();
            this.lbDiem = new System.Windows.Forms.Label();
            this.dgvTTTour = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTim = new System.Windows.Forms.Button();
            this.txtTimTour = new System.Windows.Forms.TextBox();
            this.rbMoTa = new System.Windows.Forms.RichTextBox();
            this.lbType = new System.Windows.Forms.Label();
            this.lbDescription = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbIDTour = new System.Windows.Forms.Label();
            this.ptbAnhTour = new System.Windows.Forms.PictureBox();
            this.lbTenLoaiTour = new System.Windows.Forms.Label();
            this.lbTGKetThuc = new System.Windows.Forms.Label();
            this.lbthoigian = new System.Windows.Forms.Label();
            this.lbTGBatDau = new System.Windows.Forms.Label();
            this.lbSLVe = new System.Windows.Forms.Label();
            this.lb_soluongve = new System.Windows.Forms.Label();
            this.lbphuongtien = new System.Windows.Forms.Label();
            this.btnDatTour = new System.Windows.Forms.Button();
            this.lbTenTour = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbxuatphat = new System.Windows.Forms.Label();
            this.lbDiemXP = new System.Windows.Forms.Label();
            this.lbPT = new System.Windows.Forms.Label();
            this.lbMaTour = new System.Windows.Forms.Label();
            this.lbGiaTour = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTTTour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAnhTour)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btnAll
            // 
            this.btnAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAll.FlatAppearance.BorderSize = 0;
            this.btnAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAll.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAll.ForeColor = System.Drawing.Color.White;
            this.btnAll.Location = new System.Drawing.Point(606, 607);
            this.btnAll.Margin = new System.Windows.Forms.Padding(4);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(140, 38);
            this.btnAll.TabIndex = 28;
            this.btnAll.Text = "Tất cả";
            this.btnAll.UseVisualStyleBackColor = false;
            // 
            // cboLoaiTour
            // 
            this.cboLoaiTour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboLoaiTour.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cboLoaiTour.FormattingEnabled = true;
            this.cboLoaiTour.Items.AddRange(new object[] {
            "Trong Nước",
            "Ngoài Nước"});
            this.cboLoaiTour.Location = new System.Drawing.Point(518, 78);
            this.cboLoaiTour.Margin = new System.Windows.Forms.Padding(4);
            this.cboLoaiTour.Name = "cboLoaiTour";
            this.cboLoaiTour.Size = new System.Drawing.Size(228, 34);
            this.cboLoaiTour.TabIndex = 8;
            this.cboLoaiTour.Text = "Lọc theo loại tour";
            this.cboLoaiTour.SelectedIndexChanged += new System.EventHandler(this.cboLoaiTour_SelectedIndexChanged);
            // 
            // lbTim
            // 
            this.lbTim.AutoSize = true;
            this.lbTim.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTim.Location = new System.Drawing.Point(21, 49);
            this.lbTim.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTim.Name = "lbTim";
            this.lbTim.Size = new System.Drawing.Size(214, 26);
            this.lbTim.TabIndex = 7;
            this.lbTim.Text = "Nhập tên tour cần tìm";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbMaDDL);
            this.groupBox1.Controls.Add(this.btnAll);
            this.groupBox1.Controls.Add(this.lbDiem);
            this.groupBox1.Controls.Add(this.cboLoaiTour);
            this.groupBox1.Controls.Add(this.lbTim);
            this.groupBox1.Controls.Add(this.dgvTTTour);
            this.groupBox1.Controls.Add(this.btnTim);
            this.groupBox1.Controls.Add(this.txtTimTour);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(36, 21);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(754, 666);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách Tour";
            // 
            // lbMaDDL
            // 
            this.lbMaDDL.AutoSize = true;
            this.lbMaDDL.Location = new System.Drawing.Point(605, 27);
            this.lbMaDDL.Name = "lbMaDDL";
            this.lbMaDDL.Size = new System.Drawing.Size(112, 33);
            this.lbMaDDL.TabIndex = 23;
            this.lbMaDDL.Text = "MaDiem";
            // 
            // lbDiem
            // 
            this.lbDiem.AutoSize = true;
            this.lbDiem.Location = new System.Drawing.Point(491, 27);
            this.lbDiem.Name = "lbDiem";
            this.lbDiem.Size = new System.Drawing.Size(108, 33);
            this.lbDiem.TabIndex = 22;
            this.lbDiem.Text = "MaDDL";
            // 
            // dgvTTTour
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTTTour.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvTTTour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTTTour.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11});
            this.dgvTTTour.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTTTour.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvTTTour.Location = new System.Drawing.Point(-12, 186);
            this.dgvTTTour.Name = "dgvTTTour";
            this.dgvTTTour.RowHeadersWidth = 51;
            this.dgvTTTour.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTTTour.Size = new System.Drawing.Size(745, 414);
            this.dgvTTTour.TabIndex = 42;
            this.dgvTTTour.UseWaitCursor = true;
            this.dgvTTTour.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTTTour_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "MaTour";
            this.Column1.HeaderText = "Mã tour";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "TenTour";
            this.Column2.FillWeight = 120F;
            this.Column2.HeaderText = "Tên tour";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "MoTaTour";
            this.Column3.FillWeight = 130F;
            this.Column3.HeaderText = "Mô tả tour";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "AnhTour";
            this.Column4.HeaderText = "Ảnh tour";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.DataPropertyName = "GiaTour";
            this.Column5.HeaderText = "Giá tour";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.DataPropertyName = "TGBatDau";
            this.Column6.FillWeight = 120F;
            this.Column6.HeaderText = "TG  bắt đầu";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.DataPropertyName = "TGKetThuc";
            this.Column7.FillWeight = 120F;
            this.Column7.HeaderText = "TG kết thúc";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column8.DataPropertyName = "MaLoaiTour";
            this.Column8.HeaderText = "Mã loại tour";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column9.DataPropertyName = "MaPhuongTien";
            this.Column9.HeaderText = "Mã PT";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column10.DataPropertyName = "MaXP";
            this.Column10.HeaderText = "Mã XP";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "MaDDL";
            this.Column11.HeaderText = "Mã DDL";
            this.Column11.MinimumWidth = 6;
            this.Column11.Name = "Column11";
            this.Column11.Width = 125;
            // 
            // btnTim
            // 
            this.btnTim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTim.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTim.Location = new System.Drawing.Point(384, 78);
            this.btnTim.Margin = new System.Windows.Forms.Padding(4);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(112, 32);
            this.btnTim.TabIndex = 6;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtTimTour
            // 
            this.txtTimTour.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTimTour.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtTimTour.Location = new System.Drawing.Point(26, 81);
            this.txtTimTour.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimTour.Name = "txtTimTour";
            this.txtTimTour.Size = new System.Drawing.Size(329, 31);
            this.txtTimTour.TabIndex = 5;
            // 
            // rbMoTa
            // 
            this.rbMoTa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rbMoTa.BulletIndent = 2;
            this.rbMoTa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rbMoTa.ForeColor = System.Drawing.Color.Black;
            this.rbMoTa.Location = new System.Drawing.Point(382, 461);
            this.rbMoTa.Margin = new System.Windows.Forms.Padding(4);
            this.rbMoTa.Name = "rbMoTa";
            this.rbMoTa.ReadOnly = true;
            this.rbMoTa.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rbMoTa.Size = new System.Drawing.Size(245, 153);
            this.rbMoTa.TabIndex = 21;
            this.rbMoTa.Text = "";
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbType.ForeColor = System.Drawing.Color.Black;
            this.lbType.Location = new System.Drawing.Point(378, 382);
            this.lbType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(91, 24);
            this.lbType.TabIndex = 19;
            this.lbType.Text = "Loại tour";
            // 
            // lbDescription
            // 
            this.lbDescription.AutoSize = true;
            this.lbDescription.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescription.ForeColor = System.Drawing.Color.Black;
            this.lbDescription.Location = new System.Drawing.Point(378, 431);
            this.lbDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(60, 24);
            this.lbDescription.TabIndex = 18;
            this.lbDescription.Text = "Mô tả";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbPrice.ForeColor = System.Drawing.Color.Black;
            this.lbPrice.Location = new System.Drawing.Point(29, 651);
            this.lbPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(61, 23);
            this.lbPrice.TabIndex = 17;
            this.lbPrice.Text = "Price:";
            // 
            // lbIDTour
            // 
            this.lbIDTour.AutoSize = true;
            this.lbIDTour.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbIDTour.ForeColor = System.Drawing.Color.Black;
            this.lbIDTour.Location = new System.Drawing.Point(29, 618);
            this.lbIDTour.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbIDTour.Name = "lbIDTour";
            this.lbIDTour.Size = new System.Drawing.Size(82, 23);
            this.lbIDTour.TabIndex = 16;
            this.lbIDTour.Text = "Tour ID:";
            // 
            // ptbAnhTour
            // 
            this.ptbAnhTour.Location = new System.Drawing.Point(73, 89);
            this.ptbAnhTour.Margin = new System.Windows.Forms.Padding(4);
            this.ptbAnhTour.Name = "ptbAnhTour";
            this.ptbAnhTour.Size = new System.Drawing.Size(508, 271);
            this.ptbAnhTour.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbAnhTour.TabIndex = 15;
            this.ptbAnhTour.TabStop = false;
            // 
            // lbTenLoaiTour
            // 
            this.lbTenLoaiTour.AutoSize = true;
            this.lbTenLoaiTour.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTenLoaiTour.Location = new System.Drawing.Point(496, 382);
            this.lbTenLoaiTour.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTenLoaiTour.Name = "lbTenLoaiTour";
            this.lbTenLoaiTour.Size = new System.Drawing.Size(112, 22);
            this.lbTenLoaiTour.TabIndex = 14;
            this.lbTenLoaiTour.Text = "Tên loại tour";
            // 
            // lbTGKetThuc
            // 
            this.lbTGKetThuc.AutoSize = true;
            this.lbTGKetThuc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTGKetThuc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbTGKetThuc.Location = new System.Drawing.Point(209, 569);
            this.lbTGKetThuc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTGKetThuc.Name = "lbTGKetThuc";
            this.lbTGKetThuc.Size = new System.Drawing.Size(76, 22);
            this.lbTGKetThuc.TabIndex = 13;
            this.lbTGKetThuc.Text = "Kết thúc";
            // 
            // lbthoigian
            // 
            this.lbthoigian.AutoSize = true;
            this.lbthoigian.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbthoigian.ForeColor = System.Drawing.Color.Black;
            this.lbthoigian.Location = new System.Drawing.Point(29, 528);
            this.lbthoigian.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbthoigian.Name = "lbthoigian";
            this.lbthoigian.Size = new System.Drawing.Size(89, 23);
            this.lbthoigian.TabIndex = 12;
            this.lbthoigian.Text = "Thời gian";
            // 
            // lbTGBatDau
            // 
            this.lbTGBatDau.AutoSize = true;
            this.lbTGBatDau.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTGBatDau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbTGBatDau.Location = new System.Drawing.Point(209, 528);
            this.lbTGBatDau.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTGBatDau.Name = "lbTGBatDau";
            this.lbTGBatDau.Size = new System.Drawing.Size(85, 22);
            this.lbTGBatDau.TabIndex = 11;
            this.lbTGBatDau.Text = "Xuất phát";
            // 
            // lbSLVe
            // 
            this.lbSLVe.AutoSize = true;
            this.lbSLVe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbSLVe.Location = new System.Drawing.Point(209, 476);
            this.lbSLVe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSLVe.Name = "lbSLVe";
            this.lbSLVe.Size = new System.Drawing.Size(60, 22);
            this.lbSLVe.TabIndex = 10;
            this.lbSLVe.Text = "SL vé ";
            // 
            // lb_soluongve
            // 
            this.lb_soluongve.AutoSize = true;
            this.lb_soluongve.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_soluongve.ForeColor = System.Drawing.Color.Black;
            this.lb_soluongve.Location = new System.Drawing.Point(29, 476);
            this.lb_soluongve.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_soluongve.Name = "lb_soluongve";
            this.lb_soluongve.Size = new System.Drawing.Size(108, 23);
            this.lb_soluongve.TabIndex = 9;
            this.lb_soluongve.Text = "Số lượng vé";
            // 
            // lbphuongtien
            // 
            this.lbphuongtien.AutoSize = true;
            this.lbphuongtien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbphuongtien.ForeColor = System.Drawing.Color.Black;
            this.lbphuongtien.Location = new System.Drawing.Point(29, 431);
            this.lbphuongtien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbphuongtien.Name = "lbphuongtien";
            this.lbphuongtien.Size = new System.Drawing.Size(112, 23);
            this.lbphuongtien.TabIndex = 8;
            this.lbphuongtien.Text = "Phương tiện";
            // 
            // btnDatTour
            // 
            this.btnDatTour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatTour.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDatTour.Location = new System.Drawing.Point(382, 624);
            this.btnDatTour.Margin = new System.Windows.Forms.Padding(4);
            this.btnDatTour.Name = "btnDatTour";
            this.btnDatTour.Size = new System.Drawing.Size(221, 50);
            this.btnDatTour.TabIndex = 2;
            this.btnDatTour.Text = "Đặt Tour";
            this.btnDatTour.UseVisualStyleBackColor = true;
            this.btnDatTour.Click += new System.EventHandler(this.btnDatTour_Click_1);
            // 
            // lbTenTour
            // 
            this.lbTenTour.AutoSize = true;
            this.lbTenTour.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTenTour.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbTenTour.Location = new System.Drawing.Point(103, 49);
            this.lbTenTour.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTenTour.Name = "lbTenTour";
            this.lbTenTour.Size = new System.Drawing.Size(98, 26);
            this.lbTenTour.TabIndex = 0;
            this.lbTenTour.Text = "Tên Tour";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rbMoTa);
            this.groupBox4.Controls.Add(this.lbType);
            this.groupBox4.Controls.Add(this.lbDescription);
            this.groupBox4.Controls.Add(this.lbPrice);
            this.groupBox4.Controls.Add(this.lbIDTour);
            this.groupBox4.Controls.Add(this.ptbAnhTour);
            this.groupBox4.Controls.Add(this.lbTenLoaiTour);
            this.groupBox4.Controls.Add(this.lbTGKetThuc);
            this.groupBox4.Controls.Add(this.lbthoigian);
            this.groupBox4.Controls.Add(this.lbTGBatDau);
            this.groupBox4.Controls.Add(this.lbSLVe);
            this.groupBox4.Controls.Add(this.lb_soluongve);
            this.groupBox4.Controls.Add(this.lbphuongtien);
            this.groupBox4.Controls.Add(this.lbxuatphat);
            this.groupBox4.Controls.Add(this.lbDiemXP);
            this.groupBox4.Controls.Add(this.lbPT);
            this.groupBox4.Controls.Add(this.lbMaTour);
            this.groupBox4.Controls.Add(this.btnDatTour);
            this.groupBox4.Controls.Add(this.lbGiaTour);
            this.groupBox4.Controls.Add(this.lbTenTour);
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox4.Location = new System.Drawing.Point(852, 3);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(633, 681);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông tin chi tiết Tour";
            // 
            // lbxuatphat
            // 
            this.lbxuatphat.AutoSize = true;
            this.lbxuatphat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbxuatphat.ForeColor = System.Drawing.Color.Black;
            this.lbxuatphat.Location = new System.Drawing.Point(29, 383);
            this.lbxuatphat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbxuatphat.Name = "lbxuatphat";
            this.lbxuatphat.Size = new System.Drawing.Size(138, 23);
            this.lbxuatphat.TabIndex = 7;
            this.lbxuatphat.Text = "Điểm xuất phát";
            // 
            // lbDiemXP
            // 
            this.lbDiemXP.AutoSize = true;
            this.lbDiemXP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbDiemXP.Location = new System.Drawing.Point(209, 381);
            this.lbDiemXP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDiemXP.Name = "lbDiemXP";
            this.lbDiemXP.Size = new System.Drawing.Size(85, 22);
            this.lbDiemXP.TabIndex = 6;
            this.lbDiemXP.Text = "Xuất phát";
            // 
            // lbPT
            // 
            this.lbPT.AutoSize = true;
            this.lbPT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbPT.Location = new System.Drawing.Point(209, 434);
            this.lbPT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPT.Name = "lbPT";
            this.lbPT.Size = new System.Drawing.Size(104, 22);
            this.lbPT.TabIndex = 5;
            this.lbPT.Text = "Phương tien";
            // 
            // lbMaTour
            // 
            this.lbMaTour.AutoSize = true;
            this.lbMaTour.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbMaTour.Location = new System.Drawing.Point(209, 617);
            this.lbMaTour.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMaTour.Name = "lbMaTour";
            this.lbMaTour.Size = new System.Drawing.Size(72, 22);
            this.lbMaTour.TabIndex = 4;
            this.lbMaTour.Text = "Mã tour";
            // 
            // lbGiaTour
            // 
            this.lbGiaTour.AutoSize = true;
            this.lbGiaTour.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbGiaTour.Location = new System.Drawing.Point(207, 651);
            this.lbGiaTour.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbGiaTour.Name = "lbGiaTour";
            this.lbGiaTour.Size = new System.Drawing.Size(106, 26);
            this.lbGiaTour.TabIndex = 1;
            this.lbGiaTour.Text = "giá TOUR";
            // 
            // DatTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1582, 700);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Name = "DatTour";
            this.Text = "DatTour";
            this.Load += new System.EventHandler(this.DatTour_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTTTour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAnhTour)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.ComboBox cboLoaiTour;
        private System.Windows.Forms.Label lbTim;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtTimTour;
        private System.Windows.Forms.RichTextBox rbMoTa;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbIDTour;
        private System.Windows.Forms.PictureBox ptbAnhTour;
        private System.Windows.Forms.Label lbTenLoaiTour;
        private System.Windows.Forms.Label lbTGKetThuc;
        private System.Windows.Forms.Label lbthoigian;
        private System.Windows.Forms.Label lbTGBatDau;
        private System.Windows.Forms.Label lbSLVe;
        private System.Windows.Forms.Label lb_soluongve;
        private System.Windows.Forms.Label lbphuongtien;
        private System.Windows.Forms.Button btnDatTour;
        private System.Windows.Forms.Label lbTenTour;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lbxuatphat;
        private System.Windows.Forms.Label lbDiemXP;
        private System.Windows.Forms.Label lbPT;
        private System.Windows.Forms.Label lbMaTour;
        private System.Windows.Forms.Label lbGiaTour;
        private System.Windows.Forms.Label lbMaDDL;
        private System.Windows.Forms.Label lbDiem;
        private System.Windows.Forms.DataGridView dgvTTTour;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
    }
}