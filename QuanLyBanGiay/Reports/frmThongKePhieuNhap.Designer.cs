namespace QuanLyBanGiay.Reports
{
    partial class frmThongKePhieuNhap
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
            reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            panel1 = new Panel();
            btnHienTatCa = new Button();
            btnLocKetQua = new Button();
            label2 = new Label();
            dtpDenNgay = new DateTimePicker();
            label1 = new Label();
            dtpTuNgay = new DateTimePicker();
            helpProvider1 = new HelpProvider();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // reportViewer1
            // 
            reportViewer1.Dock = DockStyle.Fill;
            reportViewer1.Location = new Point(0, 56);
            reportViewer1.Margin = new Padding(3, 2, 3, 2);
            reportViewer1.Name = "ReportViewer";
            reportViewer1.ServerReport.BearerToken = null;
            reportViewer1.Size = new Size(738, 282);
            reportViewer1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnHienTatCa);
            panel1.Controls.Add(btnLocKetQua);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(dtpDenNgay);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dtpTuNgay);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(738, 56);
            panel1.TabIndex = 1;
            // 
            // btnHienTatCa
            // 
            btnHienTatCa.Anchor = AnchorStyles.Top;
            btnHienTatCa.Location = new Point(608, 17);
            btnHienTatCa.Margin = new Padding(3, 2, 3, 2);
            btnHienTatCa.Name = "btnHienTatCa";
            btnHienTatCa.Size = new Size(97, 22);
            btnHienTatCa.TabIndex = 11;
            btnHienTatCa.Text = "Hiện tất cả";
            btnHienTatCa.UseVisualStyleBackColor = true;
            btnHienTatCa.Click += btnHienTatCa_Click;
            // 
            // btnLocKetQua
            // 
            btnLocKetQua.Anchor = AnchorStyles.Top;
            btnLocKetQua.Location = new Point(500, 17);
            btnLocKetQua.Margin = new Padding(3, 2, 3, 2);
            btnLocKetQua.Name = "btnLocKetQua";
            btnLocKetQua.Size = new Size(97, 22);
            btnLocKetQua.TabIndex = 10;
            btnLocKetQua.Text = "Lọc kết quả";
            btnLocKetQua.UseVisualStyleBackColor = true;
            btnLocKetQua.Click += btnLocKetQua_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Location = new Point(273, 21);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 9;
            label2.Text = "Từ ngày:";
            // 
            // dtpDenNgay
            // 
            dtpDenNgay.Anchor = AnchorStyles.Top;
            dtpDenNgay.CustomFormat = "dd/MM/yyyy";
            dtpDenNgay.Format = DateTimePickerFormat.Custom;
            dtpDenNgay.Location = new Point(344, 17);
            dtpDenNgay.Margin = new Padding(3, 2, 3, 2);
            dtpDenNgay.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
            dtpDenNgay.MinDate = new DateTime(2020, 1, 1, 0, 0, 0, 0);
            dtpDenNgay.Name = "dtpDenNgay";
            dtpDenNgay.Size = new Size(132, 23);
            dtpDenNgay.TabIndex = 8;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Location = new Point(32, 21);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 7;
            label1.Text = "Từ ngày:";
            // 
            // dtpTuNgay
            // 
            dtpTuNgay.Anchor = AnchorStyles.Top;
            dtpTuNgay.CustomFormat = "dd/MM/yyyy";
            dtpTuNgay.Format = DateTimePickerFormat.Custom;
            dtpTuNgay.Location = new Point(102, 17);
            dtpTuNgay.Margin = new Padding(3, 2, 3, 2);
            dtpTuNgay.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
            dtpTuNgay.MinDate = new DateTime(2020, 1, 1, 0, 0, 0, 0);
            dtpTuNgay.Name = "dtpTuNgay";
            dtpTuNgay.Size = new Size(132, 23);
            dtpTuNgay.TabIndex = 6;
            // 
            // helpProvider1
            // 
            helpProvider1.HelpNamespace = "https://maithiencan.github.io/helpqlbg/thongkenhaphang.html";
            // 
            // frmThongKePhieuNhap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(738, 338);
            Controls.Add(reportViewer1);
            Controls.Add(panel1);
            helpProvider1.SetHelpKeyword(this, "F1");
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmThongKePhieuNhap";
            helpProvider1.SetShowHelp(this, true);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thống kê phiếu nhập";
            Load += frmThongKePhieuNhap_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Panel panel1;
        private Button btnHienTatCa;
        private Button btnLocKetQua;
        private Label label2;
        private DateTimePicker dtpDenNgay;
        private Label label1;
        private DateTimePicker dtpTuNgay;
        private HelpProvider helpProvider1;
    }
}