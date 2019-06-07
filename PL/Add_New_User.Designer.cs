namespace Products_Managment.PL
{
    partial class Add_New_User
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
            this.type = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.confpass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.savebtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.type);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.confpass);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.pass);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.username);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 152);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "معلومات المستخدم";
            // 
            // type
            // 
            this.type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.type.FormattingEnabled = true;
            this.type.Items.AddRange(new object[] {
            "Admin",
            "User"});
            this.type.Location = new System.Drawing.Point(16, 105);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(146, 21);
            this.type.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(167, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "نوع المستخدم:";
            // 
            // confpass
            // 
            this.confpass.Location = new System.Drawing.Point(16, 79);
            this.confpass.Name = "confpass";
            this.confpass.Size = new System.Drawing.Size(146, 20);
            this.confpass.TabIndex = 2;
            this.confpass.UseSystemPasswordChar = true;
            this.confpass.Validated += new System.EventHandler(this.confpass_Validated);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(168, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "تاكيد كلمة المرور:";
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(16, 53);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(146, 20);
            this.pass.TabIndex = 1;
            this.pass.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "كلمة المرور:";
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(15, 27);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(146, 20);
            this.username.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "اسم المستخدم:";
            // 
            // savebtn
            // 
            this.savebtn.Location = new System.Drawing.Point(49, 180);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(96, 23);
            this.savebtn.TabIndex = 0;
            this.savebtn.Text = "اضافة";
            this.savebtn.UseVisualStyleBackColor = true;
            this.savebtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(151, 180);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "خروج";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Add_New_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 225);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Add_New_User";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافة مستخدم جديد";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button savebtn;
        public System.Windows.Forms.ComboBox type;
        public System.Windows.Forms.TextBox confpass;
        public System.Windows.Forms.TextBox pass;
        public System.Windows.Forms.TextBox username;
    }
}