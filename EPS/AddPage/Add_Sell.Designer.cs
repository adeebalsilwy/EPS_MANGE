
namespace EPS.AddPage
{
    partial class Add_Sell
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Sell));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_addclose = new DevExpress.XtraEditors.SimpleButton();
            this.btn_new = new DevExpress.XtraEditors.SimpleButton();
            this.btn_delete = new DevExpress.XtraEditors.SimpleButton();
            this.btn_edit = new DevExpress.XtraEditors.SimpleButton();
            this.btn_add = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.edt_customer = new System.Windows.Forms.TextBox();
            this.txt_message = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toastNotificationsManager1 = new DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label9 = new System.Windows.Forms.Label();
            this.edt_quantity = new System.Windows.Forms.TextBox();
            this.edt_name = new System.Windows.Forms.TextBox();
            this.txt_currentquantity = new System.Windows.Forms.Label();
            this.customerbalance = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.btn_changeconvertvalue = new System.Windows.Forms.LinkLabel();
            this.edt_convertvalue = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ch_part = new System.Windows.Forms.RadioButton();
            this.ch_no = new System.Windows.Forms.RadioButton();
            this.ch_yes = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.edt_customerbalance = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.edt_sellall = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ch_credit = new System.Windows.Forms.RadioButton();
            this.chk_cash = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.group_cash = new System.Windows.Forms.GroupBox();
            this.edt_cashbuyprimary = new System.Windows.Forms.TextBox();
            this.edt_primaryunit = new System.Windows.Forms.Label();
            this.group_credit = new System.Windows.Forms.GroupBox();
            this.edt_creditbuyprimary = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMatrialsName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSellState = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSellValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSellAllValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label13 = new System.Windows.Forms.Label();
            this.edt_payment1 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toastNotificationsManager1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.group_cash.SuspendLayout();
            this.group_credit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_addclose);
            this.panel1.Controls.Add(this.btn_new);
            this.panel1.Controls.Add(this.btn_delete);
            this.panel1.Controls.Add(this.btn_edit);
            this.panel1.Controls.Add(this.btn_add);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 611);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1142, 59);
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
            this.btn_addclose.Size = new System.Drawing.Size(246, 47);
            this.btn_addclose.TabIndex = 1;
            this.btn_addclose.Text = "انهاء وطباعة وصل";
            this.btn_addclose.Click += new System.EventHandler(this.btn_addclose_Click);
            // 
            // btn_new
            // 
            this.btn_new.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_new.Appearance.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new.Appearance.Options.UseFont = true;
            this.btn_new.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_new.ImageOptions.Image")));
            this.btn_new.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btn_new.Location = new System.Drawing.Point(393, 5);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(127, 47);
            this.btn_new.TabIndex = 1;
            this.btn_new.Text = "جديد";
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_delete.Appearance.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Appearance.Options.UseFont = true;
            this.btn_delete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete.ImageOptions.Image")));
            this.btn_delete.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btn_delete.Location = new System.Drawing.Point(733, 5);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(127, 47);
            this.btn_delete.TabIndex = 1;
            this.btn_delete.Text = "حذف";
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_edit.Appearance.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.Appearance.Options.UseFont = true;
            this.btn_edit.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btn_edit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_edit.ImageOptions.SvgImage")));
            this.btn_edit.Location = new System.Drawing.Point(869, 5);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(127, 47);
            this.btn_edit.TabIndex = 1;
            this.btn_edit.Text = "تعديل";
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_add
            // 
            this.btn_add.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_add.Appearance.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Appearance.Options.UseFont = true;
            this.btn_add.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_add.ImageOptions.Image")));
            this.btn_add.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btn_add.Location = new System.Drawing.Point(1005, 5);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(127, 47);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "اضافة";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(293, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "اسم المادة";
            // 
            // edt_customer
            // 
            this.edt_customer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.edt_customer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.edt_customer.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_customer.Location = new System.Drawing.Point(19, 252);
            this.edt_customer.Name = "edt_customer";
            this.edt_customer.Size = new System.Drawing.Size(374, 33);
            this.edt_customer.TabIndex = 2;
            this.edt_customer.Text = "بدون";
            this.edt_customer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.edt_customer.TextChanged += new System.EventHandler(this.edt_customer_TextChanged);
            // 
            // txt_message
            // 
            this.txt_message.BackColor = System.Drawing.Color.Teal;
            this.txt_message.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txt_message.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_message.ForeColor = System.Drawing.Color.White;
            this.txt_message.Location = new System.Drawing.Point(0, 571);
            this.txt_message.Name = "txt_message";
            this.txt_message.Size = new System.Drawing.Size(1142, 40);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.edt_quantity);
            this.groupBox1.Controls.Add(this.edt_name);
            this.groupBox1.Controls.Add(this.txt_currentquantity);
            this.groupBox1.Controls.Add(this.customerbalance);
            this.groupBox1.Controls.Add(this.edt_customer);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(713, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(418, 411);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "خصائص المادة";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(239, 180);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 26);
            this.label8.TabIndex = 1;
            this.label8.Text = "الكمية في المخزن";
            this.label8.Click += new System.EventHandler(this.label5_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(330, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 26);
            this.label5.TabIndex = 1;
            this.label5.Text = "الكمية";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(121, 290);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 26);
            this.label7.TabIndex = 1;
            this.label7.Text = "رصيد العميل الحالي";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("LBC", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(17, 225);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(45, 22);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "جديد";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label9.Location = new System.Drawing.Point(19, 337);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 26);
            this.label9.TabIndex = 1;
            this.label9.Text = "دينار";
            // 
            // edt_quantity
            // 
            this.edt_quantity.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_quantity.Location = new System.Drawing.Point(17, 141);
            this.edt_quantity.Name = "edt_quantity";
            this.edt_quantity.Size = new System.Drawing.Size(374, 33);
            this.edt_quantity.TabIndex = 2;
            this.edt_quantity.Text = "1";
            this.edt_quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.edt_quantity.TextChanged += new System.EventHandler(this.edt_quantity_TextChanged);
            // 
            // edt_name
            // 
            this.edt_name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.edt_name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.edt_name.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_name.Location = new System.Drawing.Point(20, 64);
            this.edt_name.Name = "edt_name";
            this.edt_name.Size = new System.Drawing.Size(374, 33);
            this.edt_name.TabIndex = 2;
            this.edt_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.edt_name.TextChanged += new System.EventHandler(this.edt_name_TextChanged);
            // 
            // txt_currentquantity
            // 
            this.txt_currentquantity.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_currentquantity.ForeColor = System.Drawing.Color.Red;
            this.txt_currentquantity.Location = new System.Drawing.Point(19, 180);
            this.txt_currentquantity.Name = "txt_currentquantity";
            this.txt_currentquantity.Size = new System.Drawing.Size(214, 38);
            this.txt_currentquantity.TabIndex = 1;
            this.txt_currentquantity.Text = "0.000";
            this.txt_currentquantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txt_currentquantity.TextChanged += new System.EventHandler(this.edt_sellall_TextChanged);
            this.txt_currentquantity.Click += new System.EventHandler(this.edt_sellall_Click);
            // 
            // customerbalance
            // 
            this.customerbalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.customerbalance.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerbalance.ForeColor = System.Drawing.Color.Teal;
            this.customerbalance.Location = new System.Drawing.Point(85, 331);
            this.customerbalance.Name = "customerbalance";
            this.customerbalance.Size = new System.Drawing.Size(245, 38);
            this.customerbalance.TabIndex = 1;
            this.customerbalance.Text = "0.000";
            this.customerbalance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.customerbalance.TextChanged += new System.EventHandler(this.edt_sellall_TextChanged);
            this.customerbalance.Click += new System.EventHandler(this.edt_sellall_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(329, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 26);
            this.label3.TabIndex = 1;
            this.label3.Text = "العميل";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.groupBox7);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.btn_changeconvertvalue);
            this.groupBox2.Controls.Add(this.edt_convertvalue);
            this.groupBox2.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(686, 411);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "السعر";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.DimGray;
            this.label18.Location = new System.Drawing.Point(368, 295);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(229, 26);
            this.label18.TabIndex = 7;
            this.label18.Text = "قيمة التحويل بين العملتين:";
            // 
            // btn_changeconvertvalue
            // 
            this.btn_changeconvertvalue.AutoSize = true;
            this.btn_changeconvertvalue.Font = new System.Drawing.Font("LBC", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_changeconvertvalue.Location = new System.Drawing.Point(314, 340);
            this.btn_changeconvertvalue.Name = "btn_changeconvertvalue";
            this.btn_changeconvertvalue.Size = new System.Drawing.Size(44, 22);
            this.btn_changeconvertvalue.TabIndex = 9;
            this.btn_changeconvertvalue.TabStop = true;
            this.btn_changeconvertvalue.Text = "تغيير";
            this.btn_changeconvertvalue.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btn_changeconvertvalue_LinkClicked);
            // 
            // edt_convertvalue
            // 
            this.edt_convertvalue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.edt_convertvalue.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_convertvalue.ForeColor = System.Drawing.Color.Teal;
            this.edt_convertvalue.Location = new System.Drawing.Point(366, 331);
            this.edt_convertvalue.Name = "edt_convertvalue";
            this.edt_convertvalue.Size = new System.Drawing.Size(245, 38);
            this.edt_convertvalue.TabIndex = 8;
            this.edt_convertvalue.Text = "0.000";
            this.edt_convertvalue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.groupBox3);
            this.groupBox7.Controls.Add(this.label16);
            this.groupBox7.Controls.Add(this.label2);
            this.groupBox7.Controls.Add(this.label15);
            this.groupBox7.Controls.Add(this.edt_payment1);
            this.groupBox7.Controls.Add(this.edt_customerbalance);
            this.groupBox7.Controls.Add(this.label13);
            this.groupBox7.Controls.Add(this.label6);
            this.groupBox7.Controls.Add(this.label4);
            this.groupBox7.Controls.Add(this.edt_sellall);
            this.groupBox7.Location = new System.Drawing.Point(6, 37);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(279, 342);
            this.groupBox7.TabIndex = 3;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "ملخص";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ch_part);
            this.groupBox3.Controls.Add(this.ch_no);
            this.groupBox3.Controls.Add(this.ch_yes);
            this.groupBox3.Location = new System.Drawing.Point(13, 126);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(245, 65);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // ch_part
            // 
            this.ch_part.AutoSize = true;
            this.ch_part.Location = new System.Drawing.Point(18, 25);
            this.ch_part.Name = "ch_part";
            this.ch_part.Size = new System.Drawing.Size(61, 30);
            this.ch_part.TabIndex = 9;
            this.ch_part.Text = "جزء";
            this.ch_part.UseVisualStyleBackColor = true;
            this.ch_part.CheckedChanged += new System.EventHandler(this.ch_part_CheckedChanged);
            // 
            // ch_no
            // 
            this.ch_no.AutoSize = true;
            this.ch_no.Location = new System.Drawing.Point(97, 25);
            this.ch_no.Name = "ch_no";
            this.ch_no.Size = new System.Drawing.Size(46, 30);
            this.ch_no.TabIndex = 9;
            this.ch_no.Text = "لا";
            this.ch_no.UseVisualStyleBackColor = true;
            this.ch_no.CheckedChanged += new System.EventHandler(this.ch_no_CheckedChanged);
            // 
            // ch_yes
            // 
            this.ch_yes.AutoSize = true;
            this.ch_yes.Checked = true;
            this.ch_yes.Location = new System.Drawing.Point(167, 25);
            this.ch_yes.Name = "ch_yes";
            this.ch_yes.Size = new System.Drawing.Size(64, 30);
            this.ch_yes.TabIndex = 9;
            this.ch_yes.TabStop = true;
            this.ch_yes.Text = "نعم";
            this.ch_yes.UseVisualStyleBackColor = true;
            this.ch_yes.CheckedChanged += new System.EventHandler(this.ch_yes_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(68, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "هل تم التسديد؟";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.DimGray;
            this.label15.Location = new System.Drawing.Point(77, 24);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(139, 26);
            this.label15.TabIndex = 1;
            this.label15.Text = "سعر البيع الكلي";
            // 
            // edt_customerbalance
            // 
            this.edt_customerbalance.Enabled = false;
            this.edt_customerbalance.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_customerbalance.Location = new System.Drawing.Point(56, 203);
            this.edt_customerbalance.Name = "edt_customerbalance";
            this.edt_customerbalance.Size = new System.Drawing.Size(193, 33);
            this.edt_customerbalance.TabIndex = 2;
            this.edt_customerbalance.Text = "0";
            this.edt_customerbalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.edt_customerbalance.TextChanged += new System.EventHandler(this.edt_customerbalance_TextChanged);
            this.edt_customerbalance.DoubleClick += new System.EventHandler(this.edt_customerbalance_DoubleClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("LBC", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label6.Location = new System.Drawing.Point(6, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 22);
            this.label6.TabIndex = 1;
            this.label6.Text = "دينار";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("LBC", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label4.Location = new System.Drawing.Point(1, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 22);
            this.label4.TabIndex = 1;
            this.label4.Text = "دينار";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // edt_sellall
            // 
            this.edt_sellall.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.edt_sellall.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_sellall.ForeColor = System.Drawing.Color.Teal;
            this.edt_sellall.Location = new System.Drawing.Point(16, 63);
            this.edt_sellall.Name = "edt_sellall";
            this.edt_sellall.Size = new System.Drawing.Size(245, 38);
            this.edt_sellall.TabIndex = 1;
            this.edt_sellall.Text = "0.000";
            this.edt_sellall.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.edt_sellall.TextChanged += new System.EventHandler(this.edt_sellall_TextChanged);
            this.edt_sellall.Click += new System.EventHandler(this.edt_sellall_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ch_credit);
            this.groupBox4.Controls.Add(this.chk_cash);
            this.groupBox4.Controls.Add(this.panel2);
            this.groupBox4.Location = new System.Drawing.Point(317, 29);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(346, 258);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "البيع";
            // 
            // ch_credit
            // 
            this.ch_credit.AutoSize = true;
            this.ch_credit.Location = new System.Drawing.Point(173, 35);
            this.ch_credit.Name = "ch_credit";
            this.ch_credit.Size = new System.Drawing.Size(63, 30);
            this.ch_credit.TabIndex = 9;
            this.ch_credit.Text = "اجل";
            this.ch_credit.UseVisualStyleBackColor = true;
            this.ch_credit.CheckedChanged += new System.EventHandler(this.ch_credit_CheckedChanged);
            // 
            // chk_cash
            // 
            this.chk_cash.AutoSize = true;
            this.chk_cash.Checked = true;
            this.chk_cash.Location = new System.Drawing.Point(258, 32);
            this.chk_cash.Name = "chk_cash";
            this.chk_cash.Size = new System.Drawing.Size(69, 30);
            this.chk_cash.TabIndex = 9;
            this.chk_cash.TabStop = true;
            this.chk_cash.Text = "نقدا";
            this.chk_cash.UseVisualStyleBackColor = true;
            this.chk_cash.CheckedChanged += new System.EventHandler(this.chk_cash_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.group_cash);
            this.panel2.Controls.Add(this.group_credit);
            this.panel2.Location = new System.Drawing.Point(13, 76);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(314, 166);
            this.panel2.TabIndex = 8;
            // 
            // group_cash
            // 
            this.group_cash.Controls.Add(this.edt_cashbuyprimary);
            this.group_cash.Controls.Add(this.edt_primaryunit);
            this.group_cash.Location = new System.Drawing.Point(18, 3);
            this.group_cash.Name = "group_cash";
            this.group_cash.Size = new System.Drawing.Size(279, 146);
            this.group_cash.TabIndex = 3;
            this.group_cash.TabStop = false;
            this.group_cash.Text = "نقدا";
            // 
            // edt_cashbuyprimary
            // 
            this.edt_cashbuyprimary.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_cashbuyprimary.Location = new System.Drawing.Point(59, 72);
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
            this.edt_primaryunit.Location = new System.Drawing.Point(4, 73);
            this.edt_primaryunit.Name = "edt_primaryunit";
            this.edt_primaryunit.Size = new System.Drawing.Size(41, 22);
            this.edt_primaryunit.TabIndex = 1;
            this.edt_primaryunit.Text = "دينار";
            this.edt_primaryunit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // group_credit
            // 
            this.group_credit.Controls.Add(this.edt_creditbuyprimary);
            this.group_credit.Controls.Add(this.label11);
            this.group_credit.Location = new System.Drawing.Point(18, 3);
            this.group_credit.Name = "group_credit";
            this.group_credit.Size = new System.Drawing.Size(279, 146);
            this.group_credit.TabIndex = 3;
            this.group_credit.TabStop = false;
            this.group_credit.Text = "اجل";
            // 
            // edt_creditbuyprimary
            // 
            this.edt_creditbuyprimary.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_creditbuyprimary.Location = new System.Drawing.Point(59, 69);
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
            this.label11.Location = new System.Drawing.Point(4, 70);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 22);
            this.label11.TabIndex = 1;
            this.label11.Text = "دينار";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = typeof(EPS.TB_SellData);
            this.gridControl1.Location = new System.Drawing.Point(7, 421);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gridControl1.Size = new System.Drawing.Size(1134, 150);
            this.gridControl1.TabIndex = 8;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FocusedRow.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.FocusedRow.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Appearance.Row.Options.UseTextOptions = true;
            this.gridView1.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.AppearancePrint.EvenRow.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.AppearancePrint.EvenRow.Options.UseFont = true;
            this.gridView1.AppearancePrint.FilterPanel.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.AppearancePrint.FilterPanel.Options.UseFont = true;
            this.gridView1.AppearancePrint.FooterPanel.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.AppearancePrint.FooterPanel.Options.UseFont = true;
            this.gridView1.AppearancePrint.GroupFooter.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.AppearancePrint.GroupFooter.Options.UseFont = true;
            this.gridView1.AppearancePrint.GroupRow.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.AppearancePrint.GroupRow.Options.UseFont = true;
            this.gridView1.AppearancePrint.HeaderPanel.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.AppearancePrint.HeaderPanel.Options.UseFont = true;
            this.gridView1.AppearancePrint.Lines.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.AppearancePrint.Lines.Options.UseFont = true;
            this.gridView1.AppearancePrint.OddRow.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.AppearancePrint.OddRow.Options.UseFont = true;
            this.gridView1.AppearancePrint.Preview.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.AppearancePrint.Preview.Options.UseFont = true;
            this.gridView1.AppearancePrint.Row.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.AppearancePrint.Row.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMatrialsName,
            this.colQuantity,
            this.colCustomerName,
            this.colSellState,
            this.colSellValue,
            this.colSellAllValue});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsPrint.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsPrint.EnableAppearanceOddRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colMatrialsName
            // 
            this.colMatrialsName.Caption = "اسم المادة";
            this.colMatrialsName.FieldName = "MatrialsName";
            this.colMatrialsName.MinWidth = 25;
            this.colMatrialsName.Name = "colMatrialsName";
            this.colMatrialsName.OptionsColumn.AllowEdit = false;
            this.colMatrialsName.Visible = true;
            this.colMatrialsName.VisibleIndex = 0;
            this.colMatrialsName.Width = 94;
            // 
            // colQuantity
            // 
            this.colQuantity.Caption = "الكمية";
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.MinWidth = 25;
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.OptionsColumn.AllowEdit = false;
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 1;
            this.colQuantity.Width = 94;
            // 
            // colCustomerName
            // 
            this.colCustomerName.Caption = "اسم العميل";
            this.colCustomerName.FieldName = "CustomerName";
            this.colCustomerName.MinWidth = 25;
            this.colCustomerName.Name = "colCustomerName";
            this.colCustomerName.OptionsColumn.AllowEdit = false;
            this.colCustomerName.Visible = true;
            this.colCustomerName.VisibleIndex = 2;
            this.colCustomerName.Width = 94;
            // 
            // colSellState
            // 
            this.colSellState.Caption = "حالة البيع";
            this.colSellState.FieldName = "SellState";
            this.colSellState.MinWidth = 25;
            this.colSellState.Name = "colSellState";
            this.colSellState.OptionsColumn.AllowEdit = false;
            this.colSellState.Visible = true;
            this.colSellState.VisibleIndex = 3;
            this.colSellState.Width = 94;
            // 
            // colSellValue
            // 
            this.colSellValue.Caption = "سعر البيع عملة رئيسة";
            this.colSellValue.FieldName = "SellValue";
            this.colSellValue.MinWidth = 25;
            this.colSellValue.Name = "colSellValue";
            this.colSellValue.OptionsColumn.AllowEdit = false;
            this.colSellValue.Visible = true;
            this.colSellValue.VisibleIndex = 4;
            this.colSellValue.Width = 94;
            // 
            // colSellAllValue
            // 
            this.colSellAllValue.Caption = "السعر الكلي";
            this.colSellAllValue.FieldName = "SellAllValue";
            this.colSellAllValue.MinWidth = 25;
            this.colSellAllValue.Name = "colSellAllValue";
            this.colSellAllValue.OptionsColumn.AllowEdit = false;
            this.colSellAllValue.Visible = true;
            this.colSellAllValue.VisibleIndex = 5;
            this.colSellAllValue.Width = 94;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("LBC", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label13.Location = new System.Drawing.Point(0, 298);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 22);
            this.label13.TabIndex = 1;
            this.label13.Text = "دينار";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // edt_payment1
            // 
            this.edt_payment1.Enabled = false;
            this.edt_payment1.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_payment1.Location = new System.Drawing.Point(51, 294);
            this.edt_payment1.Name = "edt_payment1";
            this.edt_payment1.Size = new System.Drawing.Size(193, 33);
            this.edt_payment1.TabIndex = 2;
            this.edt_payment1.Text = "0";
            this.edt_payment1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.edt_payment1.DoubleClick += new System.EventHandler(this.edt_payment1_DoubleClick);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.DimGray;
            this.label16.Location = new System.Drawing.Point(73, 262);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(141, 26);
            this.label16.TabIndex = 1;
            this.label16.Text = "الدفعة الشهرية";
            // 
            // Add_Sell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 670);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_message);
            this.Controls.Add(this.panel1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.ShowIcon = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Add_Sell";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "عملية بيع";
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.Add_Categories_Activated);
            this.Load += new System.EventHandler(this.Add_Sell_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.toastNotificationsManager1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.group_cash.ResumeLayout(false);
            this.group_cash.PerformLayout();
            this.group_credit.ResumeLayout(false);
            this.group_credit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox edt_customer;
        public DevExpress.XtraEditors.SimpleButton btn_addclose;
        public DevExpress.XtraEditors.SimpleButton btn_add;
        private System.Windows.Forms.Label txt_message;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager toastNotificationsManager1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.TextBox edt_quantity;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox group_credit;
        public System.Windows.Forms.TextBox edt_creditbuyprimary;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox group_cash;
        public System.Windows.Forms.TextBox edt_cashbuyprimary;
        private System.Windows.Forms.Label edt_primaryunit;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label15;
        public System.Windows.Forms.Label edt_sellall;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox edt_customerbalance;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox edt_name;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.LinkLabel btn_changeconvertvalue;
        private System.Windows.Forms.Label edt_convertvalue;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton ch_credit;
        private System.Windows.Forms.RadioButton chk_cash;
        private System.Windows.Forms.RadioButton ch_part;
        private System.Windows.Forms.RadioButton ch_no;
        private System.Windows.Forms.RadioButton ch_yes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label customerbalance;
        private DevExpress.XtraGrid.Columns.GridColumn colMatrialsName;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerName;
        private DevExpress.XtraGrid.Columns.GridColumn colSellState;
        private DevExpress.XtraGrid.Columns.GridColumn colSellValue;
        private DevExpress.XtraGrid.Columns.GridColumn colSellAllValue;
        public DevExpress.XtraEditors.SimpleButton btn_delete;
        public DevExpress.XtraEditors.SimpleButton btn_new;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label txt_currentquantity;
        public DevExpress.XtraEditors.SimpleButton btn_edit;
        private System.Windows.Forms.Label label16;
        public System.Windows.Forms.TextBox edt_payment1;
        private System.Windows.Forms.Label label13;
    }
}