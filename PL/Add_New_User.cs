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
    public partial class Add_New_User : Form
    {
        Login user;
        User_List_Form list;
        public Add_New_User()
        {
            InitializeComponent();
            user = new Login();
            list = new User_List_Form();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (username.Text != string.Empty || pass.Text != string.Empty || confpass.Text != string.Empty || type.Text != string.Empty)
                {
                    if (pass.Text == confpass.Text)
                    {
                        if (savebtn.Text == "اضافة")
                        {
                            user.addUser(username.Text, pass.Text, type.Text);
                            MessageBox.Show("تمت الاضافة بنجاح", "عملية الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            username.Clear();
                            pass.Clear();
                            confpass.Clear();
                            username.Focus();
                            return;
                        }
                        if (savebtn.Text == "تعديل")
                        {
                            user.updateUser(User_List_Form.id,username.Text, pass.Text, type.Text);
                            MessageBox.Show(User_List_Form.id + "تم التعديل بنجاح", "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }
                    MessageBox.Show("كلمة السر التى ادخلتها لا توافق بعض", "عملية الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                MessageBox.Show("الرجاء ادخال جميع الخانات", "عملية الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
         }

        private void confpass_Validated(object sender, EventArgs e)
        {
            if(pass.Text != confpass.Text)
            {
                MessageBox.Show("كلمة السر التى ادخلتها لا توافق بعض", "عملية الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
