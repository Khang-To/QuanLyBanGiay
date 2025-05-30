namespace QuanLyBanGiay.Reports
{
    partial class frmThongKeGiay
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
            reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            panel1 = new Panel();
            btnLamMoi = new Button();
            btnLocKetQua = new Button();
            cboLoaiGiay = new ComboBox();
            label2 = new Label();
            cboThuongHieu = new ComboBox();
            label1 = new Label();
            helpProvider1 = new HelpProvider();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // reportViewer
            // 
            reportViewer.Dock = DockStyle.Fill;
            reportViewer.Location = new Point(0, 47);
            reportViewer.Name = "ReportViewer";
            reportViewer.ServerReport.BearerToken = null;
            reportViewer.Size = new Size(800, 403);
            reportViewer.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnLamMoi);
            panel1.Controls.Add(btnLocKetQua);
            panel1.Controls.Add(cboLoaiGiay);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(cboThuongHieu);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 47);
            panel1.TabIndex = 1;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Anchor = AnchorStyles.Top;
            btnLamMoi.Location = new Point(666, 15);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(81, 23);
            btnLamMoi.TabIndex = 5;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnLocKetQua
            // 
            btnLocKetQua.Anchor = AnchorStyles.Top;
            btnLocKetQua.Location = new Point(570, 15);
            btnLocKetQua.Name = "btnLocKetQua";
            btnLocKetQua.Size = new Size(90, 23);
            btnLocKetQua.TabIndex = 4;
            btnLocKetQua.Text = "Lọc kết quả";
            btnLocKetQua.UseVisualStyleBackColor = true;
            btnLocKetQua.Click += btnLocKetQua_Click;
            // 
            // cboLoaiGiay
            // 
            cboLoaiGiay.Anchor = AnchorStyles.Top;
            cboLoaiGiay.FormattingEnabled = true;
            cboLoaiGiay.Location = new Point(443, 16);
            cboLoaiGiay.Name = "cboLoaiGiay";
            cboLoaiGiay.Size = new Size(121, 23);
            cboLoaiGiay.TabIndex = 3;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Location = new Point(380, 20);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 2;
            label2.Text = "Loại giày:";
            // 
            // cboThuongHieu
            // 
            cboThuongHieu.Anchor = AnchorStyles.Top;
            cboThuongHieu.FormattingEnabled = true;
            cboThuongHieu.Location = new Point(210, 16);
            cboThuongHieu.Name = "cboThuongHieu";
            cboThuongHieu.Size = new Size(121, 23);
            cboThuongHieu.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Location = new Point(119, 19);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 0;
            label1.Text = "Thương hiệu:";
            // 
            // helpProvider1
            // 
            helpProvider1.HelpNamespace = "https://maithiencan.github.io/helpqlbg/thongkegiay.html";
            // 
            // frmThongKeGiay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(reportViewer);
            Controls.Add(panel1);
            helpProvider1.SetHelpKeyword(this, "F1");
            MinimumSize = new Size(816, 489);
            Name = "frmThongKeGiay";
            helpProvider1.SetShowHelp(this, true);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thống kê giày";
            Load += frmThongKeGiay_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private Panel panel1;
        private ComboBox cboLoaiGiay;
        private Label label2;
        private ComboBox cboThuongHieu;
        private Label label1;
        private Button btnLocKetQua;
        private Button btnLamMoi;
        private HelpProvider helpProvider1;
    }
}