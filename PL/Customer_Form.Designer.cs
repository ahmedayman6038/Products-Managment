namespace Products_Managment.PL
{
    partial class Customer_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.custid = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.navlabel = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.custphone = new System.Windows.Forms.TextBox();
            this.custlname = new System.Windows.Forms.TextBox();
            this.custemail = new System.Windows.Forms.TextBox();
            this.custfname = new System.Windows.Forms.TextBox();
            this.custimg = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.searchbtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.searchtxt = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.addbtn = new System.Windows.Forms.Button();
            this.clsbtn = new System.Windows.Forms.Button();
            this.updatebtn = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.newbtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.custimg)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.custid);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.navlabel);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.custphone);
            this.groupBox1.Controls.Add(this.custlname);
            this.groupBox1.Controls.Add(this.custemail);
            this.groupBox1.Controls.Add(this.custfname);
            this.groupBox1.Controls.Add(this.custimg);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(414, 208);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات العميل";
            // 
            // custid
            // 
            this.custid.Location = new System.Drawing.Point(168, 32);
            this.custid.Name = "custid";
            this.custid.Size = new System.Drawing.Size(133, 20);
            this.custid.TabIndex = 0;
            this.custid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.custid_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(336, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "كود العميل:";
            // 
            // navlabel
            // 
            this.navlabel.AutoSize = true;
            this.navlabel.Location = new System.Drawing.Point(267, 175);
            this.navlabel.Name = "navlabel";
            this.navlabel.Size = new System.Drawing.Size(23, 13);
            this.navlabel.TabIndex = 13;
            this.navlabel.Text = "4/6";
            // 
            // button5
            // 
            this.button5.Image = global::Products_Managment.Properties.Resources.angle_pointing_to_left;
            this.button5.Location = new System.Drawing.Point(212, 170);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(38, 23);
            this.button5.TabIndex = 12;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Image = global::Products_Managment.Properties.Resources.double_angle_pointing_to_right;
            this.button4.Location = new System.Drawing.Point(355, 170);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(38, 23);
            this.button4.TabIndex = 11;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Image = global::Products_Managment.Properties.Resources.angle_arrow_pointing_to_right;
            this.button3.Location = new System.Drawing.Point(311, 170);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(38, 23);
            this.button3.TabIndex = 10;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Image = global::Products_Managment.Properties.Resources.double_left_chevron;
            this.button2.Location = new System.Drawing.Point(168, 170);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(38, 23);
            this.button2.TabIndex = 9;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // custphone
            // 
            this.custphone.Location = new System.Drawing.Point(168, 110);
            this.custphone.Name = "custphone";
            this.custphone.Size = new System.Drawing.Size(133, 20);
            this.custphone.TabIndex = 3;
            this.custphone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.custphone_KeyDown);
            // 
            // custlname
            // 
            this.custlname.Location = new System.Drawing.Point(168, 84);
            this.custlname.Name = "custlname";
            this.custlname.Size = new System.Drawing.Size(133, 20);
            this.custlname.TabIndex = 2;
            this.custlname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.custlname_KeyDown);
            // 
            // custemail
            // 
            this.custemail.Location = new System.Drawing.Point(168, 136);
            this.custemail.Name = "custemail";
            this.custemail.Size = new System.Drawing.Size(133, 20);
            this.custemail.TabIndex = 4;
            this.custemail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.custemail_KeyDown);
            // 
            // custfname
            // 
            this.custfname.Location = new System.Drawing.Point(168, 58);
            this.custfname.Name = "custfname";
            this.custfname.Size = new System.Drawing.Size(133, 20);
            this.custfname.TabIndex = 1;
            this.custfname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.custfname_KeyDown);
            // 
            // custimg
            // 
            this.custimg.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.custimg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.custimg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.custimg.Location = new System.Drawing.Point(6, 32);
            this.custimg.Name = "custimg";
            this.custimg.Size = new System.Drawing.Size(156, 161);
            this.custimg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.custimg.TabIndex = 4;
            this.custimg.TabStop = false;
            this.custimg.Click += new System.EventHandler(this.custimg_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(311, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "البريد الالكترونى:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(329, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "رقم التليفون:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(320, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "الاسم العائلى:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(308, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "الاسم الشخصى:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.searchbtn);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.searchtxt);
            this.groupBox2.Location = new System.Drawing.Point(432, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(527, 273);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "لأئحة العملاء";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 48);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(515, 225);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // searchbtn
            // 
            this.searchbtn.Location = new System.Drawing.Point(64, 19);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(75, 23);
            this.searchbtn.TabIndex = 11;
            this.searchbtn.Text = "موافق";
            this.searchbtn.UseVisualStyleBackColor = true;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(405, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "ابحث هنا:";
            // 
            // searchtxt
            // 
            this.searchtxt.Location = new System.Drawing.Point(145, 19);
            this.searchtxt.Name = "searchtxt";
            this.searchtxt.Size = new System.Drawing.Size(254, 20);
            this.searchtxt.TabIndex = 10;
            this.searchtxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchtxt_KeyDown);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.addbtn);
            this.groupBox3.Controls.Add(this.clsbtn);
            this.groupBox3.Controls.Add(this.updatebtn);
            this.groupBox3.Controls.Add(this.button7);
            this.groupBox3.Controls.Add(this.newbtn);
            this.groupBox3.Location = new System.Drawing.Point(12, 226);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(414, 59);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "العمليات المتاحة";
            // 
            // addbtn
            // 
            this.addbtn.Enabled = false;
            this.addbtn.Location = new System.Drawing.Point(249, 19);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(75, 23);
            this.addbtn.TabIndex = 5;
            this.addbtn.Text = "اضافة";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.button10_Click);
            // 
            // clsbtn
            // 
            this.clsbtn.Location = new System.Drawing.Point(168, 19);
            this.clsbtn.Name = "clsbtn";
            this.clsbtn.Size = new System.Drawing.Size(75, 23);
            this.clsbtn.TabIndex = 6;
            this.clsbtn.Text = "حذف";
            this.clsbtn.UseVisualStyleBackColor = true;
            this.clsbtn.Click += new System.EventHandler(this.clsbtn_Click);
            // 
            // updatebtn
            // 
            this.updatebtn.Location = new System.Drawing.Point(87, 19);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(75, 23);
            this.updatebtn.TabIndex = 7;
            this.updatebtn.Text = "تعديل";
            this.updatebtn.UseVisualStyleBackColor = true;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(6, 19);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 8;
            this.button7.Text = "خروج";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // newbtn
            // 
            this.newbtn.Location = new System.Drawing.Point(330, 19);
            this.newbtn.Name = "newbtn";
            this.newbtn.Size = new System.Drawing.Size(75, 23);
            this.newbtn.TabIndex = 9;
            this.newbtn.Text = "جديد";
            this.newbtn.UseVisualStyleBackColor = true;
            this.newbtn.Click += new System.EventHandler(this.button6_Click);
            // 
            // Customer_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 299);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Customer_Form";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "العملاء";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.custimg)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox custimg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label navlabel;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox custphone;
        private System.Windows.Forms.TextBox custlname;
        private System.Windows.Forms.TextBox custemail;
        private System.Windows.Forms.TextBox custfname;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox searchtxt;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Button clsbtn;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button newbtn;
        private System.Windows.Forms.TextBox custid;
        private System.Windows.Forms.Label label7;
    }
}