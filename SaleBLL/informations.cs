using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleBLL
{
    public class informations
    {
        //Here we declare the variables used in the application
        public string username { get; set; }
        public string password { get; set; }
        public string curPassword { get; set; }
        public string newPassword { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string role { get; set; }


        public string productID { get; set; }
        public string productName { get; set; }
        public string Brand { get; set; }
        public string Stock { get; set; }
        public string purchasePrice { get; set; }
        public string retailPrice { get; set; }
        public string maxDiscount { get; set; }
        public string notes { get; set; }
        public string salePrice { get; set; }
        public string quantity { get; set; }
        public string totalPrice { get; set; }
        public string saleDate { get; set; }


        // store current users info
        public static string currentLoggedInUser;
        public static string currentLoggedInUsersName;
        public static string currentLoggedInUsersEmail;
        public static string currentLoggedInUsersAddress;
        public static string currentLoggedInUsersPhone;
        public static string currentLoggedInUsersPassword;
    }
}
