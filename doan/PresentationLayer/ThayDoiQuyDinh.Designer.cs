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
            this.label1 = new System.Windows.Forms.Label();
            this.cbLoiNhuan = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbNgayDuKienTraNo = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lợi Nhuận";
            // 
            // cbLoiNhuan
            // 
            this.cbLoiNhuan.FormattingEnabled = true;
            this.cbLoiNhuan.Items.AddRange(new object[] {
            "10%",
            "20%",
            "30%"});
            this.cbLoiNhuan.Location = new System.Drawing.Point(81, 61);
            this.cbLoiNhuan.Name = "cbLoiNhuan";
            this.cbLoiNhuan.Size = new System.Drawing.Size(173, 21);
            this.cbLoiNhuan.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ngày dự kiến trả nợ";
            // 
            // cbNgayDuKienTraNo
            // 
            this.cbNgayDuKienTraNo.FormattingEnabled = true;
            this.cbNgayDuKienTraNo.Items.AddRange(new object[] {
            "7",
            "14",
            "21",
            "30"});
            this.cbNgayDuKienTraNo.Location = new System.Drawing.Point(80, 115);
            this.cbNgayDuKienTraNo.Name = "cbNgayDuKienTraNo";
            this.cbNgayDuKienTraNo.Size = new System.Drawing.Size(173, 21);
            this.cbNgayDuKienTraNo.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(129, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Xác Nhận";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ThayDoiQuyDinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 209);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbNgayDuKienTraNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbLoiNhuan);
            this.Controls.Add(this.label1);
            this.Name = "ThayDoiQuyDinh";
            this.Text = "ThayDoiQuyDinh";
            this.Load += new System.EventHandler(this.ThayDoiQuyDinh_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbLoiNhuan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbNgayDuKienTraNo;
        private System.Windows.Forms.Button button1;
    }
}