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
using Products_Managment.RPT;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.CrystalReports;
using CrystalDecisions.Shared;
namespace Products_Managment.PL
{
    public partial class Prod_Manage_Form : Form
    {
        Product pro;
        private static Prod_Manage_Form frm;
        static void frmClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }
        public static Prod_Manage_Form getMainFrm
        {
            get
            {
                if (frm == null)
                {
                    frm = new Prod_Manage_Form();
                    frm.FormClosed += new FormClosedEventHandler(frmClosed);
                }
                return frm;
            }
        }
        public Prod_Manage_Form()
        {
            InitializeComponent();
            if (frm == null)
            {
                frm = this;
            }
            pro = new Product();
            this.dataGridView1.DataSource = pro.getAllProd();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            pro = new Product();
            dt = pro.SearchProduct(searchtxt.Text);
            this.dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add_New_Prod_Form anp = new Add_New_Prod_Form();
            anp.ShowDialog();
            pro = new Product();
            this.dataGridView1.DataSource = pro.getAllProd();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("هل تريد حقا حذف العنصر المحدد؟","عملية الحذف",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                pro = new Product();
                pro.DeleteProduct(dataGridView1.CurrentRow.Cells[0].Value);
                MessageBox.Show("تم حذف العنصر بنجاح !", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dataGridView1.DataSource = pro.getAllProd();
            }
            else
            {
                MessageBox.Show("تم الغاء عملية الحذف !", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Add_New_Prod_Form frm = new Add_New_Prod_Form();
            frm.Text = "تحديث المنتج " + dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm.prodid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frm.prodname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm.prodqty.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frm.prodprice.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            frm.catlist.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            frm.button3.Text = "تحديث";
            frm.state = "Update";
            frm.prodid.ReadOnly = true;
            Product pro = new Product();
            DataTable dt = new DataTable();
            dt = pro.getImage(dataGridView1.CurrentRow.Cells[0].Value);
            byte[] img = (byte[])dt.Rows[0][0];
            MemoryStream ms = new MemoryStream(img);
            frm.prodimg.Image = Image.FromStream(ms);
            frm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Prod_Img_Form pif = new Prod_Img_Form();
            Product pro = new Product();
            DataTable dt = new DataTable();
            dt = pro.getImage(dataGridView1.CurrentRow.Cells[0].Value);
            byte[] img = (byte[])dt.Rows[0][0];
            MemoryStream ms = new MemoryStream(img);
            pif.pictureBox1.Image = Image.FromStream(ms);
            pif.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Single_Product_Report report = new Single_Product_Report();
            View_Report_Form prf = new View_Report_Form();
            report.Refresh();
            report.SetParameterValue("@id", dataGridView1.CurrentRow.Cells[0].Value);     
            prf.crystalReportViewer1.ReportSource = report;
            prf.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            All_Prodect_Report report = new All_Prodect_Report();
            View_Report_Form prf = new View_Report_Form();
            report.Refresh();
            prf.crystalReportViewer1.ReportSource = report;
            prf.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            All_Prodect_Report report = new All_Prodect_Report();
            ExportOptions export = new ExportOptions();
            DiskFileDestinationOptions dfoption = new DiskFileDestinationOptions();
            ExcelFormatOptions xlsformat = new ExcelFormatOptions();
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "ملف اكسيل | *.xls";
            save.InitialDirectory = @"C:\";
            if(save.ShowDialog() == DialogResult.OK)
            {
                dfoption.DiskFileName = save.FileName;
                export = report.ExportOptions;
                export.ExportDestinationType = ExportDestinationType.DiskFile;
                export.ExportFormatType = ExportFormatType.Excel;
                export.ExportFormatOptions = xlsformat;
                export.ExportDestinationOptions = dfoption;
                report.Refresh();
                report.Export();
                MessageBox.Show("تمت العملية بنجاح", "معلومة", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
