
namespace EPS.Report
{
    partial class buyReportAction
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

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraReports.UI.DetailBand Detail;
            this.winControlContainer1 = new DevExpress.XtraReports.UI.WinControlContainer();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.colCategory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSupplier = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSupplierPyment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSupplierPyment1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateAdd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.xrLine1 = new DevExpress.XtraReports.UI.XRLine();
            this.pic_company = new DevExpress.XtraReports.UI.XRPictureBox();
            this.txt_companydescription = new DevExpress.XtraReports.UI.XRLabel();
            this.txt_companyname = new DevExpress.XtraReports.UI.XRLabel();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.pageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.pageInfo2 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.txt_secodcurr = new DevExpress.XtraReports.UI.XRLabel();
            this.d = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLine3 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLine2 = new DevExpress.XtraReports.UI.XRLine();
            this.txt_currancy = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.txt_cridet = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.txt_customarname = new DevExpress.XtraReports.UI.XRLabel();
            this.label1 = new DevExpress.XtraReports.UI.XRLabel();
            this.Title = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DetailCaption1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DetailData1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DetailData3_Odd = new DevExpress.XtraReports.UI.XRControlStyle();
            this.PageInfo = new DevExpress.XtraReports.UI.XRControlStyle();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMatrialsName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSellState = new DevExpress.XtraGrid.Columns.GridColumn();
            Detail = new DevExpress.XtraReports.UI.DetailBand();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.winControlContainer1});
            Detail.FillEmptySpace = true;
            Detail.HeightF = 80F;
            Detail.Name = "Detail";
            Detail.StylePriority.UseTextAlignment = false;
            Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // winControlContainer1
            // 
            this.winControlContainer1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.winControlContainer1.Name = "winControlContainer1";
            this.winControlContainer1.SizeF = new System.Drawing.SizeF(483F, 70F);
            this.winControlContainer1.WinControl = this.gridControl1;
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataSource = typeof(EPS.TB_Buy);
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMemoEdit1,
            this.repositoryItemMemoEdit2});
            this.gridControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gridControl1.Size = new System.Drawing.Size(580, 84);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1new DevExpress.Drawing.DXFont("Arial", 20F);
            // 
            //this.gridView1.Appearance.ColumnFilterButton.Font = new DevExpress.Drawing.DXFont("LBC", 8F, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, new DevExpress.Drawing.DXFontAdditionalProperty[] {new DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", ((byte)(0)))});
            this.gridView1.Appearance.ColumnFilterButton.Font = new DevExpress.Drawing.DXFont("Arial", 20F);
            this.gridView1.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.gridView1.Appearance.ColumnFilterButton.Options.UseTextOptions = true;
            this.gridView1.Appearance.ColumnFilterButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.ColumnFilterButton.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridView1.Appearance.ColumnFilterButtonActive.Font = new DevExpress.Drawing.DXFont("Arial", 20F);
            this.gridView1.Appearance.ColumnFilterButtonActive.Options.UseFont = true;
            this.gridView1.Appearance.ColumnFilterButtonActive.Options.UseTextOptions = true;
            this.gridView1.Appearance.ColumnFilterButtonActive.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.ColumnFilterButtonActive.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridView1.Appearance.CustomizationFormHint.Font = new DevExpress.Drawing.DXFont("Arial", 20F);
            this.gridView1.Appearance.CustomizationFormHint.Options.UseFont = true;
            this.gridView1.Appearance.CustomizationFormHint.Options.UseTextOptions = true;
            this.gridView1.Appearance.CustomizationFormHint.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.CustomizationFormHint.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridView1.Appearance.DetailTip.Font = new DevExpress.Drawing.DXFont("Arial", 20F);
            this.gridView1.Appearance.DetailTip.Options.UseFont = true;
            this.gridView1.Appearance.DetailTip.Options.UseTextOptions = true;
            this.gridView1.Appearance.DetailTip.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.DetailTip.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridView1.Appearance.Empty.Font = new DevExpress.Drawing.DXFont("Arial", 20F);
            this.gridView1.Appearance.Empty.Options.UseFont = true;
            this.gridView1.Appearance.Empty.Options.UseTextOptions = true;
            this.gridView1.Appearance.Empty.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.Empty.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridView1.Appearance.EvenRow.Font = new DevExpress.Drawing.DXFont("Arial", 20F);
            this.gridView1.Appearance.EvenRow.Options.UseFont = true;
            this.gridView1.Appearance.EvenRow.Options.UseTextOptions = true;
            this.gridView1.Appearance.EvenRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.EvenRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridView1.Appearance.FilterCloseButton.Font = new DevExpress.Drawing.DXFont("Arial", 20F);
            this.gridView1.Appearance.FilterCloseButton.Options.UseFont = true;
            this.gridView1.Appearance.FilterCloseButton.Options.UseTextOptions = true;
            this.gridView1.Appearance.FilterCloseButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.FilterCloseButton.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridView1.Appearance.FilterPanel.Font = new DevExpress.Drawing.DXFont("Arial", 20F);
            this.gridView1.Appearance.FilterPanel.Options.UseFont = true;
            this.gridView1.Appearance.FilterPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.FilterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.FilterPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridView1.Appearance.FixedLine.Font = new DevExpress.Drawing.DXFont("Arial", 20F);
            this.gridView1.Appearance.FixedLine.Options.UseFont = true;
            this.gridView1.Appearance.FixedLine.Options.UseTextOptions = true;
            this.gridView1.Appearance.FixedLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.FixedLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.FixedLine.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridView1.Appearance.FocusedCell.Font = new DevExpress.Drawing.DXFont("Arial", 20F);
            this.gridView1.Appearance.FocusedCell.Options.UseFont = true;
            this.gridView1.Appearance.FocusedCell.Options.UseTextOptions = true;
            this.gridView1.Appearance.FocusedCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.FocusedCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridView1.Appearance.FocusedRow.Font = new DevExpress.Drawing.DXFont("Arial", 20F);
            this.gridView1.Appearance.FocusedRow.Options.UseFont = true;
            this.gridView1.Appearance.FocusedRow.Options.UseTextOptions = true;
            this.gridView1.Appearance.FocusedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.FocusedRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridView1.Appearance.FooterPanel.Font = new DevExpress.Drawing.DXFont("Arial", 20F);
            this.gridView1.Appearance.FooterPanel.Options.UseFont = true;
            this.gridView1.Appearance.FooterPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.FooterPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridView1.Appearance.GroupButton.Font = new DevExpress.Drawing.DXFont("LBC", 8F, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, new DevExpress.Drawing.DXFontAdditionalProperty[] { new DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", ((byte)(0))) });

            this.gridView1.Appearance.GroupButton.Options.UseFont = true;
            this.gridView1.Appearance.GroupButton.Options.UseTextOptions = true;
            this.gridView1.Appearance.GroupButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.GroupButton.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridView1.Appearance.GroupFooter.Font = new DevExpress.Drawing.DXFont("Arial", 20F);
            this.gridView1.Appearance.GroupFooter.Options.UseFont = true;
            this.gridView1.Appearance.GroupFooter.Options.UseTextOptions = true;
            this.gridView1.Appearance.GroupFooter.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.GroupFooter.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridView1.Appearance.GroupPanel.Font = new DevExpress.Drawing.DXFont("Arial", 20F);
            this.gridView1.Appearance.GroupPanel.Options.UseFont = true;
            this.gridView1.Appearance.GroupPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.GroupPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.GroupPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridView1.Appearance.GroupRow.Font = new DevExpress.Drawing.DXFont("Arial", 20F);
            this.gridView1.Appearance.GroupRow.Options.UseFont = true;
            this.gridView1.Appearance.GroupRow.Options.UseTextOptions = true;
            this.gridView1.Appearance.GroupRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.GroupRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridView1.Appearance.HeaderPanel.Font = new DevExpress.Drawing.DXFont("Arial", 20F);
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridView1.Appearance.HideSelectionRow.Font = new DevExpress.Drawing.DXFont("Arial", 20F);
            this.gridView1.Appearance.HideSelectionRow.Options.UseFont = true;
            this.gridView1.Appearance.HideSelectionRow.Options.UseTextOptions = true;
            this.gridView1.Appearance.HideSelectionRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.HideSelectionRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridView1.Appearance.HorzLine.Font = new DevExpress.Drawing.DXFont("Arial", 20F);
            this.gridView1.Appearance.HorzLine.Options.UseFont = true;
            this.gridView1.Appearance.HorzLine.Options.UseTextOptions = true;
            this.gridView1.Appearance.HorzLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.HorzLine.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridView1.Appearance.HotTrackedRow.Font = new DevExpress.Drawing.DXFont("Arial", 20F);
            this.gridView1.Appearance.HotTrackedRow.Options.UseFont = true;
            this.gridView1.Appearance.HotTrackedRow.Options.UseTextOptions = true;
            this.gridView1.Appearance.HotTrackedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.HotTrackedRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridView1.Appearance.OddRow.Font = new DevExpress.Drawing.DXFont("Arial", 20F);
            this.gridView1.Appearance.OddRow.Options.UseFont = true;
            this.gridView1.Appearance.OddRow.Options.UseTextOptions = true;
            this.gridView1.Appearance.OddRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.OddRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridView1.Appearance.Preview.Font = new DevExpress.Drawing.DXFont("Arial", 20F);
            this.gridView1.Appearance.Preview.Options.UseFont = true;
            this.gridView1.Appearance.Preview.Options.UseTextOptions = true;
            this.gridView1.Appearance.Preview.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.Preview.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridView1.Appearance.Row.Font = new DevExpress.Drawing.DXFont("Arial", 20F);
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Appearance.Row.Options.UseTextOptions = true;
            this.gridView1.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridView1.Appearance.RowSeparator.Font = new DevExpress.Drawing.DXFont("Arial", 20F);
            this.gridView1.Appearance.RowSeparator.Options.UseFont = true;
            this.gridView1.Appearance.RowSeparator.Options.UseTextOptions = true;
            this.gridView1.Appearance.RowSeparator.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.RowSeparator.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridView1.Appearance.SelectedRow.Font = new DevExpress.Drawing.DXFont("Arial", 20F);
            this.gridView1.Appearance.SelectedRow.Options.UseFont = true;
            this.gridView1.Appearance.SelectedRow.Options.UseTextOptions = true;
            this.gridView1.Appearance.SelectedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.SelectedRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridView1.Appearance.TopNewRow.Font = new DevExpress.Drawing.DXFont("Arial", 20F);
            this.gridView1.Appearance.TopNewRow.Options.UseFont = true;
            this.gridView1.Appearance.TopNewRow.Options.UseTextOptions = true;
            this.gridView1.Appearance.TopNewRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.TopNewRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridView1.Appearance.VertLine.Font = new DevExpress.Drawing.DXFont("Arial", 20F);
            this.gridView1.Appearance.VertLine.Options.UseFont = true;
            this.gridView1.Appearance.VertLine.Options.UseTextOptions = true;
            this.gridView1.Appearance.VertLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.VertLine.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridView1.Appearance.ViewCaption.Font = new DevExpress.Drawing.DXFont("Arial", 20F);
            this.gridView1.Appearance.ViewCaption.Options.UseFont = true;
            this.gridView1.Appearance.ViewCaption.Options.UseTextOptions = true;
            this.gridView1.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridView1.AppearancePrint.EvenRow.BackColor = System.Drawing.Color.White;
            this.gridView1.AppearancePrint.EvenRow.Font = new DevExpress.Drawing.DXFont("Arial", 20F);
            this.gridView1.AppearancePrint.EvenRow.Options.UseBackColor = true;
            this.gridView1.AppearancePrint.EvenRow.Options.UseFont = true;
            this.gridView1.AppearancePrint.EvenRow.Options.UseTextOptions = true;
            this.gridView1.AppearancePrint.EvenRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.AppearancePrint.EvenRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridView1.AppearancePrint.FilterPanel.Font = new DevExpress.Drawing.DXFont("Arial", 20F);
            this.gridView1.AppearancePrint.FilterPanel.Options.UseFont = true;
            this.gridView1.AppearancePrint.FilterPanel.Options.UseTextOptions = true;
            this.gridView1.AppearancePrint.FilterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.AppearancePrint.FilterPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridView1.AppearancePrint.FooterPanel.Font = new DevExpress.Drawing.DXFont("Arial", 20F);
            this.gridView1.AppearancePrint.FooterPanel.Options.UseFont = true;
            this.gridView1.AppearancePrint.FooterPanel.Options.UseTextOptions = true;
            this.gridView1.AppearancePrint.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.AppearancePrint.FooterPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridView1.AppearancePrint.GroupFooter.Font = new DevExpress.Drawing.DXFont("Arial", 20F);
            this.gridView1.AppearancePrint.GroupFooter.Options.UseFont = true;
            this.gridView1.AppearancePrint.GroupFooter.Options.UseTextOptions = true;
            this.gridView1.AppearancePrint.GroupFooter.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.AppearancePrint.GroupFooter.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridView1.AppearancePrint.GroupRow.Font = new DevExpress.Drawing.DXFont("Arial", 20F);
            this.gridView1.AppearancePrint.GroupRow.Options.UseFont = true;
            this.gridView1.AppearancePrint.GroupRow.Options.UseTextOptions = true;
            this.gridView1.AppearancePrint.GroupRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.AppearancePrint.GroupRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridView1.AppearancePrint.HeaderPanel.Font = new DevExpress.Drawing.DXFont("Arial", 20F);

            this.gridView1.AppearancePrint.HeaderPanel.Options.UseFont = true;
            this.gridView1.AppearancePrint.HeaderPanel.Options.UseTextOptions = true;
            this.gridView1.AppearancePrint.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.AppearancePrint.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridView1.AppearancePrint.Lines.Font = new DevExpress.Drawing.DXFont("Arial", 20F);
            this.gridView1.AppearancePrint.Lines.Options.UseFont = true;
            this.gridView1.AppearancePrint.Lines.Options.UseTextOptions = true;
            this.gridView1.AppearancePrint.Lines.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.AppearancePrint.Lines.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridView1.AppearancePrint.OddRow.BackColor = System.Drawing.Color.White;
            this.gridView1.AppearancePrint.OddRow.Font = new DevExpress.Drawing.DXFont("Arial", 20F);
            this.gridView1.AppearancePrint.OddRow.Options.UseBackColor = true;
            this.gridView1.AppearancePrint.OddRow.Options.UseFont = true;
            this.gridView1.AppearancePrint.OddRow.Options.UseTextOptions = true;
            this.gridView1.AppearancePrint.OddRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.AppearancePrint.OddRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridView1.AppearancePrint.Preview.Font = new DevExpress.Drawing.DXFont("Arial", 20F);
            this.gridView1.AppearancePrint.Preview.Options.UseFont = true;
            this.gridView1.AppearancePrint.Preview.Options.UseTextOptions = true;
            this.gridView1.AppearancePrint.Preview.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.AppearancePrint.Preview.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridView1.AppearancePrint.Row.Font = new DevExpress.Drawing.DXFont("Arial", 20F);
            this.gridView1.AppearancePrint.Row.Options.UseFont = true;
            this.gridView1.AppearancePrint.Row.Options.UseTextOptions = true;
            this.gridView1.AppearancePrint.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.AppearancePrint.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colCategory,
            this.colSupplier,
            this.colDescription,
            this.colSupplierPyment,
            this.colSupplierPyment1,
            this.colDateAdd});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsPrint.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsPrint.EnableAppearanceOddRow = true;
            this.gridView1.OptionsView.RowAutoHeight = true;
            // 
            // colName
            // 
            this.colName.AppearanceCell.Options.UseTextOptions = true;
            this.colName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colName.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colName.AppearanceHeader.Options.UseTextOptions = true;
            this.colName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colName.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colName.Caption = "اسم القائمة";
            this.colName.ColumnEdit = this.repositoryItemMemoEdit1;
            this.colName.FieldName = "Name";
            this.colName.MinWidth = 25;
            this.colName.Name = "colName";
            this.colName.OptionsColumn.AllowEdit = false;
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            this.colName.Width = 94;
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            this.repositoryItemMemoEdit1.ValidateOnEnterKey = true;
            // 
            // colCategory
            // 
            this.colCategory.AppearanceCell.Options.UseTextOptions = true;
            this.colCategory.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCategory.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCategory.AppearanceHeader.Options.UseTextOptions = true;
            this.colCategory.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCategory.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colCategory.Caption = "الصنف";
            this.colCategory.FieldName = "Category";
            this.colCategory.MinWidth = 25;
            this.colCategory.Name = "colCategory";
            this.colCategory.OptionsColumn.AllowEdit = false;
            this.colCategory.Visible = true;
            this.colCategory.VisibleIndex = 1;
            this.colCategory.Width = 94;
            // 
            // colSupplier
            // 
            this.colSupplier.AppearanceCell.Options.UseTextOptions = true;
            this.colSupplier.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSupplier.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSupplier.AppearanceHeader.Options.UseTextOptions = true;
            this.colSupplier.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSupplier.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colSupplier.Caption = "المورد";
            this.colSupplier.FieldName = "Supplier";
            this.colSupplier.MinWidth = 25;
            this.colSupplier.Name = "colSupplier";
            this.colSupplier.OptionsColumn.AllowEdit = false;
            this.colSupplier.Visible = true;
            this.colSupplier.VisibleIndex = 2;
            this.colSupplier.Width = 94;
            // 
            // colDescription
            // 
            this.colDescription.AppearanceCell.Options.UseTextOptions = true;
            this.colDescription.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDescription.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colDescription.Caption = "الوصف";
            this.colDescription.FieldName = "Description";
            this.colDescription.MinWidth = 25;
            this.colDescription.Name = "colDescription";
            this.colDescription.OptionsColumn.AllowEdit = false;
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 3;
            this.colDescription.Width = 94;
            // 
            // colSupplierPyment
            // 
            this.colSupplierPyment.FieldName = "SupplierPyment";
            this.colSupplierPyment.MinWidth = 25;
            this.colSupplierPyment.Name = "colSupplierPyment";
            this.colSupplierPyment.OptionsColumn.AllowEdit = false;
            this.colSupplierPyment.Visible = true;
            this.colSupplierPyment.VisibleIndex = 4;
            this.colSupplierPyment.Width = 94;
            // 
            // colSupplierPyment1
            // 
            this.colSupplierPyment1.FieldName = "SupplierPyment1";
            this.colSupplierPyment1.MinWidth = 25;
            this.colSupplierPyment1.Name = "colSupplierPyment1";
            this.colSupplierPyment1.OptionsColumn.AllowEdit = false;
            this.colSupplierPyment1.Visible = true;
            this.colSupplierPyment1.VisibleIndex = 5;
            this.colSupplierPyment1.Width = 94;
            // 
            // colDateAdd
            // 
            this.colDateAdd.Caption = "تاريخ الاضافة";
            this.colDateAdd.ColumnEdit = this.repositoryItemMemoEdit2;
            this.colDateAdd.FieldName = "DateAdd";
            this.colDateAdd.MinWidth = 25;
            this.colDateAdd.Name = "colDateAdd";
            this.colDateAdd.OptionsColumn.AllowEdit = false;
            this.colDateAdd.Visible = true;
            this.colDateAdd.VisibleIndex = 6;
            this.colDateAdd.Width = 94;
            // 
            // repositoryItemMemoEdit2
            // 
            this.repositoryItemMemoEdit2.Name = "repositoryItemMemoEdit2";
            // 
            // TopMargin
            // 
            this.TopMargin.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.TopMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLine1,
            this.pic_company,
            this.txt_companydescription,
            this.txt_companyname});
            this.TopMargin.HeightF = 123F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.StylePriority.UseBorders = false;
            // 
            // xrLine1
            // 
            this.xrLine1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 113.3333F);
            this.xrLine1.Name = "xrLine1";
            this.xrLine1.SizeF = new System.Drawing.SizeF(483F, 9.666672F);
            // 
            // pic_company
            // 
            this.pic_company.ImageAlignment = DevExpress.XtraPrinting.ImageAlignment.MiddleCenter;
            this.pic_company.LocationFloat = new DevExpress.Utils.PointFloat(10F, 10F);
            this.pic_company.Name = "pic_company";
            this.pic_company.SizeF = new System.Drawing.SizeF(94.43604F, 89.16666F);
            this.pic_company.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage;
            // 
            // txt_companydescription
            // 
            this.txt_companydescription.Font = new DevExpress.Drawing.DXFont("LBC", 9F, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, new DevExpress.Drawing.DXFontAdditionalProperty[] {new DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", ((byte)(0)))});
            this.txt_companydescription.LocationFloat = new DevExpress.Utils.PointFloat(225.8333F, 43.67515F);
            this.txt_companydescription.Name = "txt_companydescription";
            this.txt_companydescription.SizeF = new System.Drawing.SizeF(246.6667F, 55.49151F);
            this.txt_companydescription.StyleName = "Title";
            this.txt_companydescription.StylePriority.UseFont = false;
            this.txt_companydescription.StylePriority.UseTextAlignment = false;
            this.txt_companydescription.Text = "هنا وصف للمكان الشركة ";
            this.txt_companydescription.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // txt_companyname
            // 
            this.txt_companyname.Font = new DevExpress.Drawing.DXFont("LBC", 12F, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, new DevExpress.Drawing.DXFontAdditionalProperty[] {new DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", ((byte)(0)))});
            this.txt_companyname.LocationFloat = new DevExpress.Utils.PointFloat(225.8333F, 10F);
            this.txt_companyname.Name = "txt_companyname";
            this.txt_companyname.SizeF = new System.Drawing.SizeF(246.6667F, 24.84182F);
            this.txt_companyname.StyleName = "Title";
            this.txt_companyname.StylePriority.UseFont = false;
            this.txt_companyname.StylePriority.UseTextAlignment = false;
            this.txt_companyname.Text = "هنا اسم الشركة";
            this.txt_companyname.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // BottomMargin
            // 
            this.BottomMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.pageInfo1,
            this.pageInfo2});
            this.BottomMargin.HeightF = 23F;
            this.BottomMargin.Name = "BottomMargin";
            // 
            // pageInfo1
            // 
            this.pageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.pageInfo1.Name = "pageInfo1";
            this.pageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
            this.pageInfo1.SizeF = new System.Drawing.SizeF(191.5F, 23F);
            this.pageInfo1.StyleName = "PageInfo";
            // 
            // pageInfo2
            // 
            this.pageInfo2.LocationFloat = new DevExpress.Utils.PointFloat(191F, 0F);
            this.pageInfo2.Name = "pageInfo2";
            this.pageInfo2.SizeF = new System.Drawing.SizeF(191.5F, 23F);
            this.pageInfo2.StyleName = "PageInfo";
            this.pageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.pageInfo2.TextFormatString = "Page {0} of {1}";
            // 
            // ReportHeader
            // 
            this.ReportHeader.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.txt_secodcurr,
            this.d,
            this.xrLine3,
            this.xrLine2,
            this.txt_currancy,
            this.xrLabel6,
            this.txt_cridet,
            this.xrLabel2,
            this.txt_customarname,
            this.label1});
            this.ReportHeader.HeightF = 147.5F;
            this.ReportHeader.Name = "ReportHeader";
            this.ReportHeader.StylePriority.UseBorders = false;
            // 
            // txt_secodcurr
            // 
            this.txt_secodcurr.Font = new DevExpress.Drawing.DXFont("LBC", 10F, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, new DevExpress.Drawing.DXFontAdditionalProperty[] {new DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", ((byte)(0)))});
            this.txt_secodcurr.LocationFloat = new DevExpress.Utils.PointFloat(55.83333F, 112.9915F);
            this.txt_secodcurr.Multiline = true;
            this.txt_secodcurr.Name = "txt_secodcurr";
            this.txt_secodcurr.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txt_secodcurr.SizeF = new System.Drawing.SizeF(289.1666F, 23.00001F);
            this.txt_secodcurr.StylePriority.UseFont = false;
            this.txt_secodcurr.StylePriority.UseTextAlignment = false;
            this.txt_secodcurr.Text = "..........";
            this.txt_secodcurr.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // d
            // 
            this.d.Font = new DevExpress.Drawing.DXFont("LBC", 10F, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, new DevExpress.Drawing.DXFontAdditionalProperty[] {new DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", ((byte)(0)))});
            this.d.LocationFloat = new DevExpress.Utils.PointFloat(10F, 112.9915F);
            this.d.Multiline = true;
            this.d.Name = "d";
            this.d.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.d.SizeF = new System.Drawing.SizeF(45.83333F, 23.00001F);
            this.d.StylePriority.UseFont = false;
            this.d.Text = "دينار";
            // 
            // xrLine3
            // 
            this.xrLine3.LocationFloat = new DevExpress.Utils.PointFloat(0F, 137.8333F);
            this.xrLine3.Name = "xrLine3";
            this.xrLine3.SizeF = new System.Drawing.SizeF(483F, 9.666672F);
            // 
            // xrLine2
            // 
            this.xrLine2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 28.00001F);
            this.xrLine2.Name = "xrLine2";
            this.xrLine2.SizeF = new System.Drawing.SizeF(483F, 9.66667F);
            // 
            // txt_currancy
            // 
            this.txt_currancy.Font = new DevExpress.Drawing.DXFont("LBC", 10F, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, new DevExpress.Drawing.DXFontAdditionalProperty[] {new DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", ((byte)(0)))});
            this.txt_currancy.LocationFloat = new DevExpress.Utils.PointFloat(10F, 88.14967F);
            this.txt_currancy.Multiline = true;
            this.txt_currancy.Name = "txt_currancy";
            this.txt_currancy.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txt_currancy.SizeF = new System.Drawing.SizeF(45.83333F, 23.00001F);
            this.txt_currancy.StylePriority.UseFont = false;
            this.txt_currancy.Text = "دينار";
            // 
            // xrLabel6
            // 
            this.xrLabel6.Font = new DevExpress.Drawing.DXFont("LBC", 10F, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, new DevExpress.Drawing.DXFontAdditionalProperty[] {new DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", ((byte)(0)))});
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(370.5F, 98.983F);
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.SizeF = new System.Drawing.SizeF(102F, 24.84181F);
            this.xrLabel6.StyleName = "Title";
            this.xrLabel6.StylePriority.UseFont = false;
            this.xrLabel6.StylePriority.UseTextAlignment = false;
            this.xrLabel6.Text = "مجموع الديون";
            this.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // txt_cridet
            // 
            this.txt_cridet.Font = new DevExpress.Drawing.DXFont("LBC", 10F, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, new DevExpress.Drawing.DXFontAdditionalProperty[] {new DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", ((byte)(0)))});
            this.txt_cridet.LocationFloat = new DevExpress.Utils.PointFloat(55.83333F, 88.14967F);
            this.txt_cridet.Multiline = true;
            this.txt_cridet.Name = "txt_cridet";
            this.txt_cridet.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txt_cridet.SizeF = new System.Drawing.SizeF(289.1666F, 23.00001F);
            this.txt_cridet.StylePriority.UseFont = false;
            this.txt_cridet.StylePriority.UseTextAlignment = false;
            this.txt_cridet.Text = "..........";
            this.txt_cridet.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel2
            // 
            this.xrLabel2.Font = new DevExpress.Drawing.DXFont("LBC", 10F, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, new DevExpress.Drawing.DXFontAdditionalProperty[] {new DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", ((byte)(0)))});
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(371F, 47.84182F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.SizeF = new System.Drawing.SizeF(102F, 24.84182F);
            this.xrLabel2.StyleName = "Title";
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.StylePriority.UseTextAlignment = false;
            this.xrLabel2.Text = "اسم المورد";
            this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // txt_customarname
            // 
            this.txt_customarname.Font = new DevExpress.Drawing.DXFont("LBC", 10F, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, new DevExpress.Drawing.DXFontAdditionalProperty[] {new DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", ((byte)(0)))});
            this.txt_customarname.LocationFloat = new DevExpress.Utils.PointFloat(55.83333F, 47.84182F);
            this.txt_customarname.Multiline = true;
            this.txt_customarname.Name = "txt_customarname";
            this.txt_customarname.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txt_customarname.SizeF = new System.Drawing.SizeF(289.1666F, 23F);
            this.txt_customarname.StylePriority.UseFont = false;
            this.txt_customarname.StylePriority.UseTextAlignment = false;
            this.txt_customarname.Text = "..........";
            this.txt_customarname.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new DevExpress.Drawing.DXFont("LBC", 12F, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, new DevExpress.Drawing.DXFontAdditionalProperty[] {new DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", ((byte)(0)))});
            this.label1.LocationFloat = new DevExpress.Utils.PointFloat(270F, 0F);
            this.label1.Name = "label1";
            this.label1.SizeF = new System.Drawing.SizeF(203F, 24.84182F);
            this.label1.StyleName = "Title";
            this.label1.StylePriority.UseFont = false;
            this.label1.StylePriority.UseTextAlignment = false;
            this.label1.Text = "كشف حساب مورد ";
            this.label1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.BorderColor = System.Drawing.Color.Black;
            this.Title.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Title.BorderWidth = 1F;
            this.Title.Font = new DevExpress.Drawing.DXFont("Arial", 14.25F);
            this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.Title.Name = "Title";
            this.Title.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
            // 
            // DetailCaption1
            // 
            this.DetailCaption1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.DetailCaption1.BorderColor = System.Drawing.Color.White;
            this.DetailCaption1.Borders = DevExpress.XtraPrinting.BorderSide.Left;
            this.DetailCaption1.BorderWidth = 2F;
            this.DetailCaption1.Font = new DevExpress.Drawing.DXFont("Arial", 8.25F, DevExpress.Drawing.DXFontStyle.Bold);
            this.DetailCaption1.ForeColor = System.Drawing.Color.White;
            this.DetailCaption1.Name = "DetailCaption1";
            this.DetailCaption1.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
            this.DetailCaption1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // DetailData1
            // 
            this.DetailData1.BorderColor = System.Drawing.Color.Transparent;
            this.DetailData1.Borders = DevExpress.XtraPrinting.BorderSide.Left;
            this.DetailData1.BorderWidth = 2F;
            this.DetailData1.Font = new DevExpress.Drawing.DXFont("Arial", 8.25F);
            this.DetailData1.ForeColor = System.Drawing.Color.Black;
            this.DetailData1.Name = "DetailData1";
            this.DetailData1.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
            this.DetailData1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // DetailData3_Odd
            // 
            this.DetailData3_Odd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.DetailData3_Odd.BorderColor = System.Drawing.Color.Transparent;
            this.DetailData3_Odd.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.DetailData3_Odd.BorderWidth = 1F;
            this.DetailData3_Odd.Font = new DevExpress.Drawing.DXFont("Arial", 8.25F);
            this.DetailData3_Odd.ForeColor = System.Drawing.Color.Black;
            this.DetailData3_Odd.Name = "DetailData3_Odd";
            this.DetailData3_Odd.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
            this.DetailData3_Odd.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // PageInfo
            // 
            this.PageInfo.Font = new DevExpress.Drawing.DXFont("Arial", 8.25F, DevExpress.Drawing.DXFontStyle.Bold);
            this.PageInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.PageInfo.Name = "PageInfo";
            this.PageInfo.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // gridColumn2
            // 
            this.gridColumn2.MinWidth = 25;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Width = 94;
            // 
            // colMatrialsName
            // 
            this.colMatrialsName.Caption = "اسم المادة";
            this.colMatrialsName.FieldName = "MatrialsName";
            this.colMatrialsName.MinWidth = 25;
            this.colMatrialsName.Name = "colMatrialsName";
            this.colMatrialsName.OptionsColumn.AllowEdit = false;
            this.colMatrialsName.Width = 94;
            // 
            // colQuantity
            // 
            this.colQuantity.Caption = "الكمية";
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.MinWidth = 25;
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.OptionsColumn.AllowEdit = false;
            this.colQuantity.Width = 94;
            // 
            // colSellState
            // 
            this.colSellState.Caption = "حالة البيع";
            this.colSellState.FieldName = "SellState";
            this.colSellState.MinWidth = 25;
            this.colSellState.Name = "colSellState";
            this.colSellState.OptionsColumn.AllowEdit = false;
            this.colSellState.Width = 94;
            // 
            // buyReportAction
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader,
            Detail});
            this.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F);
            this.Margins = new DevExpress.Drawing.DXMargins(50, 50, 123, 23);
            this.PageHeight = 827;
            this.PageWidth = 583;
            this.PaperKind = System.Drawing.Printing.PaperKind.A5;
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.Title,
            this.DetailCaption1,
            this.DetailData1,
            this.DetailData3_Odd,
            this.PageInfo});
            this.Version = "20.2";
            this.DesignerLoaded += new DevExpress.XtraReports.UserDesigner.DesignerLoadedEventHandler(this.buyReportAction_DesignerLoaded);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.XRPageInfo pageInfo1;
        private DevExpress.XtraReports.UI.XRPageInfo pageInfo2;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.XRLabel label1;
        private DevExpress.XtraReports.UI.XRControlStyle Title;
        private DevExpress.XtraReports.UI.XRControlStyle DetailCaption1;
        private DevExpress.XtraReports.UI.XRControlStyle DetailData1;
        private DevExpress.XtraReports.UI.XRControlStyle DetailData3_Odd;
        private DevExpress.XtraReports.UI.XRControlStyle PageInfo;
        private DevExpress.XtraReports.UI.XRLabel xrLabel6;
        private DevExpress.XtraReports.UI.XRLabel txt_cridet;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRLabel txt_customarname;
        private DevExpress.XtraReports.UI.XRLabel txt_companyname;
        private DevExpress.XtraReports.UI.XRLabel txt_currancy;
        private DevExpress.XtraReports.UI.XRPictureBox pic_company;
        private DevExpress.XtraReports.UI.XRLabel txt_companydescription;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn colMatrialsName;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colSellState;
        private DevExpress.XtraReports.UI.XRLine xrLine1;
        private DevExpress.XtraReports.UI.XRLine xrLine3;
        private DevExpress.XtraReports.UI.XRLine xrLine2;
        private DevExpress.XtraReports.UI.WinControlContainer winControlContainer1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colCategory;
        private DevExpress.XtraGrid.Columns.GridColumn colSupplier;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colSupplierPyment;
        private DevExpress.XtraGrid.Columns.GridColumn colSupplierPyment1;
        private DevExpress.XtraGrid.Columns.GridColumn colDateAdd;
        private DevExpress.XtraReports.UI.XRLabel txt_secodcurr;
        private DevExpress.XtraReports.UI.XRLabel d;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit2;
    }
}
