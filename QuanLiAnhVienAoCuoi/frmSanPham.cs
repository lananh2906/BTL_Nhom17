using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLiAnhVienAoCuoi.Class;

namespace QuanLiAnhVienAoCuoi
{
    public partial class frmSanPham : Form
    {
        DataTable tblSP;
        string sql;
        public frmSanPham()
        {
            InitializeComponent();
        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            Functions.Connect();
            btnhuy.Enabled = false;
            loadDataToGridView();
            Resetvalues();
        }

        private void loadDataToGridView()
        {
            string sql = "Select MaSP, TenSP, MaLoaiSP, MaMau, ManoiSX, Soluong, Dongianhap, Dongiathue from tblSanPham";
            tblSP = Functions.GetDataToTable(sql);
            DataGridView.DataSource = tblSP;

        }

        private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaSP.Text = DataGridView.CurrentRow.Cells["MaSP"].Value.ToString();
            txtTenSP.Text = DataGridView.CurrentRow.Cells["TenSP"].Value.ToString();
            txtMaMau.Text = DataGridView.CurrentRow.Cells["MaMau"].Value.ToString();
            txtMaLoaiSP.Text = DataGridView.CurrentRow.Cells["MaLoaiSP"].Value.ToString();
            txtManoiSX.Text = DataGridView.CurrentRow.Cells["ManoiSX"].Value.ToString();
            txtSoluong.Text = DataGridView.CurrentRow.Cells["Soluong"].Value.ToString();
            txtDongianhap.Text = DataGridView.CurrentRow.Cells["Dongianhap"].Value.ToString();
            txtDongiathue.Text = DataGridView.CurrentRow.Cells["Dongiathue"].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnhuy.Enabled = true;
            btnLuu.Enabled = true;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            txtMaSP.Enabled = true;
            Resetvalues();
        }

        private void Resetvalues()
        {
            txtMaSP.Text = "";
            txtTenSP.Text = "";
            txtManoiSX.Text = "";
            txtMaMau.Text = "";
            txtMaLoaiSP.Text = "";
            txtDongianhap.Text = "0";
            txtDongiathue.Text = "0";
            txtSoluong.Text = "0";
            txtAnh.Text = "";
            picAnh.Image = null;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (tblSP.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenSP.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenSP.Focus();
                return;
            }
            if (txtSoluong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoluong.Focus();
                return;
            }
            if (txtDongianhap.Text == "")
            {
                MessageBox.Show("Bạn phải nhập đơn giá nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDongianhap.Focus();
                return;
            }
            if (txtDongiathue.Text == "")
            {
                MessageBox.Show("Bạn phải nhập đơn giá thuê", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDongiathue.Focus();
                return;
            }
            sql = "UPDATE tblSanPham SET TenSP = N'" + txtTenSP.Text.Trim().ToString() +
                "',SoLuong ='" + txtSoluong.Text.Trim().ToString() +
                "',DonGiaNhap='" + txtDongianhap.Text.ToString() +
                "',DonGiaThue='" + txtDongiathue.Text.ToString() + "' where MaSP='" + txtMaSP.Text + "'";
            Functions.RunSql(sql);
            loadDataToGridView();
            txtMaSP.Enabled = false;
            Resetvalues();

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = "delete from tblSanPham where MaSP='" + txtMaSP.Text + "'";
            Functions.RunSql(sql);
            loadDataToGridView();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaSP.Text.Trim().Length == 0)
            {
                MessageBox.Show(" Bạn phải nhập mã sản phẩm", " Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtMaSP.Focus();
                return;
            }
            if (txtTenSP.Text.Trim().Length == 0)
            {
                MessageBox.Show(" Bạn phải nhập tên sản phẩm ", " Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtTenSP.Focus();
                return;
            }
            else
            {
                string sql = "insert into tblSanPham values ('" + txtMaSP.Text + "', '" + txtTenSP.Text + "'";
                if (txtAnh.Text != "")
                    sql = sql + ", " + txtAnh.Text.Trim();
                if (txtMaMau.Text != "")
                    sql = sql + ", " + txtMaMau.Text.Trim();
                if (txtManoiSX.Text != "")
                    sql = sql + ", " + txtManoiSX.Text.Trim();
                if (txtSoluong.Text != "")
                    sql = sql + ", " + txtSoluong.Text.Trim();
                if (txtDongianhap.Text != "")
                    sql = sql + ", " + txtDongianhap.Text.Trim();
                if (txtDongiathue.Text != "")
                    sql = sql + ", " + txtDongiathue.Text.Trim();
                if (txtMaLoaiSP.Text != "")
                    sql = sql + ", " + txtMaLoaiSP.Text.Trim();
                sql = sql + ")";

                Functions.RunSql(sql);
                loadDataToGridView();
            }
            Resetvalues();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnhuy.Enabled = false;
            btnLuu.Enabled = false;
            txtMaSP.Enabled = false;
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            Resetvalues();
            btnhuy.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDongianhap_TextChanged(object sender, EventArgs e)
        {
            double dgn, dgt;
            if (txtDongianhap.Text == "")
                dgn = 0;
            else
                dgn = Convert.ToDouble(txtDongianhap.Text);
            dgt = dgn * 0.5;
            txtDongiathue.Text = dgt.ToString();
        }

        private void btnopen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = " Image file (*.BMP,*.JPG,*JPEG)|*.bmp;*.jpg;*.jpeg" ;
            dlgOpen.InitialDirectory = " D:\\";
            dlgOpen.FilterIndex = 2;
            dlgOpen.Title = " Chon hinh anh de hien thi" ;
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                picAnh.Image = Image.FromFile(dlgOpen.FileName);
                txtAnh.Text = dlgOpen.FileName;
            }
        }
    }
}
