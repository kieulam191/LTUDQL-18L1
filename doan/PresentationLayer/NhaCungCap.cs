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
    public partial class NhaCungCap : Form
    {
        public NhaCungCap()
        {
            InitializeComponent();
        }

        public delegate void mydel(Object sender, DataGridViewCellEventArgs e);
     

        private void NhaCungCap_Load(object sender, EventArgs e)
        {
            NhaCungCapBUS bus = new NhaCungCapBUS();
            CapNhapMaNCC(bus);
            dgvNhaCungCap.DataSource = bus.DSNhaCungCap(); 

        }

        void CapNhapMaNCC(NhaCungCapBUS bus)
        {

            DataTable dt = new DataTable();
            dt = bus.DSTenNCC();

            var item = dt.Rows.Count + 1;
            DataRow row = dt.NewRow();
            if (item < 10)
            {
                row[0] = "NC00" + item;
            }
            else if (item < 100)
            {
                row[0] = "NC0" + item;
            }

            dt.Rows.InsertAt(row, 0);
            cbMaNCC.DataSource = dt;
            cbMaNCC.DisplayMember = "MaNCC";
            cbMaNCC.DropDownStyle = ComboBoxStyle.DropDownList;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkEmptyAllControl() == true) return;
            NhaCungCapDTO ncc = new NhaCungCapDTO();
            ncc.MaNCC = cbMaNCC.Text;
            ncc.TenNCC = txtTenNCC.Text;
            ncc.Sdt = txtSDT.Text;
            ncc.DiaChi = txtDiaChi.Text;
            ncc.TinhTrang = txtDiaChi.Text;

            NhaCungCapBUS bus = new NhaCungCapBUS();
            DataTable dt = bus.ThemNhaCungCap(ncc);

            CapNhapMaNCC(bus);
            dgvNhaCungCap.DataSource = bus.DSNhaCungCap();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            NhaCungCapDTO ncc = new NhaCungCapDTO();
            ncc.MaNCC = cbMaNCC.Text;
            ncc.TenNCC = txtTenNCC.Text;
            ncc.Sdt = txtSDT.Text;
            ncc.DiaChi = txtDiaChi.Text;
            ncc.TinhTrang = txtDiaChi.Text;

            NhaCungCapBUS bus = new NhaCungCapBUS();
            DataTable dt = bus.CapNhatNhaCungCap(ncc);

            dgvNhaCungCap.DataSource = bus.DSNhaCungCap(); 
        }

        void LoadDuLieu(int index)
        {
            DataGridViewRow row = dgvNhaCungCap.Rows[index];
            //Đưa dữ liệu vào textbox
            cbMaNCC.SelectedIndex = dgvNhaCungCap.Rows.Count - index;
            txtTenNCC.Text = row.Cells[1].Value.ToString();
            txtSDT.Text = row.Cells[2].Value.ToString();
            txtDiaChi.Text = row.Cells[3].Value.ToString();
            txtTinhTrang.Text = row.Cells[4].Value.ToString();
        }

        private void dgvNhaCungCap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                LoadDuLieu(e.RowIndex);  
            }
        }

        bool checkEmptyAllControl()
        {
            if(txtTenNCC.Text == "" || txtSDT.Text == "" || txtDiaChi.Text == "" || txtTinhTrang.Text == "")
            {
                MessageBox.Show("Tên Nhà Cung Cấp không được để trống");
                return true;
            }
            return false;
           
        }
        

        private void btnXoa_Click(object sender, EventArgs e)
        {
            NhaCungCapBUS bus = new NhaCungCapBUS();
            DataTable dt = bus.XoaNhaCungCap(cbMaNCC.Text);

            CapNhapMaNCC(bus);
            dgvNhaCungCap.DataSource = bus.DSNhaCungCap();
        }

        private void cbMaNCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            NhaCungCapBUS bus = new NhaCungCapBUS();
            var error = "System.Data.DataRowView";

            if (cbMaNCC.Text == error) return;

            DataTable dt = bus.LayThongTinNhaCungCap(cbMaNCC.Text);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                txtTenNCC.Text = row["TenNCC"].ToString(); ;
                txtSDT.Text = row["Sdt"].ToString(); ;
                txtDiaChi.Text = row["DiaChi"].ToString(); ;
                txtTinhTrang.Text = row["TinhTrang"].ToString();
                btnThem.Enabled = false;
                btnCapNhat.Enabled = true;
            }
            else
            {
                txtTenNCC.Text = "";
                txtSDT.Text = "";
                txtDiaChi.Text = "";
                txtTinhTrang.Text = "";
                btnThem.Enabled = true;
                btnCapNhat.Enabled = false;
            }
        }
    }
}
