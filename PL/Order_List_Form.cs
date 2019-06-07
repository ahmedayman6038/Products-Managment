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
using Products_Managment.RPT;
namespace Products_Managment.PL
{
    public partial class Order_List_Form : Form
    {
        Order list;
        public Order_List_Form()
        {
            InitializeComponent();
            list = new Order();
            dataGridView1.DataSource = list.getOrders("");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void searchtxt_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = list.getOrders(searchtxt.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            Orders_Report report = new Orders_Report();
            View_Report_Form form = new View_Report_Form();
            int orderid = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            report.Refresh();
            report.SetParameterValue("@orderid", orderid);
            form.crystalReportViewer1.ReportSource = report;
            form.ShowDialog();
            this.Cursor = Cursors.Default;
        }
    }
}
