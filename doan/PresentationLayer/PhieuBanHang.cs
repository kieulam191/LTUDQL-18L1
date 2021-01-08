using doan.BusinessLayer;
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
    public partial class PhieuBanHang : Form
    {
        public PhieuBanHang()
        {
            InitializeComponent();
        }

        private void PhieuBanHang_Load(object sender, EventArgs e)
        {
            dtNgayBan.Format = DateTimePickerFormat.Custom;
            dtNgayBan.CustomFormat = "dd-MM-yyyy";
            dtNgayBan.Value = DateTime.Today;
            dtNgayBan.Enabled = false;

            txtTenKH.Enabled = false;
            txtSoLuongDaMua.Enabled = false;

            PhieuBanHangBUS bus = new PhieuBanHangBUS();
            CapNhatPhieuBan(bus);
          
            dgvPhieuBan.DataSource = bus.DSCTPhieuBan();
        }

        void CapNhatPhieuBan(PhieuBanHangBUS bus)
        {
            DataTable dt = new DataTable();
            dt = bus.DSPhieuBan();

            //Insert the Default Item to DataTable.
            var item = dt.Rows.Count + 1;
            DataRow row = dt.NewRow();
            if (item < 10)
            {
                row[0] = "PB00" + item;
            }
            else if (item < 100)
            {
                row[0] = "PB0" + item;
            }

            dt.Rows.InsertAt(row, 0);
            cbMaPhieuBan.DataSource = dt;
            cbMaPhieuBan.DisplayMember = "MaPBH";
            cbMaPhieuBan.DropDownStyle = ComboBoxStyle.DropDownList;

            PhieuNhapHangBUS busPNH = new PhieuNhapHangBUS();
            dt = busPNH.DSMaGao();
            cbMaGao.DataSource = dt;
            cbMaGao.DisplayMember = "MaGao";
            cbMaGao.DropDownStyle = ComboBoxStyle.DropDownList;

            KhachHangBUS busKH = new KhachHangBUS();
            dt = busKH.DSKhachHang();
            cbMaKH.DataSource = dt;
            cbMaKH.DisplayMember = "MaKH";
            cbMaKH.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void cbMaKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            KhachHangBUS bus = new KhachHangBUS();
            var error = "System.Data.DataRowView";

            if (cbMaKH.Text == error) return;

            DataTable dt = bus.LayThongTinKhachHang(cbMaKH.Text);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                cbMaKH.Text = row["MaKH"].ToString();
                txtTenKH.Text = row["TenKH"].ToString();
                txtSoLuongDaMua.Text = row["SoLuongDaMua"].ToString();
            }
            else
            {
                txtTenKH.Text = "";
                txtSoLuongDaMua.Text = "";
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            PhieuBanHangBUS bus = new PhieuBanHangBUS();
            PhieuNhapHangBUS busNH = new PhieuNhapHangBUS();
            //Thêm phiếu bán hàng
            PhieuBanHangDTO pb = new PhieuBanHangDTO();
            pb.MaPBH = cbMaPhieuBan.Text;
            pb.NgayBan = dtNgayBan.Text;
            DataTable dt = bus.ThemPhieuBanHang(pb);
            //thêm vào chi tiết phiếu bán hàng
            ChiTietPhieuBanDTO ct = new ChiTietPhieuBanDTO();
            ct.MaPhieuBanHang = pb.MaPBH;
            ct.MaGao = cbMaGao.Text;
            ct.MaKH = cbMaKH.Text;
            ct.SoLuongMua = int.Parse(txtSoLuong.Text);
            ct.GiaHienTai = busNH.LayGiaGaoHienTai(cbMaGao.Text);

            dt = bus.ThenCTPHieuBanHang(ct);
          
            txtSoLuongDaMua.Text = txtSoLuong.Text;
            KhachHangBUS kh = new KhachHangBUS();

            ct.SoLuongMua += int.Parse(kh.LaySoLuongDaMua(ct.MaKH).ToString());
            txtSoLuongDaMua.Text = kh.LaySoLuongDaMua(ct.MaKH).ToString();
            kh.CapNhatSoLuongDaMua(ct.MaKH, ct.SoLuongMua);
            

            CapNhatPhieuBan(bus);
            txtTongTien.Text = (ct.GiaHienTai * int.Parse(txtSoLuong.Text)).ToString();
            dgvPhieuBan.DataSource = bus.DSCTPhieuBan();
        }

        private void cbMaPhieuBan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
