using doan.BusinessLayer;
using doan.PresentationLayer;
using doan.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace doan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            loadImage();
        }

        void loadImage()
        {
            picLogo.Image = Resources.logoGao;
            picLogo.SizeMode = PictureBoxSizeMode.StretchImage;
        }

     
        private void btnOpenForm_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (btn.Text == "Nhập hàng")
            {
                PhieuNhapHang frmPhieuNhap = new PhieuNhapHang();
                frmPhieuNhap.ShowDialog();
            }
            else if(btn.Text == "Bán hàng")
            {
                PhieuBanHang frmBanHang = new PhieuBanHang();
                frmBanHang.ShowDialog();
            }
            else if (btn.Text == "Khách hàng")
            {
                KhachHang frmKhachHang = new KhachHang();
                frmKhachHang.ShowDialog();
            }
            else if (btn.Text == "Kiểm tra kho hàng")
            {
                KhoHang frmKhoHang = new KhoHang();
                //frmKhoHang.ShowDialog();
                MessageBox.Show("Chức năng chưa hoàn thành");
            }
            else if (btn.Text == "Nhà cung cấp")
            {
               NhaCungCap frmNhaCungCap = new NhaCungCap ();
               frmNhaCungCap.ShowDialog();
            }
            else if (btn.Text == "Ghi nợ")
            {
                GhiNo frmGhiNo = new GhiNo();
                //frmGhiNo.ShowDialog();
                MessageBox.Show("Chức năng chưa hoàn thành");
            }
            else if (btn.Text == "Thống kê")
            {
                ThongKe frmThongKe = new ThongKe();
                //frmThongKe.ShowDialog();
                MessageBox.Show("Chức năng chưa hoàn thành");
            }
            else
            {
                ThayDoiQuyDinh frmThayDoiQuyDinh = new ThayDoiQuyDinh();
                frmThayDoiQuyDinh.ShowDialog();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
