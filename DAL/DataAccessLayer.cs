using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Products_Managment.DAL
{
    class DataAccessLayer
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        string type;
        //Inisialize The Connection Of The DataBase
        public DataAccessLayer()
        {
            type = Properties.Settings.Default.Mode;
            if(type == "sql")
            {
                con = new SqlConnection(@"Server = " + Properties.Settings.Default.Server + "; Database = " + Properties.Settings.Default.Database + 
                    "; Integrated Security = false; User ID = " + Properties.Settings.Default.ID + "; Password = " + Properties.Settings.Default.Password + "");
            }
            else
            {
                con = new SqlConnection(@"Server = " + Properties.Settings.Default.Server + "; Database = " + Properties.Settings.Default.Database + "; Integrated Security = true");
            }
        }

        //Open The Connection Of The DataBase
        public void Open()
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
        }

        //Close The Connection Of The DataBase
        public void Close()
        {
            if (con.State != ConnectionState.Closed)
            {
                con.Close();
            }
        }

        //Read Data From Database
        public DataTable selectData(string stored_procedure, SqlParameter[] para)
        {
            cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = stored_procedure;
            cmd.Connection = con;

            if (para != null)
            {
                for (int i = 0; i < para.Length; i++)
                {
                    cmd.Parameters.Add(para[i]);
                }
            }

            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        //Execute Insert ,Update ,Delete To Database
        public void executeCommand(string stored_procedure, SqlParameter[] para)
        {
            cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = stored_procedure;
            cmd.Connection = con;

            if (para != null)
            {
                cmd.Parameters.AddRange(para);
            }

            cmd.ExecuteNonQuery();

        }
    }
}
