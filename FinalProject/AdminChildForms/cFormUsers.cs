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
    public partial class cFormUsers : Form
    {
        DataTable allUsersInfoDt;
        informations info = new informations();
        Users users = new Users();
        public cFormUsers()
        {
            InitializeComponent();

            cbxSearchBy.SelectedIndex = 0;
            allUsersInfoDt = users.getAllUserData();
            dgvAllUsersInfo.DataSource = allUsersInfoDt;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            info.name = txtName.Text.Trim();
            info.email = txtEmail.Text.Trim();
            info.address = txtAddress.Text.Trim();
            info.password = txtPassword.Text.Trim();
            info.phone = txtPhone.Text.Trim();
            info.role = cbxRole.Text.ToLower().Trim();
            info.username = txtUserName.Text.ToLower().Trim();

            if (info.name.Length == 0 || info.email.Length == 0 || info.address.Length == 0 || info.password.Length == 0 || info.phone.Length == 0 || info.username.Length == 0 || info.role.Length == 0 )
            {
                MessageBox.Show("Please Fill All the Fields..");
            }
            else if (users.isUserExists(info))
            {
                MessageBox.Show("Username already exists...");
            }
            else
            {
                if (users.addUsers(info))
                {
                    MessageBox.Show("Users Added Successfully");

                    //refresh
                    allUsersInfoDt = users.getAllUserData();
                    dgvAllUsersInfo.DataSource = allUsersInfoDt;

                    //reset fields
                    Reset();
                }
                else
                {
                    MessageBox.Show("There is some problem");
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            info.name = txtName.Text.Trim();
            info.email = txtEmail.Text.Trim();
            info.address = txtAddress.Text.Trim();
            info.password = txtPassword.Text.Trim();
            info.phone = txtPhone.Text.Trim();
            info.role = cbxRole.Text.ToLower().Trim();
            info.username = txtUserName.Text.ToLower().Trim();

            if (info.name.Length == 0 || info.email.Length == 0 || info.address.Length == 0 || info.password.Length == 0 || info.phone.Length == 0 || info.username.Length == 0 || info.role.Length == 0)
            {
                MessageBox.Show("Please Fill All the Fields..");
            }
            else
            {
                if (MessageBox.Show("Do you Want to Update?", "Update", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (users.updateUsers(info))
                    {
                        MessageBox.Show("Users Updated Successfully");

                        //refresh
                        allUsersInfoDt = users.getAllUserData();
                        dgvAllUsersInfo.DataSource = allUsersInfoDt;

                        //reset fields
                        Reset();
                    }
                    else
                    {
                        MessageBox.Show("There is some problem");
                    }
                }
                
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            info.username = txtUserName.Text.ToLower().Trim();
            if (info.username.Length == 0)
            {
                MessageBox.Show("Please Enter the username you want to delete..");
            }
            else
            {
                if (MessageBox.Show("Do you Want to Delete?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (users.deleteUsers(info))
                    {
                        MessageBox.Show("User deleted Successfully");

                        //refresh
                        allUsersInfoDt = users.getAllUserData();
                        dgvAllUsersInfo.DataSource = allUsersInfoDt;

                        //reset fields
                        Reset();
                    }
                    else
                    {
                        MessageBox.Show("username not Exists...");
                    }
                }
                
            }

        }

        private void Reset()
        {
            txtName.Text = "";
            txtEmail.Text = "";
            txtAddress.Text = "";
            txtPassword.Text = "";
            txtPhone.Text = "";
            txtUserName.Text = "";
            cbxRole.Text = "";
        }

        private void dgvAllUsersInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txtName.Text = this.dgvAllUsersInfo.Rows[this.dgvAllUsersInfo.CurrentCell.RowIndex].Cells["clmName"].Value.ToString();
            this.txtEmail.Text = this.dgvAllUsersInfo.Rows[this.dgvAllUsersInfo.CurrentCell.RowIndex].Cells["clmEmail"].Value.ToString();
            this.txtAddress.Text = this.dgvAllUsersInfo.Rows[this.dgvAllUsersInfo.CurrentCell.RowIndex].Cells["clmAddress"].Value.ToString();
            this.txtPassword.Text = this.dgvAllUsersInfo.Rows[this.dgvAllUsersInfo.CurrentCell.RowIndex].Cells["clmPassword"].Value.ToString();
            this.txtPhone.Text = this.dgvAllUsersInfo.Rows[this.dgvAllUsersInfo.CurrentCell.RowIndex].Cells["clmPhone"].Value.ToString();
            this.txtUserName.Text = this.dgvAllUsersInfo.Rows[this.dgvAllUsersInfo.CurrentCell.RowIndex].Cells["clmUsername"].Value.ToString();
            this.cbxRole.SelectedIndex = cbxRole.FindStringExact(this.dgvAllUsersInfo.Rows[this.dgvAllUsersInfo.CurrentCell.RowIndex].Cells["clmRole"].Value.ToString());
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (cbxSearchBy.SelectedIndex == 0)
            {
                DataView dv = allUsersInfoDt.DefaultView;
                dv.RowFilter = string.Format("username like '%{0}%'", txtSearch.Text);
                dgvAllUsersInfo.DataSource = dv.ToTable();
            }
            else
            {
                DataView dv = allUsersInfoDt.DefaultView;
                dv.RowFilter = string.Format("name like '%{0}%'", txtSearch.Text);
                dgvAllUsersInfo.DataSource = dv.ToTable();
            }
            
        }
    }
}
