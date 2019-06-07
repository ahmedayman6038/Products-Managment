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
namespace Products_Managment.PL
{
    public partial class Customer_Form : Form
    {
        Customer cust;
        int id;
        int postion;
        public Customer_Form()
        {
            InitializeComponent();
            // custimg.Image = Products_Managment.Properties.Resources._1;
            cust = new Customer();
            dataGridView1.DataSource = cust.getAllCustomer();
            dataGridView1.Columns[5].Visible = false;
            postion = 0;
            Navigation(postion);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] img;
                if(custimg.Image == null)
                {
                    img = new byte[0];
                    cust.addCustomer(Convert.ToInt32(custid.Text), custfname.Text, custlname.Text, custphone.Text, custemail.Text, img,"without_img");
                }
                else
                {
                    MemoryStream ms = new MemoryStream();
                    custimg.Image.Save(ms, custimg.Image.RawFormat);
                    img = ms.ToArray();
                    cust.addCustomer(Convert.ToInt32(custid.Text), custfname.Text, custlname.Text, custphone.Text, custemail.Text, img,"with_img");
                }
                MessageBox.Show("تمت الاضافة بنجاح", "عملية الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = cust.getAllCustomer();
                Navigation(postion);
                addbtn.Enabled = false;
                newbtn.Enabled = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
      
        }

        private void custimg_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "ملفات الصور|*.png;*.jpg;*.gif";
            if(file.ShowDialog() == DialogResult.OK)
            {
                custimg.Image = Image.FromFile(file.FileName);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            custid.Clear();
            custfname.Clear();
            custlname.Clear();
            custphone.Clear();
            custemail.Clear();
            custimg.Image = null;
            addbtn.Enabled = true;
            newbtn.Enabled = false;
            custid.Focus();
        }

        private void custid_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                custfname.Focus();
            }
        }

        private void custfname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                custlname.Focus();
            }
        }

        private void custlname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                custphone.Focus();
            }
        }

        private void custphone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                custemail.Focus();
            }
        }

        private void custemail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                addbtn.Focus();
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                custid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                custfname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                custlname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                custphone.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                custemail.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                byte[] img = (byte[])dataGridView1.CurrentRow.Cells[5].Value;
                MemoryStream ms = new MemoryStream(img);
                custimg.Image = Image.FromStream(ms);
            }
            catch
            {
                custimg.Image = null;
            }
            
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] img;
                if (custimg.Image == null)
                {
                    img = new byte[0];
                    cust.updateCustomer(id,Convert.ToInt32(custid.Text), custfname.Text, custlname.Text, custphone.Text, custemail.Text, img, "without_img");
                }
                else
                {
                    MemoryStream ms = new MemoryStream();
                    custimg.Image.Save(ms, custimg.Image.RawFormat);
                    img = ms.ToArray();
                    cust.updateCustomer(id, Convert.ToInt32(custid.Text), custfname.Text, custlname.Text, custphone.Text, custemail.Text, img, "with_img");
                }
                MessageBox.Show("تمت التعديل بنجاح", "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = cust.getAllCustomer();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clsbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("هل تريد حذف هذا العميل؟", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cust.DeleteCustomer(id);
                    MessageBox.Show("تم الحذف بنجاح", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = cust.getAllCustomer();
                    Navigation(postion);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = cust.searchCustomer(searchtxt.Text);
        }

        private void searchtxt_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                searchbtn_Click(sender, e);
            }
        }
        private void Navigation(int index)
        {
            try
            {
                DataRowCollection drc = cust.getAllCustomer().Rows;
                id = Convert.ToInt32(drc[index][0]);
                custid.Text = drc[index][0].ToString();
                custfname.Text = drc[index][1].ToString();
                custlname.Text = drc[index][2].ToString();
                custphone.Text = drc[index][3].ToString();
                custemail.Text = drc[index][4].ToString();
                navlabel.Text = (index+1) + "/" + drc.Count;
                byte[] img = (byte[])drc[index][5];
                MemoryStream ms = new MemoryStream(img);
                custimg.Image = Image.FromStream(ms);
                
            }
            catch
            {
                custimg.Image = null;
            }
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            postion = cust.getAllCustomer().Rows.Count - 1;
            Navigation(postion);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            postion = 0;
            Navigation(postion);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(postion < cust.getAllCustomer().Rows.Count-1)
            {
                postion += 1;
                Navigation(postion);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(postion > 0)
            {
                postion -= 1;
                Navigation(postion);
            }
        }
    }
}
