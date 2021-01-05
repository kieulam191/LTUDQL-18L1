using doan.BusinessLayer;
using doan.DataAcesee;
using doan.DTO;
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
    public partial class PhieuNhapHang : Form
    {
        public PhieuNhapHang()
        {
            InitializeComponent();
        }

        private void PhieuNhapHang_Load(object sender, EventArgs e)
        {
            dtNgayNhap.Format = DateTimePickerFormat.Custom;
            dtNgayNhap.CustomFormat = "dd-MM-yyyy";
            dtNgayNhap.Value = DateTime.Today;
            dtNgayNhap.Enabled = false;

           

            PhieuNhapHangBUS bus = new PhieuNhapHangBUS();
            //Mã Phiếu nhập
            DataTable dt = new DataTable();
            dt = bus.DSPhieuNhap();

            //Insert the Default Item to DataTable.
            var item = dt.Rows.Count + 1;
            DataRow row = dt.NewRow();
            if (item < 10)
            {
                row[0] = "PN00" + item;
            }
            else if (item < 100)
            {
                row[0] = "PN0" + item;
            }
            
            dt.Rows.InsertAt(row, 0);
            cbMaPhieuNhap.DataSource = dt;
            cbMaPhieuNhap.DisplayMember = "MaPN";
            cbMaPhieuNhap.DropDownStyle = ComboBoxStyle.DropDownList;
            

            //Ma gao
            cbMaGao.DataSource = bus.DSMaGao();
            cbMaGao.DisplayMember = "MaGao";
            cbMaGao.DropDownStyle = ComboBoxStyle.DropDownList;

            dgvCTPN.DataSource = bus.DSCTPhieuNhap();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnThemPhieuNhap_Click(object sender, EventArgs e)
        {
            //thêm vào bảng phiếu nhập hàng
            PhieuNhapHangDTO phieu = new PhieuNhapHangDTO();
            phieu.MaPN = cbMaPhieuNhap.Text;
            phieu.NgayNhap = dtNgayNhap.Text;
          
    

            PhieuNhapHangBUS bus = new PhieuNhapHangBUS();
            bus.ThemPhieuNhap(phieu);

            //thêm vào bảng chi tiết phiếu nhập
            ChiTietPhieuNhapDTO chiTiet = new ChiTietPhieuNhapDTO();
            chiTiet.MaPhieuNhap = phieu.MaPN;
            chiTiet.MaGao = cbMaGao.Text;
            chiTiet.SoLuongNhap = int.Parse(txtSoLuong.Text);
            chiTiet.GiaMuaVao = double.Parse(txtGiaMuaVao.Text);
            chiTiet.GiaBanRa = (chiTiet.GiaMuaVao / chiTiet.SoLuongNhap) + 0.1 * (chiTiet.GiaMuaVao / chiTiet.SoLuongNhap);
            chiTiet.MaNCC = cbNhaCC.Text;

            ChiTietPhieuNhapDAO.insert(chiTiet);

            dgvCTPN.DataSource = bus.DSCTPhieuNhap();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnTimPhieuNhap_Click(object sender, EventArgs e)
        {
            //khoa hết các button khác lại
            rbtnCu.Enabled = false;
            rbtnMoi.Enabled = false;
            txtSoLuong.Enabled = false;
            txtGiaMuaVao.Enabled = false;
        }
    }
}
