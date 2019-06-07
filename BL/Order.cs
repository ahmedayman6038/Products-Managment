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
    class Order
    {
        DataAccessLayer dal;
        DataTable dt;
        SqlParameter[] par;
        public DataTable getLastOrder()
        {
            dal = new DataAccessLayer();
            dal.Open();
            dt = new DataTable();
            dt = dal.selectData("Get_Last_Order", null);
            dal.Close();
            return dt;
        }
        public void addOrder(int custid, DateTime date, string desc, string salesman)
        {
            dal = new DataAccessLayer();
            dal.Open();
            par = new SqlParameter[4];
            par[0] = new SqlParameter("@custid", SqlDbType.Int);
            par[0].Value = custid;
            par[1] = new SqlParameter("@date", SqlDbType.Date);
            par[1].Value = date;
            par[2] = new SqlParameter("@desc", SqlDbType.Text);
            par[2].Value = desc;
            par[3] = new SqlParameter("@salesman", SqlDbType.VarChar, 50);
            par[3].Value = salesman;
            dal.executeCommand("Add_Order", par);
            dal.Close();

        }
        public void addOrderDetails(int prodid, int orderid, int qty, double price, double discount,double amount,double total)
        {
            dal = new DataAccessLayer();
            dal.Open();
            par = new SqlParameter[7];
            par[0] = new SqlParameter("@prodid", SqlDbType.Int);
            par[0].Value = prodid;
            par[1] = new SqlParameter("@orderid", SqlDbType.Int);
            par[1].Value = orderid;
            par[2] = new SqlParameter("@qty", SqlDbType.Int);
            par[2].Value = qty;
            par[3] = new SqlParameter("@price", SqlDbType.Float);
            par[3].Value = price;
            par[4] = new SqlParameter("@discount", SqlDbType.Float);
            par[4].Value = discount;
            par[5] = new SqlParameter("@amount", SqlDbType.Float);
            par[5].Value = amount;
            par[6] = new SqlParameter("@total", SqlDbType.Float);
            par[6].Value = total;
            dal.executeCommand("Add_Order_Details", par);
            dal.Close();

        }
        public DataTable verifyProdQty(int id, int qty)
        {
            dal = new DataAccessLayer();
            dal.Open();
            par = new SqlParameter[2];
            par[0] = new SqlParameter("@id", SqlDbType.Int);
            par[0].Value = id;
            par[1] = new SqlParameter("@qty", SqlDbType.Int);
            par[1].Value = qty;
            dt = new DataTable();
            dt = dal.selectData("Verfiy_Prod_Qty", par);
            dal.Close();
            return dt;
        }
        public DataTable getOrdersDetails(int id)
        {
            dal = new DataAccessLayer();
            dal.Open();
            par = new SqlParameter[1];
            par[0] = new SqlParameter("@orderid", SqlDbType.Int);
            par[0].Value = id;
            dt = new DataTable();
            dt = dal.selectData("Get_Order_Details", par);
            dal.Close();
            return dt;
        }
        public DataTable getLastOrderPrint()
        {
            dal = new DataAccessLayer();
            dal.Open();
            dt = new DataTable();
            dt = dal.selectData("Get_Last_Order_Print", null);
            dal.Close();
            return dt;
        }
        public DataTable getOrders(string text)
        {
            dal = new DataAccessLayer();
            dal.Open();
            par = new SqlParameter[1];
            par[0] = new SqlParameter("@text", SqlDbType.VarChar,50);
            par[0].Value = text;
            dt = new DataTable();
            dt = dal.selectData("Search_Orders", par);
            dal.Close();
            return dt;
        }
    }
}
