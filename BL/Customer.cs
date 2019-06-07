using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Products_Managment.DAL;
namespace Products_Managment.BL
{
    
    class Customer
    {
        DataAccessLayer dal;
        DataTable dt;
        SqlParameter[] par;
        public void addCustomer(int id,string fname,string lname,string phone,string email,byte[] img,string img_state)
        {
            dal = new DataAccessLayer();
            dal.Open();
            par = new SqlParameter[7];
            par[0] = new SqlParameter("@id", SqlDbType.Int);
            par[0].Value = id;
            par[1] = new SqlParameter("@fname", SqlDbType.VarChar, 10);
            par[1].Value = fname;
            par[2] = new SqlParameter("@lname", SqlDbType.VarChar, 10);
            par[2].Value = lname;
            par[3] = new SqlParameter("@phone ", SqlDbType.VarChar, 15);
            par[3].Value = phone;
            par[4] = new SqlParameter("@email", SqlDbType.VarChar, 30);
            par[4].Value = email;
            par[5] = new SqlParameter("@img", SqlDbType.Image);
            par[5].Value = img;
            par[6] = new SqlParameter("@img_state", SqlDbType.VarChar, 20);
            par[6].Value = img_state;
            dal.executeCommand("Add_Customer", par);
            dal.Close();

        }
        public DataTable getAllCustomer()
        {
            dal = new DataAccessLayer();
            dal.Open();
            dt = new DataTable();
            dt = dal.selectData("Get_Customer", null);
            dal.Close();
            return dt;
        }
        public void updateCustomer(int id,int newid, string fname, string lname, string phone, string email, byte[] img, string img_state)
        {
            dal = new DataAccessLayer();
            dal.Open();
            par = new SqlParameter[8];
            par[0] = new SqlParameter("@id", SqlDbType.Int);
            par[0].Value = id;
            par[1] = new SqlParameter("@new_id", SqlDbType.Int);
            par[1].Value = newid;
            par[2] = new SqlParameter("@fname", SqlDbType.VarChar, 10);
            par[2].Value = fname;
            par[3] = new SqlParameter("@lname", SqlDbType.VarChar, 10);
            par[3].Value = lname;
            par[4] = new SqlParameter("@phone ", SqlDbType.VarChar, 15);
            par[4].Value = phone;
            par[5] = new SqlParameter("@email", SqlDbType.VarChar, 30);
            par[5].Value = email;
            par[6] = new SqlParameter("@img", SqlDbType.Image);
            par[6].Value = img;
            par[7] = new SqlParameter("@img_state", SqlDbType.VarChar, 20);
            par[7].Value = img_state;
            dal.executeCommand("Update_Customer", par);
            dal.Close();

        }
        public void DeleteCustomer(object custID)
        {
            dal = new DataAccessLayer();
            dal.Open();
            par = new SqlParameter[1];
            par[0] = new SqlParameter("@id", SqlDbType.Int);
            par[0].Value = custID;
            dal.executeCommand("Delete_Customer", par);
            dal.Close();
        }
        public DataTable searchCustomer(string text)
        {
            dal = new DataAccessLayer();
            par = new SqlParameter[1];
            par[0] = new SqlParameter("@text", SqlDbType.VarChar, 50);
            par[0].Value = text;
            dal.Open();
            dt = new DataTable();
            dt = dal.selectData("Search_Customer", par);
            dal.Close();
            return dt;
        }

    }
}
