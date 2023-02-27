
namespace EPS.Report
{
    partial class SellReportAction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SellReportAction));
            this.winControlContainer1 = new DevExpress.XtraReports.UI.WinControlContainer();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSellValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSellAllValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.xrLine1 = new DevExpress.XtraReports.UI.XRLine();
            this.pic_company = new DevExpress.XtraReports.UI.XRPictureBox();
            this.txt_companydescription = new DevExpress.XtraReports.UI.XRLabel();
            this.txt_companyname = new DevExpress.XtraReports.UI.XRLabel();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.pageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.pageInfo2 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.xrLine3 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLine2 = new DevExpress.XtraReports.UI.XRLine();
            this.txt_currancy = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.txt_cridet = new DevExpress.XtraReports.UI.XRLabel();
            this.txt_totlaprice = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.txt_customarname = new DevExpress.XtraReports.UI.XRLabel();
            this.txt_sellid = new DevExpress.XtraReports.UI.XRLabel();
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
            this.winControlContainer1.SizeF = new System.Drawing.SizeF(383F, 80F);
            this.winControlContainer1.WinControl = this.gridControl1;
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataSource = typeof(EPS.TB_SellData);
            this.gridControl1.Location = new System.Drawing.Point(8, 398);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gridControl1.Size = new System.Drawing.Size(460, 96);
            this.gridControl1.TabIndex = 8;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
           // this.gridView1.Appearance.ColumnFilterButton.Font = new DevExpress.Drawing.DXFont("LBC", 7.8F, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, new DevExpress.Drawing.DXFontAdditionalProperty[] {new DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", ((byte)(0)))});
            this.gridView1.Appearance.ColumnFilterButton.Options.UseFont = true;
           // this.gridView1.Appearance.ColumnFilterButtonActive.Font = new DevExpress.Drawing.DXFont("LBC", 7.8F, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, new DevExpress.Drawing.DXFontAdditionalProperty[] {new DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", ((byte)(0)))});
            this.gridView1.Appearance.ColumnFilterButtonActive.Options.UseFont = true;
           // this.gridView1.Appearance.CustomizationFormHint.Font = new DevExpress.Drawing.DXFont("LBC", 7.8F, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, new DevExpress.Drawing.DXFontAdditionalProperty[] {new DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", ((byte)(0)))});
            this.gridView1.Appearance.CustomizationFormHint.Options.UseFont = true;
           // this.gridView1.Appearance.DetailTip.Font = new DevExpress.Drawing.DXFont("LBC", 7.8F, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, new DevExpress.Drawing.DXFontAdditionalProperty[] {new DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", ((byte)(0)))});
            this.gridView1.Appearance.DetailTip.Options.UseFont = true;
           // this.gridView1.Appearance.Empty.Font = new DevExpress.Drawing.DXFont("LBC", 7.8F, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, new DevExpress.Drawing.DXFontAdditionalProperty[] {new DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", ((byte)(0)))});
            this.gridView1.Appearance.Empty.Options.UseFont = true;
            this.gridView1.Appearance.EvenRow.Font = new DevExpress.Drawing.DXFont("LBC", 7.8F, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, new DevExpress.Drawing.DXFontAdditionalProperty[] {new DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", ((byte)(0)))});
            this.gridView1.Appearance.EvenRow.Options.UseFont = true;
            this.gridView1.Appearance.FilterCloseButton.Font = new DevExpress.Drawing.DXFont("LBC", 7.8F, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, new DevExpress.Drawing.DXFontAdditionalProperty[] {new DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", ((byte)(0)))});
            this.gridView1.Appearance.FilterCloseButton.Options.UseFont = true;
            this.gridView1.Appearance.FilterPanel.Font = new DevExpress.Drawing.DXFont("LBC", 7.8F, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, new DevExpress.Drawing.DXFontAdditionalProperty[] {new DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", ((byte)(0)))});
            this.gridView1.Appearance.FilterPanel.Options.UseFont = true;
            this.gridView1.Appearance.FixedLine.Font = new DevExpress.Drawing.DXFont("LBC", 7.8F, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, new DevExpress.Drawing.DXFontAdditionalProperty[] {new DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", ((byte)(0)))});
            this.gridView1.Appearance.FixedLine.Options.UseFont = true;
            this.gridView1.Appearance.FocusedCell.Font = new DevExpress.Drawing.DXFont("LBC", 7.8F, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, new DevExpress.Drawing.DXFontAdditionalProperty[] {new DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", ((byte)(0)))});
            this.gridView1.Appearance.FocusedCell.Options.UseFont = true;
            this.gridView1.Appearance.FocusedRow.Font = new DevExpress.Drawing.DXFont("LBC", 7.8F, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, new DevExpress.Drawing.DXFontAdditionalProperty[] {new DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", ((byte)(0)))});
            this.gridView1.Appearance.FocusedRow.Options.UseFont = true;
            this.gridView1.Appearance.FooterPanel.Font = new DevExpress.Drawing.DXFont("LBC", 7.8F, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, new DevExpress.Drawing.DXFontAdditionalProperty[] {new DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", ((byte)(0)))});
            this.gridView1.Appearance.FooterPanel.Options.UseFont = true;
            this.gridView1.Appearance.GroupButton.Font = new DevExpress.Drawing.DXFont("LBC", 7.8F, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, new DevExpress.Drawing.DXFontAdditionalProperty[] {new DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", ((byte)(0)))});
            this.gridView1.Appearance.GroupButton.Options.UseFont = true;
            this.gridView1.Appearance.GroupFooter.Font = new DevExpress.Drawing.DXFont("LBC", 7.8F, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, new DevExpress.Drawing.DXFontAdditionalProperty[] {new DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", ((byte)(0)))});
            this.gridView1.Appearance.GroupFooter.Options.UseFont = true;
            this.gridView1.Appearance.GroupPanel.Font = new DevExpress.Drawing.DXFont("LBC", 7.8F, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, new DevExpress.Drawing.DXFontAdditionalProperty[] {new DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", ((byte)(0)))});
            this.gridView1.Appearance.GroupPanel.Options.UseFont = true;
            this.gridView1.Appearance.GroupRow.Font = new DevExpress.Drawing.DXFont("LBC", 7.8F, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, new DevExpress.Drawing.DXFontAdditionalProperty[] {new DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", ((byte)(0)))});
            this.gridView1.Appearance.GroupRow.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Font = new DevExpress.Drawing.DXFont("LBC", 7.8F, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, new DevExpress.Drawing.DXFontAdditionalProperty[] {new DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", ((byte)(0)))});
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.HideSelectionRow.Font = new DevExpress.Drawing.DXFont("LBC", 7.8F, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, new DevExpress.Drawing.DXFontAdditionalProperty[] {new DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", ((byte)(0)))});
            this.gridView1.Appearance.HideSelectionRow.Options.UseFont = true;
            this.gridView1.Appearance.HorzLine.Font = new DevExpress.Drawing.DXFont("LBC", 7.8F, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, new DevExpress.Drawing.DXFontAdditionalProperty[] {new DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", ((byte)(0)))});
            this.gridView1.Appearance.HorzLine.Options.UseFont = true;
            this.gridView1.Appearance.HotTrackedRow.Font = new DevExpress.Drawing.DXFont("LBC", 7.8F, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, new DevExpress.Drawing.DXFontAdditionalProperty[] {new DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", ((byte)(0)))});
            this.gridView1.Appearance.HotTrackedRow.Options.UseFont = true;
            this.gridView1.Appearance.OddRow.Font = new DevExpress.Drawing.DXFont("LBC", 7.8F, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, new DevExpress.Drawing.DXFontAdditionalProperty[] {new DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", ((byte)(0)))});
            this.gridView1.Appearance.OddRow.Options.UseFont = true;
            this.gridView1.Appearance.Preview.Font = new DevExpress.Drawing.DXFont("LBC", 7.8F, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, new DevExpress.Drawing.DXFontAdditionalProperty[] {new DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", ((byte)(0)))});
            this.gridView1.Appearance.Preview.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new DevExpress.Drawing.DXFont("LBC", 7.8F, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, new DevExpress.Drawing.DXFontAdditionalProperty[] {new DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", ((byte)(0)))});
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Appearance.Row.Options.UseTextOptions = true;
            this.gridView1.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.RowSeparator.Font = new DevExpress.Drawing.DXFont("LBC", 7.8F, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, new DevExpress.Drawing.DXFontAdditionalProperty[] {new DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", ((byte)(0)))});
            this.gridView1.Appearance.RowSeparator.Options.UseFont = true;
            this.gridView1.Appearance.SelectedRow.Font = new DevExpress.Drawing.DXFont("LBC", 7.8F, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, new DevExpress.Drawing.DXFontAdditionalProperty[] {new DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", ((byte)(0)))});
            this.gridView1.Appearance.SelectedRow.Options.UseFont = true;
            this.gridView1.Appearance.TopNewRow.Font = new DevExpress.Drawing.DXFont("LBC", 7.8F, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, new DevExpress.Drawing.DXFontAdditionalProperty[] {new DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", ((byte)(0)))});
            this.gridView1.Appearance.TopNewRow.Options.UseFont = true;
            this.gridView1.Appearance.VertLine.Font = new DevExpress.Drawing.DXFont("LBC", 7.8F, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, new DevExpress.Drawing.DXFontAdditionalProperty[] {new DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", ((byte)(0)))});
            this.gridView1.Appearance.VertLine.Options.UseFont = true;
            this.gridView1.Appearance.ViewCaption.Font = new DevExpress.Drawing.DXFont("LBC", 7.8F, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, new DevExpress.Drawing.DXFontAdditionalProperty[] {new DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", ((byte)(0)))});
            this.gridView1.Appearance.ViewCaption.Options.UseFont = true;
            this.gridView1.AppearancePrint.EvenRow.BackColor = System.Drawing.Color.White;
            this.gridView1.AppearancePrint.EvenRow.Font = new DevExpress.Drawing.DXFont("LBC", 7.8F, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, new DevExpress.Drawing.DXFontAdditionalProperty[] {new DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", ((byte)(0)))});
            this.gridView1.AppearancePrint.EvenRow.Options.UseBackColor = true;
            this.gridView1.AppearancePrint.EvenRow.Options.UseFont = true;
            this.gridView1.AppearancePrint.EvenRow.Options.UseTextOptions = true;
            this.gridView1.AppearancePrint.EvenRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.AppearancePrint.FilterPanel.Font = new DevExpress.Drawing.DXFont("LBC", 7.8F, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, new DevExpress.Drawing.DXFontAdditionalProperty[] {new DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", ((byte)(0)))});
            this.gridView1.AppearancePrint.FilterPanel.Options.UseFont = true;
            this.gridView1.AppearancePrint.FilterPanel.Options.UseTextOptions = true;
            this.gridView1.AppearancePrint.FilterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.AppearancePrint.FooterPanel.Font = new DevExpress.Drawing.DXFont("LBC", 7.8F, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, new DevExpress.Drawing.DXFontAdditionalProperty[] {new DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", ((byte)(0)))});
            this.gridView1.AppearancePrint.FooterPanel.Options.UseFont = true;
            this.gridView1.AppearancePrint.FooterPanel.Options.UseTextOptions = true;
            this.gridView1.AppearancePrint.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.AppearancePrint.GroupFooter.Font = new DevExpress.Drawing.DXFont("LBC", 7.8F, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, new DevExpress.Drawing.DXFontAdditionalProperty[] {new DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", ((byte)(0)))});
            this.gridView1.AppearancePrint.GroupFooter.Options.UseFont = true;
            this.gridView1.AppearancePrint.GroupFooter.Options.UseTextOptions = true;
            this.gridView1.AppearancePrint.GroupFooter.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.AppearancePrint.GroupRow.Font = new DevExpress.Drawing.DXFont("LBC", 7.8F, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, new DevExpress.Drawing.DXFontAdditionalProperty[] {new DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", ((byte)(0)))});
            this.gridView1.AppearancePrint.GroupRow.Options.UseFont = true;
            this.gridView1.AppearancePrint.GroupRow.Options.UseTextOptions = true;
            this.gridView1.AppearancePrint.GroupRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.AppearancePrint.HeaderPanel.Font = new DevExpress.Drawing.DXFont("LBC", 7.8F, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, new DevExpress.Drawing.DXFontAdditionalProperty[] {new DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", ((byte)(0)))});
            this.gridView1.AppearancePrint.HeaderPanel.Options.UseFont = true;
            this.gridView1.AppearancePrint.HeaderPanel.Options.UseTextOptions = true;
            this.gridView1.AppearancePrint.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.AppearancePrint.Lines.Font = new DevExpress.Drawing.DXFont("LBC", 7.8F, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, new DevExpress.Drawing.DXFontAdditionalProperty[] {new DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", ((byte)(0)))});
            this.gridView1.AppearancePrint.Lines.Options.UseFont = true;
            this.gridView1.AppearancePrint.Lines.Options.UseTextOptions = true;
            this.gridView1.AppearancePrint.Lines.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.AppearancePrint.OddRow.BackColor = System.Drawing.Color.White;
            this.gridView1.AppearancePrint.OddRow.Font = new DevExpress.Drawing.DXFont("LBC", 7.8F, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, new DevExpress.Drawing.DXFontAdditionalProperty[] {new DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", ((byte)(0)))});
            this.gridView1.AppearancePrint.OddRow.Options.UseBackColor = true;
            this.gridView1.AppearancePrint.OddRow.Options.UseFont = true;
            this.gridView1.AppearancePrint.OddRow.Options.UseTextOptions = true;
            this.gridView1.AppearancePrint.OddRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.AppearancePrint.Preview.Font = new DevExpress.Drawing.DXFont("LBC", 7.8F, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, new DevExpress.Drawing.DXFontAdditionalProperty[] {new DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", ((byte)(0)))});
            this.gridView1.AppearancePrint.Preview.Options.UseFont = true;
            this.gridView1.AppearancePrint.Preview.Options.UseTextOptions = true;
            this.gridView1.AppearancePrint.Preview.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.AppearancePrint.Row.Font = new DevExpress.Drawing.DXFont("LBC", 7.8F, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, new DevExpress.Drawing.DXFontAdditionalProperty[] {new DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", ((byte)(0)))});
            this.gridView1.AppearancePrint.Row.Options.UseFont = true;
            this.gridView1.AppearancePrint.Row.Options.UseTextOptions = true;
            this.gridView1.AppearancePrint.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn3,
            this.gridColumn4,
            this.colSellValue,
            this.colSellAllValue});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsPrint.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsPrint.EnableAppearanceOddRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "اسم المادة";
            this.gridColumn1.FieldName = "MatrialsName";
            this.gridColumn1.MinWidth = 25;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 94;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "الكمية";
            this.gridColumn3.FieldName = "Quantity";
            this.gridColumn3.MinWidth = 25;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            this.gridColumn3.Width = 94;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "حالة البيع";
            this.gridColumn4.FieldName = "SellState";
            this.gridColumn4.MinWidth = 25;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            this.gridColumn4.Width = 94;
            // 
            // colSellValue
            // 
            this.colSellValue.Caption = "سعر البيع";
            this.colSellValue.FieldName = "SellValue";
            this.colSellValue.MinWidth = 25;
            this.colSellValue.Name = "colSellValue";
            this.colSellValue.OptionsColumn.AllowEdit = false;
            this.colSellValue.Visible = true;
            this.colSellValue.VisibleIndex = 3;
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
            this.colSellAllValue.VisibleIndex = 4;
            this.colSellAllValue.Width = 94;
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
            this.xrLine1.SizeF = new System.Drawing.SizeF(382.5F, 9.666672F);
            // 
            // pic_company
            // 
            this.pic_company.ImageAlignment = DevExpress.XtraPrinting.ImageAlignment.MiddleCenter;
            this.pic_company.ImageSource = new DevExpress.XtraPrinting.Drawing.ImageSource("img", resources.GetString("pic_company.ImageSource"));
            this.pic_company.LocationFloat = new DevExpress.Utils.PointFloat(10F, 10F);
            this.pic_company.Name = "pic_company";
            this.pic_company.SizeF = new System.Drawing.SizeF(94.43604F, 89.16666F);
            this.pic_company.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            // 
            // txt_companydescription
            // 
            this.txt_companydescription.Font = new DevExpress.Drawing.DXFont("LBC", 9F, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, new DevExpress.Drawing.DXFontAdditionalProperty[] {new DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", ((byte)(0)))});
            this.txt_companydescription.LocationFloat = new DevExpress.Utils.PointFloat(135.8333F, 43.67515F);
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
            this.txt_companyname.LocationFloat = new DevExpress.Utils.PointFloat(135.8333F, 10F);
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
            this.xrLine3,
            this.xrLine2,
            this.txt_currancy,
            this.xrLabel6,
            this.txt_cridet,
            this.txt_totlaprice,
            this.xrLabel5,
            this.xrLabel2,
            this.txt_customarname,
            this.txt_sellid,
            this.label1});
            this.ReportHeader.HeightF = 147.5F;
            this.ReportHeader.Name = "ReportHeader";
            this.ReportHeader.StylePriority.UseBorders = false;
            // 
            // xrLine3
            // 
            this.xrLine3.LocationFloat = new DevExpress.Utils.PointFloat(0F, 137.8333F);
            this.xrLine3.Name = "xrLine3";
            this.xrLine3.SizeF = new System.Drawing.SizeF(382.5F, 9.666672F);
            // 
            // xrLine2
            // 
            this.xrLine2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 28F);
            this.xrLine2.Name = "xrLine2";
            this.xrLine2.SizeF = new System.Drawing.SizeF(382.5F, 9.666672F);
            // 
            // txt_currancy
            // 
            this.txt_currancy.Font = new DevExpress.Drawing.DXFont("LBC", 10F, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, new DevExpress.Drawing.DXFontAdditionalProperty[] {new DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", ((byte)(0)))});
            this.txt_currancy.LocationFloat = new DevExpress.Utils.PointFloat(10F, 98.67516F);
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
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(191F, 110.3333F);
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.SizeF = new System.Drawing.SizeF(192F, 24.84182F);
            this.xrLabel6.StyleName = "Title";
            this.xrLabel6.StylePriority.UseFont = false;
            this.xrLabel6.StylePriority.UseTextAlignment = false;
            this.xrLabel6.Text = "الديون";
            this.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // txt_cridet
            // 
            this.txt_cridet.Font = new DevExpress.Drawing.DXFont("LBC", 10F, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, new DevExpress.Drawing.DXFontAdditionalProperty[] {new DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", ((byte)(0)))});
            this.txt_cridet.LocationFloat = new DevExpress.Utils.PointFloat(55.83333F, 110.3333F);
            this.txt_cridet.Multiline = true;
            this.txt_cridet.Name = "txt_cridet";
            this.txt_cridet.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txt_cridet.SizeF = new System.Drawing.SizeF(121.6667F, 23F);
            this.txt_cridet.StylePriority.UseFont = false;
            this.txt_cridet.StylePriority.UseTextAlignment = false;
            this.txt_cridet.Text = "..........";
            this.txt_cridet.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // txt_totlaprice
            // 
            this.txt_totlaprice.Font = new DevExpress.Drawing.DXFont("LBC", 10F, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, new DevExpress.Drawing.DXFontAdditionalProperty[] {new DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", ((byte)(0)))});
            this.txt_totlaprice.LocationFloat = new DevExpress.Utils.PointFloat(55.83333F, 78.67516F);
            this.txt_totlaprice.Multiline = true;
            this.txt_totlaprice.Name = "txt_totlaprice";
            this.txt_totlaprice.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txt_totlaprice.SizeF = new System.Drawing.SizeF(121.6667F, 23F);
            this.txt_totlaprice.StylePriority.UseFont = false;
            this.txt_totlaprice.StylePriority.UseTextAlignment = false;
            this.txt_totlaprice.Text = "..........";
            this.txt_totlaprice.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel5
            // 
            this.xrLabel5.Font = new DevExpress.Drawing.DXFont("LBC", 10F, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, new DevExpress.Drawing.DXFontAdditionalProperty[] {new DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", ((byte)(0)))});
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(191F, 78.67516F);
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.SizeF = new System.Drawing.SizeF(192F, 24.84182F);
            this.xrLabel5.StyleName = "Title";
            this.xrLabel5.StylePriority.UseFont = false;
            this.xrLabel5.StylePriority.UseTextAlignment = false;
            this.xrLabel5.Text = "السعر الاجمالي";
            this.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel2
            // 
            this.xrLabel2.Font = new DevExpress.Drawing.DXFont("LBC", 10F, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, new DevExpress.Drawing.DXFontAdditionalProperty[] {new DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", ((byte)(0)))});
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(191F, 47.84182F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.SizeF = new System.Drawing.SizeF(192F, 24.84182F);
            this.xrLabel2.StyleName = "Title";
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.StylePriority.UseTextAlignment = false;
            this.xrLabel2.Text = "اسم العميل";
            this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // txt_customarname
            // 
            this.txt_customarname.Font = new DevExpress.Drawing.DXFont("LBC", 10F, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, new DevExpress.Drawing.DXFontAdditionalProperty[] {new DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", ((byte)(0)))});
            this.txt_customarname.LocationFloat = new DevExpress.Utils.PointFloat(55.83333F, 47.84182F);
            this.txt_customarname.Multiline = true;
            this.txt_customarname.Name = "txt_customarname";
            this.txt_customarname.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txt_customarname.SizeF = new System.Drawing.SizeF(121.6667F, 23F);
            this.txt_customarname.StylePriority.UseFont = false;
            this.txt_customarname.StylePriority.UseTextAlignment = false;
            this.txt_customarname.Text = "..........";
            this.txt_customarname.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // txt_sellid
            // 
            this.txt_sellid.Font = new DevExpress.Drawing.DXFont("LBC", 10F, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, new DevExpress.Drawing.DXFontAdditionalProperty[] {new DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", ((byte)(0)))});
            this.txt_sellid.LocationFloat = new DevExpress.Utils.PointFloat(55.83333F, 1.841812F);
            this.txt_sellid.Multiline = true;
            this.txt_sellid.Name = "txt_sellid";
            this.txt_sellid.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txt_sellid.SizeF = new System.Drawing.SizeF(121.6667F, 23F);
            this.txt_sellid.StylePriority.UseFont = false;
            this.txt_sellid.StylePriority.UseTextAlignment = false;
            this.txt_sellid.Text = "..........";
            this.txt_sellid.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new DevExpress.Drawing.DXFont("LBC", 12F, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, new DevExpress.Drawing.DXFontAdditionalProperty[] {new DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", ((byte)(0)))});
            this.label1.LocationFloat = new DevExpress.Utils.PointFloat(180F, 0F);
            this.label1.Name = "label1";
            this.label1.SizeF = new System.Drawing.SizeF(203F, 24.84182F);
            this.label1.StyleName = "Title";
            this.label1.StylePriority.UseFont = false;
            this.label1.StylePriority.UseTextAlignment = false;
            this.label1.Text = "وصل استلام فاتورة بيع رقم ";
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
            // SellReportAction
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader,
            Detail});
            this.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F);
            this.Margins = new DevExpress.Drawing.DXMargins(100, 100, 123, 23);
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
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
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
        private DevExpress.XtraReports.UI.XRLabel txt_totlaprice;
        private DevExpress.XtraReports.UI.XRLabel xrLabel5;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRLabel txt_customarname;
        private DevExpress.XtraReports.UI.XRLabel txt_sellid;
        private DevExpress.XtraReports.UI.XRLabel txt_companyname;
        private DevExpress.XtraReports.UI.XRLabel txt_currancy;
        private DevExpress.XtraReports.UI.XRPictureBox pic_company;
        private DevExpress.XtraReports.UI.XRLabel txt_companydescription;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn colMatrialsName;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colSellState;
        private DevExpress.XtraReports.UI.WinControlContainer winControlContainer1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn colSellValue;
        private DevExpress.XtraGrid.Columns.GridColumn colSellAllValue;
        private DevExpress.XtraReports.UI.XRLine xrLine1;
        private DevExpress.XtraReports.UI.XRLine xrLine3;
        private DevExpress.XtraReports.UI.XRLine xrLine2;
    }
}
