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

        public PhieuNhapHang(string send): this()
        {
            this.txtLoiNhuan.Text = send;
        }

        


        bool checkEmptyAllControll()
        {
            if(txtSoLuong.Text == "" || txtGiaMuaVao.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                return true;
            }
            return false;
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

            //Ma Nhacc
            NhaCungCapBUS ncc = new NhaCungCapBUS();
            cbNhaCC.DataSource = ncc.DSNhaCungCap();
            cbNhaCC.DisplayMember = "MaNCC";
            cbNhaCC.DropDownStyle = ComboBoxStyle.DropDownList;

          
            txtTenGao.Enabled = false;

            dgvCTPN.DataSource = bus.DSCTPhieuNhap();

        }

       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnThemPhieuNhap_Click(object sender, EventArgs e)
        {
            if (checkEmptyAllControll() == true) return;
            //thêm vào bảng phiếu nhập hàng
            PhieuNhapHangDTO phieu = new PhieuNhapHangDTO();
            phieu.MaPN = cbMaPhieuNhap.Text;
            phieu.NgayNhap = dtNgayNhap.Text;
          
    

            PhieuNhapHangBUS bus = new PhieuNhapHangBUS();
            bus.ThemPhieuNhap(phieu);

            double loinhuan = double.Parse(txtLoiNhuan.Text.Substring(0, 2)) / 100;

            //thêm vào bảng chi tiết phiếu nhập
            ChiTietPhieuNhapDTO chiTiet = new ChiTietPhieuNhapDTO();
            chiTiet.MaPhieuNhap = phieu.MaPN;
            chiTiet.MaGao = cbMaGao.Text;
            chiTiet.SoLuongNhap = int.Parse(txtSoLuong.Text);
            chiTiet.GiaMuaVao = double.Parse(txtGiaMuaVao.Text);
            chiTiet.GiaBanRa = (chiTiet.GiaMuaVao / chiTiet.SoLuongNhap) + loinhuan * (chiTiet.GiaMuaVao / chiTiet.SoLuongNhap);
            chiTiet.MaNCC = cbNhaCC.Text;

            ChiTietPhieuNhapDAO.insert(chiTiet);

            dgvCTPN.DataSource = bus.DSCTPhieuNhap();
        }

     
       

        private void cbMaGao_SelectedIndexChanged(object sender, EventArgs e)
        {

            PhieuNhapHangBUS bus = new PhieuNhapHangBUS();
            var error = "System.Data.DataRowView";

            if (cbMaGao.Text == error) return;

            DataTable dt = bus.LayThongTinGao(cbMaGao.Text);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                txtTenGao.Text = row["TenSanPham"].ToString();
            }
            else
            {
                txtTenGao.Text = "";
            }
        }

        private void cbMaPhieuNhap_SelectedIndexChanged(object sender, EventArgs e)
        {
            PhieuNhapHangBUS bus = new PhieuNhapHangBUS();
            var error = "System.Data.DataRowView";

            if (cbMaPhieuNhap.Text == error) return;

            DataTable dt = bus.LayThongTinPhieuNhap(cbMaPhieuNhap.Text);
       
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                txtSoLuong.Text = row["SoLuongNhap"].ToString(); ;
                txtGiaMuaVao.Text = row["GiaMuaVao"].ToString(); ;
                cbNhaCC.Text = row["MaNCC"].ToString(); ;
                dtNgayNhap.Text = row["NgayNhap"].ToString();
                cbMaGao.Text = row["MaGao"].ToString();
            }
            else
            {
                txtSoLuong.Text = "";
                txtGiaMuaVao.Text = "";
                dtNgayNhap.Value = DateTime.Today;
               
            }
        }

        private void dgvCTPN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCTPN.Rows[e.RowIndex];
                //Đưa dữ liệu vào textbox
                cbMaPhieuNhap.SelectedIndex = dgvCTPN.Rows.Count - e.RowIndex;
            }
        }
    }
}
