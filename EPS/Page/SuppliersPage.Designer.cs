
namespace EPS.PL
{
    partial class SuppliersPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuppliersPage));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btn_payment = new DevExpress.XtraEditors.SimpleButton();
            this.btn_print = new DevExpress.XtraEditors.SimpleButton();
            this.btn_update = new DevExpress.XtraEditors.SimpleButton();
            this.btn_delete = new DevExpress.XtraEditors.SimpleButton();
            this.btn_edit = new DevExpress.XtraEditors.SimpleButton();
            this.btn_add = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSupplierName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSupplierBalance = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSupplierBalancePrim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSupplierPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSupplierAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSupplierDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toastNotificationsManager1 = new DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager(this.components);
            this.btn_showdateofpayments = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toastNotificationsManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btn_showdateofpayments);
            this.panelControl1.Controls.Add(this.btn_payment);
            this.panelControl1.Controls.Add(this.btn_print);
            this.panelControl1.Controls.Add(this.btn_update);
            this.panelControl1.Controls.Add(this.btn_delete);
            this.panelControl1.Controls.Add(this.btn_edit);
            this.panelControl1.Controls.Add(this.btn_add);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 572);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1063, 108);
            this.panelControl1.TabIndex = 0;
            // 
            // btn_payment
            // 
            this.btn_payment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_payment.Appearance.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_payment.Appearance.Options.UseFont = true;
            this.btn_payment.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_payment.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_payment.ImageOptions.SvgImage")));
            this.btn_payment.Location = new System.Drawing.Point(234, 12);
            this.btn_payment.Name = "btn_payment";
            this.btn_payment.Size = new System.Drawing.Size(115, 84);
            this.btn_payment.TabIndex = 1;
            this.btn_payment.Text = "كشف حساب";
            this.btn_payment.Click += new System.EventHandler(this.btn_payment_Click);
            // 
            // btn_print
            // 
            this.btn_print.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_print.Appearance.Font = new System.Drawing.Font("LBC", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print.Appearance.Options.UseFont = true;
            this.btn_print.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_print.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_print.ImageOptions.SvgImage")));
            this.btn_print.Location = new System.Drawing.Point(355, 12);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(115, 84);
            this.btn_print.TabIndex = 0;
            this.btn_print.Text = "تصفير الحساب";
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // btn_update
            // 
            this.btn_update.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_update.Appearance.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Appearance.Options.UseFont = true;
            this.btn_update.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_update.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_update.ImageOptions.SvgImage")));
            this.btn_update.Location = new System.Drawing.Point(476, 12);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(115, 84);
            this.btn_update.TabIndex = 0;
            this.btn_update.Text = "تحديث";
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_delete.Appearance.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Appearance.Options.UseFont = true;
            this.btn_delete.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_delete.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_delete.ImageOptions.SvgImage")));
            this.btn_delete.Location = new System.Drawing.Point(597, 12);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(115, 84);
            this.btn_delete.TabIndex = 0;
            this.btn_delete.Text = "حذف";
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_edit.Appearance.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.Appearance.Options.UseFont = true;
            this.btn_edit.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_edit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_edit.ImageOptions.SvgImage")));
            this.btn_edit.Location = new System.Drawing.Point(718, 12);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(115, 84);
            this.btn_edit.TabIndex = 0;
            this.btn_edit.Text = "تعديل";
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_add
            // 
            this.btn_add.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_add.Appearance.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Appearance.Options.UseFont = true;
            this.btn_add.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_add.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_add.ImageOptions.SvgImage")));
            this.btn_add.Location = new System.Drawing.Point(839, 12);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(115, 84);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "اضافة";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = typeof(EPS.TB_Suppliers);
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gridControl1.Size = new System.Drawing.Size(1063, 572);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
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
            this.colSupplierName,
            this.colSupplierBalance,
            this.colSupplierBalancePrim,
            this.colSupplierPhone,
            this.colSupplierAddress,
            this.colSupplierDate});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsPrint.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsPrint.EnableAppearanceOddRow = true;
            // 
            // colSupplierName
            // 
            this.colSupplierName.Caption = "اسم المورد";
            this.colSupplierName.FieldName = "SupplierName";
            this.colSupplierName.MinWidth = 25;
            this.colSupplierName.Name = "colSupplierName";
            this.colSupplierName.OptionsColumn.AllowEdit = false;
            this.colSupplierName.Visible = true;
            this.colSupplierName.VisibleIndex = 0;
            this.colSupplierName.Width = 94;
            // 
            // colSupplierBalance
            // 
            this.colSupplierBalance.Caption = "الرصديد - دينار";
            this.colSupplierBalance.FieldName = "SupplierBalance";
            this.colSupplierBalance.MinWidth = 25;
            this.colSupplierBalance.Name = "colSupplierBalance";
            this.colSupplierBalance.OptionsColumn.AllowEdit = false;
            this.colSupplierBalance.Visible = true;
            this.colSupplierBalance.VisibleIndex = 1;
            this.colSupplierBalance.Width = 94;
            // 
            // colSupplierBalancePrim
            // 
            this.colSupplierBalancePrim.Caption = "الرصيد - دولار";
            this.colSupplierBalancePrim.FieldName = "SupplierBalancePrim";
            this.colSupplierBalancePrim.MinWidth = 25;
            this.colSupplierBalancePrim.Name = "colSupplierBalancePrim";
            this.colSupplierBalancePrim.OptionsColumn.AllowEdit = false;
            this.colSupplierBalancePrim.Visible = true;
            this.colSupplierBalancePrim.VisibleIndex = 2;
            this.colSupplierBalancePrim.Width = 94;
            // 
            // colSupplierPhone
            // 
            this.colSupplierPhone.Caption = "رقم الهاتف";
            this.colSupplierPhone.FieldName = "SupplierPhone";
            this.colSupplierPhone.MinWidth = 25;
            this.colSupplierPhone.Name = "colSupplierPhone";
            this.colSupplierPhone.OptionsColumn.AllowEdit = false;
            this.colSupplierPhone.Visible = true;
            this.colSupplierPhone.VisibleIndex = 3;
            this.colSupplierPhone.Width = 94;
            // 
            // colSupplierAddress
            // 
            this.colSupplierAddress.Caption = "العنوان";
            this.colSupplierAddress.FieldName = "SupplierAddress";
            this.colSupplierAddress.MinWidth = 25;
            this.colSupplierAddress.Name = "colSupplierAddress";
            this.colSupplierAddress.OptionsColumn.AllowEdit = false;
            this.colSupplierAddress.Visible = true;
            this.colSupplierAddress.VisibleIndex = 4;
            this.colSupplierAddress.Width = 94;
            // 
            // colSupplierDate
            // 
            this.colSupplierDate.Caption = "تاريخ الاضافة";
            this.colSupplierDate.FieldName = "SupplierDate";
            this.colSupplierDate.MinWidth = 25;
            this.colSupplierDate.Name = "colSupplierDate";
            this.colSupplierDate.OptionsColumn.AllowEdit = false;
            this.colSupplierDate.Visible = true;
            this.colSupplierDate.VisibleIndex = 5;
            this.colSupplierDate.Width = 94;
            // 
            // toastNotificationsManager1
            // 
            this.toastNotificationsManager1.ApplicationId = "67317d9e-9c1a-45dc-9c6f-79273460fd6a";
            this.toastNotificationsManager1.Notifications.AddRange(new DevExpress.XtraBars.ToastNotifications.IToastNotificationProperties[] {
            new DevExpress.XtraBars.ToastNotifications.ToastNotification("f1449fe1-3838-416b-b71a-c50500f603ee", ((System.Drawing.Image)(resources.GetObject("toastNotificationsManager1.Notifications"))), "تم اجراء الدفعة بنجاح", "تم اجراء الدفعة بنجاح", "تم اجراء الدفعة بنجاح", DevExpress.XtraBars.ToastNotifications.ToastNotificationTemplate.ImageAndText01)});
            // 
            // btn_showdateofpayments
            // 
            this.btn_showdateofpayments.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_showdateofpayments.Appearance.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_showdateofpayments.Appearance.Options.UseFont = true;
            this.btn_showdateofpayments.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_showdateofpayments.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_showdateofpayments.ImageOptions.SvgImage")));
            this.btn_showdateofpayments.Location = new System.Drawing.Point(75, 11);
            this.btn_showdateofpayments.Name = "btn_showdateofpayments";
            this.btn_showdateofpayments.Size = new System.Drawing.Size(153, 84);
            this.btn_showdateofpayments.TabIndex = 2;
            this.btn_showdateofpayments.Text = "تواريخ الدفعات";
            this.btn_showdateofpayments.Click += new System.EventHandler(this.btn_showdateofpayments_Click);
            // 
            // SuppliersPage
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl1);
            this.Name = "SuppliersPage";
            this.Size = new System.Drawing.Size(1063, 680);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toastNotificationsManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_update;
        private DevExpress.XtraEditors.SimpleButton btn_delete;
        private DevExpress.XtraEditors.SimpleButton btn_edit;
        private DevExpress.XtraEditors.SimpleButton btn_add;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btn_print;
        private DevExpress.XtraEditors.SimpleButton btn_payment;
        private DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager toastNotificationsManager1;
        private DevExpress.XtraGrid.Columns.GridColumn colSupplierName;
        private DevExpress.XtraGrid.Columns.GridColumn colSupplierBalance;
        private DevExpress.XtraGrid.Columns.GridColumn colSupplierBalancePrim;
        private DevExpress.XtraGrid.Columns.GridColumn colSupplierPhone;
        private DevExpress.XtraGrid.Columns.GridColumn colSupplierAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colSupplierDate;
        private DevExpress.XtraEditors.SimpleButton btn_showdateofpayments;
    }
}
