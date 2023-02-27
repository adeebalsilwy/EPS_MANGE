
namespace EPS.BL
{
    partial class Pymnetsrequired
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pymnetsrequired));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIDSELL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPaymentone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPaymentDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCurrentPaymentone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCurrentDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPaymentState = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSellName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.lb_credit = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_creditpay = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_creditreq = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_showdateoflogs = new DevExpress.XtraEditors.SimpleButton();
            this.btn_payment = new DevExpress.XtraEditors.SimpleButton();
            this.toastNotificationsManager1 = new DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toastNotificationsManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = typeof(EPS.TB_Pyments);
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gridControl1.Size = new System.Drawing.Size(1377, 524);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.gridView1.Appearance.ColumnFilterButton.Options.UseTextOptions = true;
            this.gridView1.Appearance.ColumnFilterButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.ColumnFilterButton.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridView1.Appearance.ColumnFilterButtonActive.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.ColumnFilterButtonActive.Options.UseFont = true;
            this.gridView1.Appearance.ColumnFilterButtonActive.Options.UseTextOptions = true;
            this.gridView1.Appearance.ColumnFilterButtonActive.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.ColumnFilterButtonActive.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridView1.Appearance.CustomizationFormHint.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.CustomizationFormHint.Options.UseFont = true;
            this.gridView1.Appearance.CustomizationFormHint.Options.UseTextOptions = true;
            this.gridView1.Appearance.CustomizationFormHint.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.CustomizationFormHint.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridView1.Appearance.DetailTip.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.DetailTip.Options.UseFont = true;
            this.gridView1.Appearance.DetailTip.Options.UseTextOptions = true;
            this.gridView1.Appearance.DetailTip.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.DetailTip.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridView1.Appearance.Empty.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Empty.Options.UseFont = true;
            this.gridView1.Appearance.Empty.Options.UseTextOptions = true;
            this.gridView1.Appearance.Empty.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.Empty.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridView1.Appearance.EvenRow.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.EvenRow.Options.UseFont = true;
            this.gridView1.Appearance.EvenRow.Options.UseTextOptions = true;
            this.gridView1.Appearance.EvenRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.EvenRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridView1.Appearance.FilterCloseButton.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.FilterCloseButton.Options.UseFont = true;
            this.gridView1.Appearance.FilterCloseButton.Options.UseTextOptions = true;
            this.gridView1.Appearance.FilterCloseButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.FilterCloseButton.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridView1.Appearance.FilterPanel.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.FilterPanel.Options.UseFont = true;
            this.gridView1.Appearance.FilterPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.FilterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.FilterPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridView1.Appearance.FixedLine.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.FixedLine.Options.UseFont = true;
            this.gridView1.Appearance.FixedLine.Options.UseTextOptions = true;
            this.gridView1.Appearance.FixedLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.FixedLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.FixedLine.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridView1.Appearance.FocusedCell.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.FocusedCell.Options.UseFont = true;
            this.gridView1.Appearance.FocusedCell.Options.UseTextOptions = true;
            this.gridView1.Appearance.FocusedCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.FocusedCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridView1.Appearance.FocusedRow.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.FocusedRow.Options.UseFont = true;
            this.gridView1.Appearance.FocusedRow.Options.UseTextOptions = true;
            this.gridView1.Appearance.FocusedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.FocusedRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridView1.Appearance.FooterPanel.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.FooterPanel.Options.UseFont = true;
            this.gridView1.Appearance.FooterPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.FooterPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridView1.Appearance.GroupButton.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.GroupButton.Options.UseFont = true;
            this.gridView1.Appearance.GroupButton.Options.UseTextOptions = true;
            this.gridView1.Appearance.GroupButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.GroupButton.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridView1.Appearance.GroupFooter.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.GroupFooter.Options.UseFont = true;
            this.gridView1.Appearance.GroupFooter.Options.UseTextOptions = true;
            this.gridView1.Appearance.GroupFooter.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.GroupFooter.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridView1.Appearance.GroupPanel.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.GroupPanel.Options.UseFont = true;
            this.gridView1.Appearance.GroupPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.GroupPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.GroupPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridView1.Appearance.GroupRow.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.GroupRow.Options.UseFont = true;
            this.gridView1.Appearance.GroupRow.Options.UseTextOptions = true;
            this.gridView1.Appearance.GroupRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.GroupRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridView1.Appearance.HideSelectionRow.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HideSelectionRow.Options.UseFont = true;
            this.gridView1.Appearance.HideSelectionRow.Options.UseTextOptions = true;
            this.gridView1.Appearance.HideSelectionRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.HideSelectionRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridView1.Appearance.HorzLine.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HorzLine.Options.UseFont = true;
            this.gridView1.Appearance.HorzLine.Options.UseTextOptions = true;
            this.gridView1.Appearance.HorzLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.HorzLine.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridView1.Appearance.HotTrackedRow.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HotTrackedRow.Options.UseFont = true;
            this.gridView1.Appearance.HotTrackedRow.Options.UseTextOptions = true;
            this.gridView1.Appearance.HotTrackedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.HotTrackedRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridView1.Appearance.OddRow.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.OddRow.Options.UseFont = true;
            this.gridView1.Appearance.OddRow.Options.UseTextOptions = true;
            this.gridView1.Appearance.OddRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.OddRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridView1.Appearance.Preview.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Preview.Options.UseFont = true;
            this.gridView1.Appearance.Preview.Options.UseTextOptions = true;
            this.gridView1.Appearance.Preview.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.Preview.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Appearance.Row.Options.UseTextOptions = true;
            this.gridView1.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridView1.Appearance.RowSeparator.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.RowSeparator.Options.UseFont = true;
            this.gridView1.Appearance.RowSeparator.Options.UseTextOptions = true;
            this.gridView1.Appearance.RowSeparator.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.RowSeparator.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridView1.Appearance.SelectedRow.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.SelectedRow.Options.UseFont = true;
            this.gridView1.Appearance.SelectedRow.Options.UseTextOptions = true;
            this.gridView1.Appearance.SelectedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.SelectedRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridView1.Appearance.TopNewRow.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.TopNewRow.Options.UseFont = true;
            this.gridView1.Appearance.TopNewRow.Options.UseTextOptions = true;
            this.gridView1.Appearance.TopNewRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.TopNewRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridView1.Appearance.VertLine.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.VertLine.Options.UseFont = true;
            this.gridView1.Appearance.VertLine.Options.UseTextOptions = true;
            this.gridView1.Appearance.VertLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.VertLine.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridView1.Appearance.ViewCaption.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.ViewCaption.Options.UseFont = true;
            this.gridView1.Appearance.ViewCaption.Options.UseTextOptions = true;
            this.gridView1.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridView1.AppearancePrint.EvenRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.AppearancePrint.EvenRow.Options.UseFont = true;
            this.gridView1.AppearancePrint.FilterPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.AppearancePrint.FilterPanel.Options.UseFont = true;
            this.gridView1.AppearancePrint.FooterPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.AppearancePrint.FooterPanel.Options.UseFont = true;
            this.gridView1.AppearancePrint.GroupFooter.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.AppearancePrint.GroupFooter.Options.UseFont = true;
            this.gridView1.AppearancePrint.GroupRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.AppearancePrint.GroupRow.Options.UseFont = true;
            this.gridView1.AppearancePrint.HeaderPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.AppearancePrint.HeaderPanel.Options.UseFont = true;
            this.gridView1.AppearancePrint.Lines.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.AppearancePrint.Lines.Options.UseFont = true;
            this.gridView1.AppearancePrint.OddRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.AppearancePrint.OddRow.Options.UseFont = true;
            this.gridView1.AppearancePrint.Preview.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.AppearancePrint.Preview.Options.UseFont = true;
            this.gridView1.AppearancePrint.Row.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.AppearancePrint.Row.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIDSELL,
            this.colCustomerName,
            this.colPaymentone,
            this.colPaymentDate,
            this.colCurrentPaymentone,
            this.colCurrentDate,
            this.colPaymentState,
            this.colSellName});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsPrint.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsPrint.EnableAppearanceOddRow = true;
            // 
            // colIDSELL
            // 
            this.colIDSELL.Caption = "قائمة البيع";
            this.colIDSELL.FieldName = "IDSELL";
            this.colIDSELL.MinWidth = 25;
            this.colIDSELL.Name = "colIDSELL";
            this.colIDSELL.OptionsColumn.AllowEdit = false;
            this.colIDSELL.Visible = true;
            this.colIDSELL.VisibleIndex = 0;
            this.colIDSELL.Width = 94;
            // 
            // colCustomerName
            // 
            this.colCustomerName.Caption = "العميل";
            this.colCustomerName.FieldName = "CustomerName";
            this.colCustomerName.MinWidth = 25;
            this.colCustomerName.Name = "colCustomerName";
            this.colCustomerName.OptionsColumn.AllowEdit = false;
            this.colCustomerName.Visible = true;
            this.colCustomerName.VisibleIndex = 1;
            this.colCustomerName.Width = 94;
            // 
            // colPaymentone
            // 
            this.colPaymentone.Caption = "الدفعة المستحقة";
            this.colPaymentone.FieldName = "Paymentone";
            this.colPaymentone.MinWidth = 25;
            this.colPaymentone.Name = "colPaymentone";
            this.colPaymentone.OptionsColumn.AllowEdit = false;
            this.colPaymentone.Visible = true;
            this.colPaymentone.VisibleIndex = 2;
            this.colPaymentone.Width = 94;
            // 
            // colPaymentDate
            // 
            this.colPaymentDate.Caption = "التاريخ التسديد";
            this.colPaymentDate.FieldName = "PaymentDate";
            this.colPaymentDate.MinWidth = 25;
            this.colPaymentDate.Name = "colPaymentDate";
            this.colPaymentDate.OptionsColumn.AllowEdit = false;
            this.colPaymentDate.Visible = true;
            this.colPaymentDate.VisibleIndex = 3;
            this.colPaymentDate.Width = 94;
            // 
            // colCurrentPaymentone
            // 
            this.colCurrentPaymentone.Caption = "الدفعة الجارية";
            this.colCurrentPaymentone.FieldName = "CurrentPaymentone";
            this.colCurrentPaymentone.MinWidth = 25;
            this.colCurrentPaymentone.Name = "colCurrentPaymentone";
            this.colCurrentPaymentone.OptionsColumn.AllowEdit = false;
            this.colCurrentPaymentone.Visible = true;
            this.colCurrentPaymentone.VisibleIndex = 4;
            this.colCurrentPaymentone.Width = 94;
            // 
            // colCurrentDate
            // 
            this.colCurrentDate.Caption = "تاريخ التسديد";
            this.colCurrentDate.FieldName = "CurrentDate";
            this.colCurrentDate.MinWidth = 25;
            this.colCurrentDate.Name = "colCurrentDate";
            this.colCurrentDate.OptionsColumn.AllowEdit = false;
            this.colCurrentDate.Visible = true;
            this.colCurrentDate.VisibleIndex = 5;
            this.colCurrentDate.Width = 94;
            // 
            // colPaymentState
            // 
            this.colPaymentState.Caption = "حالة الدفعة";
            this.colPaymentState.FieldName = "PaymentState";
            this.colPaymentState.MinWidth = 25;
            this.colPaymentState.Name = "colPaymentState";
            this.colPaymentState.OptionsColumn.AllowEdit = false;
            this.colPaymentState.Visible = true;
            this.colPaymentState.VisibleIndex = 6;
            this.colPaymentState.Width = 94;
            // 
            // colSellName
            // 
            this.colSellName.Caption = "تفاصيل";
            this.colSellName.FieldName = "SellName";
            this.colSellName.MinWidth = 25;
            this.colSellName.Name = "colSellName";
            this.colSellName.OptionsColumn.AllowEdit = false;
            this.colSellName.Visible = true;
            this.colSellName.VisibleIndex = 7;
            this.colSellName.Width = 94;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.lb_credit);
            this.panelControl1.Controls.Add(this.label5);
            this.panelControl1.Controls.Add(this.lb_creditpay);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.lb_creditreq);
            this.panelControl1.Controls.Add(this.label3);
            this.panelControl1.Controls.Add(this.btn_showdateoflogs);
            this.panelControl1.Controls.Add(this.btn_payment);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 524);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1377, 149);
            this.panelControl1.TabIndex = 2;
            // 
            // lb_credit
            // 
            this.lb_credit.BackColor = System.Drawing.Color.Olive;
            this.lb_credit.Font = new System.Drawing.Font("LBC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_credit.ForeColor = System.Drawing.Color.White;
            this.lb_credit.Location = new System.Drawing.Point(8, 101);
            this.lb_credit.Name = "lb_credit";
            this.lb_credit.Size = new System.Drawing.Size(233, 37);
            this.lb_credit.TabIndex = 1;
            this.lb_credit.Text = "0";
            this.lb_credit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("LBC", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(247, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(238, 42);
            this.label5.TabIndex = 1;
            this.label5.Text = "المتبقي";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_creditpay
            // 
            this.lb_creditpay.BackColor = System.Drawing.Color.Teal;
            this.lb_creditpay.Font = new System.Drawing.Font("LBC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_creditpay.ForeColor = System.Drawing.Color.White;
            this.lb_creditpay.Location = new System.Drawing.Point(8, 49);
            this.lb_creditpay.Name = "lb_creditpay";
            this.lb_creditpay.Size = new System.Drawing.Size(233, 37);
            this.lb_creditpay.TabIndex = 1;
            this.lb_creditpay.Text = "0";
            this.lb_creditpay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("LBC", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(247, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 42);
            this.label2.TabIndex = 1;
            this.label2.Text = "مجموع الديون المدفوعة ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_creditreq
            // 
            this.lb_creditreq.BackColor = System.Drawing.Color.Red;
            this.lb_creditreq.Font = new System.Drawing.Font("LBC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_creditreq.ForeColor = System.Drawing.Color.White;
            this.lb_creditreq.Location = new System.Drawing.Point(8, 2);
            this.lb_creditreq.Name = "lb_creditreq";
            this.lb_creditreq.Size = new System.Drawing.Size(233, 37);
            this.lb_creditreq.TabIndex = 1;
            this.lb_creditreq.Text = "0";
            this.lb_creditreq.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("LBC", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(247, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(238, 42);
            this.label3.TabIndex = 1;
            this.label3.Text = "مجموع الديون المطلوبة ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_showdateoflogs
            // 
            this.btn_showdateoflogs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_showdateoflogs.Appearance.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_showdateoflogs.Appearance.Options.UseFont = true;
            this.btn_showdateoflogs.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_showdateoflogs.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.btn_showdateoflogs.Location = new System.Drawing.Point(586, 50);
            this.btn_showdateoflogs.Name = "btn_showdateoflogs";
            this.btn_showdateoflogs.Size = new System.Drawing.Size(200, 84);
            this.btn_showdateoflogs.TabIndex = 0;
            this.btn_showdateoflogs.Text = "تاريخ الدفعات";
            this.btn_showdateoflogs.Click += new System.EventHandler(this.btn_showdateoflogs_Click);
            // 
            // btn_payment
            // 
            this.btn_payment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_payment.Appearance.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_payment.Appearance.Options.UseFont = true;
            this.btn_payment.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_payment.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_payment.ImageOptions.SvgImage")));
            this.btn_payment.Location = new System.Drawing.Point(792, 49);
            this.btn_payment.Name = "btn_payment";
            this.btn_payment.Size = new System.Drawing.Size(291, 84);
            this.btn_payment.TabIndex = 0;
            this.btn_payment.Text = "اجراء دفعة";
            this.btn_payment.Click += new System.EventHandler(this.btn_payment_Click);
            // 
            // toastNotificationsManager1
            // 
            this.toastNotificationsManager1.ApplicationId = "67317d9e-9c1a-45dc-9c6f-79273460fd6a";
            this.toastNotificationsManager1.Notifications.AddRange(new DevExpress.XtraBars.ToastNotifications.IToastNotificationProperties[] {
            new DevExpress.XtraBars.ToastNotifications.ToastNotification("f1449fe1-3838-416b-b71a-c50500f603ee", ((System.Drawing.Image)(resources.GetObject("toastNotificationsManager1.Notifications"))), "تم اجراء الدفعة بنجاح", "تم اجراء الدفعة بنجاح", "تم اجراء الدفعة بنجاح", DevExpress.XtraBars.ToastNotifications.ToastNotificationTemplate.ImageAndText01)});
            // 
            // Pymnetsrequired
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1377, 673);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.ShowIcon = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Pymnetsrequired";
            this.RightToLeftLayout = true;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تفاصيل الدفعات المستحقة";
            this.Load += new System.EventHandler(this.Pymnets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.toastNotificationsManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_payment;
        private DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager toastNotificationsManager1;
        private System.Windows.Forms.Label lb_creditreq;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_credit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_creditpay;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraGrid.Columns.GridColumn colIDSELL;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerName;
        private DevExpress.XtraGrid.Columns.GridColumn colPaymentone;
        private DevExpress.XtraGrid.Columns.GridColumn colPaymentDate;
        private DevExpress.XtraGrid.Columns.GridColumn colCurrentPaymentone;
        private DevExpress.XtraGrid.Columns.GridColumn colCurrentDate;
        private DevExpress.XtraGrid.Columns.GridColumn colPaymentState;
        private DevExpress.XtraGrid.Columns.GridColumn colSellName;
        private DevExpress.XtraEditors.SimpleButton btn_showdateoflogs;
    }
}