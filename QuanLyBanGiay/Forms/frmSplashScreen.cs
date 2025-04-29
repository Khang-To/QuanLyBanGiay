using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.InteropServices;

namespace QuanLyBanGiay.Forms
{
    public partial class frmSplashScreen : Form
    {
        // Đổ bóng Form sử dụng DWM API
        [DllImport("dwmapi.dll")]
        private static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset);

        [DllImport("dwmapi.dll")]
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

        [StructLayout(LayoutKind.Sequential)]
        public struct MARGINS
        {
            public int cxLeftWidth;
            public int cxRightWidth;
            public int cyTopHeight;
            public int cyBottomHeight;
        }

        public frmSplashScreen()
        {
            InitializeComponent();
        }

        private void ApplyShadow()
        {
            int val = 2;
            DwmSetWindowAttribute(this.Handle, 2, ref val, 4);

            MARGINS margins = new MARGINS()
            {
                cxLeftWidth = 5,
                cxRightWidth = 5,
                cyTopHeight = 5,
                cyBottomHeight = 5
            };
            DwmExtendFrameIntoClientArea(this.Handle, ref margins);
        }


        private void frmSplashScreen_Load(object sender, EventArgs e)
        {
            ApplyShadow();
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (progressBar.Value < progressBar.Maximum)
            {
                progressBar.Value += 2;
                lblPhanTram.Text = progressBar.Value + "%";
            }
            else
            {
                timer.Stop();
                this.Close();
            }
        }
    }
}
