namespace Products_Managment.PL
{
    partial class Orders_Form
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.orderdesc = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.orderdate = new System.Windows.Forms.DateTimePicker();
            this.orderid = new System.Windows.Forms.TextBox();
            this.ordername = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.custemail = new System.Windows.Forms.TextBox();
            this.custphone = new System.Windows.Forms.TextBox();
            this.custlname = new System.Windows.Forms.TextBox();
            this.custfname = new System.Windows.Forms.TextBox();
            this.custnumb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.prodtotal = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.proddisc = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.prodamount = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.prodqty = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.prodprice = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.prodname = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.prodid = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.deletecurrentrow = new System.Windows.Forms.Button();
            this.totalsum = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.تعديلToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.حذفالسطرالمحددToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.حذفالكلToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chosbtn = new System.Windows.Forms.Button();
            this.newbtn = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.printbtn = new System.Windows.Forms.Button();
            this.savebtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.orderdesc);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.orderdate);
            this.groupBox1.Controls.Add(this.orderid);
            this.groupBox1.Controls.Add(this.ordername);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 170);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات الفاتورة";
            // 
            // orderdesc
            // 
            this.orderdesc.Location = new System.Drawing.Point(6, 51);
            this.orderdesc.Multiline = true;
            this.orderdesc.Name = "orderdesc";
            this.orderdesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.orderdesc.Size = new System.Drawing.Size(183, 53);
            this.orderdesc.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(195, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "وصف الفاتورة:";
            // 
            // orderdate
            // 
            this.orderdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.orderdate.Location = new System.Drawing.Point(6, 110);
            this.orderdate.Name = "orderdate";
            this.orderdate.Size = new System.Drawing.Size(183, 20);
            this.orderdate.TabIndex = 1;
            // 
            // orderid
            // 
            this.orderid.Location = new System.Drawing.Point(6, 26);
            this.orderid.Name = "orderid";
            this.orderid.ReadOnly = true;
            this.orderid.Size = new System.Drawing.Size(183, 20);
            this.orderid.TabIndex = 9;
            // 
            // ordername
            // 
            this.ordername.Location = new System.Drawing.Point(6, 136);
            this.ordername.Name = "ordername";
            this.ordername.ReadOnly = true;
            this.ordername.Size = new System.Drawing.Size(183, 20);
            this.ordername.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(207, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "اسم البائع:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(210, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "تاريخ البيع:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(202, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "رقم الفاتورة:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.custemail);
            this.groupBox2.Controls.Add(this.custphone);
            this.groupBox2.Controls.Add(this.custlname);
            this.groupBox2.Controls.Add(this.custfname);
            this.groupBox2.Controls.Add(this.custnumb);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(295, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(412, 170);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "بيانات العميل";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(132, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "......";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(6, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 149);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // custemail
            // 
            this.custemail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.custemail.Location = new System.Drawing.Point(132, 133);
            this.custemail.Name = "custemail";
            this.custemail.ReadOnly = true;
            this.custemail.Size = new System.Drawing.Size(176, 20);
            this.custemail.TabIndex = 10;
            // 
            // custphone
            // 
            this.custphone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.custphone.Location = new System.Drawing.Point(132, 107);
            this.custphone.Name = "custphone";
            this.custphone.ReadOnly = true;
            this.custphone.Size = new System.Drawing.Size(176, 20);
            this.custphone.TabIndex = 9;
            // 
            // custlname
            // 
            this.custlname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.custlname.Location = new System.Drawing.Point(132, 81);
            this.custlname.Name = "custlname";
            this.custlname.ReadOnly = true;
            this.custlname.Size = new System.Drawing.Size(176, 20);
            this.custlname.TabIndex = 8;
            // 
            // custfname
            // 
            this.custfname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.custfname.Location = new System.Drawing.Point(132, 55);
            this.custfname.Name = "custfname";
            this.custfname.ReadOnly = true;
            this.custfname.Size = new System.Drawing.Size(176, 20);
            this.custfname.TabIndex = 7;
            // 
            // custnumb
            // 
            this.custnumb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.custnumb.Location = new System.Drawing.Point(208, 29);
            this.custnumb.Name = "custnumb";
            this.custnumb.ReadOnly = true;
            this.custnumb.Size = new System.Drawing.Size(100, 20);
            this.custnumb.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(320, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "الاسم الشخصى:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(332, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "الاسم العائلى:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(349, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "رقم الهاتف:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(323, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "البريد الالكترونى:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(346, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "رقم العميل:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.prodtotal);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.proddisc);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.prodamount);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.prodqty);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.prodprice);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.prodname);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.prodid);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.deletecurrentrow);
            this.groupBox3.Controls.Add(this.totalsum);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Controls.Add(this.chosbtn);
            this.groupBox3.Location = new System.Drawing.Point(12, 188);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(695, 202);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "المنتجات";
            // 
            // prodtotal
            // 
            this.prodtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prodtotal.Location = new System.Drawing.Point(6, 35);
            this.prodtotal.Name = "prodtotal";
            this.prodtotal.ReadOnly = true;
            this.prodtotal.Size = new System.Drawing.Size(110, 20);
            this.prodtotal.TabIndex = 28;
            this.prodtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label18
            // 
            this.label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label18.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(6, 16);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(110, 19);
            this.label18.TabIndex = 27;
            this.label18.Text = "المبلغ الاجمالى";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // proddisc
            // 
            this.proddisc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.proddisc.Location = new System.Drawing.Point(112, 35);
            this.proddisc.MaxLength = 4;
            this.proddisc.Name = "proddisc";
            this.proddisc.Size = new System.Drawing.Size(90, 20);
            this.proddisc.TabIndex = 26;
            this.proddisc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.proddisc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.proddisc_KeyDown);
            this.proddisc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.proddisc_KeyPress);
            this.proddisc.KeyUp += new System.Windows.Forms.KeyEventHandler(this.proddisc_KeyUp);
            // 
            // label17
            // 
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label17.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(112, 16);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(90, 19);
            this.label17.TabIndex = 25;
            this.label17.Text = "الخصم (%)";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // prodamount
            // 
            this.prodamount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prodamount.Location = new System.Drawing.Point(199, 35);
            this.prodamount.Name = "prodamount";
            this.prodamount.ReadOnly = true;
            this.prodamount.Size = new System.Drawing.Size(70, 20);
            this.prodamount.TabIndex = 24;
            this.prodamount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label16
            // 
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label16.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(199, 16);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(70, 19);
            this.label16.TabIndex = 23;
            this.label16.Text = "المبلغ";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // prodqty
            // 
            this.prodqty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prodqty.Location = new System.Drawing.Point(266, 35);
            this.prodqty.MaxLength = 7;
            this.prodqty.Name = "prodqty";
            this.prodqty.Size = new System.Drawing.Size(70, 20);
            this.prodqty.TabIndex = 22;
            this.prodqty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.prodqty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.prodqty_KeyDown);
            this.prodqty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.prodqty_KeyPress);
            this.prodqty.KeyUp += new System.Windows.Forms.KeyEventHandler(this.prodqty_KeyUp);
            // 
            // label13
            // 
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(266, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 19);
            this.label13.TabIndex = 21;
            this.label13.Text = "الكمية";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label14.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(617, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 19);
            this.label14.TabIndex = 19;
            this.label14.Text = "اختيار";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // prodprice
            // 
            this.prodprice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prodprice.Location = new System.Drawing.Point(335, 35);
            this.prodprice.MaxLength = 7;
            this.prodprice.Name = "prodprice";
            this.prodprice.Size = new System.Drawing.Size(70, 20);
            this.prodprice.TabIndex = 18;
            this.prodprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.prodprice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.prodprice_KeyPress);
            this.prodprice.KeyUp += new System.Windows.Forms.KeyEventHandler(this.prodprice_KeyUp);
            // 
            // label15
            // 
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label15.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(335, 16);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(70, 19);
            this.label15.TabIndex = 17;
            this.label15.Text = "الثمن";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // prodname
            // 
            this.prodname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prodname.Location = new System.Drawing.Point(402, 35);
            this.prodname.Name = "prodname";
            this.prodname.ReadOnly = true;
            this.prodname.Size = new System.Drawing.Size(116, 20);
            this.prodname.TabIndex = 16;
            // 
            // label12
            // 
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(402, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(116, 19);
            this.label12.TabIndex = 15;
            this.label12.Text = "اسم المنتج";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // prodid
            // 
            this.prodid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prodid.Location = new System.Drawing.Point(517, 35);
            this.prodid.Name = "prodid";
            this.prodid.ReadOnly = true;
            this.prodid.Size = new System.Drawing.Size(102, 20);
            this.prodid.TabIndex = 14;
            this.prodid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(517, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 19);
            this.label11.TabIndex = 13;
            this.label11.Text = "كود المنتج";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // deletecurrentrow
            // 
            this.deletecurrentrow.Location = new System.Drawing.Point(549, 172);
            this.deletecurrentrow.Name = "deletecurrentrow";
            this.deletecurrentrow.Size = new System.Drawing.Size(140, 23);
            this.deletecurrentrow.TabIndex = 12;
            this.deletecurrentrow.Text = "حذف السطر المحدد";
            this.deletecurrentrow.UseVisualStyleBackColor = true;
            this.deletecurrentrow.Click += new System.EventHandler(this.deletecurrentrow_Click);
            // 
            // totalsum
            // 
            this.totalsum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalsum.Location = new System.Drawing.Point(6, 175);
            this.totalsum.Name = "totalsum";
            this.totalsum.ReadOnly = true;
            this.totalsum.Size = new System.Drawing.Size(150, 20);
            this.totalsum.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(162, 178);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "المجموع:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(6, 54);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(683, 115);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridView1_RowsRemoved);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.تعديلToolStripMenuItem,
            this.toolStripSeparator1,
            this.حذفالسطرالمحددToolStripMenuItem,
            this.حذفالكلToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(171, 76);
            // 
            // تعديلToolStripMenuItem
            // 
            this.تعديلToolStripMenuItem.Name = "تعديلToolStripMenuItem";
            this.تعديلToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.تعديلToolStripMenuItem.Text = "تعديل";
            this.تعديلToolStripMenuItem.Click += new System.EventHandler(this.تعديلToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(167, 6);
            // 
            // حذفالسطرالمحددToolStripMenuItem
            // 
            this.حذفالسطرالمحددToolStripMenuItem.Name = "حذفالسطرالمحددToolStripMenuItem";
            this.حذفالسطرالمحددToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.حذفالسطرالمحددToolStripMenuItem.Text = "حذف السطر المحدد";
            this.حذفالسطرالمحددToolStripMenuItem.Click += new System.EventHandler(this.حذفالسطرالمحددToolStripMenuItem_Click);
            // 
            // حذفالكلToolStripMenuItem
            // 
            this.حذفالكلToolStripMenuItem.Name = "حذفالكلToolStripMenuItem";
            this.حذفالكلToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.حذفالكلToolStripMenuItem.Text = "حذف الكل";
            this.حذفالكلToolStripMenuItem.Click += new System.EventHandler(this.حذفالكلToolStripMenuItem_Click);
            // 
            // chosbtn
            // 
            this.chosbtn.Location = new System.Drawing.Point(617, 32);
            this.chosbtn.Name = "chosbtn";
            this.chosbtn.Size = new System.Drawing.Size(72, 23);
            this.chosbtn.TabIndex = 20;
            this.chosbtn.Text = ".....";
            this.chosbtn.UseVisualStyleBackColor = true;
            this.chosbtn.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // newbtn
            // 
            this.newbtn.Location = new System.Drawing.Point(137, 408);
            this.newbtn.Name = "newbtn";
            this.newbtn.Size = new System.Drawing.Size(96, 23);
            this.newbtn.TabIndex = 3;
            this.newbtn.Text = "مبيعة جديدة";
            this.newbtn.UseVisualStyleBackColor = true;
            this.newbtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(447, 408);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(98, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "خروج";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // printbtn
            // 
            this.printbtn.Location = new System.Drawing.Point(342, 408);
            this.printbtn.Name = "printbtn";
            this.printbtn.Size = new System.Drawing.Size(99, 23);
            this.printbtn.TabIndex = 5;
            this.printbtn.Text = "طباعة الفاتورة";
            this.printbtn.UseVisualStyleBackColor = true;
            this.printbtn.Click += new System.EventHandler(this.printbtn_Click);
            // 
            // savebtn
            // 
            this.savebtn.Enabled = false;
            this.savebtn.Location = new System.Drawing.Point(239, 408);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(97, 23);
            this.savebtn.TabIndex = 6;
            this.savebtn.Text = "حفظ المبيعة";
            this.savebtn.UseVisualStyleBackColor = true;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // Orders_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 443);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.printbtn);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.newbtn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Orders_Form";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "عملية البيع";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker orderdate;
        private System.Windows.Forms.TextBox orderid;
        private System.Windows.Forms.TextBox ordername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox custemail;
        private System.Windows.Forms.TextBox custphone;
        private System.Windows.Forms.TextBox custlname;
        private System.Windows.Forms.TextBox custfname;
        private System.Windows.Forms.TextBox custnumb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button deletecurrentrow;
        private System.Windows.Forms.TextBox totalsum;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button newbtn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button printbtn;
        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.TextBox orderdesc;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox prodname;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox prodid;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button chosbtn;
        private System.Windows.Forms.TextBox prodtotal;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox proddisc;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox prodamount;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox prodqty;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox prodprice;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem تعديلToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem حذفالسطرالمحددToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem حذفالكلToolStripMenuItem;
    }
}