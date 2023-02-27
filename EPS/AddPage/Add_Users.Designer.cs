
namespace EPS.AddPage
{
    partial class Add_Users
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Users));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_addclose = new DevExpress.XtraEditors.SimpleButton();
            this.btn_add = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.edt_name = new System.Windows.Forms.TextBox();
            this.txt_message = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toastNotificationsManager1 = new DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.edt_username = new System.Windows.Forms.TextBox();
            this.edt_password = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pic_profile = new DevExpress.XtraEditors.PictureEdit();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ch_main = new System.Windows.Forms.CheckBox();
            this.ch_sal = new System.Windows.Forms.CheckBox();
            this.ch_gr = new System.Windows.Forms.CheckBox();
            this.ch_cat = new System.Windows.Forms.CheckBox();
            this.ch_py = new System.Windows.Forms.CheckBox();
            this.ch_cast = new System.Windows.Forms.CheckBox();
            this.ch_sup = new System.Windows.Forms.CheckBox();
            this.ch_resp = new System.Windows.Forms.CheckBox();
            this.ch_ana = new System.Windows.Forms.CheckBox();
            this.ch_use = new System.Windows.Forms.CheckBox();
            this.ch_sett = new System.Windows.Forms.CheckBox();
            this.ch_add = new System.Windows.Forms.CheckBox();
            this.ch_del = new System.Windows.Forms.CheckBox();
            this.ch_up = new System.Windows.Forms.CheckBox();
            this.ch_riges = new System.Windows.Forms.CheckBox();
            this.ch_acti = new System.Windows.Forms.CheckBox();
            this.ch_help = new System.Windows.Forms.CheckBox();
            this.ch_apu = new System.Windows.Forms.CheckBox();
            this.checkBox20 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.com_priv = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toastNotificationsManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_profile.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_addclose);
            this.panel1.Controls.Add(this.btn_add);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 478);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(860, 48);
            this.panel1.TabIndex = 0;
            // 
            // btn_addclose
            // 
            this.btn_addclose.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_addclose.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addclose.Appearance.Options.UseFont = true;
            this.btn_addclose.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btn_addclose.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_addclose.ImageOptions.SvgImage")));
            this.btn_addclose.Location = new System.Drawing.Point(5, 4);
            this.btn_addclose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_addclose.Name = "btn_addclose";
            this.btn_addclose.Size = new System.Drawing.Size(143, 38);
            this.btn_addclose.TabIndex = 1;
            this.btn_addclose.Text = "اضافة+ غلق";
            this.btn_addclose.Click += new System.EventHandler(this.btn_addclose_Click);
            // 
            // btn_add
            // 
            this.btn_add.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_add.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Appearance.Options.UseFont = true;
            this.btn_add.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btn_add.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_add.ImageOptions.SvgImage")));
            this.btn_add.Location = new System.Drawing.Point(525, 4);
            this.btn_add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(327, 38);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "اضافة";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(571, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "الاسم الكامل";
            // 
            // edt_name
            // 
            this.edt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_name.Location = new System.Drawing.Point(424, 46);
            this.edt_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.edt_name.Name = "edt_name";
            this.edt_name.Size = new System.Drawing.Size(407, 28);
            this.edt_name.TabIndex = 2;
            this.edt_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_message
            // 
            this.txt_message.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txt_message.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txt_message.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_message.ForeColor = System.Drawing.Color.White;
            this.txt_message.Location = new System.Drawing.Point(0, 436);
            this.txt_message.Name = "txt_message";
            this.txt_message.Size = new System.Drawing.Size(860, 42);
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
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(560, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "اسم المستخدم";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(583, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "كلمة السر";
            // 
            // edt_username
            // 
            this.edt_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_username.Location = new System.Drawing.Point(424, 113);
            this.edt_username.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.edt_username.Name = "edt_username";
            this.edt_username.Size = new System.Drawing.Size(407, 28);
            this.edt_username.TabIndex = 2;
            this.edt_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // edt_password
            // 
            this.edt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_password.Location = new System.Drawing.Point(424, 185);
            this.edt_password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.edt_password.Name = "edt_password";
            this.edt_password.Size = new System.Drawing.Size(407, 28);
            this.edt_password.TabIndex = 2;
            this.edt_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.edt_password.TextChanged += new System.EventHandler(this.edt_phonenumber_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(777, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 24);
            this.label5.TabIndex = 1;
            this.label5.Text = "صورة";
            // 
            // pic_profile
            // 
            this.pic_profile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pic_profile.EditValue = ((object)(resources.GetObject("pic_profile.EditValue")));
            this.pic_profile.Location = new System.Drawing.Point(508, 240);
            this.pic_profile.Margin = new System.Windows.Forms.Padding(4);
            this.pic_profile.Name = "pic_profile";
            this.pic_profile.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pic_profile.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pic_profile.Size = new System.Drawing.Size(189, 171);
            this.pic_profile.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Gray;
            this.groupBox1.Location = new System.Drawing.Point(29, 29);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(368, 322);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "الصلاحيات( النسخة الحالية لا تدعم تعدد الصلاحيات)";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.ch_main);
            this.flowLayoutPanel1.Controls.Add(this.ch_sal);
            this.flowLayoutPanel1.Controls.Add(this.ch_gr);
            this.flowLayoutPanel1.Controls.Add(this.ch_cat);
            this.flowLayoutPanel1.Controls.Add(this.ch_py);
            this.flowLayoutPanel1.Controls.Add(this.ch_cast);
            this.flowLayoutPanel1.Controls.Add(this.ch_sup);
            this.flowLayoutPanel1.Controls.Add(this.ch_resp);
            this.flowLayoutPanel1.Controls.Add(this.ch_ana);
            this.flowLayoutPanel1.Controls.Add(this.ch_use);
            this.flowLayoutPanel1.Controls.Add(this.ch_sett);
            this.flowLayoutPanel1.Controls.Add(this.ch_add);
            this.flowLayoutPanel1.Controls.Add(this.ch_del);
            this.flowLayoutPanel1.Controls.Add(this.ch_up);
            this.flowLayoutPanel1.Controls.Add(this.ch_riges);
            this.flowLayoutPanel1.Controls.Add(this.ch_acti);
            this.flowLayoutPanel1.Controls.Add(this.ch_help);
            this.flowLayoutPanel1.Controls.Add(this.ch_apu);
            this.flowLayoutPanel1.Controls.Add(this.checkBox20);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Enabled = false;
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanel1.ForeColor = System.Drawing.Color.Black;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 18);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(362, 302);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // ch_main
            // 
            this.ch_main.AutoSize = true;
            this.ch_main.Checked = true;
            this.ch_main.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ch_main.Location = new System.Drawing.Point(271, 12);
            this.ch_main.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.ch_main.Name = "ch_main";
            this.ch_main.Size = new System.Drawing.Size(74, 24);
            this.ch_main.TabIndex = 0;
            this.ch_main.Text = "الرئيسة";
            this.ch_main.UseVisualStyleBackColor = true;
            // 
            // ch_sal
            // 
            this.ch_sal.AutoSize = true;
            this.ch_sal.Location = new System.Drawing.Point(176, 12);
            this.ch_sal.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.ch_sal.Name = "ch_sal";
            this.ch_sal.Size = new System.Drawing.Size(77, 24);
            this.ch_sal.TabIndex = 1;
            this.ch_sal.Text = "المبيعات";
            this.ch_sal.UseVisualStyleBackColor = true;
            // 
            // ch_gr
            // 
            this.ch_gr.AutoSize = true;
            this.ch_gr.Location = new System.Drawing.Point(82, 12);
            this.ch_gr.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.ch_gr.Name = "ch_gr";
            this.ch_gr.Size = new System.Drawing.Size(76, 24);
            this.ch_gr.TabIndex = 2;
            this.ch_gr.Text = "المجاميع";
            this.ch_gr.UseVisualStyleBackColor = true;
            // 
            // ch_cat
            // 
            this.ch_cat.AutoSize = true;
            this.ch_cat.Location = new System.Drawing.Point(263, 52);
            this.ch_cat.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.ch_cat.Name = "ch_cat";
            this.ch_cat.Size = new System.Drawing.Size(82, 24);
            this.ch_cat.TabIndex = 3;
            this.ch_cat.Text = "الاصناف";
            this.ch_cat.UseVisualStyleBackColor = true;
            // 
            // ch_py
            // 
            this.ch_py.AutoSize = true;
            this.ch_py.Location = new System.Drawing.Point(156, 52);
            this.ch_py.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.ch_py.Name = "ch_py";
            this.ch_py.Size = new System.Drawing.Size(89, 24);
            this.ch_py.TabIndex = 4;
            this.ch_py.Text = "المشتريات";
            this.ch_py.UseVisualStyleBackColor = true;
            // 
            // ch_cast
            // 
            this.ch_cast.AutoSize = true;
            this.ch_cast.Location = new System.Drawing.Point(69, 52);
            this.ch_cast.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.ch_cast.Name = "ch_cast";
            this.ch_cast.Size = new System.Drawing.Size(69, 24);
            this.ch_cast.TabIndex = 5;
            this.ch_cast.Text = "العملاء";
            this.ch_cast.UseVisualStyleBackColor = true;
            // 
            // ch_sup
            // 
            this.ch_sup.AutoSize = true;
            this.ch_sup.Location = new System.Drawing.Point(265, 92);
            this.ch_sup.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.ch_sup.Name = "ch_sup";
            this.ch_sup.Size = new System.Drawing.Size(80, 24);
            this.ch_sup.TabIndex = 6;
            this.ch_sup.Text = "الموردين";
            this.ch_sup.UseVisualStyleBackColor = true;
            // 
            // ch_resp
            // 
            this.ch_resp.AutoSize = true;
            this.ch_resp.Location = new System.Drawing.Point(171, 92);
            this.ch_resp.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.ch_resp.Name = "ch_resp";
            this.ch_resp.Size = new System.Drawing.Size(76, 24);
            this.ch_resp.TabIndex = 8;
            this.ch_resp.Text = "التقارير";
            this.ch_resp.UseVisualStyleBackColor = true;
            // 
            // ch_ana
            // 
            this.ch_ana.AutoSize = true;
            this.ch_ana.Location = new System.Drawing.Point(84, 92);
            this.ch_ana.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.ch_ana.Name = "ch_ana";
            this.ch_ana.Size = new System.Drawing.Size(69, 24);
            this.ch_ana.TabIndex = 9;
            this.ch_ana.Text = "التحليل";
            this.ch_ana.UseVisualStyleBackColor = true;
            // 
            // ch_use
            // 
            this.ch_use.AutoSize = true;
            this.ch_use.Location = new System.Drawing.Point(252, 132);
            this.ch_use.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.ch_use.Name = "ch_use";
            this.ch_use.Size = new System.Drawing.Size(93, 24);
            this.ch_use.TabIndex = 10;
            this.ch_use.Text = "المستخدمين";
            this.ch_use.UseVisualStyleBackColor = true;
            // 
            // ch_sett
            // 
            this.ch_sett.AutoSize = true;
            this.ch_sett.Checked = true;
            this.ch_sett.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ch_sett.Location = new System.Drawing.Point(148, 132);
            this.ch_sett.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.ch_sett.Name = "ch_sett";
            this.ch_sett.Size = new System.Drawing.Size(86, 24);
            this.ch_sett.TabIndex = 11;
            this.ch_sett.Text = "الاعدادات";
            this.ch_sett.UseVisualStyleBackColor = true;
            // 
            // ch_add
            // 
            this.ch_add.AutoSize = true;
            this.ch_add.Location = new System.Drawing.Point(64, 132);
            this.ch_add.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.ch_add.Name = "ch_add";
            this.ch_add.Size = new System.Drawing.Size(66, 24);
            this.ch_add.TabIndex = 12;
            this.ch_add.Text = "اضافة";
            this.ch_add.UseVisualStyleBackColor = true;
            // 
            // ch_del
            // 
            this.ch_del.AutoSize = true;
            this.ch_del.Location = new System.Drawing.Point(288, 172);
            this.ch_del.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.ch_del.Name = "ch_del";
            this.ch_del.Size = new System.Drawing.Size(57, 24);
            this.ch_del.TabIndex = 13;
            this.ch_del.Text = "حذف";
            this.ch_del.UseVisualStyleBackColor = true;
            // 
            // ch_up
            // 
            this.ch_up.AutoSize = true;
            this.ch_up.Location = new System.Drawing.Point(210, 172);
            this.ch_up.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.ch_up.Name = "ch_up";
            this.ch_up.Size = new System.Drawing.Size(60, 24);
            this.ch_up.TabIndex = 14;
            this.ch_up.Text = "تعديل";
            this.ch_up.UseVisualStyleBackColor = true;
            // 
            // ch_riges
            // 
            this.ch_riges.AutoSize = true;
            this.ch_riges.Location = new System.Drawing.Point(132, 172);
            this.ch_riges.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.ch_riges.Name = "ch_riges";
            this.ch_riges.Size = new System.Drawing.Size(60, 24);
            this.ch_riges.TabIndex = 15;
            this.ch_riges.Text = "تسديد";
            this.ch_riges.UseVisualStyleBackColor = true;
            // 
            // ch_acti
            // 
            this.ch_acti.AutoSize = true;
            this.ch_acti.Location = new System.Drawing.Point(45, 172);
            this.ch_acti.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.ch_acti.Name = "ch_acti";
            this.ch_acti.Size = new System.Drawing.Size(69, 24);
            this.ch_acti.TabIndex = 16;
            this.ch_acti.Text = "التفعيل";
            this.ch_acti.UseVisualStyleBackColor = true;
            // 
            // ch_help
            // 
            this.ch_help.AutoSize = true;
            this.ch_help.Checked = true;
            this.ch_help.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ch_help.Location = new System.Drawing.Point(266, 212);
            this.ch_help.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.ch_help.Name = "ch_help";
            this.ch_help.Size = new System.Drawing.Size(79, 24);
            this.ch_help.TabIndex = 17;
            this.ch_help.Text = "المساعدة";
            this.ch_help.UseVisualStyleBackColor = true;
            // 
            // ch_apu
            // 
            this.ch_apu.AutoSize = true;
            this.ch_apu.Checked = true;
            this.ch_apu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ch_apu.Location = new System.Drawing.Point(194, 212);
            this.ch_apu.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.ch_apu.Name = "ch_apu";
            this.ch_apu.Size = new System.Drawing.Size(54, 24);
            this.ch_apu.TabIndex = 18;
            this.ch_apu.Text = "حول";
            this.ch_apu.UseVisualStyleBackColor = true;
            // 
            // checkBox20
            // 
            this.checkBox20.AutoSize = true;
            this.checkBox20.Location = new System.Drawing.Point(53, 212);
            this.checkBox20.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.checkBox20.Name = "checkBox20";
            this.checkBox20.Size = new System.Drawing.Size(123, 24);
            this.checkBox20.TabIndex = 19;
            this.checkBox20.Text = "الوصول السريع";
            this.checkBox20.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(516, 414);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "انقر زر الايمن على الصورة لتغييرها";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(205, 353);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 24);
            this.label6.TabIndex = 6;
            this.label6.Text = "الصلاحيه";
            // 
            // com_priv
            // 
            this.com_priv.FormattingEnabled = true;
            this.com_priv.Items.AddRange(new object[] {
            "مدير ",
            "مبيعات ",
            "مشتريات"});
            this.com_priv.Location = new System.Drawing.Point(87, 390);
            this.com_priv.Name = "com_priv";
            this.com_priv.Size = new System.Drawing.Size(258, 21);
            this.com_priv.TabIndex = 7;
            // 
            // Add_Users
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 526);
            this.Controls.Add(this.com_priv);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pic_profile);
            this.Controls.Add(this.txt_message);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.edt_password);
            this.Controls.Add(this.edt_username);
            this.Controls.Add(this.edt_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.ShowIcon = false;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Add_Users";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافة مستخدم";
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.Add_Categories_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Add_Users_FormClosed);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.toastNotificationsManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_profile.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox edt_username;
        public System.Windows.Forms.TextBox edt_password;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.CheckBox ch_main;
        private System.Windows.Forms.CheckBox ch_sal;
        private System.Windows.Forms.CheckBox ch_gr;
        private System.Windows.Forms.CheckBox ch_cat;
        private System.Windows.Forms.CheckBox ch_py;
        private System.Windows.Forms.CheckBox ch_cast;
        private System.Windows.Forms.CheckBox ch_sup;
        private System.Windows.Forms.CheckBox ch_resp;
        private System.Windows.Forms.CheckBox ch_ana;
        private System.Windows.Forms.CheckBox ch_use;
        private System.Windows.Forms.CheckBox ch_sett;
        private System.Windows.Forms.CheckBox ch_add;
        private System.Windows.Forms.CheckBox ch_del;
        private System.Windows.Forms.CheckBox ch_up;
        private System.Windows.Forms.CheckBox ch_riges;
        private System.Windows.Forms.CheckBox ch_acti;
        private System.Windows.Forms.CheckBox ch_help;
        private System.Windows.Forms.CheckBox ch_apu;
        private System.Windows.Forms.CheckBox checkBox20;
        public DevExpress.XtraEditors.PictureEdit pic_profile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.ComboBox com_priv;
    }
}