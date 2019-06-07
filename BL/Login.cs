using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Products_Managment.DAL;

namespace Products_Managment.BL
{
    class Login
    {
        DataAccessLayer dal;
        SqlParameter[] para;
        DataTable dt;
        public DataTable userLogin(string name, string id)
        {
            dal = new DataAccessLayer();
            para = new SqlParameter[2];
            para[0] = new SqlParameter("@username", SqlDbType.VarChar, 30);
            para[0].Value = name;
            para[1] = new SqlParameter("@password", SqlDbType.VarChar, 30);
            para[1].Value = id;
       
            dal.Open();
            dt = new DataTable();
            dt = dal.selectData("Sys_Login", para);
            dal.Close();
            return dt;
        }
        public void addUser(string username, string pass, string type)
        {
            dal = new DataAccessLayer();
            dal.Open();
            para = new SqlParameter[3];
            para[0] = new SqlParameter("@username", SqlDbType.VarChar,30);
            para[0].Value = username;
            para[1] = new SqlParameter("@pass", SqlDbType.VarChar, 30);
            para[1].Value = pass;
            para[2] = new SqlParameter("@type", SqlDbType.VarChar, 15);
            para[2].Value = type;
            dal.executeCommand("Add_User", para);
            dal.Close();

        }
        public DataTable getUsers(string text)
        {
            dal = new DataAccessLayer();
            dal.Open();
            para = new SqlParameter[1];
            para[0] = new SqlParameter("@text", SqlDbType.VarChar, 50);
            para[0].Value = text;
            dt = new DataTable();
            dt = dal.selectData("Search_User", para);
            dal.Close();
            return dt;
        }
        public void updateUser(string id,string username, string pass, string type)
        {
            dal = new DataAccessLayer();
            dal.Open();
            para = new SqlParameter[4];
            para[0] = new SqlParameter("@id", SqlDbType.VarChar, 30);
            para[0].Value = id;
            para[1] = new SqlParameter("@username", SqlDbType.VarChar, 30);
            para[1].Value = username;
            para[2] = new SqlParameter("@pass", SqlDbType.VarChar, 30);
            para[2].Value = pass;
            para[3] = new SqlParameter("@type", SqlDbType.VarChar, 15);
            para[3].Value = type;
            dal.executeCommand("Update_User", para);
            dal.Close();
       
        }
        public void DeleteUser(string pass)
        {
            dal = new DataAccessLayer();
            dal.Open();
            para = new SqlParameter[1];
            para[0] = new SqlParameter("@pass", SqlDbType.VarChar,30);
            para[0].Value = pass;
            dal.executeCommand("Delete_User", para);
            dal.Close();
        }
    }
}
