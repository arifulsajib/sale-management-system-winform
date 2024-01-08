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
    public partial class FormMainAdmin : Form
    {
        //objects for classes
        public informations info = new informations();
        public Users users = new Users();

        //fields
        private Button currentBtn;
        private Button previousBtn;
        private Image defaultImage;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        Thread th;

        public FormMainAdmin()
        {
            InitializeComponent();
            //left border before button
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 50);
            panelSideMenu.Controls.Add(leftBorderBtn);

            users.getUserData(informations.currentLoggedInUser);

            //current users name
            lblLoggedInUser.Text = informations.currentLoggedInUsersName;

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

        //custom close, maximize and minimize button
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
            
        }


        //Struct
        private struct RGBColors
        {
            public static Color white = Color.White;
            public static Color textColor1 = Color.FromArgb(26, 25, 62);
            public static Color backColor1 = Color.FromArgb(31, 30, 68);
            public static Color backColor2 = Color.FromArgb(37, 36, 81);

            public static Color color0 = Color.FromArgb(172, 126, 241);
            public static Color color1 = Color.FromArgb(249, 118, 176);
            public static Color color2 = Color.FromArgb(253, 138, 114);
            public static Color color3 = Color.FromArgb(95, 77, 221);
            public static Color color4 = Color.FromArgb(249, 88, 155);
            public static Color color5 = Color.FromArgb(78, 185, 85);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }


        // Methods 
        private void activeButton(object senderbtn, Color color, Image defaultImagecur, Image changedimage)
        {
            if (senderbtn != null)
            {
                currentBtn = (Button)senderbtn;
                disableButton(defaultImagecur);

                currentBtn.BackColor = RGBColors.backColor2;
                currentBtn.ForeColor = color;
                currentBtn.Image = changedimage;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                //Left border before button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                //Current Child Form Icon
                iconCurrentChildForm.Image = currentBtn.Image;

            }
        }

        private void disableButton(Image defaultImagecur)
        {
            if (currentBtn != null)
            {
                if (previousBtn != null)
                {
                    previousBtn.Image = defaultImage;
                    previousBtn.BackColor = RGBColors.backColor1;
                    previousBtn.ForeColor = RGBColors.white;
                    previousBtn.TextAlign = ContentAlignment.MiddleLeft;
                    previousBtn.ImageAlign = ContentAlignment.MiddleCenter;
                }
                previousBtn = currentBtn;
                defaultImage = defaultImagecur;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            //open only 1 childform
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChild.Controls.Add(childForm);
            panelChild.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChildForm.Text = childForm.Text;
        }


        // listeners
        private void btnProducts_Click(object sender, EventArgs e)
        {
            Image defaultImagecur = Properties.Resources.product;
            Image changedimage = Properties.Resources.productColor;
            activeButton(sender, RGBColors.color1, defaultImagecur, changedimage);
            OpenChildForm(new AdminChildForms.cFormProducts());
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            Image defaultImagecur = Properties.Resources.sales;
            Image changedimage = Properties.Resources.salesColor;
            activeButton(sender, RGBColors.color2, defaultImagecur, changedimage);
            OpenChildForm(new AdminChildForms.cFormSales());
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            Image defaultImagecur = Properties.Resources.users;
            Image changedimage = Properties.Resources.usersColor;
            activeButton(sender, RGBColors.color3, defaultImagecur, changedimage);
            OpenChildForm(new AdminChildForms.cFormUsers());
        }

        private void btnAnalysis_Click(object sender, EventArgs e)
        {
            Image defaultImagecur = Properties.Resources.analysis;
            Image changedimage = Properties.Resources.analysisColor;
            activeButton(sender, RGBColors.color4, defaultImagecur, changedimage);
            OpenChildForm(new AdminChildForms.cFormAnalysis());
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            Image defaultImagecur = Properties.Resources.settings;
            Image changedimage = Properties.Resources.settingsColor;
            activeButton(sender, RGBColors.color5, defaultImagecur, changedimage);
            OpenChildForm(new AdminChildForms.cFormSettings());
        }

        private void btnDevinfo_Click(object sender, EventArgs e)
        {
            Image defaultImagecur = Properties.Resources.info;
            Image changedimage = Properties.Resources.infoColor;
            activeButton(sender, RGBColors.color6, defaultImagecur, changedimage);
            OpenChildForm(new AdminChildForms.cFormDevInfo());
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            disableButton(defaultImage);
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.Image = Properties.Resources.homeColor;
            lblTitleChildForm.Text = "Home";
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to Logout?", "Logout Alert", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
                th = new Thread(openLoginForm);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }
        }

        private void openLoginForm()
        {
            Application.Run(new FormLogin());
        }

    }
}
