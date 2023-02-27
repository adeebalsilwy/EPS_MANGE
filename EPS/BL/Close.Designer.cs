
namespace EPS.BL
{
    partial class Close
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
            DevExpress.Utils.Animation.Transition transition3 = new DevExpress.Utils.Animation.Transition();
            DevExpress.Utils.Animation.PushFadeTransition pushFadeTransition3 = new DevExpress.Utils.Animation.PushFadeTransition();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_state = new System.Windows.Forms.Label();
            this.btn_exit = new DevExpress.XtraEditors.SimpleButton();
            this.btn_no = new DevExpress.XtraEditors.SimpleButton();
            this.transitionManager1 = new DevExpress.Utils.Animation.TransitionManager(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.btn_no);
            this.panel1.Controls.Add(this.btn_exit);
            this.panel1.Controls.Add(this.lb_state);
            this.panel1.Location = new System.Drawing.Point(170, 129);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(663, 330);
            this.panel1.TabIndex = 0;
            this.panel1.Visible = false;
            // 
            // lb_state
            // 
            this.lb_state.BackColor = System.Drawing.Color.Transparent;
            this.lb_state.Dock = System.Windows.Forms.DockStyle.Top;
            this.lb_state.Font = new System.Drawing.Font("LBC", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_state.ForeColor = System.Drawing.Color.Silver;
            this.lb_state.Location = new System.Drawing.Point(0, 0);
            this.lb_state.Name = "lb_state";
            this.lb_state.Size = new System.Drawing.Size(663, 99);
            this.lb_state.TabIndex = 11;
            this.lb_state.Text = "EPS هل تود فعلا الخروج من ";
            this.lb_state.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_exit
            // 
            this.btn_exit.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger;
            this.btn_exit.Appearance.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Appearance.ForeColor = System.Drawing.Color.White;
            this.btn_exit.Appearance.Options.UseBackColor = true;
            this.btn_exit.Appearance.Options.UseFont = true;
            this.btn_exit.Appearance.Options.UseForeColor = true;
            this.btn_exit.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btn_exit.Location = new System.Drawing.Point(454, 240);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(173, 71);
            this.btn_exit.TabIndex = 12;
            this.btn_exit.Text = "نعم";
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_no
            // 
            this.btn_no.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.btn_no.Appearance.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_no.Appearance.ForeColor = System.Drawing.Color.White;
            this.btn_no.Appearance.Options.UseBackColor = true;
            this.btn_no.Appearance.Options.UseFont = true;
            this.btn_no.Appearance.Options.UseForeColor = true;
            this.btn_no.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btn_no.Location = new System.Drawing.Point(28, 240);
            this.btn_no.Name = "btn_no";
            this.btn_no.Size = new System.Drawing.Size(173, 71);
            this.btn_no.TabIndex = 12;
            this.btn_no.Text = "لا";
            this.btn_no.Click += new System.EventHandler(this.btn_no_Click);
            // 
            // transitionManager1
            // 
            this.transitionManager1.ShowWaitingIndicator = false;
            transition3.BarWaitingIndicatorProperties.Caption = "";
            transition3.BarWaitingIndicatorProperties.Description = "";
            transition3.Control = this.panel1;
            transition3.EasingMode = DevExpress.Data.Utils.EasingMode.EaseInOut;
            transition3.LineWaitingIndicatorProperties.AnimationElementCount = 5;
            transition3.LineWaitingIndicatorProperties.Caption = "";
            transition3.LineWaitingIndicatorProperties.Description = "";
            transition3.RingWaitingIndicatorProperties.AnimationElementCount = 5;
            transition3.RingWaitingIndicatorProperties.Caption = "";
            transition3.RingWaitingIndicatorProperties.Description = "";
            transition3.TransitionType = pushFadeTransition3;
            transition3.WaitingIndicatorProperties.Caption = "";
            transition3.WaitingIndicatorProperties.Description = "";
            this.transitionManager1.Transitions.Add(transition3);
            // 
            // Close
            // 
            this.Appearance.BackColor = System.Drawing.Color.Black;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(29F, 61F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 588);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("LBC", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.Name = "Close";
            this.ShowInTaskbar = false;
            this.Text = "Close";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Close_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_state;
        public DevExpress.XtraEditors.SimpleButton btn_no;
        public DevExpress.XtraEditors.SimpleButton btn_exit;
        private DevExpress.Utils.Animation.TransitionManager transitionManager1;
    }
}