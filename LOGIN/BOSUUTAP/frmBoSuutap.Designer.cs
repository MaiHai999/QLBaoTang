namespace LOGIN.BOSUUTAP
{
    partial class frmBoSuutap
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
            System.Windows.Forms.Label mASUUTAPLabel;
            System.Windows.Forms.Label tENSUUTAPLabel;
            System.Windows.Forms.Label mAHINHTHUCLabel;
            System.Windows.Forms.Label mANHANVIENLabel;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBoSuutap));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnHoanTac = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MASUUTAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tENSUUTAPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mAHINHTHUCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MANV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bOSUUTAPBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.qLBAOTANGDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_BAOTANGDataSet = new LOGIN.QL_BAOTANGDataSet();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtMaNhanVien = new System.Windows.Forms.ComboBox();
            this.nHANVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtMaSuuTap = new DevExpress.XtraEditors.TextEdit();
            this.txtTenSuuTap = new DevExpress.XtraEditors.TextEdit();
            this.txtMaHinhThuc = new DevExpress.XtraEditors.TextEdit();
            this.bOSUUTAPTableAdapter = new LOGIN.QL_BAOTANGDataSetTableAdapters.BOSUUTAPTableAdapter();
            this.tableAdapterManager = new LOGIN.QL_BAOTANGDataSetTableAdapters.TableAdapterManager();
            this.nHANVIENTableAdapter = new LOGIN.QL_BAOTANGDataSetTableAdapters.NHANVIENTableAdapter();
            mASUUTAPLabel = new System.Windows.Forms.Label();
            tENSUUTAPLabel = new System.Windows.Forms.Label();
            mAHINHTHUCLabel = new System.Windows.Forms.Label();
            mANHANVIENLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOSUUTAPBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBAOTANGDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_BAOTANGDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSuuTap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenSuuTap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaHinhThuc.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // mASUUTAPLabel
            // 
            mASUUTAPLabel.AutoSize = true;
            mASUUTAPLabel.Location = new System.Drawing.Point(37, 37);
            mASUUTAPLabel.Name = "mASUUTAPLabel";
            mASUUTAPLabel.Size = new System.Drawing.Size(86, 13);
            mASUUTAPLabel.TabIndex = 0;
            mASUUTAPLabel.Text = "Mã  Bộ Sưu Tập:";
            // 
            // tENSUUTAPLabel
            // 
            tENSUUTAPLabel.AutoSize = true;
            tENSUUTAPLabel.Location = new System.Drawing.Point(36, 63);
            tENSUUTAPLabel.Name = "tENSUUTAPLabel";
            tENSUUTAPLabel.Size = new System.Drawing.Size(87, 13);
            tENSUUTAPLabel.TabIndex = 2;
            tENSUUTAPLabel.Text = "Tên Bộ Sưu Tập:";
            // 
            // mAHINHTHUCLabel
            // 
            mAHINHTHUCLabel.AutoSize = true;
            mAHINHTHUCLabel.Location = new System.Drawing.Point(328, 41);
            mAHINHTHUCLabel.Name = "mAHINHTHUCLabel";
            mAHINHTHUCLabel.Size = new System.Drawing.Size(102, 13);
            mAHINHTHUCLabel.TabIndex = 4;
            mAHINHTHUCLabel.Text = "Hình Thức Sưu Tập:";
            // 
            // mANHANVIENLabel
            // 
            mANHANVIENLabel.AutoSize = true;
            mANHANVIENLabel.Location = new System.Drawing.Point(371, 67);
            mANHANVIENLabel.Name = "mANHANVIENLabel";
            mANHANVIENLabel.Size = new System.Drawing.Size(59, 13);
            mANHANVIENLabel.TabIndex = 6;
            mANHANVIENLabel.Text = "Nhân Viên:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(542, 74);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(125, 22);
            label1.TabIndex = 10;
            label1.Text = "BỘ SƯU TẬP";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnXoa,
            this.btnGhi,
            this.btnHoanTac});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 4;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.Text = "Tools";
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhi, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHoanTac, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "ADD";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.LargeImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "DELETE";
            this.btnXoa.Id = 1;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.LargeImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnGhi
            // 
            this.btnGhi.Caption = "UPDATE";
            this.btnGhi.Id = 2;
            this.btnGhi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.Image")));
            this.btnGhi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.LargeImage")));
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhi_ItemClick);
            // 
            // btnHoanTac
            // 
            this.btnHoanTac.Caption = "Reaload";
            this.btnHoanTac.Id = 3;
            this.btnHoanTac.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHoanTac.ImageOptions.Image")));
            this.btnHoanTac.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnHoanTac.ImageOptions.LargeImage")));
            this.btnHoanTac.Name = "btnHoanTac";
            this.btnHoanTac.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHoanTac_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1096, 45);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 432);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1096, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 45);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 387);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1096, 45);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 387);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(250, 237);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(662, 176);
            this.panel1.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MASUUTAP,
            this.tENSUUTAPDataGridViewTextBoxColumn,
            this.mAHINHTHUCDataGridViewTextBoxColumn,
            this.MANV});
            this.dataGridView1.DataSource = this.bOSUUTAPBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(6, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(653, 170);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // MASUUTAP
            // 
            this.MASUUTAP.DataPropertyName = "MASUUTAP";
            this.MASUUTAP.HeaderText = "MASUUTAP";
            this.MASUUTAP.Name = "MASUUTAP";
            this.MASUUTAP.ReadOnly = true;
            // 
            // tENSUUTAPDataGridViewTextBoxColumn
            // 
            this.tENSUUTAPDataGridViewTextBoxColumn.DataPropertyName = "TENSUUTAP";
            this.tENSUUTAPDataGridViewTextBoxColumn.HeaderText = "TENSUUTAP";
            this.tENSUUTAPDataGridViewTextBoxColumn.Name = "tENSUUTAPDataGridViewTextBoxColumn";
            this.tENSUUTAPDataGridViewTextBoxColumn.ReadOnly = true;
            this.tENSUUTAPDataGridViewTextBoxColumn.Width = 150;
            // 
            // mAHINHTHUCDataGridViewTextBoxColumn
            // 
            this.mAHINHTHUCDataGridViewTextBoxColumn.DataPropertyName = "MAHINHTHUC";
            this.mAHINHTHUCDataGridViewTextBoxColumn.HeaderText = "MAHINHTHUC";
            this.mAHINHTHUCDataGridViewTextBoxColumn.Name = "mAHINHTHUCDataGridViewTextBoxColumn";
            this.mAHINHTHUCDataGridViewTextBoxColumn.ReadOnly = true;
            this.mAHINHTHUCDataGridViewTextBoxColumn.Width = 150;
            // 
            // MANV
            // 
            this.MANV.DataPropertyName = "MANHANVIEN";
            this.MANV.HeaderText = "MANHANVIEN";
            this.MANV.Name = "MANV";
            this.MANV.ReadOnly = true;
            this.MANV.Width = 150;
            // 
            // bOSUUTAPBindingSource1
            // 
            this.bOSUUTAPBindingSource1.DataMember = "BOSUUTAP";
            this.bOSUUTAPBindingSource1.DataSource = this.qLBAOTANGDataSetBindingSource;
            // 
            // qLBAOTANGDataSetBindingSource
            // 
            this.qLBAOTANGDataSetBindingSource.DataSource = this.qL_BAOTANGDataSet;
            this.qLBAOTANGDataSetBindingSource.Position = 0;
            // 
            // qL_BAOTANGDataSet
            // 
            this.qL_BAOTANGDataSet.DataSetName = "QL_BAOTANGDataSet";
            this.qL_BAOTANGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtMaNhanVien);
            this.panel2.Controls.Add(mASUUTAPLabel);
            this.panel2.Controls.Add(this.txtMaSuuTap);
            this.panel2.Controls.Add(tENSUUTAPLabel);
            this.panel2.Controls.Add(this.txtTenSuuTap);
            this.panel2.Controls.Add(mAHINHTHUCLabel);
            this.panel2.Controls.Add(this.txtMaHinhThuc);
            this.panel2.Controls.Add(mANHANVIENLabel);
            this.panel2.Location = new System.Drawing.Point(256, 115);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(656, 106);
            this.panel2.TabIndex = 5;
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.DataSource = this.nHANVIENBindingSource;
            this.txtMaNhanVien.DisplayMember = "TEN";
            this.txtMaNhanVien.FormattingEnabled = true;
            this.txtMaNhanVien.Location = new System.Drawing.Point(455, 67);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Size = new System.Drawing.Size(121, 21);
            this.txtMaNhanVien.TabIndex = 7;
            this.txtMaNhanVien.ValueMember = "MANV";
            // 
            // nHANVIENBindingSource
            // 
            this.nHANVIENBindingSource.DataMember = "NHANVIEN";
            this.nHANVIENBindingSource.DataSource = this.qL_BAOTANGDataSet;
            // 
            // txtMaSuuTap
            // 
            this.txtMaSuuTap.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bOSUUTAPBindingSource1, "MASUUTAP", true));
            this.txtMaSuuTap.Location = new System.Drawing.Point(138, 34);
            this.txtMaSuuTap.MenuManager = this.barManager1;
            this.txtMaSuuTap.Name = "txtMaSuuTap";
            this.txtMaSuuTap.Size = new System.Drawing.Size(120, 20);
            this.txtMaSuuTap.TabIndex = 1;
            // 
            // txtTenSuuTap
            // 
            this.txtTenSuuTap.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bOSUUTAPBindingSource1, "TENSUUTAP", true));
            this.txtTenSuuTap.Location = new System.Drawing.Point(138, 60);
            this.txtTenSuuTap.MenuManager = this.barManager1;
            this.txtTenSuuTap.Name = "txtTenSuuTap";
            this.txtTenSuuTap.Size = new System.Drawing.Size(120, 20);
            this.txtTenSuuTap.TabIndex = 3;
            // 
            // txtMaHinhThuc
            // 
            this.txtMaHinhThuc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bOSUUTAPBindingSource1, "MAHINHTHUC", true));
            this.txtMaHinhThuc.Location = new System.Drawing.Point(455, 38);
            this.txtMaHinhThuc.MenuManager = this.barManager1;
            this.txtMaHinhThuc.Name = "txtMaHinhThuc";
            this.txtMaHinhThuc.Size = new System.Drawing.Size(121, 20);
            this.txtMaHinhThuc.TabIndex = 5;
            // 
            // bOSUUTAPTableAdapter
            // 
            this.bOSUUTAPTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BOSUUTAPTableAdapter = this.bOSUUTAPTableAdapter;
            this.tableAdapterManager.CT_TRIENLAMTableAdapter = null;
            this.tableAdapterManager.HOIHOATableAdapter = null;
            this.tableAdapterManager.KHACTableAdapter = null;
            this.tableAdapterManager.LOAIMUONTableAdapter = null;
            this.tableAdapterManager.LOAIRIENGTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.TACGIATableAdapter = null;
            this.tableAdapterManager.TACTUONGTableAdapter = null;
            this.tableAdapterManager.TPNTTableAdapter = null;
            this.tableAdapterManager.TRIENLAMTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = LOGIN.QL_BAOTANGDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // nHANVIENTableAdapter
            // 
            this.nHANVIENTableAdapter.ClearBeforeFill = true;
            // 
            // frmBoSuutap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 452);
            this.Controls.Add(label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmBoSuutap";
            this.Text = "BỘ SƯU TẬP";
            this.Load += new System.EventHandler(this.frmBoSuutap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOSUUTAPBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBAOTANGDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_BAOTANGDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSuuTap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenSuuTap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaHinhThuc.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnHoanTac;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private QL_BAOTANGDataSet qL_BAOTANGDataSet;
        private QL_BAOTANGDataSetTableAdapters.BOSUUTAPTableAdapter bOSUUTAPTableAdapter;
        private QL_BAOTANGDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.TextEdit txtMaSuuTap;
        private DevExpress.XtraEditors.TextEdit txtTenSuuTap;
        private DevExpress.XtraEditors.TextEdit txtMaHinhThuc;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource qLBAOTANGDataSetBindingSource;
        private System.Windows.Forms.BindingSource bOSUUTAPBindingSource1;
        private System.Windows.Forms.ComboBox txtMaNhanVien;
        private System.Windows.Forms.BindingSource nHANVIENBindingSource;
        private QL_BAOTANGDataSetTableAdapters.NHANVIENTableAdapter nHANVIENTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn MASUUTAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENSUUTAPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAHINHTHUCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANV;
    }
}