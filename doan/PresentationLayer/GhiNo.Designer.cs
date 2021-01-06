namespace doan.PresentationLayer
{
    partial class GhiNo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GhiNo));
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.lblTenKH = new System.Windows.Forms.Label();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.lblNgayNo = new System.Windows.Forms.Label();
            this.dateTimePickerNgayNo = new System.Windows.Forms.DateTimePicker();
            this.lblTienNo = new System.Windows.Forms.Label();
            this.txtTienNo = new System.Windows.Forms.TextBox();
            this.lblNgayDKTra = new System.Windows.Forms.Label();
            this.dateTimePickerNgayDKTra = new System.Windows.Forms.DateTimePicker();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.lblMaTGhiNo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMaKH
            // 
            this.txtMaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKH.Location = new System.Drawing.Point(234, 22);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(200, 35);
            this.txtMaKH.TabIndex = 1;
            this.txtMaKH.TextChanged += new System.EventHandler(this.txtMaKH_TextChanged);
            // 
            // lblTenKH
            // 
            this.lblTenKH.AutoSize = true;
            this.lblTenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenKH.Location = new System.Drawing.Point(2, 77);
            this.lblTenKH.Name = "lblTenKH";
            this.lblTenKH.Size = new System.Drawing.Size(190, 29);
            this.lblTenKH.TabIndex = 3;
            this.lblTenKH.Text = "Tên khách hàng:";
            this.lblTenKH.Click += new System.EventHandler(this.lblTenKH_Click);
            // 
            // txtTenKH
            // 
            this.txtTenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKH.Location = new System.Drawing.Point(234, 77);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(200, 35);
            this.txtTenKH.TabIndex = 4;
            this.txtTenKH.TextChanged += new System.EventHandler(this.txtTenKH_TextChanged);
            // 
            // lblNgayNo
            // 
            this.lblNgayNo.AutoSize = true;
            this.lblNgayNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayNo.Location = new System.Drawing.Point(2, 133);
            this.lblNgayNo.Name = "lblNgayNo";
            this.lblNgayNo.Size = new System.Drawing.Size(108, 29);
            this.lblNgayNo.TabIndex = 5;
            this.lblNgayNo.Text = "Ngày nợ:";
            this.lblNgayNo.Click += new System.EventHandler(this.lblNgayNo_Click);
            // 
            // dateTimePickerNgayNo
            // 
            this.dateTimePickerNgayNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerNgayNo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerNgayNo.Location = new System.Drawing.Point(234, 135);
            this.dateTimePickerNgayNo.Name = "dateTimePickerNgayNo";
            this.dateTimePickerNgayNo.Size = new System.Drawing.Size(200, 35);
            this.dateTimePickerNgayNo.TabIndex = 6;
            this.dateTimePickerNgayNo.ValueChanged += new System.EventHandler(this.dateTimePickerNgayNo_ValueChanged);
            // 
            // lblTienNo
            // 
            this.lblTienNo.AutoSize = true;
            this.lblTienNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTienNo.Location = new System.Drawing.Point(2, 191);
            this.lblTienNo.Name = "lblTienNo";
            this.lblTienNo.Size = new System.Drawing.Size(101, 29);
            this.lblTienNo.TabIndex = 7;
            this.lblTienNo.Text = "Tiền nợ:";
            this.lblTienNo.Click += new System.EventHandler(this.lblTienNo_Click);
            // 
            // txtTienNo
            // 
            this.txtTienNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTienNo.Location = new System.Drawing.Point(234, 191);
            this.txtTienNo.Name = "txtTienNo";
            this.txtTienNo.Size = new System.Drawing.Size(200, 35);
            this.txtTienNo.TabIndex = 8;
            this.txtTienNo.TextChanged += new System.EventHandler(this.txtTienNo_TextChanged);
            // 
            // lblNgayDKTra
            // 
            this.lblNgayDKTra.AutoSize = true;
            this.lblNgayDKTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayDKTra.Location = new System.Drawing.Point(2, 255);
            this.lblNgayDKTra.Name = "lblNgayDKTra";
            this.lblNgayDKTra.Size = new System.Drawing.Size(192, 29);
            this.lblNgayDKTra.TabIndex = 9;
            this.lblNgayDKTra.Text = "Ngaỳ dự kiến trả:";
            this.lblNgayDKTra.Click += new System.EventHandler(this.lblNgayDKTra_Click);
            // 
            // dateTimePickerNgayDKTra
            // 
            this.dateTimePickerNgayDKTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerNgayDKTra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerNgayDKTra.Location = new System.Drawing.Point(234, 255);
            this.dateTimePickerNgayDKTra.Name = "dateTimePickerNgayDKTra";
            this.dateTimePickerNgayDKTra.Size = new System.Drawing.Size(200, 35);
            this.dateTimePickerNgayDKTra.TabIndex = 10;
            this.dateTimePickerNgayDKTra.ValueChanged += new System.EventHandler(this.dateTimePickerNgayDKTra_ValueChanged);
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTim.Location = new System.Drawing.Point(503, 22);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 44);
            this.btnTim.TabIndex = 11;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnXacNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhan.Location = new System.Drawing.Point(61, 317);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(121, 48);
            this.btnXacNhan.TabIndex = 12;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = false;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(286, 317);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 48);
            this.btnSua.TabIndex = 13;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(75, 383);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(89, 45);
            this.btnThem.TabIndex = 14;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(286, 383);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 45);
            this.btnXoa.TabIndex = 15;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // lblMaTGhiNo
            // 
            this.lblMaTGhiNo.AutoSize = true;
            this.lblMaTGhiNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaTGhiNo.Location = new System.Drawing.Point(2, 22);
            this.lblMaTGhiNo.Name = "lblMaTGhiNo";
            this.lblMaTGhiNo.Size = new System.Drawing.Size(163, 29);
            this.lblMaTGhiNo.TabIndex = 16;
            this.lblMaTGhiNo.Text = "Mã thẻ ghi nợ:";
            this.lblMaTGhiNo.Click += new System.EventHandler(this.lblMaTGhiNo_Click);
            // 
            // GhiNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMaTGhiNo);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.dateTimePickerNgayDKTra);
            this.Controls.Add(this.lblNgayDKTra);
            this.Controls.Add(this.txtTienNo);
            this.Controls.Add(this.lblTienNo);
            this.Controls.Add(this.dateTimePickerNgayNo);
            this.Controls.Add(this.lblNgayNo);
            this.Controls.Add(this.txtTenKH);
            this.Controls.Add(this.lblTenKH);
            this.Controls.Add(this.txtMaKH);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GhiNo";
            this.Text = "Lập thẻ ghi nợ";
            this.Load += new System.EventHandler(this.GhiNo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label lblTenKH;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label lblNgayNo;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayNo;
        private System.Windows.Forms.Label lblTienNo;
        private System.Windows.Forms.TextBox txtTienNo;
        private System.Windows.Forms.Label lblNgayDKTra;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayDKTra;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label lblMaTGhiNo;
    }
}