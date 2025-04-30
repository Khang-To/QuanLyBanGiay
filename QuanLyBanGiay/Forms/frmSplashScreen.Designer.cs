namespace QuanLyBanGiay.Forms
{
    partial class frmSplashScreen
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
            components = new System.ComponentModel.Container();
            timer = new System.Windows.Forms.Timer(components);
            progressBar = new ProgressBar();
            lblPhanTram = new Label();
            SuspendLayout();
            // 
            // timer
            // 
            timer.Interval = 20;
            timer.Tick += timer_Tick;
            // 
            // progressBar
            // 
            progressBar.Dock = DockStyle.Bottom;
            progressBar.Location = new Point(0, 336);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(595, 25);
            progressBar.TabIndex = 0;
            // 
            // lblPhanTram
            // 
            lblPhanTram.AutoSize = true;
            lblPhanTram.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPhanTram.Location = new Point(273, 307);
            lblPhanTram.Name = "lblPhanTram";
            lblPhanTram.Size = new Size(48, 25);
            lblPhanTram.TabIndex = 1;
            lblPhanTram.Text = "00%";
            // 
            // frmSplashScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.SplashScreen;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(595, 361);
            Controls.Add(lblPhanTram);
            Controls.Add(progressBar);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmSplashScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmSplashScreen";
            Load += frmSplashScreen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private ProgressBar progressBar;
        private Label lblPhanTram;
    }
}