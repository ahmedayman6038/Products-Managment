using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;
namespace Products_Managment.PL
{
    public partial class Main_Form : Form
    {
        private static Main_Form frm;
        static void frmClosed(object sender,FormClosedEventArgs e)
        {
            frm = null;
        }
        public static Main_Form getMainFrm
        {
            get
            {
                if (frm == null)
                {
                    frm = new Main_Form();
                    frm.FormClosed += new FormClosedEventHandler(frmClosed);
                }
                return frm;
            }
        }
        public Main_Form()
        {
            InitializeComponent();
            
            if(frm == null)
            {
                frm = this;
            }
            this.استعادةنسخةمحفوظةToolStripMenuItem.Enabled = false;
            this.العملاءToolStripMenuItem.Enabled = false;
            this.المستخدمونToolStripMenuItem.Enabled = false;
            this.انشاءنسخةاحتياطيةToolStripMenuItem.Enabled = false;
            this.المنتوجاتToolStripMenuItem.Enabled = false;
           
        }

        private void تسجيلالدخولToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login_Form login = new Login_Form();
            login.ShowDialog();
        }

        private void اضافةمنتوجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_New_Prod_Form prod = new Add_New_Prod_Form();
            prod.ShowDialog(); 
        }

        private void ادارةالمنتوجاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Prod_Manage_Form pmf = new Prod_Manage_Form();
            pmf.ShowDialog();
        }

        private void ادارةالاصنافToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Categories_Form cat = new Categories_Form();
            cat.ShowDialog();
        }

        private void اضافةعميلجديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer_Form cust = new Customer_Form();
            cust.ShowDialog();
        }

        private void اضافةبيعجديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Orders_Form order = new Orders_Form();
            order.ShowDialog();
        }

        private void ادارةالمبيعاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Order_List_Form list = new Order_List_Form();
            list.ShowDialog();
        }

        private void اضافةمستخدمجديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_New_User user = new Add_New_User();
            user.ShowDialog();
        }

        private void ادارةالمستخدمينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User_List_Form user = new User_List_Form();
            user.ShowDialog();
        }

        private void انشاءنسخةاحتياطيةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Backup_Form backup = new Backup_Form();
            backup.ShowDialog();
        }

        private void استعادةنسخةمحفوظةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Restore_Form restore = new Restore_Form();
            restore.ShowDialog();
        }

        private void اعداداتالاتصالبالسيرفرToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Configuration_Form conf = new Configuration_Form();
            conf.ShowDialog();
        }
    }
}
