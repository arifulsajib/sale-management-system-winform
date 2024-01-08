using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SaleBLL;

namespace FinalProject.AdminChildForms
{
    public partial class cFormSettings : Form
    {
        int i = 0;
        informations info = new informations();
        Users users = new Users();
        public cFormSettings()
        {
            InitializeComponent();

            //set info
            setUsersInfo();
        }

        private void btnEditEnable_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                btnEditEnable.Text = "Disable Edit";
                btnEditEnable.BackColor = Color.Purple;
                btnEditEnable.ForeColor = Color.White;
                i = 1;

                txtCurName.Enabled = true;
                txtCurName.BackColor = Color.White;
                txtCurName.ForeColor = Color.FromArgb(26, 25, 62);
                txtCurAddress.Enabled = true;
                txtCurAddress.BackColor = Color.White;
                txtCurAddress.ForeColor = Color.FromArgb(26, 25, 62);
                txtCurEmail.Enabled = true;
                txtCurEmail.BackColor = Color.White;
                txtCurEmail.ForeColor = Color.FromArgb(26, 25, 62);
                txtCurPhone.Enabled = true;
                txtCurPhone.BackColor = Color.White;
                txtCurPhone.ForeColor = Color.FromArgb(26, 25, 62);


            }
            else
            {
                btnEditEnable.Text = "Enable Edit";
                btnEditEnable.BackColor = Color.White;
                btnEditEnable.ForeColor = Color.FromArgb(26, 25, 62);
                i = 0;

                txtCurName.Enabled = false;
                txtCurName.BackColor = Color.FromArgb(34, 33, 74);
                txtCurName.ForeColor = Color.White;
                txtCurAddress.Enabled = false;
                txtCurAddress.BackColor = Color.FromArgb(34, 33, 74);
                txtCurAddress.ForeColor = Color.White;
                txtCurEmail.Enabled = false;
                txtCurEmail.BackColor = Color.FromArgb(34, 33, 74);
                txtCurEmail.ForeColor = Color.FromArgb(26, 25, 62);
                txtCurPhone.Enabled = false;
                txtCurPhone.BackColor = Color.FromArgb(34, 33, 74);
                txtCurPhone.ForeColor = Color.White;
            }
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            info.name = txtCurName.Text.Trim();
            info.address = txtCurAddress.Text.Trim();
            info.phone = txtCurPhone.Text.Trim();
            info.email = txtCurEmail.Text.Trim();
            info.username = informations.currentLoggedInUser;

            if (i == 0)
            {
                MessageBox.Show("Please Enable Edit first!");
            }
            else if (info.name.Length == 0 || info.address.Length == 0 || info.email.Length == 0 || info.phone.Length == 0)
            {
                MessageBox.Show("Please Enter something");
            }
            else
            {
                if (users.updateUserInfo(info))
                {
                    MessageBox.Show("Users Data Updated Successfully..");

                    //refresh
                    users.getUserData(informations.currentLoggedInUser);
                    setUsersInfo();
                } 
                else
                {
                    MessageBox.Show("There is some problem");
                }
                
            }

        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            info.username = informations.currentLoggedInUser;
            info.curPassword = txtCurPass.Text.Trim();
            info.newPassword = txtNewPass.Text.Trim();

            if (info.curPassword != informations.currentLoggedInUsersPassword)
            {
                MessageBox.Show("Your current password is wrong!");
            }
            else
            {
                if (users.changePass(info))
                {
                    MessageBox.Show("Password Changed Successfully..");

                    //refresh
                    informations.currentLoggedInUsersPassword = info.newPassword;
                    txtCurPass.Text = "";
                    txtNewPass.Text = "";
                }
                else
                {
                    MessageBox.Show("There is some problem");
                }
            }
            
        }

        private void setUsersInfo()
        {
            txtCurUserName.Text = informations.currentLoggedInUser;
            txtCurPhone.Text = informations.currentLoggedInUsersPhone;
            txtCurName.Text = informations.currentLoggedInUsersName;
            txtCurEmail.Text = informations.currentLoggedInUsersEmail;
            txtCurAddress.Text = informations.currentLoggedInUsersAddress;
        }

        
    }
}
