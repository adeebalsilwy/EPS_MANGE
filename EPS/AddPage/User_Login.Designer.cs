
namespace EPS.AddPage
{
    partial class User_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_Login));
            this.btn_add = new DevExpress.XtraEditors.SimpleButton();
            this.txt_message = new System.Windows.Forms.Label();
            this.toastNotificationsManager1 = new DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.edt_username = new System.Windows.Forms.TextBox();
            this.edt_password = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.toastNotificationsManager1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Warning;
            this.btn_add.Appearance.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Appearance.ForeColor = System.Drawing.Color.White;
            this.btn_add.Appearance.Options.UseBackColor = true;
            this.btn_add.Appearance.Options.UseFont = true;
            this.btn_add.Appearance.Options.UseForeColor = true;
            this.btn_add.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btn_add.Location = new System.Drawing.Point(54, 535);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(404, 71);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "دخول";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txt_message
            // 
            this.txt_message.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txt_message.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_message.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_message.ForeColor = System.Drawing.Color.White;
            this.txt_message.Location = new System.Drawing.Point(0, 0);
            this.txt_message.Name = "txt_message";
            this.txt_message.Size = new System.Drawing.Size(1094, 36);
            this.txt_message.TabIndex = 3;
            this.txt_message.Text = "رسالة";
            this.txt_message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txt_message.Visible = false;
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
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("LBC", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(177, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "اسم المستخدم";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("LBC", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(207, 412);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 35);
            this.label3.TabIndex = 1;
            this.label3.Text = "كلمة السر";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // edt_username
            // 
            this.edt_username.Font = new System.Drawing.Font("LBC", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_username.Location = new System.Drawing.Point(23, 345);
            this.edt_username.Name = "edt_username";
            this.edt_username.Size = new System.Drawing.Size(474, 50);
            this.edt_username.TabIndex = 2;
            this.edt_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.edt_username.TextChanged += new System.EventHandler(this.edt_username_TextChanged);
            // 
            // edt_password
            // 
            this.edt_password.Font = new System.Drawing.Font("LBC", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_password.Location = new System.Drawing.Point(23, 459);
            this.edt_password.Name = "edt_password";
            this.edt_password.PasswordChar = '*';
            this.edt_password.Size = new System.Drawing.Size(474, 50);
            this.edt_password.TabIndex = 2;
            this.edt_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.edt_password.TextChanged += new System.EventHandler(this.edt_password_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 4000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btn_add);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.edt_username);
            this.panel1.Controls.Add(this.edt_password);
            this.panel1.Location = new System.Drawing.Point(279, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(528, 629);
            this.panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(168, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 225);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // User_Login
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundImageStore = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImageStore")));
            this.ClientSize = new System.Drawing.Size(1094, 729);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_message);
            this.DoubleBuffered = true;
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.ShowIcon = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "User_Login";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.Add_Categories_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.User_Login_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.toastNotificationsManager1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public DevExpress.XtraEditors.SimpleButton btn_add;
        private System.Windows.Forms.Label txt_message;
        private DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager toastNotificationsManager1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox edt_username;
        public System.Windows.Forms.TextBox edt_password;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}