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
    public partial class cFormAnalysis : Form
    {
        DataTable allSalesInfoDt;
  
        informations info = new informations();
        Sales sales = new Sales();
        public cFormAnalysis()
        {
            InitializeComponent();

            cbxSearchBy.SelectedIndex = 0;
            txtDateTo.MaxDate = DateTime.Today;
            allSalesInfoDt = sales.getAllSalesData();
            dgvAllSalesInfo.DataSource = allSalesInfoDt;
            sumText();
        }

        private void sumText()
        {
            decimal totalSaleAmount = 0;
            decimal totalPurchaseAmount = 0;

            for (int i = 0; i < dgvAllSalesInfo.RowCount - 1; i++)   
            {
                totalSaleAmount += decimal.Parse(dgvAllSalesInfo.Rows[i].Cells["clmTotalPrice"].Value.ToString());
                totalPurchaseAmount += decimal.Parse(dgvAllSalesInfo.Rows[i].Cells["clmTotalPurchasePrice"].Value.ToString());
            }
            this.lblTotalSales.Text = (dgvAllSalesInfo.RowCount - 1).ToString(); 
            this.lblTotalAmount.Text = totalSaleAmount.ToString();
            this.lblTotalProfit.Text = (totalSaleAmount - totalPurchaseAmount).ToString();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text.Trim() == "")
            {
                allSalesInfoDt = sales.getAllSalesData();
                dgvAllSalesInfo.DataSource = allSalesInfoDt;
                sumText();
            }

            else if (cbxSearchBy.SelectedIndex == 0)
            {
                DataView dv = allSalesInfoDt.DefaultView;
                dv.RowFilter = string.Format("product_id like '%{0}%' and date >= #{1:yyyy/MM/dd}# And date <= #{2:yyyy/MM/dd}# ", txtSearch.Text, txtDateFrom.Value, txtDateTo.Value);
                dgvAllSalesInfo.DataSource = dv.ToTable();
                sumText();
            }
            else if (cbxSearchBy.SelectedIndex == 1)
            {
                DataView dv = allSalesInfoDt.DefaultView;
                dv.RowFilter = string.Format("product_name like '%{0}%' and date >= #{1:yyyy/MM/dd}# And date <= #{2:yyyy/MM/dd}# ", txtSearch.Text, txtDateFrom.Value, txtDateTo.Value);
                dgvAllSalesInfo.DataSource = dv.ToTable();
                sumText();
            }
            else if (cbxSearchBy.SelectedIndex == 2)
            {
                DataView dv = allSalesInfoDt.DefaultView;
                dv.RowFilter = string.Format("brand like '%{0}%' and date >= #{1:yyyy/MM/dd}# And date <= #{2:yyyy/MM/dd}# ", txtSearch.Text, txtDateFrom.Value, txtDateTo.Value);
                dgvAllSalesInfo.DataSource = dv.ToTable();
                sumText();
            }
            else
            {
                DataView dv = allSalesInfoDt.DefaultView;
                dv.RowFilter = string.Format("username like '%{0}%' and date >= #{1:yyyy/MM/dd}# And date <= #{2:yyyy/MM/dd}# ", txtSearch.Text, txtDateFrom.Value, txtDateTo.Value);
                dgvAllSalesInfo.DataSource = dv.ToTable();
                sumText();
            }
        }


    }
}
