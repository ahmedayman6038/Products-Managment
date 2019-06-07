namespace Products_Managment.PL
{
    partial class Login_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Form));
            this.passlabel = new System.Windows.Forms.Label();
            this.userlabel = new System.Windows.Forms.Label();
            this.usertxt = new System.Windows.Forms.TextBox();
            this.passtxt = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.enter = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // passlabel
            // 
            this.passlabel.AutoSize = true;
            this.passlabel.Location = new System.Drawing.Point(12, 217);
            this.passlabel.Name = "passlabel";
            this.passlabel.Size = new System.Drawing.Size(59, 13);
            this.passlabel.TabIndex = 2;
            this.passlabel.Text = "كلمة المرور";
            // 
            // userlabel
            // 
            this.userlabel.AutoSize = true;
            this.userlabel.Location = new System.Drawing.Point(12, 191);
            this.userlabel.Name = "userlabel";
            this.userlabel.Size = new System.Drawing.Size(81, 13);
            this.userlabel.TabIndex = 3;
            this.userlabel.Text = "اسم المستخدم";
            // 
            // usertxt
            // 
            this.usertxt.Location = new System.Drawing.Point(105, 184);
            this.usertxt.Name = "usertxt";
            this.usertxt.Size = new System.Drawing.Size(156, 20);
            this.usertxt.TabIndex = 0;
            // 
            // passtxt
            // 
            this.passtxt.Location = new System.Drawing.Point(105, 210);
            this.passtxt.Name = "passtxt";
            this.passtxt.Size = new System.Drawing.Size(156, 20);
            this.passtxt.TabIndex = 1;
            this.passtxt.UseSystemPasswordChar = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Products_Managment.Properties.Resources.keyhole;
            this.pictureBox1.Location = new System.Drawing.Point(79, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // enter
            // 
            this.enter.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enter.Image = global::Products_Managment.Properties.Resources.User_Interface_Login_icon;
            this.enter.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.enter.Location = new System.Drawing.Point(12, 258);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(75, 38);
            this.enter.TabIndex = 2;
            this.enter.Text = "دخول";
            this.enter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.enter.UseVisualStyleBackColor = true;
            this.enter.Click += new System.EventHandler(this.enter_Click);
            // 
            // close
            // 
            this.close.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Image = global::Products_Managment.Properties.Resources.cancel_mark;
            this.close.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.close.Location = new System.Drawing.Point(186, 258);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(75, 38);
            this.close.TabIndex = 3;
            this.close.Text = "الغاء";
            this.close.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 308);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.passtxt);
            this.Controls.Add(this.usertxt);
            this.Controls.Add(this.userlabel);
            this.Controls.Add(this.passlabel);
            this.Controls.Add(this.enter);
            this.Controls.Add(this.close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login_Form";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تسجيل الدخول";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.Label passlabel;
        private System.Windows.Forms.Label userlabel;
        private System.Windows.Forms.TextBox usertxt;
        private System.Windows.Forms.TextBox passtxt;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}