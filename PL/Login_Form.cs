using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Products_Managment.BL;

namespace Products_Managment.PL
{
    public partial class Login_Form : Form
    {
        Login login = new Login();
        DataTable dt = new DataTable();
        public Login_Form()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void enter_Click(object sender, EventArgs e)
        {
            dt = login.userLogin(usertxt.Text, passtxt.Text);
            if (dt.Rows.Count > 0)
            {
                if(dt.Rows[0][2].ToString() == "Admin")
                {
                    Main_Form.getMainFrm.استعادةنسخةمحفوظةToolStripMenuItem.Enabled = true;
                    Main_Form.getMainFrm.العملاءToolStripMenuItem.Enabled = true;
                    Main_Form.getMainFrm.المستخدمونToolStripMenuItem.Enabled = true;
                    Main_Form.getMainFrm.المنتوجاتToolStripMenuItem.Enabled = true;
                    Main_Form.getMainFrm.انشاءنسخةاحتياطيةToolStripMenuItem.Enabled = true;
                    Program.salesman = dt.Rows[0][0].ToString();
                }
                else
                {
                    Main_Form.getMainFrm.استعادةنسخةمحفوظةToolStripMenuItem.Enabled = true;
                    Main_Form.getMainFrm.العملاءToolStripMenuItem.Enabled = true;
                    Main_Form.getMainFrm.المستخدمونToolStripMenuItem.Enabled = false;
                    Main_Form.getMainFrm.المنتوجاتToolStripMenuItem.Enabled = true;
                    Main_Form.getMainFrm.انشاءنسخةاحتياطيةToolStripMenuItem.Enabled = true;
                    Program.salesman = dt.Rows[0][0].ToString();
                }
                this.Close();

            }
            else
            {
                MessageBox.Show("خطأ فى اسم المستخدم او فى كلمة المرور","فشل فى الدخول",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
    }
}
