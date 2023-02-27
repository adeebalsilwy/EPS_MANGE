
namespace EPS.PL
{
    partial class HomePage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions7 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions8 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions9 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions10 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions11 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions12 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            this.txt_time = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_add = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_time
            // 
            this.txt_time.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_time.BackColor = System.Drawing.Color.White;
            this.txt_time.Font = new System.Drawing.Font("Tahoma", 30F);
            this.txt_time.ForeColor = System.Drawing.Color.Silver;
            this.txt_time.Location = new System.Drawing.Point(158, 488);
            this.txt_time.Name = "txt_time";
            this.txt_time.Size = new System.Drawing.Size(555, 98);
            this.txt_time.TabIndex = 0;
            this.txt_time.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.txt_time.Click += new System.EventHandler(this.txt_time_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_add
            // 
            this.btn_add.AppearanceButton.Hovered.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.AppearanceButton.Hovered.ForeColor = System.Drawing.Color.White;
            this.btn_add.AppearanceButton.Hovered.Options.UseFont = true;
            this.btn_add.AppearanceButton.Hovered.Options.UseForeColor = true;
            this.btn_add.AppearanceButton.Normal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.AppearanceButton.Normal.ForeColor = System.Drawing.Color.White;
            this.btn_add.AppearanceButton.Normal.Options.UseFont = true;
            this.btn_add.AppearanceButton.Normal.Options.UseForeColor = true;
            this.btn_add.AppearanceButton.Pressed.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.AppearanceButton.Pressed.ForeColor = System.Drawing.Color.White;
            this.btn_add.AppearanceButton.Pressed.Options.UseFont = true;
            this.btn_add.AppearanceButton.Pressed.Options.UseForeColor = true;
            this.btn_add.BackColor = System.Drawing.Color.Black;
            this.btn_add.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_add.BackgroundImage")));
            this.btn_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            windowsUIButtonImageOptions7.Image = ((System.Drawing.Image)(resources.GetObject("windowsUIButtonImageOptions7.Image")));
            windowsUIButtonImageOptions8.Image = ((System.Drawing.Image)(resources.GetObject("windowsUIButtonImageOptions8.Image")));
            windowsUIButtonImageOptions9.Image = ((System.Drawing.Image)(resources.GetObject("windowsUIButtonImageOptions9.Image")));
            windowsUIButtonImageOptions10.Image = ((System.Drawing.Image)(resources.GetObject("windowsUIButtonImageOptions10.Image")));
            windowsUIButtonImageOptions11.Image = ((System.Drawing.Image)(resources.GetObject("windowsUIButtonImageOptions11.Image")));
            windowsUIButtonImageOptions12.Image = ((System.Drawing.Image)(resources.GetObject("windowsUIButtonImageOptions12.Image")));
            this.btn_add.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("اضافة مجموعة", true, windowsUIButtonImageOptions7, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUISeparator(),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("اضافة صنف", true, windowsUIButtonImageOptions8, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUISeparator(),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("عملية شراء", true, windowsUIButtonImageOptions9, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUISeparator(),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("عملية بيع", true, windowsUIButtonImageOptions10, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUISeparator(),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("اضافة عميل", true, windowsUIButtonImageOptions11, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUISeparator(),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("اضافة مورد", true, windowsUIButtonImageOptions12, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1, false)});
            this.btn_add.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_add.Location = new System.Drawing.Point(0, 0);
            this.btn_add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.btn_add.Size = new System.Drawing.Size(153, 585);
            this.btn_add.TabIndex = 1;
            this.btn_add.Tag = "sell";
            this.btn_add.Text = "windowsUIButtonPanel1";
            this.btn_add.ButtonClick += new DevExpress.XtraBars.Docking2010.ButtonEventHandler(this.btn_add_Click);
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(158, 332);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(752, 114);
            this.label1.TabIndex = 3;
            this.label1.Text = "EPS Pro";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Location = new System.Drawing.Point(371, 108);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(271, 221);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // HomePage
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_time);
            this.Controls.Add(this.btn_add);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "HomePage";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(926, 585);
            this.Load += new System.EventHandler(this.HomePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label txt_time;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel btn_add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
