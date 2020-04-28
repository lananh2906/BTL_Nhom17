using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLiAnhVienAoCuoi.Class;

namespace QuanLiAnhVienAoCuoi
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Class.Functions.Connect();
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            Class.Functions.Disconnect();
            Application.Exit();
        }

        private void mnuSanPham_Click(object sender, EventArgs e)
        {
            frmSanPham f = new frmSanPham();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void mnuDSachHDN_Click(object sender, EventArgs e)
        {
            frmBCHoaDonNhap f = new frmBCHoaDonNhap();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void mnuDsachHD_Click(object sender, EventArgs e)
        {
            frmBCHopDong f = new frmBCHopDong();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void mnuDSChuatra_Click(object sender, EventArgs e)
        {
            frmBCChuatra f = new frmBCChuatra();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }
    }
}
