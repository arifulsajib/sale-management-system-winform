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
    public partial class cFormProducts : Form
    {
        DataTable allProductsInfoDt;
        informations info = new informations();
        Products products = new Products();

        public cFormProducts()
        {
            InitializeComponent();

            cbxSearchBy.SelectedIndex = 0;
            allProductsInfoDt = products.getAllProductsData();
            dgvAllProductsInfo.DataSource = allProductsInfoDt;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            info.productID = txtProductId.Text.ToLower().Trim();
            info.productName = txtProductName.Text.Trim();
            info.Brand = txtBrand.Text.Trim();
            info.Stock = txtStock.Text.Trim();
            info.purchasePrice = txtPurchasePrice.Text.Trim();
            info.retailPrice = txtRetailPrice.Text.Trim();
            info.maxDiscount = txtMaxDiscount.Text.Trim();
            info.notes = txtNotes.Text.Trim();

            if (info.productID.Length == 0 || info.productName.Length == 0 || info.Brand.Length == 0 || info.Stock.Length == 0 || info.purchasePrice.Length == 0 || info.retailPrice.Length == 0 || info.maxDiscount.Length == 0)
            {
                MessageBox.Show("Please Fill All the Fields..");
            }
            else if (products.isProductExists(info))
            {
                MessageBox.Show("Product already exists...");
            }
            else
            {
                if (products.addProduct(info))
                {
                    MessageBox.Show("Product Added Successfully");

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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            info.productID = txtProductId.Text.ToLower().Trim();
            info.productName = txtProductName.Text.Trim();
            info.Brand = txtBrand.Text.Trim();
            info.Stock = txtStock.Text.Trim();
            info.purchasePrice = txtPurchasePrice.Text.Trim();
            info.retailPrice = txtRetailPrice.Text.Trim();
            info.maxDiscount = txtMaxDiscount.Text.Trim();
            info.notes = txtNotes.Text.Trim();

            if (info.productID.Length == 0 || info.productName.Length == 0 || info.Brand.Length == 0 || info.Stock.Length == 0 || info.purchasePrice.Length == 0 || info.retailPrice.Length == 0 || info.maxDiscount.Length == 0)
            {
                MessageBox.Show("Please Fill All the Fields..");
            }
            else
            {
                if (MessageBox.Show("Do you Want to Update?", "Update", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (products.updateProduct(info))
                    {
                        MessageBox.Show("Product Updated Successfully");

                        //refresh
                        allProductsInfoDt = products.getAllProductsData();
                        dgvAllProductsInfo.DataSource = allProductsInfoDt;

                        //reset fields
                        Reset();
                    }
                    else
                    {
                        MessageBox.Show("Product not exists");
                    }
                }
                
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            info.productID = txtProductId.Text.ToLower().Trim();
            if (info.productID.Length == 0)
            {
                MessageBox.Show("Please Enter the ProductID you want to delete..");
            }
            else
            {
                if (MessageBox.Show("Do you Want to Delete?","Delete",MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (products.deleteProduct(info))
                    {
                        MessageBox.Show("Product deleted Successfully");

                        //refresh
                        allProductsInfoDt = products.getAllProductsData();
                        dgvAllProductsInfo.DataSource = allProductsInfoDt;

                        //reset fields
                        Reset();
                    }
                    else
                    {
                        MessageBox.Show("Product not Exists...");
                    }
                }
                
            }
        }

        private void Reset()
        {
            txtProductId.Text = "";
            txtProductName.Text = "";
            txtBrand.Text = "";
            txtStock.Text = "";
            txtPurchasePrice.Text = "";
            txtRetailPrice.Text = "";
            txtMaxDiscount.Text = "";
            txtNotes.Text = "";
        }

        private void dgvAllProductsInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txtProductId.Text = this.dgvAllProductsInfo.Rows[this.dgvAllProductsInfo.CurrentCell.RowIndex].Cells["clmProductId"].Value.ToString();
            this.txtProductName.Text = this.dgvAllProductsInfo.Rows[this.dgvAllProductsInfo.CurrentCell.RowIndex].Cells["clmProductName"].Value.ToString();
            this.txtBrand.Text = this.dgvAllProductsInfo.Rows[this.dgvAllProductsInfo.CurrentCell.RowIndex].Cells["clmBrand"].Value.ToString();
            this.txtPurchasePrice.Text = this.dgvAllProductsInfo.Rows[this.dgvAllProductsInfo.CurrentCell.RowIndex].Cells["clmPurchasePrice"].Value.ToString();
            this.txtRetailPrice.Text = this.dgvAllProductsInfo.Rows[this.dgvAllProductsInfo.CurrentCell.RowIndex].Cells["clmRetailPrice"].Value.ToString();
            this.txtMaxDiscount.Text = this.dgvAllProductsInfo.Rows[this.dgvAllProductsInfo.CurrentCell.RowIndex].Cells["clmMaxDiscount"].Value.ToString();
            this.txtStock.Text = this.dgvAllProductsInfo.Rows[this.dgvAllProductsInfo.CurrentCell.RowIndex].Cells["clmStock"].Value.ToString();
            this.txtNotes.Text = this.dgvAllProductsInfo.Rows[this.dgvAllProductsInfo.CurrentCell.RowIndex].Cells["clmNotes"].Value.ToString();
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
    }
}
