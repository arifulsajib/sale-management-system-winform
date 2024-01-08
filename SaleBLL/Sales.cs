using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SaleDAL;

namespace SaleBLL
{
    public class Sales
    {
        //objects for the classes
        public sqlHelp sqlHelp = new sqlHelp();
        public informations info = new informations();

        //Get all Sales Info
        public DataTable getAllSalesData()
        {
            string sql = string.Format("select sale_id, tbl_sales.product_id, product_name, brand, username, purchase_price, sell_price, quantity, total_price, date, sale_notes, CAST(purchase_price as decimal) * CAST(quantity as decimal) as totalPurchasePrice from tbl_sales inner join tbl_products on tbl_sales.product_id = tbl_products.product_id order by len(sale_id), sale_id");
            DataTable allProductsInfoDt = sqlHelp.ExecuteQuery(sql);
            if (allProductsInfoDt.Rows.Count > 0)
            {
                return allProductsInfoDt;
            }
            else
            {
                return null;
            }
        }

        //Get specific users all sell data
        public DataTable specificUsersAllSalesData(string username)
        {
            string sql = string.Format("select sale_id, tbl_sales.product_id, product_name, brand, username, purchase_price, sell_price, quantity, total_price, date, sale_notes, CAST(purchase_price as decimal) * CAST(quantity as decimal) as totalPurchasePrice from tbl_sales inner join tbl_products on tbl_sales.product_id = tbl_products.product_id where username = '{0}' order by len(sale_id), sale_id", username);
            DataTable allProductsInfoDt = sqlHelp.ExecuteQuery(sql);
            if (allProductsInfoDt.Rows.Count > 0)
            {
                return allProductsInfoDt;
            }
            else
            {
                return null;
            }
        }

        //Add sales
        public bool addSales(informations info)
        {
            string sql = string.Format("insert into tbl_sales(product_id, sell_price, quantity, total_price, username, date, sale_notes) values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')", info.productID, info.salePrice, info.quantity, info.totalPrice, info.username, info.saleDate, info.notes);
            int i = sqlHelp.ExecuteUpdate(sql);

            String currStock = (decimal.Parse(info.Stock) - decimal.Parse(info.quantity)).ToString();
            String updateStockSql = string.Format("Update tbl_products SET stock = '{0}' where product_id = '{1}'", currStock, info.productID);
            sqlHelp.ExecuteUpdate(updateStockSql);

            if (i == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
