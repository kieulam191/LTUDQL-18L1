namespace doan.PresentationLayer
{
    partial class ThayDoiQuyDinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThayDoiQuyDinh));
            this.lblGiaBanRa = new System.Windows.Forms.Label();
            this.txtGiaBanRa = new System.Windows.Forms.TextBox();
            this.lblSLSP = new System.Windows.Forms.Label();
            this.lblNgayDKTra = new System.Windows.Forms.Label();
            this.txtSLSP = new System.Windows.Forms.TextBox();
            this.dateTimePickerNgayDKTra = new System.Windows.Forms.DateTimePicker();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblGiaBanRa
            // 
            this.lblGiaBanRa.AutoSize = true;
            this.lblGiaBanRa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiaBanRa.Location = new System.Drawing.Point(12, 9);
            this.lblGiaBanRa.Name = "lblGiaBanRa";
            this.lblGiaBanRa.Size = new System.Drawing.Size(129, 29);
            this.lblGiaBanRa.TabIndex = 0;
            this.lblGiaBanRa.Text = "Giá bán ra:";
            this.lblGiaBanRa.Click += new System.EventHandler(this.lblGiaBanRa_Click);
            // 
            // txtGiaBanRa
            // 
            this.txtGiaBanRa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaBanRa.Location = new System.Drawing.Point(244, 12);
            this.txtGiaBanRa.Name = "txtGiaBanRa";
            this.txtGiaBanRa.Size = new System.Drawing.Size(136, 35);
            this.txtGiaBanRa.TabIndex = 1;
            this.txtGiaBanRa.TextChanged += new System.EventHandler(this.txtGiaBanRa_TextChanged);
            // 
            // lblSLSP
            // 
            this.lblSLSP.AutoSize = true;
            this.lblSLSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSLSP.Location = new System.Drawing.Point(12, 66);
            this.lblSLSP.Name = "lblSLSP";
            this.lblSLSP.Size = new System.Drawing.Size(153, 29);
            this.lblSLSP.TabIndex = 2;
            this.lblSLSP.Text = "Số lượng SP:";
            this.lblSLSP.Click += new System.EventHandler(this.lblSLSP_Click);
            // 
            // lblNgayDKTra
            // 
            this.lblNgayDKTra.AutoSize = true;
            this.lblNgayDKTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayDKTra.Location = new System.Drawing.Point(12, 124);
            this.lblNgayDKTra.Name = "lblNgayDKTra";
            this.lblNgayDKTra.Size = new System.Drawing.Size(192, 29);
            this.lblNgayDKTra.TabIndex = 3;
            this.lblNgayDKTra.Text = "Ngày dự kiến trả:";
            // 
            // txtSLSP
            // 
            this.txtSLSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSLSP.Location = new System.Drawing.Point(244, 60);
            this.txtSLSP.Name = "txtSLSP";
            this.txtSLSP.Size = new System.Drawing.Size(136, 35);
            this.txtSLSP.TabIndex = 4;
            this.txtSLSP.TextChanged += new System.EventHandler(this.txtSLSP_TextChanged);
            // 
            // dateTimePickerNgayDKTra
            // 
            this.dateTimePickerNgayDKTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerNgayDKTra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerNgayDKTra.Location = new System.Drawing.Point(244, 124);
            this.dateTimePickerNgayDKTra.Name = "dateTimePickerNgayDKTra";
            this.dateTimePickerNgayDKTra.Size = new System.Drawing.Size(200, 35);
            this.dateTimePickerNgayDKTra.TabIndex = 5;
            this.dateTimePickerNgayDKTra.ValueChanged += new System.EventHandler(this.dateTimePickerNgayDKTra_ValueChanged);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnXacNhan.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btnXacNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhan.Location = new System.Drawing.Point(201, 202);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(122, 57);
            this.btnXacNhan.TabIndex = 6;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = false;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(390, 202);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(93, 57);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            // 
            // ThayDoiQuyDinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.dateTimePickerNgayDKTra);
            this.Controls.Add(this.txtSLSP);
            this.Controls.Add(this.lblNgayDKTra);
            this.Controls.Add(this.lblSLSP);
            this.Controls.Add(this.txtGiaBanRa);
            this.Controls.Add(this.lblGiaBanRa);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ThayDoiQuyDinh";
            this.Text = "Thay đổi qui định";
            this.Load += new System.EventHandler(this.ThayDoiQuyDinh_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGiaBanRa;
        private System.Windows.Forms.TextBox txtGiaBanRa;
        private System.Windows.Forms.Label lblSLSP;
        private System.Windows.Forms.Label lblNgayDKTra;
        private System.Windows.Forms.TextBox txtSLSP;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayDKTra;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Button btnThoat;
    }
}