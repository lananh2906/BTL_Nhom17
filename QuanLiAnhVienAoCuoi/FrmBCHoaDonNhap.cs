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
    public partial class frmBCHoaDonNhap : Form
    {
        
        DataTable tblBC;
        string sql;
        Double tong;

        public frmBCHoaDonNhap()
        {

            InitializeComponent();
        }
        private void FrmHoaDonNhap_Load(object sender, EventArgs e)
        {
            Functions.Connect();
            ResetValues();
            cboQuy.Items.Add("1");
            cboQuy.Items.Add("2");
            cboQuy.Items.Add("3");
            cboQuy.Items.Add("4");
            DataGridView.DataSource = null;
        }

        private void ResetValues()
        {
            txtThang.Text = "" ;
            txtNam.Text = "" ;
            cboQuy.SelectedItem = null;
            txtTongtien.Text = "0" ;
        }
        private void btnBaocao_Click(object sender, EventArgs e)
        {
            if (txtNam.Text=="")
            {
                MessageBox.Show("Bạn phải nhập năm", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNam.Focus();
                return;
            }
            if (txtNam.Text != "" && cboQuy.Text == "" && txtThang.Text == "")
            {
                sql = "SELECT * FROM tblHoaDonNhap WHERE datepart(YEAR,(NgayNhap))='" + txtNam.Text + "'";
                tblBC = Functions.GetDataToTable(sql);
                if (tblBC.Rows.Count == 0)
                    ResetValues();
                else
                    tong = Convert.ToDouble(Functions.GetFieldValues("SELECT sum(Tongtien) FROM tblHoaDonNhap WHERE datepart(YEAR,(NgayNhap))=N'" + txtNam.Text + "'"));
            }    
            if (txtThang.Text != "" && txtNam.Text != "" && cboQuy.Text =="")
            {
                sql = "SELECT * FROM tblHoaDonNhap WHERE datepart(MONTH,(NgayNhap))='" + txtThang.Text + "'AND datepart(YEAR,(NgayNhap))='" + txtNam.Text + "'";
                tblBC = Functions.GetDataToTable(sql);
                if (tblBC.Rows.Count == 0)
                    ResetValues();
                else
                    tong = Convert.ToDouble(Functions.GetFieldValues("SELECT sum(Tongtien) FROM tblHoaDonNhap WHERE datepart(MONTH,(NgayNhap))=N'" + txtThang.Text + "' AND datepart(YEAR,(NgayNhap))=N'" + txtNam.Text + "'"));
            }    
            if(txtNam.Text != "" && cboQuy.Text != "" && txtThang.Text == "")
            { 
                sql = "SELECT * FROM tblHoaDonNhap WHERE datepart(QUARTER,(NgayNhap))='" + cboQuy.Text + "'AND datepart(YEAR,(NgayNhap))='" + txtNam.Text + "'";
                tblBC = Functions.GetDataToTable(sql);
                if (tblBC.Rows.Count == 0)
                    ResetValues();
                else
                {
                    tong = Convert.ToDouble(Functions.GetFieldValues("SELECT sum(Tongtien) FROM tblHoaDonNhap WHERE datepart(YEAR,(NgayNhap))=N'" + txtNam.Text + "' AND datepart(QUARTER,(NgayNhap))=N'" + cboQuy.Text + "'"));
                }
            }
            if(txtThang.Text !="" && cboQuy.Text !="" && txtNam.Text != "")
            {
                sql = "SELECT * FROM tblHoaDonNhap WHERE datepart(MONTH,(NgayNhap))='" + txtThang.Text + "'AND datepart(QUARTER,(NgayNhap))='" + cboQuy.Text + "'AND datepart(YEAR,(NgayNhap))='" + txtNam.Text + "'";
                tblBC = Functions.GetDataToTable(sql);
                if (tblBC.Rows.Count == 0)
                    ResetValues();
                else
                    tong = Convert.ToDouble(Functions.GetFieldValues("SELECT sum(Tongtien) FROM tblHoaDonNhap WHERE datepart(MONTH,(NgayNhap))=N'" + txtThang.Text + "' AND datepart(YEAR,(NgayNhap))=N'" + txtNam.Text + "' AND datepart(QUARTER,(NgayNhap))=N'" + cboQuy.Text + "'"));
            }
            tblBC = Functions.GetDataToTable(sql);
            if (tblBC.Rows.Count == 0)
            {
                MessageBox.Show("Không có bản ghi thỏa mãn điều kiện!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tong = 0;
            }
            else
            {
                MessageBox.Show("Có" + tblBC.Rows.Count + "Bản ghi thỏa mãn điều kiện!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            txtTongtien.Text = tong.ToString();
            DataGridView.DataSource = tblBC;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInbaocao_Click(object sender, EventArgs e)
        {
            // Khởi động chương trình Excel
            COMExcel.Application exApp = new COMExcel.Application();
            COMExcel.Workbook exBook; //Trong 1 chương trình Excel có nhiều Workbook
            COMExcel.Worksheet exSheet; //Trong 1 Workbook có nhiều Worksheet
            COMExcel.Range exRange;
            string sql;
            int hang = 0, cot = 0;
            exBook = exApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);
            exSheet = exBook.Worksheets[1];
            // Định dạng chung
            exRange = exSheet.Cells[1, 1];
            exRange.Range["A1:B3"].Font.Size = 10;
            exRange.Range["A1:B3"].Font.Name = "Times new roman";
            exRange.Range["A1:B3"].Font.Bold = true;
            exRange.Range["A1:B3"].Font.ColorIndex = 5; //Màu xanh da trời
            exRange.Range["A1:A1"].ColumnWidth = 7;
            exRange.Range["B1:B1"].ColumnWidth = 15;
            exRange.Range["A1:B1"].MergeCells = true;
            exRange.Range["A1:B1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A1:B1"].Value = "Ảnh Viện Áo Cưới 17 ";

            exRange.Range["A2:B2"].MergeCells = true;
            exRange.Range["A2:B2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:B2"].Value = "Cầu Giấy - Hà Nội";

            exRange.Range["A3:B3"].MergeCells = true;
            exRange.Range["A3:B3"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A3:B3"].Value = "Điện thoại: (04)44456789";


            exRange.Range["C2:F2"].Font.Size = 16;
            exRange.Range["C2:F2"].Font.Name = "Times new roman";
            exRange.Range["C2:F2"].Font.Bold = true;
            exRange.Range["C2:F2"].Font.ColorIndex = 3; //Màu đỏ
            exRange.Range["C2:F2"].MergeCells = true;
            exRange.Range["C2:F2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C2:F2"].Value = "BÁO CÁO DANH SÁCH HÓA ĐƠN";

            exRange.Range["B5:B5"].MergeCells = true;
            exRange.Range["B5:B5"].Font.Bold = true;
            exRange.Range["B5:B5"].Font.Italic = true;
            exRange.Range["B5:B5"].Value = "Kì báo cáo: ";

            exRange.Range["C5:C5"].MergeCells = true;
            exRange.Range["C5:C5"].Value = "Quí " + cboQuy.SelectedItem;
            exRange.Range["D5:D5"].MergeCells = true;
            exRange.Range["D5:D5"].Value = txtThang.Text + "/" + txtNam.Text;

            //Tạo dòng tiêu đề bảng
            exRange.Range["A7:F7"].Font.Bold = true;
            exRange.Range["A7:F7"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C7:F7"].ColumnWidth = 12;
            exRange.Range["A7:A7"].Value = "STT";
            exRange.Range["B7:B7"].Value = "Mã HDN";
            exRange.Range["C7:C7"].Value = "Ngày nhập";
            exRange.Range["D7:D7"].Value = "Mã NV";
            exRange.Range["E7:E7"].Value = "Mã NCC";
            exRange.Range["F7:F7"].Value = "Tổng tiền";

            for (hang = 0; hang <= DataGridView.Rows.Count - 2; hang++)
            {
                exSheet.Cells[1][hang + 8] = hang + 1;
                for (cot = 0; cot < DataGridView.ColumnCount ; cot ++)
                {
                    exSheet.Cells[hang + 8, cot + 2] = DataGridView.Rows[hang].Cells[cot].Value;
                }
            }
            exRange = exSheet.Cells[cot][hang + 10];
            exRange.Font.Bold = true;
            exRange.Value2 = "Tổng tiền:";
            exRange.Value2 = "Tổng tiền: " + txtTongtien.Text.ToString();
            exRange = exSheet.Cells[1][hang + 11];
            exRange.Range["B1:G1"].MergeCells = true;
            exRange.Range["B1:G1"].Font.Bold = true;
            exRange.Range["B1:G1"].Font.Italic = true;
            exRange.Range["B1:G1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignRight;
            exRange.Range["B1:G1"].Value = "Bằng chữ:   " + Functions.ChuyenSoSangChu(txtTongtien.Text.ToString());

            exRange = exSheet.Cells[4][hang + 12];
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

            exSheet.Name = "Hóa đơn nhập";
            exApp.Visible = true;

        }

        private void btnLamlai_Click(object sender, EventArgs e)
        {
            ResetValues();
            DataGridView.DataSource = null;
        }
    }  
}
