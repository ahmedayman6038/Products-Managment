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
    public partial class Add_New_Prod_Form : Form
    {
        Product anp;
        public string state = "Add";
        public Add_New_Prod_Form()
        {
            InitializeComponent();
            anp = new Product();
            catlist.DataSource = anp.getAllCat();
            catlist.DisplayMember = "Cat_name";
            catlist.ValueMember = "Cat_id";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "ملفات الصور | *.JPG; *.PNG; *.GIF";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                prodimg.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                anp = new Product();
                if (state == "Add")
                {
                    MemoryStream ms = new MemoryStream();
                    prodimg.Image.Save(ms, prodimg.Image.RawFormat);
                    byte[] byteImage = ms.ToArray();
                    anp.AddProduct(Convert.ToInt32(prodid.Text), Convert.ToInt16(catlist.SelectedValue), prodname.Text, Convert.ToInt16(prodqty.Text), Convert.ToDouble(prodprice.Text), byteImage);
                    MessageBox.Show("تمت الاضافة بنجاح", "عملية الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    prodid.Clear();
                    prodname.Clear();
                    prodqty.Clear();
                    prodprice.Clear();
                    catlist.SelectedIndex = 0;
                    prodimg.Image = Products_Managment.Properties.Resources._1;
                }
                else
                {
                    MemoryStream ms = new MemoryStream();
                    prodimg.Image.Save(ms, prodimg.Image.RawFormat);
                    byte[] byteImage = ms.ToArray();
                    anp.UpdateProduct(Convert.ToInt32(prodid.Text), Convert.ToInt16(catlist.SelectedValue), prodname.Text, Convert.ToInt16(prodqty.Text), Convert.ToDouble(prodprice.Text), byteImage);
                    MessageBox.Show("تمت التعديل بنجاح", "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                Prod_Manage_Form.getMainFrm.dataGridView1.DataSource = anp.getAllProd();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void prodid_Validated(object sender, EventArgs e)
        {
            if(prodid.Text != "")
            {
                if(state == "Add")
                {
                    DataTable dt = new DataTable();
                    anp = new Product();
                    dt = anp.verifyProdID(Convert.ToInt32(prodid.Text));
                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("هذا الكود موجود من قبل", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        prodid.Focus();
                        prodid.SelectionStart = 0;
                        prodid.SelectionLength = prodid.TextLength;
                    }
                }
                   
            }   

        }

     
    }
}
