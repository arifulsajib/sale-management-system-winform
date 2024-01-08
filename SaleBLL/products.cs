using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SaleDAL;

namespace SaleBLL
{
    public class Products
    {
        //objects for the classes
        public sqlHelp sqlHelp = new sqlHelp();
        public informations info = new informations();

        //get all products info
        public DataTable getAllProductsData()
        {
            string sql = string.Format("select * from tbl_products order by len(product_id), product_id");
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


        //Add Products
        public bool addProduct(informations info)
        {
            string sql = string.Format("insert into tbl_products values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')", info.productID, info.productName, info.Brand, info.Stock, info.purchasePrice, info.retailPrice, info.maxDiscount, info.notes);
            int i = sqlHelp.ExecuteUpdate(sql);

            if (i == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Update Products
        public bool updateProduct(informations info)
        {
            string sql = string.Format("Update tbl_products SET product_name = '{1}', brand = '{2}', stock = '{3}', purchase_price = '{4}', retail_price = '{5}', max_discount = '{6}', product_notes = '{7}' where product_id = '{0}'", info.productID, info.productName, info.Brand, info.Stock, info.purchasePrice, info.retailPrice, info.maxDiscount, info.notes);
            int i = sqlHelp.ExecuteUpdate(sql);

            if (i == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        //Delete Products
        public bool deleteProduct(informations info)
        {
            string sql = string.Format("Delete From tbl_products where product_id = '{0}'", info.productID);
            int i = sqlHelp.ExecuteUpdate(sql);

            if (i == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Is product exists
        public bool isProductExists(informations info)
        {
            string sql = string.Format("select * from tbl_products where product_id='{0}'", info.productID);
            DataTable dt = sqlHelp.ExecuteQuery(sql);
            if (dt.Rows.Count > 0)
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
