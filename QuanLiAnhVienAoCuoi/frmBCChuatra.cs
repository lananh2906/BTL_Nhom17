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
using COMExcel = Microsoft.Office.Interop.Excel;
using QuanLiAnhVienAoCuoi.Class;

namespace QuanLiAnhVienAoCuoi
{
    public partial class frmBCChuatra : Form
    {
        DataTable tblBC;
        string sql;

        public frmBCChuatra()
        {
            InitializeComponent();
        }

        private void frmBCChuatra_Load(object sender, EventArgs e)
        {
            Functions.Connect();
        }
        private void ResetValue()
        {
            txtMaHD.Text = "";
            cboMaSP.Text = "";
            txtNgaythue.Text = "";
            txtSoluong.Text = "";
            txtTenSP.Text = "";
        }

        private void btnBaocao_Click(object sender, EventArgs e)
        {
            sql = "Select b.MaHD, a.MaSP,a.TenSP,b.SoLuong,b.NgayThue from tblSanPham AS a, tblChitietHDong AS b where b.ChuaTra = '1' and a.MaSP = b.MaSP";
            tblBC = Functions.GetDataToTable(sql);
            DataGridView.DataSource = tblBC;
        }

        private void btnLamlai_Click(object sender, EventArgs e)
        {
            ResetValue();
            DataGridView.DataSource = null;
        }

        private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaHD.Text = DataGridView.CurrentRow.Cells["MaHD"].Value.ToString();
            cboMaSP.Text = DataGridView.CurrentRow.Cells["MaSP"].Value.ToString();
            txtNgaythue.Text = DataGridView.CurrentRow.Cells["NgayThue"].Value.ToString();
            txtSoluong.Text = DataGridView.CurrentRow.Cells["SoLuong"].Value.ToString();
            txtTenSP.Text = DataGridView.CurrentRow.Cells["TenSP"].Value.ToString();
        }

        private void btnInbaocao_Click(object sender, EventArgs e)
        {
            COMExcel.Application exApp = new COMExcel.Application();
            COMExcel.Workbook exBook;
            COMExcel.Worksheet exSheet;
            COMExcel.Range exRange;
            string sql;
            int hang = 0, cot = 0;
            DataTable tblBCCT;
            exBook = exApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);
            exSheet = exBook.Worksheets[1];
            // Định dạng chung
            exRange = exSheet.Cells[1, 1];
            exRange.Range["A1:Z300"].Font.Name = "Times new roman"; //Font chữ
            exRange.Range["A1:B3"].Font.Size = 10;
            exRange.Range["A1:B3"].Font.Bold = true;
            exRange.Range["A1:B3"].Font.ColorIndex = 5; //Màu xanh da trời
            exRange.Range["A1:A1"].ColumnWidth = 7;
            exRange.Range["B1:B1"].ColumnWidth = 15;
            exRange.Range["A1:B1"].MergeCells = true;
            exRange.Range["A1:B1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A1:B1"].Value = "Ảnh viện áo cưới 17";
            exRange.Range["A2:B2"].MergeCells = true;
            exRange.Range["A2:B2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:B2"].Value = "Chùa Bộc - Hà Nội";
            exRange.Range["A3:B3"].MergeCells = true;
            exRange.Range["A3:B3"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A3:B3"].Value = "Điện thoại: (04)38526419";
            exRange.Range["C2:G2"].Font.Size = 16;
            exRange.Range["C2:G2"].Font.Bold = true;
            exRange.Range["C2:G2"].Font.ColorIndex = 3; //Màu đỏ
            exRange.Range["C2:G2"].MergeCells = true;
            exRange.Range["C2:G2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C2:G2"].Value = "BÁO CÁO SẢN PHẨM THUÊ CHƯA TRẢ";

            sql = "Select b.MaHD, a.MaSP,a.TenSP,b.SoLuong,b.NgayThue from tblSanPham AS a, tblChitietHDong AS b where b.ChuaTra = '1' and a.MaSP = b.MaSP";
            tblBCCT = Functions.GetDataToTable(sql);
            exRange.Range["A6:F6"].Font.Bold = true;
            exRange.Range["A6:F6"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C6:F6"].ColumnWidth = 12;
            exRange.Range["A6:A6"].Value = "STT";
            exRange.Range["B6:B6"].Value = "Mã HĐ";
            exRange.Range["C6:C6"].Value = "Mã Sản Phẩm";
            exRange.Range["D6:D6"].Value = "Tên Sản Phẩm";
            exRange.Range["E6:E6"].Value = "Số Lượng";
            exRange.Range["F6:F6"].Value = "Ngày thuê";
            for (hang = 0; hang < tblBCCT.Rows.Count; hang++)
            {
                //Điền số thứ tự vào cột 1 từ dòng 7
                exSheet.Cells[1][hang + 7] = hang + 1;
                for (cot = 0; cot < tblBCCT.Columns.Count; cot++)
                //Điền thông tin hàng từ cột thứ 2, dòng 7
                {
                    exSheet.Cells[cot + 2][hang + 7] = tblBCCT.Rows[hang][cot].ToString();
                }
            }

            exRange = exSheet.Cells[4][hang + 10];
            exRange.Range["A1:C1"].MergeCells = true;
            exRange.Range["A1:C1"].Font.Italic = true;
            exRange.Range["A1:C1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            int day = DateTime.Now.Day;
            int month = DateTime.Now.Month;
            int year = DateTime.Now.Year;
            exRange.Range["A1:C1"].Value = "Hà Nội, ngày " + day + " tháng " + month + " năm " + year;

            exRange.Range["A2:C2"].MergeCells = true;
            exRange.Range["A2:C2"].Font.Italic = true;
            exRange.Range["A2:C2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:C2"].Value = "Nhân viên lập báo cáo";

            exRange.Range["A3:C3"].MergeCells = true;
            exRange.Range["A3:C3"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A3:C3"].Value = "(Kí, Ghi rõ họ tên)";

            exSheet.Name = "BC SẢN PHẨM THUÊ CHƯA TRẢ";
            exApp.Visible = true;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
