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
    public partial class KhachHang : Form
    {
        public KhachHang()
        {
            InitializeComponent();
        }

        



        private void KhachHang_Load(object sender, EventArgs e)
        {
            dtNgayLap.Format = DateTimePickerFormat.Custom;
            dtNgayLap.CustomFormat = "dd-MM-yyyy";
            dtNgayLap.Value = DateTime.Today;
            dtNgayLap.Enabled = false;

            txtSoLuong.Text = "0";
            txtSoLuong.Enabled = false;

            KhachHangBUS bus = new KhachHangBUS();
            CapNhatMaKH(bus);
            CapNhatMaThe(bus);


            dgvKhachHang.DataSource = bus.DSCTKhachHang();
        }

        void CapNhatMaKH(KhachHangBUS bus)
        {
            DataTable dt = new DataTable();
            dt = bus.DSKhachHang();

            var item = dt.Rows.Count + 1;
            DataRow row = dt.NewRow();
            if (item < 10)
            {
                row[0] = "KH00" + item;
            }
            else if (item < 100)
            {
                row[0] = "KH0" + item;
            }

            dt.Rows.InsertAt(row, 0);
            cbMaKH.DataSource = dt;
            cbMaKH.DisplayMember = "MaKH";
            cbMaKH.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        void CapNhatMaThe(KhachHangBUS bus)
        {
            DataTable dt = new DataTable();
            dt = bus.DSMaThe();

            var item = dt.Rows.Count + 1;
            DataRow row = dt.NewRow();
            if (item < 10)
            {
                row[0] = "MT00" + item;
            }
            else if (item < 100)
            {
                row[0] = "MT0" + item;
            }

            dt.Rows.InsertAt(row, 0);
            cbTheKH.DataSource = dt;
            cbTheKH.DisplayMember = "MaThe";
            cbTheKH.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        bool checkEmptyAllControl()
        {
            if (txtTenKH.Text == "" || txtSdt.Text == "" || txtDiaChi.Text == "" || txtCMND.Text == "" ||
                txtSoLuong.Text== "")
            {
                MessageBox.Show("điền đầy đủ các thông tin");
                return true;
            }
            return false;
        }

        void LoadDuLieu(int index)
        {
            DataGridViewRow row = dgvKhachHang.Rows[index];
            //Đưa dữ liệu vào textbox
            cbMaKH.SelectedIndex = dgvKhachHang.Rows.Count - index;
            cbTheKH.Text = row.Cells[0].Value.ToString();
            txtTenKH.Text = row.Cells[1].Value.ToString();
            txtSdt.Text = row.Cells[2].Value.ToString();
            txtDiaChi.Text = row.Cells[3].Value.ToString();
            txtCMND.Text = row.Cells[4].Value.ToString();
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                LoadDuLieu(e.RowIndex);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            KhachHangBUS bus = new KhachHangBUS();
            if (checkEmptyAllControl() == true) return;
            //Thong Tin khachHang
            KhachHangDTO kh = new KhachHangDTO();
            kh.MaKH = cbMaKH.Text;
            kh.TenKH = txtTenKH.Text;
            kh.Sdt = txtSdt.Text;
            kh.DiaChi = txtDiaChi.Text;
            kh.Cmnd = txtCMND.Text;
            bus.ThemMaThe(kh);

            //The KhachHang
            TheKhachHangDTO thekh = new TheKhachHangDTO();
            thekh.MaThe = cbTheKH.Text;
            thekh.MaKH = cbMaKH.Text;
            thekh.NgayLap = dtNgayLap.Text;
            thekh.SoLuongDaMua = int.Parse(txtSoLuong.Text);
            bus.ThemMaThe(thekh);

            CapNhatMaKH(bus);
            CapNhatMaThe(bus);


            dgvKhachHang.DataSource = bus.DSCTKhachHang();

        }

        private void cbTheKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            KhachHangBUS bus = new KhachHangBUS();
            var error = "System.Data.DataRowView";

          
            if (cbTheKH.Text == error) return;

            DataTable dt = bus.LayThongTinThe(cbTheKH.Text);


            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                cbMaKH.Text = row["MaKH"].ToString();
                dtNgayLap.Text = row["NgayLap"].ToString();
                txtSoLuong.Text = row["SoLuongDaMua"].ToString();
            }
            else
            {
                dtNgayLap.Value = DateTime.Today;
                txtSoLuong.Text = "0";
            }
           
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
                cbTheKH.Text = row["MaThe"].ToString();
                txtTenKH.Text = row["TenKH"].ToString(); ;
                txtSdt.Text = row["Sdt"].ToString(); ;
                txtDiaChi.Text = row["DiaChi"].ToString(); ;
                txtCMND.Text = row["Cmnd"].ToString();
                btnThem.Enabled = false;
                btnCapNhat.Enabled = true;
            }
            else
            {
                txtTenKH.Text = "";
                txtSdt.Text = "";
                txtDiaChi.Text = "";
                txtCMND.Text = "";
                btnCapNhat.Enabled = false;
                btnThem.Enabled = true;
            }
        }

        

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (checkEmptyAllControl() == true) return;

            KhachHangDTO kh = new KhachHangDTO();
            kh.MaKH = cbMaKH.Text;
            kh.TenKH = txtTenKH.Text;
            kh.Sdt = txtSdt.Text;
            kh.DiaChi = txtDiaChi.Text;
            kh.Cmnd = txtCMND.Text;

            KhachHangBUS bus = new KhachHangBUS();
            DataTable dt = bus.CapNhatThongTinKhachHang(kh);

            dgvKhachHang.DataSource = bus.DSCTKhachHang();

            
        }
    }
}
