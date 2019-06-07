using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Products_Managment.PL
{
    public partial class Startup_Form : Form
    {
        int set = 0;
        public Startup_Form()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 3;
            if(panel2.Width >= panel1.Width)
            {
                timer1.Stop();
                this.Close();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if(set == 4)
            {
                label3.Text = "Loading";
                set = 0;
            }else
            {
                label3.Text += ".";
                set++;
            }
        }
    }
}
