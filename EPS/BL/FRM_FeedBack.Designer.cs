
namespace EPS
{
    partial class FRM_FeedBack
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_FeedBack));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_state = new System.Windows.Forms.Label();
            this.pic_key = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btn_add = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_key)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.txt_state);
            this.panel1.Controls.Add(this.pic_key);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("LBC", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1014, 212);
            this.panel1.TabIndex = 0;
            // 
            // txt_state
            // 
            this.txt_state.Font = new System.Drawing.Font("LBC", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_state.ForeColor = System.Drawing.Color.White;
            this.txt_state.Location = new System.Drawing.Point(296, 9);
            this.txt_state.Name = "txt_state";
            this.txt_state.Size = new System.Drawing.Size(716, 203);
            this.txt_state.TabIndex = 0;
            this.txt_state.Text = "يسعدنا كثيرا لتكون احد المساهمين معنا في تطوير وتحسين البرنامج\r\n";
            this.txt_state.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txt_state.Click += new System.EventHandler(this.txt_state_Click);
            // 
            // pic_key
            // 
            this.pic_key.Image = ((System.Drawing.Image)(resources.GetObject("pic_key.Image")));
            this.pic_key.Location = new System.Drawing.Point(36, 12);
            this.pic_key.Name = "pic_key";
            this.pic_key.Size = new System.Drawing.Size(222, 176);
            this.pic_key.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_key.TabIndex = 1;
            this.pic_key.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.linkLabel1);
            this.panel2.Controls.Add(this.richTextBox1);
            this.panel2.Controls.Add(this.btn_add);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(27, 218);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(975, 543);
            this.panel2.TabIndex = 1;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(35, 107);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.richTextBox1.Size = new System.Drawing.Size(693, 319);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "ضع شرحا مختصر يوضح الخطأ او الميزة التي تحب توفرها في البرنامج في التحديثات القاد" +
    "مة \n...";
            // 
            // btn_add
            // 
            this.btn_add.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_add.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger;
            this.btn_add.Appearance.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Appearance.Options.UseBackColor = true;
            this.btn_add.Appearance.Options.UseFont = true;
            this.btn_add.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_add.Location = new System.Drawing.Point(136, 433);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(515, 55);
            this.btn_add.TabIndex = 2;
            this.btn_add.Text = "ارسال";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("LBC", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(830, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 31);
            this.label3.TabIndex = 0;
            this.label3.Text = "الشرح";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("LBC", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(35, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(693, 37);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "اكتب هنا عنوان الخطأ او الملاحظة ... مثلا المبيعات ...";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("LBC", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(752, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "العنوان او القسم";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("LBC", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(197, 511);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(454, 22);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "يمكنك ارسال الملاحظات والانضام الى القناة الخاصة في البرنامج";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // FRM_FeedBack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 765);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Glow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.ShowIcon = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_FeedBack";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "التفعيل";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_key)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label txt_state;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton btn_add;
        private System.Windows.Forms.PictureBox pic_key;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}