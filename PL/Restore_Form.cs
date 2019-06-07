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
namespace Products_Managment.PL
{
    public partial class Restore_Form : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        string type;
        public Restore_Form()
        {
            InitializeComponent();
            type = Properties.Settings.Default.Mode;
            if (type == "sql")
            {
                con = new SqlConnection(@"Server = " + Properties.Settings.Default.Server + "; Database = master; Integrated Security = false; User ID = " + Properties.Settings.Default.ID + "; Password = " + Properties.Settings.Default.Password + "");
            }
            else
            {
                con = new SqlConnection(@"Server = " + Properties.Settings.Default.Server + "; Database = master; Integrated Security = true");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            string query = "Alter Database Product SET OFFLINE WITH ROLLBACK IMMEDIATE;Restore Database Product from Disk = '" + textBox1.Text + "'";
            cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            this.Cursor = Cursors.Default;
            MessageBox.Show("تمت العملية بنجاح", "عملية استعادة نسخة احتياطية", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
