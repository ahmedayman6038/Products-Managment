using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Products_Managment.RPT;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.CrystalReports;
using CrystalDecisions.Shared;
namespace Products_Managment.PL
{
    public partial class Categories_Form : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        DataTable dt;
        BindingManagerBase bmb;
        SqlCommandBuilder cb;
        SqlCommand cmd;
        string type;
        public Categories_Form()
        {
            InitializeComponent();
            type = Properties.Settings.Default.Mode;
            if (type == "sql")
            {
                con = new SqlConnection(@"Server = " + Properties.Settings.Default.Server + "; Database = " + Properties.Settings.Default.Database +
                    "; Integrated Security = false; User ID = " + Properties.Settings.Default.ID + "; Password = " + Properties.Settings.Default.Password + "");
            }
            else
            {
                con = new SqlConnection(@"Server = " + Properties.Settings.Default.Server + "; Database = " + Properties.Settings.Default.Database + "; Integrated Security = true");
            }
            da = new SqlDataAdapter("select Cat_id as 'رقم الصنف',Cat_name as 'اسم الصنف',Cat_desc as 'وصف الصنف' from Category", con);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            numbtxt.DataBindings.Add("text", dt, "رقم الصنف");
            nametxt.DataBindings.Add("text", dt, "اسم الصنف");
            desctxt.DataBindings.Add("text", dt, "وصف الصنف");
            bmb = this.BindingContext[dt];
            poslabel.Text = (bmb.Position+1) + "/" + bmb.Count;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bmb.Position = bmb.Count - 1;
            poslabel.Text = (bmb.Position + 1) + "/" + bmb.Count;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bmb.Position = 0;
            poslabel.Text = (bmb.Position + 1) + "/" + bmb.Count;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bmb.Position += 1;
            poslabel.Text = (bmb.Position + 1) + "/" + bmb.Count;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bmb.Position -= 1;
            poslabel.Text = (bmb.Position + 1) + "/" + bmb.Count;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bmb.AddNew();
            newbtn.Enabled = false;
            addbtn.Enabled = true;
            numbtxt.Focus();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            try
            {
                bmb.EndCurrentEdit();
                cb = new SqlCommandBuilder(da);
                da.Update(dt);
                MessageBox.Show("تمت الاضافة بنجاح", "عملية الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                addbtn.Enabled = false;
                newbtn.Enabled = true;
                poslabel.Text = (bmb.Position + 1) + "/" + bmb.Count;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           

        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            try
            {
                bmb.RemoveAt(bmb.Position);
                bmb.EndCurrentEdit();
                cb = new SqlCommandBuilder(da);
                da.Update(dt);
                MessageBox.Show("تم الحذف بنجاح", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                poslabel.Text = (bmb.Position + 1) + "/" + bmb.Count;
            }
            catch
            {
                MessageBox.Show("لايمكن حذف هذا الصنف لوجود منتجات تحت هذا الصنف !", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Warning);
              
            }
           
            
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            try
            {
                bmb.EndCurrentEdit();
                cb = new SqlCommandBuilder(da);
                da.Update(dt);
                MessageBox.Show("تم التعديل بنجاح", "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                poslabel.Text = (bmb.Position + 1) + "/" + bmb.Count;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void printcurbtn_Click(object sender, EventArgs e)
        {
            Single_Cat_Report report = new Single_Cat_Report();
            View_Report_Form prf = new View_Report_Form();
            report.Refresh();
            report.SetParameterValue("@id", Convert.ToInt32(numbtxt.Text));
            prf.crystalReportViewer1.ReportSource = report;
            prf.ShowDialog();
        }

        private void printallbtn_Click(object sender, EventArgs e)
        {
            All_Cat_Report report = new All_Cat_Report();
            View_Report_Form prf = new View_Report_Form();
            report.Refresh();
            prf.crystalReportViewer1.ReportSource = report;
            prf.ShowDialog();
        }

        private void exportpdfbtn_Click(object sender, EventArgs e)
        {
            All_Cat_Report report = new All_Cat_Report();
            ExportOptions export = new ExportOptions();
            DiskFileDestinationOptions dfoption = new DiskFileDestinationOptions();
            PdfFormatOptions pdf = new PdfFormatOptions();
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "ملف اكسيل | *.pdf";
            save.InitialDirectory = @"C:\";
            if (save.ShowDialog() == DialogResult.OK)
            {
                dfoption.DiskFileName = save.FileName;
                export = report.ExportOptions;
                export.ExportDestinationType = ExportDestinationType.DiskFile;
                export.ExportFormatType = ExportFormatType.PortableDocFormat;
                export.ExportFormatOptions = pdf;
                export.ExportDestinationOptions = dfoption;
                report.Refresh();
                report.Export();
                MessageBox.Show("تمت العملية بنجاح", "معلومة", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void exportcurpdfbtn_Click(object sender, EventArgs e)
        {
            Single_Cat_Report report = new Single_Cat_Report();
            ExportOptions export = new ExportOptions();
            DiskFileDestinationOptions dfoption = new DiskFileDestinationOptions();
            PdfFormatOptions pdf = new PdfFormatOptions();
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "ملف اكسيل | *.pdf";
            save.InitialDirectory = @"C:\";
            if (save.ShowDialog() == DialogResult.OK)
            {
                dfoption.DiskFileName = save.FileName;
                export = report.ExportOptions;
                export.ExportDestinationType = ExportDestinationType.DiskFile;
                export.ExportFormatType = ExportFormatType.PortableDocFormat;
                export.ExportFormatOptions = pdf;
                export.ExportDestinationOptions = dfoption;
                report.Refresh();
                report.SetParameterValue("@id", Convert.ToInt32(numbtxt.Text));
                report.Export();
                MessageBox.Show("تمت العملية بنجاح", "معلومة", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
