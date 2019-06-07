using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Products_Managment.DAL;
namespace Products_Managment.PL
{
    public partial class Backup_Form : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        string type;
        public Backup_Form()
        {
            InitializeComponent();
            type = Properties.Settings.Default.Mode;
            if (type == "sql")
            {
                con = new SqlConnection(@"Server = " + Properties.Settings.Default.Server + "; Database = " + Properties.Settings.Default.Database +
                    "; Integrated Security = false; User ID = " + Properties.Settings.Default.ID + "; Password = " + Properties.Settings.Default.Password + "");
            }
            else
            {
                con = new SqlConnection(@"Server = " + Properties.Settings.Default.Server + "; Database = " + Properties.Settings.Default.Database + "; Integrated Security = true");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            string fileName = textBox1.Text + "\\Product_DB " + DateTime.Now.ToShortDateString().Replace('/','-') + "_" + DateTime.Now.ToShortTimeString().Replace(':','-');
            string query = "Backup Database Product to Disk = '" + fileName + ".bak'";
            cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            this.Cursor = Cursors.Default;
            MessageBox.Show("تمت العملية بنجاح", "عملية النسخ الاحتياطى", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
