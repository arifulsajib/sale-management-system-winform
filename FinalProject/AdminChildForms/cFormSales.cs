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
    public partial class cFormSales : Form
    {
        DataTable allProductsInfoDt;
        string productID;
        string maxDiscount;
        decimal totalAmount;
        decimal salePrice;

        informations info = new informations();
        Products products = new Products();
        Sales sales = new Sales();

        public cFormSales()
        {
            InitializeComponent();

            cbxSearchBy.SelectedIndex = 0;
            txtSaleDate.MaxDate = DateTime.Today;
            allProductsInfoDt = products.getAllProductsData();
            dgvAllProductsInfo.DataSource = allProductsInfoDt;
        }

        private void btnAddSell_Click(object sender, EventArgs e)
        {
            salePrice = (txtPrice.Value - txtDiscount.Value);

            info.productID = productID.ToLower().Trim();
            info.salePrice = salePrice.ToString().Trim();
            info.quantity = txtQuantity.Value.ToString().Trim();
            info.totalPrice = totalAmount.ToString().Trim();
            info.username = informations.currentLoggedInUser;
            info.saleDate = txtSaleDate.Value.ToString().Trim();
            info.Stock = txtStock.Value.ToString().Trim();
            info.notes = txtNotes.Text.Trim();

            if (txtQuantity.Value.ToString().Trim() == "" || txtDiscount.Value.ToString().Trim() == "")
            {
                MessageBox.Show("Fields can't be empty..");
            }
            else if (txtQuantity.Value < 1)
            {
                MessageBox.Show("Quantity Must be at least 1");
            }
            else
            {
                if (sales.addSales(info))
                {
                    MessageBox.Show("Sales Added Successfully");

                    //refresh
                    allProductsInfoDt = products.getAllProductsData();
                    dgvAllProductsInfo.DataSource = allProductsInfoDt;

                    //reset fields
                    Reset();
                }
                else
                {
                    MessageBox.Show("There is some problem");
                }
            }

        }

        private void Reset()
        {
            productID = "";
            txtProductName.Text = "";
            txtBrand.Text = "";
            txtStock.Value = 0;
            txtPrice.Value = 0;
            lblMaxDiscount.Text = "";
            lblMaxQuantity.Text = "";
            txtNotes.Text = "";
            txtDiscount.Value = 0;
            txtQuantity.Value = 0;
            txtSaleDate.Value = DateTime.Today;
        }

        private void dgvAllProductsInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.productID = this.dgvAllProductsInfo.Rows[this.dgvAllProductsInfo.CurrentCell.RowIndex].Cells["clmProductId"].Value.ToString();
            this.txtProductName.Text = this.dgvAllProductsInfo.Rows[this.dgvAllProductsInfo.CurrentCell.RowIndex].Cells["clmProductName"].Value.ToString();
            this.txtBrand.Text = this.dgvAllProductsInfo.Rows[this.dgvAllProductsInfo.CurrentCell.RowIndex].Cells["clmBrand"].Value.ToString();
            this.txtPrice.Text = this.dgvAllProductsInfo.Rows[this.dgvAllProductsInfo.CurrentCell.RowIndex].Cells["clmRetailPrice"].Value.ToString();
            this.maxDiscount = this.dgvAllProductsInfo.Rows[this.dgvAllProductsInfo.CurrentCell.RowIndex].Cells["clmMaxDiscount"].Value.ToString();
            this.txtStock.Text = this.dgvAllProductsInfo.Rows[this.dgvAllProductsInfo.CurrentCell.RowIndex].Cells["clmStock"].Value.ToString();

            lblMaxDiscount.Text = "Max : " + maxDiscount;
            lblMaxQuantity.Text = "Max : " + txtStock.Value.ToString();
            txtDiscount.Maximum = decimal.Parse(maxDiscount);
            txtQuantity.Maximum = txtStock.Value;
            
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (cbxSearchBy.SelectedIndex == 0)
            {
                DataView dv = allProductsInfoDt.DefaultView;
                dv.RowFilter = string.Format("product_id like '%{0}%'", txtSearch.Text);
                dgvAllProductsInfo.DataSource = dv.ToTable();
            }
            else if (cbxSearchBy.SelectedIndex == 1)
            {
                DataView dv = allProductsInfoDt.DefaultView;
                dv.RowFilter = string.Format("product_name like '%{0}%'", txtSearch.Text);
                dgvAllProductsInfo.DataSource = dv.ToTable();
            }
            else
            {
                DataView dv = allProductsInfoDt.DefaultView;
                dv.RowFilter = string.Format("brand like '%{0}%'", txtSearch.Text);
                dgvAllProductsInfo.DataSource = dv.ToTable();
            }
        }

        private void txtDiscount_ValueChanged(object sender, EventArgs e)
        {
            totalAmount = (txtPrice.Value - txtDiscount.Value) * txtQuantity.Value;
            txtTotal.Value = totalAmount;
        }

        private void txtQuantity_ValueChanged(object sender, EventArgs e)
        {
            totalAmount = (txtPrice.Value - txtDiscount.Value) * txtQuantity.Value;
            txtTotal.Value = totalAmount;
        }
    }
}
