using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace doan.PresentationLayer
{
    public partial class ThayDoiQuyDinh : Form
    {
        public ThayDoiQuyDinh()
        {
            InitializeComponent();
        }

        public delegate void SendMessge(string value);
        public SendMessge send;


        private void ThayDoiQuyDinh_Load(object sender, EventArgs e)
        {
            cbLoiNhuan.SelectedIndex = 0;
            cbLoiNhuan.DropDownStyle = ComboBoxStyle.DropDownList;

            cbNgayDuKienTraNo.SelectedIndex = 0;
            cbNgayDuKienTraNo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = "Bạn muốn thay đổi quy định?";
            string title = "Xác nhận";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.No)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Thay đổi thành công");
                PhieuNhapHang phieu = new PhieuNhapHang(cbLoiNhuan.Text);
                phieu.Show();

            }
        }
    }
}
