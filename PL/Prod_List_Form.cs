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
    public partial class Prod_List_Form : Form
    {
        Product list;
        public Prod_List_Form()
        {
            InitializeComponent();
            list = new Product();
            dataGridView1.DataSource = list.getAllProd();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
