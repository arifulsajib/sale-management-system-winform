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
    public class Users
    {
        //objects for the classes
        public sqlHelp sqlHelp = new sqlHelp();
        public informations info = new informations();

        //Is it a valid user
        public bool isValidUser(informations info)
        {
            string sql = string.Format("select * from tbl_users where username='{0}' and password='{1}' and role='user'", info.username, info.password);

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

        //Is it a valid admin
        public bool isValidAdmin(informations info)
        {
            string sql = string.Format("select * from tbl_users where username='{0}' and password='{1}' and role='admin'", info.username, info.password);

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

        //get all users data
        public DataTable getAllUserData()
        {
            string sql = string.Format("select * from tbl_users order by len(user_id), user_id");
            DataTable allUsersInfoDt = sqlHelp.ExecuteQuery(sql);
            if (allUsersInfoDt.Rows.Count > 0)
            {
                return allUsersInfoDt;
            }
            else
            {
                return null;
            }

        }

        //Is username exists
        public bool isUserExists(informations info)
        {
            string sql = string.Format("select * from tbl_users where username='{0}'", info.username);
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


        //Add Users
        public bool addUsers(informations info)
        {
            string sql = string.Format("insert into tbl_users(name, username, password, email, address, phone, role) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", info.name, info.username, info.password, info.email, info.address, info.phone, info.role);
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

        //Update users
        public bool updateUsers(informations info)
        {
            string sql = string.Format("Update tbl_users SET name = '{0}', password = '{2}', email = '{3}', address = '{4}', phone = '{5}', role = '{6}' where username = '{1}'", info.name, info.username, info.password, info.email, info.address, info.phone, info.role);
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


        //Delete users
        public bool deleteUsers(informations info)
        {
            string sql = string.Format("Delete From tbl_users where username = '{0}'", info.username);
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


        //get personal info
        public void getUserData(string username)
        {
            string sql = string.Format("select * from tbl_users where username='{0}'", username);
            DataTable infoDt = sqlHelp.ExecuteQuery(sql);
            if (infoDt.Rows.Count > 0)
            {
                informations.currentLoggedInUsersEmail = infoDt.Rows[0]["email"].ToString();
                informations.currentLoggedInUsersAddress = infoDt.Rows[0]["address"].ToString();
                informations.currentLoggedInUsersPhone = infoDt.Rows[0]["phone"].ToString();
                informations.currentLoggedInUsersPassword = infoDt.Rows[0]["password"].ToString();
                informations.currentLoggedInUsersName = infoDt.Rows[0]["name"].ToString();
            }

        }

        //update personal Information
        public bool updateUserInfo(informations info)
        {
            string sql = string.Format("Update tbl_users SET name = '{0}', address = '{1}', email = '{2}', phone = '{3}' where username = '{4}'", info.name, info.address, info.email, info.phone, info.username);
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

        // update personal password
        public bool changePass(informations info)
        {
            string sql = string.Format("Update tbl_users SET password = '{0}' where username = '{1}'", info.newPassword, info.username);
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
    }
}
