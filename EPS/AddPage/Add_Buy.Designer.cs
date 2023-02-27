
namespace EPS.AddPage
{
    partial class Add_Buy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Buy));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_addclose = new DevExpress.XtraEditors.SimpleButton();
            this.btn_add = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.edt_name = new System.Windows.Forms.TextBox();
            this.txt_message = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toastNotificationsManager1 = new DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.link_addnewgroups = new System.Windows.Forms.LinkLabel();
            this.edt_category = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.edt_description = new System.Windows.Forms.RichTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_barcodegenerator = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.edt_barcode = new System.Windows.Forms.TextBox();
            this.edt_quantity = new System.Windows.Forms.TextBox();
            this.edt_supplier = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.edt_creditbuysecondry = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.edt_creditbuyprimary = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.btn_changeconvertvalue = new System.Windows.Forms.LinkLabel();
            this.edt_convertvalue = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.edt_cahbuysecondry = new System.Windows.Forms.TextBox();
            this.edt_secondryunit = new System.Windows.Forms.Label();
            this.edt_cashbuyprimary = new System.Windows.Forms.TextBox();
            this.edt_primaryunit = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.edt_benfit = new System.Windows.Forms.Label();
            this.edt_sellall = new System.Windows.Forms.Label();
            this.edt_buyall = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radio_part = new System.Windows.Forms.RadioButton();
            this.radio_no = new System.Windows.Forms.RadioButton();
            this.radio_yes = new System.Windows.Forms.RadioButton();
            this.edt_supplierpaymentsec = new System.Windows.Forms.TextBox();
            this.edt_supplierpayment = new System.Windows.Forms.TextBox();
            this.edt_buysecondry = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.edt_buyprimary = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toastNotificationsManager1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_addclose);
            this.panel1.Controls.Add(this.btn_add);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 645);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1144, 59);
            this.panel1.TabIndex = 0;
            // 
            // btn_addclose
            // 
            this.btn_addclose.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_addclose.Appearance.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addclose.Appearance.Options.UseFont = true;
            this.btn_addclose.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btn_addclose.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_addclose.ImageOptions.SvgImage")));
            this.btn_addclose.Location = new System.Drawing.Point(6, 5);
            this.btn_addclose.Name = "btn_addclose";
            this.btn_addclose.Size = new System.Drawing.Size(167, 47);
            this.btn_addclose.TabIndex = 1;
            this.btn_addclose.Text = "اضافة+ غلق";
            this.btn_addclose.Click += new System.EventHandler(this.btn_addclose_Click);
            // 
            // btn_add
            // 
            this.btn_add.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_add.Appearance.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Appearance.Options.UseFont = true;
            this.btn_add.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btn_add.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_add.ImageOptions.SvgImage")));
            this.btn_add.Location = new System.Drawing.Point(967, 5);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(167, 47);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "اضافة";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(293, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "اسم المادة";
            // 
            // edt_name
            // 
            this.edt_name.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_name.Location = new System.Drawing.Point(20, 60);
            this.edt_name.Name = "edt_name";
            this.edt_name.Size = new System.Drawing.Size(374, 33);
            this.edt_name.TabIndex = 2;
            this.edt_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_message
            // 
            this.txt_message.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txt_message.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txt_message.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_message.ForeColor = System.Drawing.Color.White;
            this.txt_message.Location = new System.Drawing.Point(0, 605);
            this.txt_message.Name = "txt_message";
            this.txt_message.Size = new System.Drawing.Size(1144, 40);
            this.txt_message.TabIndex = 3;
            this.txt_message.Text = "رسالة";
            this.txt_message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txt_message.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 4000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // toastNotificationsManager1
            // 
            this.toastNotificationsManager1.ApplicationId = "67317d9e-9c1a-45dc-9c6f-79273460fd6a";
            this.toastNotificationsManager1.Notifications.AddRange(new DevExpress.XtraBars.ToastNotifications.IToastNotificationProperties[] {
            new DevExpress.XtraBars.ToastNotifications.ToastNotification("b63bb4e2-c3ce-411f-975a-c860580f1dc7", ((System.Drawing.Image)(resources.GetObject("toastNotificationsManager1.Notifications"))), "تمت الاضافة بنجاح", "تمت الاضافة بنجاح", "تمت الاضافة بنجاح", DevExpress.XtraBars.ToastNotifications.ToastNotificationTemplate.ImageAndText01),
            new DevExpress.XtraBars.ToastNotifications.ToastNotification("5eb82af2-6df7-42a2-89da-1a50da44d73b", ((System.Drawing.Image)(resources.GetObject("toastNotificationsManager1.Notifications1"))), "تمت عملية التعديل بنجاح", "تمت عملية التعديل بنجاح", "تمت عملية التعديل بنجاح", DevExpress.XtraBars.ToastNotifications.ToastNotificationTemplate.ImageAndText01)});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(330, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "الصنف";
            // 
            // link_addnewgroups
            // 
            this.link_addnewgroups.AutoSize = true;
            this.link_addnewgroups.Font = new System.Drawing.Font("LBC", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_addnewgroups.Location = new System.Drawing.Point(20, 103);
            this.link_addnewgroups.Name = "link_addnewgroups";
            this.link_addnewgroups.Size = new System.Drawing.Size(45, 22);
            this.link_addnewgroups.TabIndex = 6;
            this.link_addnewgroups.TabStop = true;
            this.link_addnewgroups.Text = "جديد";
            this.link_addnewgroups.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_addnewgroups_LinkClicked);
            // 
            // edt_category
            // 
            this.edt_category.AllowDrop = true;
            this.edt_category.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.edt_category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.edt_category.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_category.FormattingEnabled = true;
            this.edt_category.Location = new System.Drawing.Point(18, 134);
            this.edt_category.Name = "edt_category";
            this.edt_category.Size = new System.Drawing.Size(374, 34);
            this.edt_category.TabIndex = 5;
            this.edt_category.SelectedIndexChanged += new System.EventHandler(this.combo_groups_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.edt_description);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_barcodegenerator);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.link_addnewgroups);
            this.groupBox1.Controls.Add(this.edt_barcode);
            this.groupBox1.Controls.Add(this.edt_quantity);
            this.groupBox1.Controls.Add(this.edt_name);
            this.groupBox1.Controls.Add(this.edt_supplier);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.edt_category);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(713, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(418, 594);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "خصائص المادة";
            // 
            // edt_description
            // 
            this.edt_description.Font = new System.Drawing.Font("LBC", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_description.Location = new System.Drawing.Point(7, 440);
            this.edt_description.Name = "edt_description";
            this.edt_description.Size = new System.Drawing.Size(387, 148);
            this.edt_description.TabIndex = 7;
            this.edt_description.Text = "";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.DimGray;
            this.label13.Location = new System.Drawing.Point(324, 411);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 26);
            this.label13.TabIndex = 1;
            this.label13.Text = "الوصف";
            this.label13.Click += new System.EventHandler(this.label5_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(331, 336);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 26);
            this.label5.TabIndex = 1;
            this.label5.Text = "الكمية";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(333, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 26);
            this.label4.TabIndex = 1;
            this.label4.Text = "باركود";
            // 
            // btn_barcodegenerator
            // 
            this.btn_barcodegenerator.AutoSize = true;
            this.btn_barcodegenerator.Font = new System.Drawing.Font("LBC", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_barcodegenerator.Location = new System.Drawing.Point(18, 264);
            this.btn_barcodegenerator.Name = "btn_barcodegenerator";
            this.btn_barcodegenerator.Size = new System.Drawing.Size(46, 22);
            this.btn_barcodegenerator.TabIndex = 6;
            this.btn_barcodegenerator.TabStop = true;
            this.btn_barcodegenerator.Text = "توليد";
            this.btn_barcodegenerator.Visible = false;
            this.btn_barcodegenerator.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btn_barcodegenerator_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("LBC", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(20, 185);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(45, 22);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "جديد";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // edt_barcode
            // 
            this.edt_barcode.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_barcode.Location = new System.Drawing.Point(18, 296);
            this.edt_barcode.Name = "edt_barcode";
            this.edt_barcode.Size = new System.Drawing.Size(374, 33);
            this.edt_barcode.TabIndex = 2;
            this.edt_barcode.Text = "0A";
            this.edt_barcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.edt_barcode.TextChanged += new System.EventHandler(this.edt_barcode_TextChanged);
            // 
            // edt_quantity
            // 
            this.edt_quantity.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_quantity.Location = new System.Drawing.Point(18, 368);
            this.edt_quantity.Name = "edt_quantity";
            this.edt_quantity.Size = new System.Drawing.Size(374, 33);
            this.edt_quantity.TabIndex = 2;
            this.edt_quantity.Text = "1";
            this.edt_quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.edt_quantity.TextChanged += new System.EventHandler(this.edt_quantity_TextChanged);
            // 
            // edt_supplier
            // 
            this.edt_supplier.AllowDrop = true;
            this.edt_supplier.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.edt_supplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.edt_supplier.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_supplier.FormattingEnabled = true;
            this.edt_supplier.Location = new System.Drawing.Point(20, 219);
            this.edt_supplier.Name = "edt_supplier";
            this.edt_supplier.Size = new System.Drawing.Size(374, 34);
            this.edt_supplier.TabIndex = 5;
            this.edt_supplier.SelectedIndexChanged += new System.EventHandler(this.edt_supplier_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(330, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 26);
            this.label3.TabIndex = 1;
            this.label3.Text = "المورد";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox7);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(686, 594);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "السعر";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.btn_changeconvertvalue);
            this.groupBox4.Controls.Add(this.edt_convertvalue);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Location = new System.Drawing.Point(317, 32);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(346, 505);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "البيع";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.edt_creditbuysecondry);
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Controls.Add(this.edt_creditbuyprimary);
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Location = new System.Drawing.Point(31, 227);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(279, 146);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "اجل";
            // 
            // edt_creditbuysecondry
            // 
            this.edt_creditbuysecondry.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_creditbuysecondry.Location = new System.Drawing.Point(59, 90);
            this.edt_creditbuysecondry.Name = "edt_creditbuysecondry";
            this.edt_creditbuysecondry.Size = new System.Drawing.Size(193, 33);
            this.edt_creditbuysecondry.TabIndex = 2;
            this.edt_creditbuysecondry.Text = "0";
            this.edt_creditbuysecondry.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.edt_creditbuysecondry.TextChanged += new System.EventHandler(this.edt_creditbuysecondry_TextChanged);
            this.edt_creditbuysecondry.DoubleClick += new System.EventHandler(this.edt_creditbuysecondry_DoubleClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("LBC", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label10.Location = new System.Drawing.Point(4, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 22);
            this.label10.TabIndex = 1;
            this.label10.Text = "دولار";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // edt_creditbuyprimary
            // 
            this.edt_creditbuyprimary.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_creditbuyprimary.Location = new System.Drawing.Point(59, 38);
            this.edt_creditbuyprimary.Name = "edt_creditbuyprimary";
            this.edt_creditbuyprimary.Size = new System.Drawing.Size(193, 33);
            this.edt_creditbuyprimary.TabIndex = 2;
            this.edt_creditbuyprimary.Text = "0";
            this.edt_creditbuyprimary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.edt_creditbuyprimary.TextChanged += new System.EventHandler(this.edt_creditbuyprimary_TextChanged);
            this.edt_creditbuyprimary.DoubleClick += new System.EventHandler(this.edt_creditbuyprimary_DoubleClick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("LBC", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label11.Location = new System.Drawing.Point(4, 39);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 22);
            this.label11.TabIndex = 1;
            this.label11.Text = "دينار";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.DimGray;
            this.label18.Location = new System.Drawing.Point(67, 412);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(229, 26);
            this.label18.TabIndex = 1;
            this.label18.Text = "قيمة التحويل بين العملتين:";
            // 
            // btn_changeconvertvalue
            // 
            this.btn_changeconvertvalue.AutoSize = true;
            this.btn_changeconvertvalue.Font = new System.Drawing.Font("LBC", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_changeconvertvalue.Location = new System.Drawing.Point(13, 457);
            this.btn_changeconvertvalue.Name = "btn_changeconvertvalue";
            this.btn_changeconvertvalue.Size = new System.Drawing.Size(44, 22);
            this.btn_changeconvertvalue.TabIndex = 6;
            this.btn_changeconvertvalue.TabStop = true;
            this.btn_changeconvertvalue.Text = "تغيير";
            this.btn_changeconvertvalue.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btn_changeconvertvalue_LinkClicked);
            // 
            // edt_convertvalue
            // 
            this.edt_convertvalue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.edt_convertvalue.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_convertvalue.ForeColor = System.Drawing.Color.Teal;
            this.edt_convertvalue.Location = new System.Drawing.Point(65, 448);
            this.edt_convertvalue.Name = "edt_convertvalue";
            this.edt_convertvalue.Size = new System.Drawing.Size(245, 38);
            this.edt_convertvalue.TabIndex = 1;
            this.edt_convertvalue.Text = "0.000";
            this.edt_convertvalue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.edt_cahbuysecondry);
            this.groupBox5.Controls.Add(this.edt_secondryunit);
            this.groupBox5.Controls.Add(this.edt_cashbuyprimary);
            this.groupBox5.Controls.Add(this.edt_primaryunit);
            this.groupBox5.Location = new System.Drawing.Point(31, 75);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(279, 146);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "نقدا";
            // 
            // edt_cahbuysecondry
            // 
            this.edt_cahbuysecondry.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_cahbuysecondry.Location = new System.Drawing.Point(59, 90);
            this.edt_cahbuysecondry.Name = "edt_cahbuysecondry";
            this.edt_cahbuysecondry.Size = new System.Drawing.Size(193, 33);
            this.edt_cahbuysecondry.TabIndex = 2;
            this.edt_cahbuysecondry.Text = "0";
            this.edt_cahbuysecondry.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.edt_cahbuysecondry.TextChanged += new System.EventHandler(this.edt_cahbuysecondry_TextChanged);
            this.edt_cahbuysecondry.DoubleClick += new System.EventHandler(this.edt_cahbuysecondry_DoubleClick);
            // 
            // edt_secondryunit
            // 
            this.edt_secondryunit.AutoSize = true;
            this.edt_secondryunit.Font = new System.Drawing.Font("LBC", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_secondryunit.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.edt_secondryunit.Location = new System.Drawing.Point(4, 91);
            this.edt_secondryunit.Name = "edt_secondryunit";
            this.edt_secondryunit.Size = new System.Drawing.Size(46, 22);
            this.edt_secondryunit.TabIndex = 1;
            this.edt_secondryunit.Text = "دولار";
            this.edt_secondryunit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.edt_secondryunit.Click += new System.EventHandler(this.edt_secondryunit_Click);
            // 
            // edt_cashbuyprimary
            // 
            this.edt_cashbuyprimary.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_cashbuyprimary.Location = new System.Drawing.Point(59, 38);
            this.edt_cashbuyprimary.Name = "edt_cashbuyprimary";
            this.edt_cashbuyprimary.Size = new System.Drawing.Size(193, 33);
            this.edt_cashbuyprimary.TabIndex = 2;
            this.edt_cashbuyprimary.Text = "0";
            this.edt_cashbuyprimary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.edt_cashbuyprimary.TextChanged += new System.EventHandler(this.edt_cashbuyprimary_TextChanged);
            this.edt_cashbuyprimary.DoubleClick += new System.EventHandler(this.edt_cashbuyprimary_DoubleClick);
            // 
            // edt_primaryunit
            // 
            this.edt_primaryunit.AutoSize = true;
            this.edt_primaryunit.Font = new System.Drawing.Font("LBC", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_primaryunit.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.edt_primaryunit.Location = new System.Drawing.Point(4, 39);
            this.edt_primaryunit.Name = "edt_primaryunit";
            this.edt_primaryunit.Size = new System.Drawing.Size(41, 22);
            this.edt_primaryunit.TabIndex = 1;
            this.edt_primaryunit.Text = "دينار";
            this.edt_primaryunit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label17);
            this.groupBox7.Controls.Add(this.label15);
            this.groupBox7.Controls.Add(this.label12);
            this.groupBox7.Controls.Add(this.edt_benfit);
            this.groupBox7.Controls.Add(this.edt_sellall);
            this.groupBox7.Controls.Add(this.edt_buyall);
            this.groupBox7.Location = new System.Drawing.Point(12, 296);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(279, 292);
            this.groupBox7.TabIndex = 3;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "ملخص (عملة رئيسية نقدا)";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.DimGray;
            this.label17.Location = new System.Drawing.Point(108, 205);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(62, 26);
            this.label17.TabIndex = 1;
            this.label17.Text = "الارباح";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.DimGray;
            this.label15.Location = new System.Drawing.Point(80, 121);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(139, 26);
            this.label15.TabIndex = 1;
            this.label15.Text = "سعر البيع الكلي";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DimGray;
            this.label12.Location = new System.Drawing.Point(75, 37);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(151, 26);
            this.label12.TabIndex = 1;
            this.label12.Text = "سعر الشراء الكلي";
            // 
            // edt_benfit
            // 
            this.edt_benfit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.edt_benfit.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_benfit.ForeColor = System.Drawing.Color.Teal;
            this.edt_benfit.Location = new System.Drawing.Point(19, 242);
            this.edt_benfit.Name = "edt_benfit";
            this.edt_benfit.Size = new System.Drawing.Size(245, 38);
            this.edt_benfit.TabIndex = 1;
            this.edt_benfit.Text = "0.000";
            this.edt_benfit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.edt_benfit.Click += new System.EventHandler(this.edt_benfit_Click);
            // 
            // edt_sellall
            // 
            this.edt_sellall.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.edt_sellall.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_sellall.ForeColor = System.Drawing.Color.Teal;
            this.edt_sellall.Location = new System.Drawing.Point(19, 160);
            this.edt_sellall.Name = "edt_sellall";
            this.edt_sellall.Size = new System.Drawing.Size(245, 38);
            this.edt_sellall.TabIndex = 1;
            this.edt_sellall.Text = "0.000";
            this.edt_sellall.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.edt_sellall.TextChanged += new System.EventHandler(this.edt_sellall_TextChanged);
            this.edt_sellall.Click += new System.EventHandler(this.edt_sellall_Click);
            // 
            // edt_buyall
            // 
            this.edt_buyall.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.edt_buyall.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_buyall.ForeColor = System.Drawing.Color.Teal;
            this.edt_buyall.Location = new System.Drawing.Point(19, 76);
            this.edt_buyall.Name = "edt_buyall";
            this.edt_buyall.Size = new System.Drawing.Size(245, 38);
            this.edt_buyall.TabIndex = 1;
            this.edt_buyall.Text = "0.000";
            this.edt_buyall.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.edt_buyall.TextChanged += new System.EventHandler(this.edt_buyall_TextChanged);
            this.edt_buyall.Click += new System.EventHandler(this.edt_buyall_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radio_part);
            this.groupBox3.Controls.Add(this.radio_no);
            this.groupBox3.Controls.Add(this.radio_yes);
            this.groupBox3.Controls.Add(this.edt_supplierpaymentsec);
            this.groupBox3.Controls.Add(this.edt_supplierpayment);
            this.groupBox3.Controls.Add(this.edt_buysecondry);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.edt_buyprimary);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(20, 32);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(279, 258);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "شراء";
            // 
            // radio_part
            // 
            this.radio_part.AutoSize = true;
            this.radio_part.Font = new System.Drawing.Font("LBC", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_part.Location = new System.Drawing.Point(19, 128);
            this.radio_part.Name = "radio_part";
            this.radio_part.Size = new System.Drawing.Size(47, 21);
            this.radio_part.TabIndex = 3;
            this.radio_part.Text = "جزء";
            this.radio_part.UseVisualStyleBackColor = true;
            this.radio_part.CheckedChanged += new System.EventHandler(this.radio_part_CheckedChanged);
            // 
            // radio_no
            // 
            this.radio_no.AutoSize = true;
            this.radio_no.Font = new System.Drawing.Font("LBC", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_no.Location = new System.Drawing.Point(70, 130);
            this.radio_no.Name = "radio_no";
            this.radio_no.Size = new System.Drawing.Size(38, 21);
            this.radio_no.TabIndex = 3;
            this.radio_no.Text = "لا";
            this.radio_no.UseVisualStyleBackColor = true;
            this.radio_no.CheckedChanged += new System.EventHandler(this.radio_no_CheckedChanged);
            // 
            // radio_yes
            // 
            this.radio_yes.AutoSize = true;
            this.radio_yes.Checked = true;
            this.radio_yes.Font = new System.Drawing.Font("LBC", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_yes.Location = new System.Drawing.Point(110, 128);
            this.radio_yes.Name = "radio_yes";
            this.radio_yes.Size = new System.Drawing.Size(51, 21);
            this.radio_yes.TabIndex = 3;
            this.radio_yes.TabStop = true;
            this.radio_yes.Text = "نعم";
            this.radio_yes.UseVisualStyleBackColor = true;
            this.radio_yes.CheckedChanged += new System.EventHandler(this.radio_yes_CheckedChanged);
            // 
            // edt_supplierpaymentsec
            // 
            this.edt_supplierpaymentsec.Enabled = false;
            this.edt_supplierpaymentsec.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_supplierpaymentsec.Location = new System.Drawing.Point(59, 211);
            this.edt_supplierpaymentsec.Name = "edt_supplierpaymentsec";
            this.edt_supplierpaymentsec.Size = new System.Drawing.Size(193, 33);
            this.edt_supplierpaymentsec.TabIndex = 2;
            this.edt_supplierpaymentsec.Text = "0";
            this.edt_supplierpaymentsec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.edt_supplierpaymentsec.TextChanged += new System.EventHandler(this.edt_supplierpayment_TextChanged);
            this.edt_supplierpaymentsec.DoubleClick += new System.EventHandler(this.edt_supplierpaymentsec_DoubleClick);
            // 
            // edt_supplierpayment
            // 
            this.edt_supplierpayment.Enabled = false;
            this.edt_supplierpayment.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_supplierpayment.Location = new System.Drawing.Point(59, 154);
            this.edt_supplierpayment.Name = "edt_supplierpayment";
            this.edt_supplierpayment.Size = new System.Drawing.Size(193, 33);
            this.edt_supplierpayment.TabIndex = 2;
            this.edt_supplierpayment.Text = "0";
            this.edt_supplierpayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.edt_supplierpayment.TextChanged += new System.EventHandler(this.edt_supplierpayment_TextChanged);
            this.edt_supplierpayment.DoubleClick += new System.EventHandler(this.edt_supplierpayment_DoubleClick);
            // 
            // edt_buysecondry
            // 
            this.edt_buysecondry.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_buysecondry.Location = new System.Drawing.Point(59, 69);
            this.edt_buysecondry.Name = "edt_buysecondry";
            this.edt_buysecondry.Size = new System.Drawing.Size(193, 33);
            this.edt_buysecondry.TabIndex = 2;
            this.edt_buysecondry.Text = "0";
            this.edt_buysecondry.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.edt_buysecondry.TextChanged += new System.EventHandler(this.edt_buysecondry_TextChanged);
            this.edt_buysecondry.DoubleClick += new System.EventHandler(this.edt_buysecondry_DoubleClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("LBC", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label6.Location = new System.Drawing.Point(4, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 22);
            this.label6.TabIndex = 1;
            this.label6.Text = "دولار";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // edt_buyprimary
            // 
            this.edt_buyprimary.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_buyprimary.Location = new System.Drawing.Point(59, 31);
            this.edt_buyprimary.Name = "edt_buyprimary";
            this.edt_buyprimary.Size = new System.Drawing.Size(193, 33);
            this.edt_buyprimary.TabIndex = 2;
            this.edt_buyprimary.Text = "0";
            this.edt_buyprimary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.edt_buyprimary.TextChanged += new System.EventHandler(this.edt_buyprimary_TextChanged);
            this.edt_buyprimary.DoubleClick += new System.EventHandler(this.edt_buyprimary_DoubleClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("LBC", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label7.Location = new System.Drawing.Point(172, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "هل تم التسديد؟";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("LBC", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label14.Location = new System.Drawing.Point(6, 215);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 22);
            this.label14.TabIndex = 1;
            this.label14.Text = "دينار";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("LBC", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label9.Location = new System.Drawing.Point(4, 159);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 22);
            this.label9.TabIndex = 1;
            this.label9.Text = "دينار";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("LBC", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label8.Location = new System.Drawing.Point(4, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 22);
            this.label8.TabIndex = 1;
            this.label8.Text = "دينار";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Add_Buy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 704);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_message);
            this.Controls.Add(this.panel1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.ShowIcon = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Add_Buy";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "عملية شراء";
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.Add_Categories_Activated);
            this.Load += new System.EventHandler(this.Add_Buy_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.toastNotificationsManager1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox edt_name;
        public DevExpress.XtraEditors.SimpleButton btn_addclose;
        public DevExpress.XtraEditors.SimpleButton btn_add;
        private System.Windows.Forms.Label txt_message;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager toastNotificationsManager1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel link_addnewgroups;
        public System.Windows.Forms.ComboBox edt_category;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel btn_barcodegenerator;
        private System.Windows.Forms.LinkLabel linkLabel1;
        public System.Windows.Forms.TextBox edt_barcode;
        public System.Windows.Forms.ComboBox edt_supplier;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox edt_buyprimary;
        public System.Windows.Forms.TextBox edt_quantity;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox6;
        public System.Windows.Forms.TextBox edt_creditbuysecondry;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox edt_creditbuyprimary;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox5;
        public System.Windows.Forms.TextBox edt_cahbuysecondry;
        private System.Windows.Forms.Label edt_secondryunit;
        public System.Windows.Forms.TextBox edt_cashbuyprimary;
        private System.Windows.Forms.Label edt_primaryunit;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.TextBox edt_buysecondry;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.LinkLabel btn_changeconvertvalue;
        private System.Windows.Forms.Label edt_convertvalue;
        private System.Windows.Forms.RadioButton radio_part;
        private System.Windows.Forms.RadioButton radio_no;
        private System.Windows.Forms.RadioButton radio_yes;
        public System.Windows.Forms.TextBox edt_supplierpayment;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label edt_benfit;
        public System.Windows.Forms.Label edt_sellall;
        public System.Windows.Forms.Label edt_buyall;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.RichTextBox edt_description;
        public System.Windows.Forms.TextBox edt_supplierpaymentsec;
        private System.Windows.Forms.Label label14;
    }
}