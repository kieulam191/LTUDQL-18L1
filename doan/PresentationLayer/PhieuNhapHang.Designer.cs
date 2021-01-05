namespace doan.PresentationLayer
{
    partial class PhieuNhapHang
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbNhaCC = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtGiaMuaVao = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnTimPhieuNhap = new System.Windows.Forms.Button();
            this.cbMaGao = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnThemPhieuNhap = new System.Windows.Forms.Button();
            this.rbtnMoi = new System.Windows.Forms.RadioButton();
            this.rbtnCu = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.dtNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.cbMaPhieuNhap = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvCTPN = new System.Windows.Forms.DataGridView();
            this.NgayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPhieuNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaGao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaBanRa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTPN)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cbNhaCC);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtGiaMuaVao);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.btnTimPhieuNhap);
            this.panel1.Controls.Add(this.cbMaGao);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnThemPhieuNhap);
            this.panel1.Controls.Add(this.rbtnMoi);
            this.panel1.Controls.Add(this.rbtnCu);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dtNgayNhap);
            this.panel1.Controls.Add(this.txtSoLuong);
            this.panel1.Controls.Add(this.cbMaPhieuNhap);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 508);
            this.panel1.TabIndex = 0;
            // 
            // cbNhaCC
            // 
            this.cbNhaCC.FormattingEnabled = true;
            this.cbNhaCC.Items.AddRange(new object[] {
            "NC001"});
            this.cbNhaCC.Location = new System.Drawing.Point(94, 190);
            this.cbNhaCC.Name = "cbNhaCC";
            this.cbNhaCC.Size = new System.Drawing.Size(141, 21);
            this.cbNhaCC.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 193);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Mã Nhà cung cấp";
            // 
            // txtGiaMuaVao
            // 
            this.txtGiaMuaVao.Location = new System.Drawing.Point(93, 138);
            this.txtGiaMuaVao.Name = "txtGiaMuaVao";
            this.txtGiaMuaVao.Size = new System.Drawing.Size(140, 20);
            this.txtGiaMuaVao.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 141);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Giá mua vào";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // btnTimPhieuNhap
            // 
            this.btnTimPhieuNhap.Location = new System.Drawing.Point(11, 254);
            this.btnTimPhieuNhap.Name = "btnTimPhieuNhap";
            this.btnTimPhieuNhap.Size = new System.Drawing.Size(95, 23);
            this.btnTimPhieuNhap.TabIndex = 18;
            this.btnTimPhieuNhap.Text = "Tìm Phiếu nhập";
            this.btnTimPhieuNhap.UseVisualStyleBackColor = true;
            this.btnTimPhieuNhap.Click += new System.EventHandler(this.btnTimPhieuNhap_Click);
            // 
            // cbMaGao
            // 
            this.cbMaGao.FormattingEnabled = true;
            this.cbMaGao.Location = new System.Drawing.Point(94, 56);
            this.cbMaGao.Name = "cbMaGao";
            this.cbMaGao.Size = new System.Drawing.Size(141, 21);
            this.cbMaGao.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Mã Gạo";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(157, 225);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnThemPhieuNhap
            // 
            this.btnThemPhieuNhap.Location = new System.Drawing.Point(10, 225);
            this.btnThemPhieuNhap.Name = "btnThemPhieuNhap";
            this.btnThemPhieuNhap.Size = new System.Drawing.Size(111, 23);
            this.btnThemPhieuNhap.TabIndex = 14;
            this.btnThemPhieuNhap.Text = "Thêm Phiếu nhập";
            this.btnThemPhieuNhap.UseVisualStyleBackColor = true;
            this.btnThemPhieuNhap.Click += new System.EventHandler(this.btnThemPhieuNhap_Click);
            // 
            // rbtnMoi
            // 
            this.rbtnMoi.AutoSize = true;
            this.rbtnMoi.Location = new System.Drawing.Point(192, 89);
            this.rbtnMoi.Name = "rbtnMoi";
            this.rbtnMoi.Size = new System.Drawing.Size(42, 17);
            this.rbtnMoi.TabIndex = 13;
            this.rbtnMoi.TabStop = true;
            this.rbtnMoi.Text = "Mới";
            this.rbtnMoi.UseVisualStyleBackColor = true;
            // 
            // rbtnCu
            // 
            this.rbtnCu.AutoSize = true;
            this.rbtnCu.Location = new System.Drawing.Point(94, 89);
            this.rbtnCu.Name = "rbtnCu";
            this.rbtnCu.Size = new System.Drawing.Size(38, 17);
            this.rbtnCu.TabIndex = 12;
            this.rbtnCu.TabStop = true;
            this.rbtnCu.Text = "Cũ";
            this.rbtnCu.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ngày Nhập";
            // 
            // dtNgayNhap
            // 
            this.dtNgayNhap.Location = new System.Drawing.Point(94, 164);
            this.dtNgayNhap.Name = "dtNgayNhap";
            this.dtNgayNhap.Size = new System.Drawing.Size(139, 20);
            this.dtNgayNhap.TabIndex = 10;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(94, 112);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(140, 20);
            this.txtSoLuong.TabIndex = 9;
            // 
            // cbMaPhieuNhap
            // 
            this.cbMaPhieuNhap.FormattingEnabled = true;
            this.cbMaPhieuNhap.Location = new System.Drawing.Point(93, 29);
            this.cbMaPhieuNhap.Name = "cbMaPhieuNhap";
            this.cbMaPhieuNhap.Size = new System.Drawing.Size(141, 21);
            this.cbMaPhieuNhap.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Thông Tin Phiếu Nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Số Lượng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Loại";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Phiếu Nhập";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.dgvCTPN);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(273, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(746, 263);
            this.panel2.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Danh Sách Chi Tiết Phiếu nhập";
            // 
            // dgvCTPN
            // 
            this.dgvCTPN.AllowUserToAddRows = false;
            this.dgvCTPN.AllowUserToDeleteRows = false;
            this.dgvCTPN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCTPN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTPN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NgayNhap,
            this.MaPhieuNhap,
            this.MaGao,
            this.SoLuongNhap,
            this.GiaBanRa});
            this.dgvCTPN.Location = new System.Drawing.Point(0, 26);
            this.dgvCTPN.Name = "dgvCTPN";
            this.dgvCTPN.ReadOnly = true;
            this.dgvCTPN.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCTPN.Size = new System.Drawing.Size(747, 233);
            this.dgvCTPN.TabIndex = 3;
            // 
            // NgayNhap
            // 
            this.NgayNhap.DataPropertyName = "NgayNhap";
            this.NgayNhap.HeaderText = "Ngày Nhập";
            this.NgayNhap.Name = "NgayNhap";
            this.NgayNhap.ReadOnly = true;
            // 
            // MaPhieuNhap
            // 
            this.MaPhieuNhap.DataPropertyName = "MaPhieuNhap";
            this.MaPhieuNhap.HeaderText = "Mã Phiếu Nhập";
            this.MaPhieuNhap.Name = "MaPhieuNhap";
            this.MaPhieuNhap.ReadOnly = true;
            // 
            // MaGao
            // 
            this.MaGao.DataPropertyName = "MaGao";
            this.MaGao.HeaderText = "Mã Gạo";
            this.MaGao.Name = "MaGao";
            this.MaGao.ReadOnly = true;
            // 
            // SoLuongNhap
            // 
            this.SoLuongNhap.DataPropertyName = "SoLuongNhap";
            this.SoLuongNhap.HeaderText = "Số lượng nhập";
            this.SoLuongNhap.Name = "SoLuongNhap";
            this.SoLuongNhap.ReadOnly = true;
            // 
            // GiaBanRa
            // 
            this.GiaBanRa.DataPropertyName = "GiaBanRa";
            this.GiaBanRa.HeaderText = "Giá Bán Ra";
            this.GiaBanRa.Name = "GiaBanRa";
            this.GiaBanRa.ReadOnly = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label8);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(273, 263);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(746, 245);
            this.panel3.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(157, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Danh Sách Chi Tiết Phiếu nhập";
            // 
            // PhieuNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 508);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "PhieuNhapHang";
            this.Text = "PhieuNhapHang";
            this.Load += new System.EventHandler(this.PhieuNhapHang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTPN)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtNgayNhap;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.ComboBox cbMaPhieuNhap;
        private System.Windows.Forms.RadioButton rbtnMoi;
        private System.Windows.Forms.RadioButton rbtnCu;
        private System.Windows.Forms.Button btnThemPhieuNhap;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cbMaGao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvCTPN;
        private System.Windows.Forms.Button btnTimPhieuNhap;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtGiaMuaVao;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhieuNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaGao;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaBanRa;
        private System.Windows.Forms.ComboBox cbNhaCC;
        private System.Windows.Forms.Label label10;
    }
}