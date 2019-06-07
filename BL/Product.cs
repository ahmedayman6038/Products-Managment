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
    class Product
    {
        DataAccessLayer dal;
        DataTable dt;
        SqlParameter[] par;
        public DataTable getAllCat()
        {
            dal = new DataAccessLayer();
            dal.Open();
            dt = new DataTable();
            dt = dal.selectData("Get_Cat", null);
            dal.Close();
            return dt;
        }
        public void AddProduct(int prodID,int catID,string prodname,int qty,double price,byte[] img)
        {
            dal = new DataAccessLayer();
            dal.Open();
            par = new SqlParameter[6];
            par[0] = new SqlParameter("@prodid", SqlDbType.Int);
            par[0].Value = prodID;
            par[1] = new SqlParameter("@catid", SqlDbType.Int);
            par[1].Value = catID;
            par[2] = new SqlParameter("@prodname", SqlDbType.VarChar,20);
            par[2].Value = prodname;
            par[3] = new SqlParameter("@qty ", SqlDbType.Int);
            par[3].Value = qty;
            par[4] = new SqlParameter("@price", SqlDbType.Float);
            par[4].Value = price;
            par[5] = new SqlParameter("@img", SqlDbType.Image);
            par[5].Value = img;
            dal.executeCommand("Add_Product", par);
            dal.Close();
        }

      

        public DataTable verifyProdID(int id)
        {
            dal = new DataAccessLayer();
            dal.Open();
            par = new SqlParameter[1];
            par[0] = new SqlParameter("@id", SqlDbType.Int);
            par[0].Value = id;
            dt = new DataTable();
            dt = dal.selectData("Verfiy_Prod_ID", par);
            dal.Close();
            return dt;
        }
        public DataTable getAllProd()
        {
            dal = new DataAccessLayer();
            dal.Open();
            dt = new DataTable();
            dt = dal.selectData("Get_Product", null);
            dal.Close();
            return dt;
        }
        public DataTable SearchProduct(string text)
        {
            dal = new DataAccessLayer();
            dal.Open();
            par = new SqlParameter[1];
            par[0] = new SqlParameter("@text", SqlDbType.VarChar);
            par[0].Value = text;
            dt = new DataTable();
            dt = dal.selectData("Search_Product", par);
            dal.Close();
            return dt;
        }
        public void DeleteProduct(object prodID)
        {
            dal = new DataAccessLayer();
            dal.Open();
            par = new SqlParameter[1];
            par[0] = new SqlParameter("@id", SqlDbType.Int);
            par[0].Value = prodID;
            dal.executeCommand("Delete_Product", par);
            dal.Close();
        }
        public DataTable getImage(object id)
        {
            dal = new DataAccessLayer();
            dal.Open();
            par = new SqlParameter[1];
            par[0] = new SqlParameter("@id", SqlDbType.Int);
            par[0].Value = id;
            dt = new DataTable();
            dt = dal.selectData("Get_Img", par);
            dal.Close();
            return dt;
        }
        public void UpdateProduct(int prodID, int catID, string prodname, int qty, double price, byte[] img)
        {
            dal = new DataAccessLayer();
            dal.Open();
            par = new SqlParameter[6];
            par[0] = new SqlParameter("@prodid", SqlDbType.Int);
            par[0].Value = prodID;
            par[1] = new SqlParameter("@catid", SqlDbType.Int);
            par[1].Value = catID;
            par[2] = new SqlParameter("@prodname", SqlDbType.VarChar, 20);
            par[2].Value = prodname;
            par[3] = new SqlParameter("@qty ", SqlDbType.Int);
            par[3].Value = qty;
            par[4] = new SqlParameter("@price", SqlDbType.Float);
            par[4].Value = price;
            par[5] = new SqlParameter("@img", SqlDbType.Image);
            par[5].Value = img;
            dal.executeCommand("Update_Product", par);
            dal.Close();
        }
    }
}
