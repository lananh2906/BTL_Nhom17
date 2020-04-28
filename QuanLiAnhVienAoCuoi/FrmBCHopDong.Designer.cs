namespace QuanLiAnhVienAoCuoi
{
    partial class frmBCHopDong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtTongtien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnLamlai = new System.Windows.Forms.Button();
            this.btnBaocao = new System.Windows.Forms.Button();
            this.btnInbaocao = new System.Windows.Forms.Button();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKHach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngaythanhtoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Khuyenmai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TamUng = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tongtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNam = new System.Windows.Forms.TextBox();
            this.txtThang = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboQuy = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTongtien
            // 
            this.txtTongtien.Location = new System.Drawing.Point(543, 410);
            this.txtTongtien.Name = "txtTongtien";
            this.txtTongtien.Size = new System.Drawing.Size(195, 26);
            this.txtTongtien.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(459, 416);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "Tổng tiền";
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnDong.Location = new System.Drawing.Point(654, 452);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(84, 35);
            this.btnDong.TabIndex = 23;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnLamlai
            // 
            this.btnLamlai.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnLamlai.Location = new System.Drawing.Point(310, 452);
            this.btnLamlai.Name = "btnLamlai";
            this.btnLamlai.Size = new System.Drawing.Size(84, 35);
            this.btnLamlai.TabIndex = 22;
            this.btnLamlai.Text = "Làm Lại";
            this.btnLamlai.UseVisualStyleBackColor = false;
            this.btnLamlai.Click += new System.EventHandler(this.btnLamlai_Click);
            // 
            // btnBaocao
            // 
            this.btnBaocao.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnBaocao.Location = new System.Drawing.Point(208, 452);
            this.btnBaocao.Name = "btnBaocao";
            this.btnBaocao.Size = new System.Drawing.Size(84, 35);
            this.btnBaocao.TabIndex = 21;
            this.btnBaocao.Text = "Báo cáo";
            this.btnBaocao.UseVisualStyleBackColor = false;
            this.btnBaocao.Click += new System.EventHandler(this.btnBaocao_Click);
            // 
            // btnInbaocao
            // 
            this.btnInbaocao.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnInbaocao.Location = new System.Drawing.Point(72, 432);
            this.btnInbaocao.Name = "btnInbaocao";
            this.btnInbaocao.Size = new System.Drawing.Size(118, 55);
            this.btnInbaocao.TabIndex = 20;
            this.btnInbaocao.Text = "In báo cáo";
            this.btnInbaocao.UseVisualStyleBackColor = false;
            this.btnInbaocao.Click += new System.EventHandler(this.btnInbaocao_Click);
            // 
            // DataGridView
            // 
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHD,
            this.MaKHach,
            this.MaNV,
            this.NgayHD,
            this.Ngaythanhtoan,
            this.Khuyenmai,
            this.TamUng,
            this.Tongtien});
            this.DataGridView.Location = new System.Drawing.Point(72, 200);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.RowHeadersWidth = 62;
            this.DataGridView.RowTemplate.Height = 28;
            this.DataGridView.Size = new System.Drawing.Size(666, 192);
            this.DataGridView.TabIndex = 19;
            // 
            // MaHD
            // 
            this.MaHD.DataPropertyName = "MaHD";
            this.MaHD.HeaderText = "Mã HD";
            this.MaHD.MinimumWidth = 8;
            this.MaHD.Name = "MaHD";
            this.MaHD.Width = 150;
            // 
            // MaKHach
            // 
            this.MaKHach.DataPropertyName = "MaKHach";
            this.MaKHach.HeaderText = "Mã khách";
            this.MaKHach.MinimumWidth = 8;
            this.MaKHach.Name = "MaKHach";
            this.MaKHach.Width = 150;
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã NV";
            this.MaNV.MinimumWidth = 8;
            this.MaNV.Name = "MaNV";
            this.MaNV.Width = 150;
            // 
            // NgayHD
            // 
            this.NgayHD.DataPropertyName = "NgayHD";
            this.NgayHD.HeaderText = "Ngày HD";
            this.NgayHD.MinimumWidth = 8;
            this.NgayHD.Name = "NgayHD";
            this.NgayHD.Width = 150;
            // 
            // Ngaythanhtoan
            // 
            this.Ngaythanhtoan.DataPropertyName = "Ngaythanhtoan";
            this.Ngaythanhtoan.HeaderText = "Ngày thanh toán";
            this.Ngaythanhtoan.MinimumWidth = 8;
            this.Ngaythanhtoan.Name = "Ngaythanhtoan";
            this.Ngaythanhtoan.Width = 150;
            // 
            // Khuyenmai
            // 
            this.Khuyenmai.DataPropertyName = "Khuyenmai";
            this.Khuyenmai.HeaderText = "Khuyến mại";
            this.Khuyenmai.MinimumWidth = 8;
            this.Khuyenmai.Name = "Khuyenmai";
            this.Khuyenmai.Width = 150;
            // 
            // TamUng
            // 
            this.TamUng.DataPropertyName = "TamUng";
            this.TamUng.HeaderText = "Tạm ứng";
            this.TamUng.MinimumWidth = 8;
            this.TamUng.Name = "TamUng";
            this.TamUng.Width = 150;
            // 
            // Tongtien
            // 
            this.Tongtien.DataPropertyName = "Tongtien";
            this.Tongtien.HeaderText = "Tổng tiền";
            this.Tongtien.MinimumWidth = 8;
            this.Tongtien.Name = "Tongtien";
            this.Tongtien.Width = 150;
            // 
            // txtNam
            // 
            this.txtNam.Location = new System.Drawing.Point(168, 140);
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(195, 26);
            this.txtNam.TabIndex = 18;
            // 
            // txtThang
            // 
            this.txtThang.Location = new System.Drawing.Point(168, 88);
            this.txtThang.Name = "txtThang";
            this.txtThang.Size = new System.Drawing.Size(195, 26);
            this.txtThang.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(152, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(478, 32);
            this.label4.TabIndex = 16;
            this.label4.Text = "BÁO CÁO DANH SÁCH HỢP ĐỒNG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Năm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Tháng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(459, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "Qúy";
            // 
            // cboQuy
            // 
            this.cboQuy.FormattingEnabled = true;
            this.cboQuy.Location = new System.Drawing.Point(535, 86);
            this.cboQuy.Name = "cboQuy";
            this.cboQuy.Size = new System.Drawing.Size(195, 28);
            this.cboQuy.TabIndex = 27;
            // 
            // frmBCHopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(791, 499);
            this.Controls.Add(this.cboQuy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTongtien);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnLamlai);
            this.Controls.Add(this.btnBaocao);
            this.Controls.Add(this.btnInbaocao);
            this.Controls.Add(this.DataGridView);
            this.Controls.Add(this.txtNam);
            this.Controls.Add(this.txtThang);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmBCHopDong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBCHopDong";
            this.Load += new System.EventHandler(this.FrmBCHopDong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTongtien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnLamlai;
        private System.Windows.Forms.Button btnBaocao;
        private System.Windows.Forms.Button btnInbaocao;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.TextBox txtNam;
        private System.Windows.Forms.TextBox txtThang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboQuy;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKHach;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngaythanhtoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Khuyenmai;
        private System.Windows.Forms.DataGridViewTextBoxColumn TamUng;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tongtien;
    }
}