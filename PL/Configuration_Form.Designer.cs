namespace Products_Managment.PL
{
    partial class Configuration_Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.server = new System.Windows.Forms.TextBox();
            this.database = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.windows = new System.Windows.Forms.RadioButton();
            this.sql = new System.Windows.Forms.RadioButton();
            this.pass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.savebtn = new System.Windows.Forms.Button();
            this.closebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "اسم السيرفر:";
            // 
            // server
            // 
            this.server.Location = new System.Drawing.Point(103, 27);
            this.server.Name = "server";
            this.server.Size = new System.Drawing.Size(154, 20);
            this.server.TabIndex = 0;
            // 
            // database
            // 
            this.database.Location = new System.Drawing.Point(103, 53);
            this.database.Name = "database";
            this.database.Size = new System.Drawing.Size(154, 20);
            this.database.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "قاعدة البيانات:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "طريقة الدخول:";
            // 
            // windows
            // 
            this.windows.AutoSize = true;
            this.windows.Checked = true;
            this.windows.Location = new System.Drawing.Point(103, 86);
            this.windows.Name = "windows";
            this.windows.Size = new System.Drawing.Size(141, 17);
            this.windows.TabIndex = 5;
            this.windows.TabStop = true;
            this.windows.Text = "Windows Authentication";
            this.windows.UseVisualStyleBackColor = true;
            this.windows.CheckedChanged += new System.EventHandler(this.windows_CheckedChanged);
            // 
            // sql
            // 
            this.sql.AutoSize = true;
            this.sql.Location = new System.Drawing.Point(103, 109);
            this.sql.Name = "sql";
            this.sql.Size = new System.Drawing.Size(147, 17);
            this.sql.TabIndex = 6;
            this.sql.Text = "Sql Server Authentication";
            this.sql.UseVisualStyleBackColor = true;
            this.sql.CheckedChanged += new System.EventHandler(this.sql_CheckedChanged);
            // 
            // pass
            // 
            this.pass.Enabled = false;
            this.pass.Location = new System.Drawing.Point(103, 161);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(154, 20);
            this.pass.TabIndex = 3;
            this.pass.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "كلمة المرور:";
            // 
            // username
            // 
            this.username.Enabled = false;
            this.username.Location = new System.Drawing.Point(103, 135);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(154, 20);
            this.username.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "اسم المستخدم:";
            // 
            // savebtn
            // 
            this.savebtn.Location = new System.Drawing.Point(101, 206);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(75, 34);
            this.savebtn.TabIndex = 4;
            this.savebtn.Text = "حفظ";
            this.savebtn.UseVisualStyleBackColor = true;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // closebtn
            // 
            this.closebtn.Location = new System.Drawing.Point(182, 206);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(75, 34);
            this.closebtn.TabIndex = 5;
            this.closebtn.Text = "خروج";
            this.closebtn.UseVisualStyleBackColor = true;
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click);
            // 
            // Configuration_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 257);
            this.Controls.Add(this.closebtn);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.sql);
            this.Controls.Add(this.windows);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.database);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.server);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Configuration_Form";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اعدادات التحكم فى الاتصال بالسيرفر";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox server;
        private System.Windows.Forms.TextBox database;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton windows;
        private System.Windows.Forms.RadioButton sql;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.Button closebtn;
    }
}