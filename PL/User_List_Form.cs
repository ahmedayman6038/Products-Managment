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
    public partial class User_List_Form : Form
    {
        Login user;
        public static string id;
        public User_List_Form()
        {
            InitializeComponent();
            user = new Login();
            dataGridView1.DataSource = user.getUsers("");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Add_New_User add = new Add_New_User();
            add.savebtn.Text = "اضافة";
            add.ShowDialog();
            dataGridView1.DataSource = user.getUsers("");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Add_New_User update = new Add_New_User();
            update.savebtn.Text = "تعديل";
            update.username.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            update.pass.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            update.confpass.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            update.type.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            id = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            update.ShowDialog();
            dataGridView1.DataSource = user.getUsers("");
        }

        private void searchtxt_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = user.getUsers(searchtxt.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            user.DeleteUser(dataGridView1.CurrentRow.Cells[1].Value.ToString());
            MessageBox.Show("تم الحذف بنجاح", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataGridView1.DataSource = user.getUsers("");
        }
    }
}
