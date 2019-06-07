using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Products_Managment.PL
{
    public partial class Configuration_Form : Form
    {
        public Configuration_Form()
        {
            InitializeComponent();
            server.Text = Properties.Settings.Default.Server;
            database.Text = Properties.Settings.Default.Database;
            username.Text = Properties.Settings.Default.ID;
            pass.Text = Properties.Settings.Default.Password;
            if (Properties.Settings.Default.Mode == "sql")
            {
                sql.Checked = true;
                username.Enabled = true;
                pass.Enabled = true;
            }
            else
            {
                windows.Checked = true;
                username.Enabled = false;
                pass.Enabled = false;
            }
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Server = server.Text;
            Properties.Settings.Default.Database = database.Text;
            Properties.Settings.Default.Mode = sql.Checked == true? "sql" : "windows";
            Properties.Settings.Default.ID = username.Text;
            Properties.Settings.Default.Password = pass.Text;
            Properties.Settings.Default.Save();
            MessageBox.Show("تم الحفظ بنجاح", "عملية الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void sql_CheckedChanged(object sender, EventArgs e)
        {
            username.Enabled = true;
            pass.Enabled = true;
            username.Focus();
        }

        private void windows_CheckedChanged(object sender, EventArgs e)
        {
            username.Enabled = false;
            pass.Enabled = false;
        }
    }
}
