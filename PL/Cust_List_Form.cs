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
    public partial class Cust_List_Form : Form
    {
        Customer list;
        public Cust_List_Form()
        {
            InitializeComponent();
            list = new Customer();
            dataGridView1.DataSource = list.getAllCustomer();
            dataGridView1.Columns[5].Visible = false;
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
