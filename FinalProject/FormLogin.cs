using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using SaleBLL;

namespace FinalProject
{
    public partial class FormLogin : Form
    {
        //objects for classes
        public informations info = new informations();
        public Users users = new Users();

        //fields
        private Button currentBtn;
        private string loginType;
        Thread th;

        public FormLogin()
        {
            InitializeComponent();

            //disable input
            txtUsername.Enabled = false;
            txtPassword.Enabled = false;

            //Titlebar
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }

        //drag form from custom titlebar
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        // Resize window without border
        private const int cGrip = 16;      // Grip size
        private const int cCaption = 32;   // Caption bar height;

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {  // Trap WM_NCHITTEST
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);
                if (pos.Y < cCaption)
                {
                    m.Result = (IntPtr)2;  // HTCAPTION
                    return;
                }
                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17; // HTBOTTOMRIGHT
                    return;
                }
            }
            base.WndProc(ref m);
        }

        //custom close and minimize button
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }



        //Struct
        private struct RGBColors
        {
            public static Color white = Color.White;
            public static Color textColor1 = Color.FromArgb(26, 25, 62);
            public static Color color1 = Color.FromArgb(172,126,241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }

        private void activeButton(object senderbtn, Color color)
        {
            if (senderbtn != null)
            {
                disableButton();
                currentBtn = (Button)senderbtn;
                currentBtn.BackColor = color;
                currentBtn.ForeColor = RGBColors.white;

                txtUsername.Enabled = true;
                txtPassword.Enabled = true;
            }
        }

        private void disableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = RGBColors.white;
                currentBtn.ForeColor = RGBColors.textColor1;
            }
        }

        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            activeButton(sender, RGBColors.color5);
            loginType = "admin";
            
        }

        private void btnUserLogin_Click(object sender, EventArgs e)
        {
            activeButton(sender, RGBColors.color5);
            loginType = "user";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            info.username = txtUsername.Text.Trim();
            info.password = txtPassword.Text.Trim();

            if (info.username.Length == 0)
            {
                MessageBox.Show("Please input Username.");
                txtUsername.Focus();
            }

            else if (info.password.Length == 0)
            {
                MessageBox.Show("Please input password.");
                txtPassword.Focus();
            }

            else if (loginType == "admin" && users.isValidAdmin(info))
            {
                informations.currentLoggedInUser = info.username;

                Close();
                th = new Thread(openAdminForm);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }

            else if (loginType == "user" && users.isValidUser(info))
            {
                informations.currentLoggedInUser = info.username;

                Close();
                th = new Thread(openUserForm);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }

            else
            {
                MessageBox.Show("Username or password is incorrect!");
                txtUsername.Focus();
            }

        }

        private void openUserForm()
        {
            Application.Run(new FormMainUser());
        }

        private void openAdminForm()
        {
            Application.Run(new FormMainAdmin());
        }

    }
}
