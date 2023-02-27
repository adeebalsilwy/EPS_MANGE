
namespace EPS.Page
{
    partial class Notifications
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
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition2 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition3 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition4 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement3 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement4 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notifications));
            this.colNoteDes = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colNoteDate = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.tileView1 = new DevExpress.XtraGrid.Views.Tile.TileView();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_state = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_showlog = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.combo_filter = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_clearall = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // colNoteDes
            // 
            this.colNoteDes.FieldName = "NoteDes";
            this.colNoteDes.MinWidth = 25;
            this.colNoteDes.Name = "colNoteDes";
            this.colNoteDes.Visible = true;
            this.colNoteDes.VisibleIndex = 0;
            this.colNoteDes.Width = 94;
            // 
            // colNoteDate
            // 
            this.colNoteDate.Caption = "التاريخ : ";
            this.colNoteDate.FieldName = "NoteDate";
            this.colNoteDate.MinWidth = 25;
            this.colNoteDate.Name = "colNoteDate";
            this.colNoteDate.Visible = true;
            this.colNoteDate.VisibleIndex = 1;
            this.colNoteDate.Width = 94;
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataSource = typeof(EPS.TB_Note);
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.tileView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(463, 595);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tileView1,
            this.gridView2,
            this.gridView1});
            this.gridControl1.MouseLeave += new System.EventHandler(this.gridControl1_MouseLeave);
            // 
            // tileView1
            // 
            this.tileView1.Appearance.EmptySpace.BackColor = System.Drawing.SystemColors.Control;
            this.tileView1.Appearance.EmptySpace.Options.UseBackColor = true;
            this.tileView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNoteDes,
            this.colNoteDate});
            this.tileView1.GridControl = this.gridControl1;
            this.tileView1.Name = "tileView1";
            this.tileView1.OptionsTiles.GroupTextPadding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.tileView1.OptionsTiles.IndentBetweenGroups = 0;
            this.tileView1.OptionsTiles.IndentBetweenItems = 0;
            this.tileView1.OptionsTiles.ItemSize = new System.Drawing.Size(248, 58);
            this.tileView1.OptionsTiles.LayoutMode = DevExpress.XtraGrid.Views.Tile.TileViewLayoutMode.List;
            this.tileView1.OptionsTiles.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tileView1.OptionsTiles.Padding = new System.Windows.Forms.Padding(0);
            this.tileView1.OptionsTiles.RowCount = 0;
            this.tileView1.TileColumns.Add(tableColumnDefinition2);
            this.tileView1.TileRows.Add(tableRowDefinition3);
            this.tileView1.TileRows.Add(tableRowDefinition4);
            tileViewItemElement3.Appearance.Normal.Font = new System.Drawing.Font("LBC", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tileViewItemElement3.Appearance.Normal.Options.UseBorderColor = true;
            tileViewItemElement3.Appearance.Normal.Options.UseFont = true;
            tileViewItemElement3.Column = this.colNoteDes;
            tileViewItemElement3.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement3.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileViewItemElement3.Text = "colNoteDes";
            tileViewItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement4.Appearance.Normal.Font = new System.Drawing.Font("LBC", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tileViewItemElement4.Appearance.Normal.Options.UseFont = true;
            tileViewItemElement4.Column = this.colNoteDate;
            tileViewItemElement4.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement4.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileViewItemElement4.RowIndex = 1;
            tileViewItemElement4.Text = "colNoteDate";
            tileViewItemElement4.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tileView1.TileTemplate.Add(tileViewItemElement3);
            this.tileView1.TileTemplate.Add(tileViewItemElement4);
            this.tileView1.ItemDoubleClick += new DevExpress.XtraGrid.Views.Tile.TileViewItemClickEventHandler(this.tileView1_ItemDoubleClick);
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lb_state);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.gridControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(463, 649);
            this.panel1.TabIndex = 0;
            // 
            // lb_state
            // 
            this.lb_state.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_state.Font = new System.Drawing.Font("LBC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_state.Location = new System.Drawing.Point(44, 220);
            this.lb_state.Name = "lb_state";
            this.lb_state.Size = new System.Drawing.Size(375, 208);
            this.lb_state.TabIndex = 2;
            this.lb_state.Text = "لا يوجد اشعارت  \r\nيتم هنا تسجيل كافة التحركات في النظام \r\nيمكنك عرض سجل النظام لم" +
    "شاهدة كافة التحركات ";
            this.lb_state.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_state.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.btn_showlog);
            this.panel2.Controls.Add(this.linkLabel1);
            this.panel2.Controls.Add(this.combo_filter);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btn_clearall);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 591);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(463, 58);
            this.panel2.TabIndex = 1;
            // 
            // btn_showlog
            // 
            this.btn_showlog.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_showlog.AutoSize = true;
            this.btn_showlog.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_showlog.Location = new System.Drawing.Point(55, 23);
            this.btn_showlog.Name = "btn_showlog";
            this.btn_showlog.Size = new System.Drawing.Size(114, 17);
            this.btn_showlog.TabIndex = 3;
            this.btn_showlog.TabStop = true;
            this.btn_showlog.Text = "عرض سجل النظام";
            this.btn_showlog.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btn_showlog_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.linkLabel1.Location = new System.Drawing.Point(197, 21);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(71, 17);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "حذف الفلتر";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // combo_filter
            // 
            this.combo_filter.AllowDrop = true;
            this.combo_filter.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.combo_filter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_filter.Font = new System.Drawing.Font("LBC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_filter.FormattingEnabled = true;
            this.combo_filter.Items.AddRange(new object[] {
            "اضافة",
            "حذف",
            "تعديل",
            "تصفير"});
            this.combo_filter.Location = new System.Drawing.Point(274, 9);
            this.combo_filter.Name = "combo_filter";
            this.combo_filter.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.combo_filter.Size = new System.Drawing.Size(136, 38);
            this.combo_filter.TabIndex = 2;
            this.combo_filter.SelectedIndexChanged += new System.EventHandler(this.combo_filter_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Font = new System.Drawing.Font("LBC", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(416, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 58);
            this.label1.TabIndex = 1;
            this.label1.Text = "فلترة";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_clearall
            // 
            this.btn_clearall.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_clearall.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_clearall.ImageOptions.Image")));
            this.btn_clearall.Location = new System.Drawing.Point(0, 0);
            this.btn_clearall.Name = "btn_clearall";
            this.btn_clearall.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_clearall.Size = new System.Drawing.Size(49, 58);
            this.btn_clearall.TabIndex = 0;
            this.btn_clearall.ToolTip = "تنظيف";
            this.btn_clearall.Click += new System.EventHandler(this.btn_clearall_Click);
            // 
            // Notifications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "Notifications";
            this.Size = new System.Drawing.Size(463, 649);
            this.Load += new System.EventHandler(this.Notifications_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Tile.TileView tileView1;
        private DevExpress.XtraGrid.Columns.TileViewColumn colNoteDes;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox combo_filter;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btn_clearall;
        private DevExpress.XtraGrid.Columns.TileViewColumn colNoteDate;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel btn_showlog;
        private System.Windows.Forms.Label lb_state;
    }
}
