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
using System.IO;
using System.Globalization;
using Products_Managment.RPT;
namespace Products_Managment.PL
{
    public partial class Orders_Form : Form
    {
        Order order;
        DataTable dt;
        double amount;
        double totalAmount;
        double discount;
        public Orders_Form()
        {
            InitializeComponent();
            order = new Order();
            dt = new DataTable();
            createDataTable();
            ordername.Text = Program.salesman;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            orderid.Text = order.getLastOrder().Rows[0][0].ToString();
            savebtn.Enabled = true;
            newbtn.Enabled = false;
            orderdesc.Focus();
            clearAllData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Cust_List_Form list = new Cust_List_Form();
                list.ShowDialog();
                custnumb.Text = list.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                custfname.Text = list.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                custlname.Text = list.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                custphone.Text = list.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                custemail.Text = list.dataGridView1.CurrentRow.Cells[4].Value.ToString();
                byte[] img = (byte[])list.dataGridView1.CurrentRow.Cells[5].Value;
                MemoryStream ms = new MemoryStream(img);
                pictureBox1.Image = Image.FromStream(ms);
            }
            catch
            {
                pictureBox1.Image = null;
            }
            
        }
        private void createDataTable()
        {
            dt.Columns.Add("كود المنتج");
            dt.Columns.Add("اسم المنتج");
            dt.Columns.Add("الثمن");
            dt.Columns.Add("الكمية");
            dt.Columns.Add("المبلغ");
            dt.Columns.Add("نسبة الخصم (%)");
            dt.Columns.Add("المبلغ الاجمالى");
            dataGridView1.DataSource = dt;
            dataGridView1.RowHeadersWidth = 70;
            dataGridView1.Columns[0].Width = 101;
            dataGridView1.Columns[1].Width = 113;
            dataGridView1.Columns[2].Width = 69;
            dataGridView1.Columns[3].Width = 67;
            dataGridView1.Columns[4].Width = 67;
            dataGridView1.Columns[5].Width = 86;
            dataGridView1.Columns[6].Width = 108;
            /** 
             * Create a btn in the data Grid View 
             **/

            /* DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
             btn.HeaderText = "اختيار المنتج";
             btn.Text = "البحث";
             btn.UseColumnTextForButtonValue = true;
             dataGridView1.Columns.Insert(0, btn);
             */
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Prod_List_Form list = new Prod_List_Form();
            list.ShowDialog();
            clear();
            prodid.Text = list.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            prodname.Text = list.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            prodprice.Text = list.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            prodqty.Focus();
        }

        private void prodprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator))
            {
                e.Handled = true;
            }
        }

        private void prodqty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void proddisc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator))
            {
                e.Handled = true;
            }
        }
        private void calculateAmount()
        {
            if(prodqty.Text != string.Empty && prodprice.Text != string.Empty)
            {
                amount = Convert.ToDouble(prodprice.Text) * Convert.ToInt32(prodqty.Text);
                prodamount.Text = Convert.ToString(amount);
            }
        }
        private void calculateTotalAmount()
        {
            if(prodamount.Text != string.Empty && proddisc.Text != string.Empty)
            {
                discount = Convert.ToDouble(proddisc.Text);
                totalAmount = amount - (amount * (discount / 100));
                prodtotal.Text = Convert.ToString(totalAmount);
            }
        }
        private void prodprice_KeyUp(object sender, KeyEventArgs e)
        {
            calculateAmount();
            calculateTotalAmount();
        }

        private void prodqty_KeyUp(object sender, KeyEventArgs e)
        {
            calculateAmount();
            calculateTotalAmount();
        }

        private void proddisc_KeyUp(object sender, KeyEventArgs e)
        {
            calculateTotalAmount();
        }

        private void proddisc_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {

                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    if(dataGridView1.Rows[i].Cells[0].Value.ToString() == prodid.Text)
                    {
                        MessageBox.Show("هذا المنتج موجود من قبل", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }
                if(order.verifyProdQty(Convert.ToInt32(prodid.Text),Convert.ToInt32(prodqty.Text)).Rows.Count < 1)
                {
                    MessageBox.Show("الكمية اكبر من الكمية المتاحة", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                DataRow dr = dt.NewRow();
                dr[0] = prodid.Text;
                dr[1] = prodname.Text;
                dr[2] = prodprice.Text;
                dr[3] = prodqty.Text;
                dr[4] = prodamount.Text;
                dr[5] = proddisc.Text;
                dr[6] = prodtotal.Text;
                dt.Rows.Add(dr);
                dataGridView1.DataSource = dt;
                clear();
                chosbtn.Focus();
                totalsum.Text =
                    (from DataGridViewRow row in dataGridView1.Rows
                     where row.Cells[6].FormattedValue != string.Empty
                     select Convert.ToDouble(row.Cells[6].FormattedValue)).Sum().ToString();
            }
        }
        private void clear()
        {
            prodid.Clear();
            prodname.Clear();
            prodprice.Clear();
            prodqty.Clear();
            prodamount.Clear();
            proddisc.Clear();
            prodtotal.Clear();
        }

        private void prodqty_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                proddisc.Focus();
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            prodid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            prodname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            prodprice.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            prodqty.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            prodamount.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            proddisc.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            prodtotal.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
        
        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            totalsum.Text =
                   (from DataGridViewRow row in dataGridView1.Rows
                    where row.Cells[6].FormattedValue != string.Empty
                    select Convert.ToDouble(row.Cells[6].FormattedValue)).Sum().ToString();
        }

        private void deletecurrentrow_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
        }

        private void تعديلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1_DoubleClick(sender, e);
        }

        private void حذفالسطرالمحددToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deletecurrentrow_Click(sender, e);
        }

        private void حذفالكلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dt.Clear();
            dataGridView1.Refresh();
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (custnumb.Text == string.Empty || dataGridView1.Rows.Count < 1)
                {
                    MessageBox.Show("يجب ملى العناصر اولا", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                order.addOrder(Convert.ToInt32(custnumb.Text), orderdate.Value, orderdesc.Text, ordername.Text);
                for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
                {
                    order.addOrderDetails(Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value),
                                          Convert.ToInt32(orderid.Text),
                                          Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value),
                                          Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value),
                                          Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value),
                                          Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value),
                                          Convert.ToDouble(dataGridView1.Rows[i].Cells[6].Value));
                }
                MessageBox.Show("تم الحفظ بنجاح", "عملية الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                newbtn.Enabled = true;
                savebtn.Enabled = false;
                printbtn.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void clearAllData()
        {
            clear();
            custnumb.Clear();
            orderdesc.Clear();
            custfname.Clear();
            custlname.Clear();
            custphone.Clear();
            custemail.Clear();
            totalsum.Clear();
            pictureBox1.Image = null;
            dt.Clear();
            dataGridView1.DataSource = dt;
        }

        private void printbtn_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            Orders_Report report = new Orders_Report();
            View_Report_Form form = new View_Report_Form();
            int orderid = Convert.ToInt32(order.getLastOrderPrint().Rows[0][0]);
            report.Refresh();
            report.SetParameterValue("@orderid", orderid);
            form.crystalReportViewer1.ReportSource = report;
            form.ShowDialog();
            this.Cursor = Cursors.Default;
        }
    }
}
