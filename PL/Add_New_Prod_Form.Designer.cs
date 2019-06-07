namespace Products_Managment.PL
{
    partial class Add_New_Prod_Form
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
            this.prodid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.prodimg = new System.Windows.Forms.PictureBox();
            this.catlist = new System.Windows.Forms.ComboBox();
            this.prodprice = new System.Windows.Forms.TextBox();
            this.prodqty = new System.Windows.Forms.TextBox();
            this.prodname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prodimg)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.prodid);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.prodimg);
            this.groupBox1.Controls.Add(this.catlist);
            this.groupBox1.Controls.Add(this.prodprice);
            this.groupBox1.Controls.Add(this.prodqty);
            this.groupBox1.Controls.Add(this.prodname);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 398);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات المنتج";
            // 
            // prodid
            // 
            this.prodid.Location = new System.Drawing.Point(49, 81);
            this.prodid.Name = "prodid";
            this.prodid.Size = new System.Drawing.Size(142, 20);
            this.prodid.TabIndex = 0;
            this.prodid.Validated += new System.EventHandler(this.prodid_Validated);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(207, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "كود المنتج:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(116, 369);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "اضافة";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 369);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "الغاء";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(49, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "تحديد ملف الصورة";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // prodimg
            // 
            this.prodimg.Image = global::Products_Managment.Properties.Resources._1;
            this.prodimg.Location = new System.Drawing.Point(49, 224);
            this.prodimg.Name = "prodimg";
            this.prodimg.Size = new System.Drawing.Size(142, 91);
            this.prodimg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.prodimg.TabIndex = 12;
            this.prodimg.TabStop = false;
            
            // 
            // catlist
            // 
            this.catlist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.catlist.FormattingEnabled = true;
            this.catlist.Location = new System.Drawing.Point(49, 45);
            this.catlist.Name = "catlist";
            this.catlist.Size = new System.Drawing.Size(142, 21);
            this.catlist.TabIndex = 7;
            // 
            // prodprice
            // 
            this.prodprice.Location = new System.Drawing.Point(49, 187);
            this.prodprice.Name = "prodprice";
            this.prodprice.Size = new System.Drawing.Size(142, 20);
            this.prodprice.TabIndex = 3;
            // 
            // prodqty
            // 
            this.prodqty.Location = new System.Drawing.Point(49, 152);
            this.prodqty.Name = "prodqty";
            this.prodqty.Size = new System.Drawing.Size(142, 20);
            this.prodqty.TabIndex = 2;
            // 
            // prodname
            // 
            this.prodname.Location = new System.Drawing.Point(49, 116);
            this.prodname.Name = "prodname";
            this.prodname.Size = new System.Drawing.Size(142, 20);
            this.prodname.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(207, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "صورة المنتج:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(212, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "ثمن المنتج:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(196, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "الكمية المخزنة:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "اسم المنتج:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "صنف المنتج:";
            // 
            // Add_New_Prod_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 422);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Add_New_Prod_Form";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافة منتج جديد";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prodimg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.PictureBox prodimg;
        public System.Windows.Forms.ComboBox catlist;
        public System.Windows.Forms.TextBox prodprice;
        public System.Windows.Forms.TextBox prodqty;
        public System.Windows.Forms.TextBox prodname;
        public System.Windows.Forms.TextBox prodid;
    }
}