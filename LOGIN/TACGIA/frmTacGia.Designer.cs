namespace LOGIN.TACGIA
{
    partial class frmTacGia
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
            System.Windows.Forms.Label mATACGIALabel;
            System.Windows.Forms.Label tENLabel;
            System.Windows.Forms.Label nGAYSINHLabel;
            System.Windows.Forms.Label nGAYMATLabel;
            System.Windows.Forms.Label qUOCTICHLabel;
            System.Windows.Forms.Label tHOIDAILabel;
            System.Windows.Forms.Label pHONGCACHCHINHLabel;
            System.Windows.Forms.Label dIENGIAILabel;
            System.Windows.Forms.Label label1;
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MATACGIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tENDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nGAYSINHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nGAYMATDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qUOCTICHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tHOIDAIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pHONGCACHCHINHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIENGIAIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tACGIABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_BAOTANGDataSet = new LOGIN.QL_BAOTANGDataSet();
            this.tACGIATableAdapter = new LOGIN.QL_BAOTANGDataSetTableAdapters.TACGIATableAdapter();
            this.tableAdapterManager = new LOGIN.QL_BAOTANGDataSetTableAdapters.TableAdapterManager();
            this.textMaTacGia = new DevExpress.XtraEditors.TextEdit();
            this.textTen = new DevExpress.XtraEditors.TextEdit();
            this.textNgaySinh = new DevExpress.XtraEditors.DateEdit();
            this.textNgayMat = new DevExpress.XtraEditors.DateEdit();
            this.textQuocTich = new DevExpress.XtraEditors.TextEdit();
            this.textThoiDai = new DevExpress.XtraEditors.TextEdit();
            this.textPhongCach = new DevExpress.XtraEditors.TextEdit();
            this.textDenDai = new DevExpress.XtraEditors.TextEdit();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            mATACGIALabel = new System.Windows.Forms.Label();
            tENLabel = new System.Windows.Forms.Label();
            nGAYSINHLabel = new System.Windows.Forms.Label();
            nGAYMATLabel = new System.Windows.Forms.Label();
            qUOCTICHLabel = new System.Windows.Forms.Label();
            tHOIDAILabel = new System.Windows.Forms.Label();
            pHONGCACHCHINHLabel = new System.Windows.Forms.Label();
            dIENGIAILabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tACGIABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_BAOTANGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textMaTacGia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textNgaySinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textNgaySinh.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textNgayMat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textNgayMat.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textQuocTich.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textThoiDai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textPhongCach.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textDenDai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // mATACGIALabel
            // 
            mATACGIALabel.AutoSize = true;
            mATACGIALabel.Location = new System.Drawing.Point(179, 127);
            mATACGIALabel.Name = "mATACGIALabel";
            mATACGIALabel.Size = new System.Drawing.Size(64, 13);
            mATACGIALabel.TabIndex = 1;
            mATACGIALabel.Text = "MATACGIA:";
            // 
            // tENLabel
            // 
            tENLabel.AutoSize = true;
            tENLabel.Location = new System.Drawing.Point(452, 127);
            tENLabel.Name = "tENLabel";
            tENLabel.Size = new System.Drawing.Size(30, 13);
            tENLabel.TabIndex = 3;
            tENLabel.Text = "TEN:";
            // 
            // nGAYSINHLabel
            // 
            nGAYSINHLabel.AutoSize = true;
            nGAYSINHLabel.Location = new System.Drawing.Point(703, 153);
            nGAYSINHLabel.Name = "nGAYSINHLabel";
            nGAYSINHLabel.Size = new System.Drawing.Size(62, 13);
            nGAYSINHLabel.TabIndex = 5;
            nGAYSINHLabel.Text = "NGAYSINH:";
            // 
            // nGAYMATLabel
            // 
            nGAYMATLabel.AutoSize = true;
            nGAYMATLabel.Location = new System.Drawing.Point(179, 153);
            nGAYMATLabel.Name = "nGAYMATLabel";
            nGAYMATLabel.Size = new System.Drawing.Size(59, 13);
            nGAYMATLabel.TabIndex = 7;
            nGAYMATLabel.Text = "NGAYMAT:";
            // 
            // qUOCTICHLabel
            // 
            qUOCTICHLabel.AutoSize = true;
            qUOCTICHLabel.Location = new System.Drawing.Point(452, 153);
            qUOCTICHLabel.Name = "qUOCTICHLabel";
            qUOCTICHLabel.Size = new System.Drawing.Size(65, 13);
            qUOCTICHLabel.TabIndex = 9;
            qUOCTICHLabel.Text = "QUOCTICH:";
            // 
            // tHOIDAILabel
            // 
            tHOIDAILabel.AutoSize = true;
            tHOIDAILabel.Location = new System.Drawing.Point(703, 180);
            tHOIDAILabel.Name = "tHOIDAILabel";
            tHOIDAILabel.Size = new System.Drawing.Size(54, 13);
            tHOIDAILabel.TabIndex = 11;
            tHOIDAILabel.Text = "THOIDAI:";
            // 
            // pHONGCACHCHINHLabel
            // 
            pHONGCACHCHINHLabel.AutoSize = true;
            pHONGCACHCHINHLabel.Location = new System.Drawing.Point(179, 180);
            pHONGCACHCHINHLabel.Name = "pHONGCACHCHINHLabel";
            pHONGCACHCHINHLabel.Size = new System.Drawing.Size(106, 13);
            pHONGCACHCHINHLabel.TabIndex = 13;
            pHONGCACHCHINHLabel.Text = "PHONGCACHCHINH:";
            // 
            // dIENGIAILabel
            // 
            dIENGIAILabel.AutoSize = true;
            dIENGIAILabel.Location = new System.Drawing.Point(452, 180);
            dIENGIAILabel.Name = "dIENGIAILabel";
            dIENGIAILabel.Size = new System.Drawing.Size(57, 13);
            dIENGIAILabel.TabIndex = 15;
            dIENGIAILabel.Text = "DIENGIAI:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(525, 44);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(90, 22);
            label1.TabIndex = 21;
            label1.Text = "TÁC GIẢ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MATACGIA,
            this.tENDataGridViewTextBoxColumn,
            this.nGAYSINHDataGridViewTextBoxColumn,
            this.nGAYMATDataGridViewTextBoxColumn,
            this.qUOCTICHDataGridViewTextBoxColumn,
            this.tHOIDAIDataGridViewTextBoxColumn,
            this.pHONGCACHCHINHDataGridViewTextBoxColumn,
            this.dIENGIAIDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tACGIABindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(128, 227);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(948, 189);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // MATACGIA
            // 
            this.MATACGIA.DataPropertyName = "MATACGIA";
            this.MATACGIA.HeaderText = "MATACGIA";
            this.MATACGIA.Name = "MATACGIA";
            this.MATACGIA.ReadOnly = true;
            // 
            // tENDataGridViewTextBoxColumn
            // 
            this.tENDataGridViewTextBoxColumn.DataPropertyName = "TEN";
            this.tENDataGridViewTextBoxColumn.HeaderText = "TEN";
            this.tENDataGridViewTextBoxColumn.Name = "tENDataGridViewTextBoxColumn";
            this.tENDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nGAYSINHDataGridViewTextBoxColumn
            // 
            this.nGAYSINHDataGridViewTextBoxColumn.DataPropertyName = "NGAYSINH";
            this.nGAYSINHDataGridViewTextBoxColumn.HeaderText = "NGAYSINH";
            this.nGAYSINHDataGridViewTextBoxColumn.Name = "nGAYSINHDataGridViewTextBoxColumn";
            this.nGAYSINHDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nGAYMATDataGridViewTextBoxColumn
            // 
            this.nGAYMATDataGridViewTextBoxColumn.DataPropertyName = "NGAYMAT";
            this.nGAYMATDataGridViewTextBoxColumn.HeaderText = "NGAYMAT";
            this.nGAYMATDataGridViewTextBoxColumn.Name = "nGAYMATDataGridViewTextBoxColumn";
            this.nGAYMATDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // qUOCTICHDataGridViewTextBoxColumn
            // 
            this.qUOCTICHDataGridViewTextBoxColumn.DataPropertyName = "QUOCTICH";
            this.qUOCTICHDataGridViewTextBoxColumn.HeaderText = "QUOCTICH";
            this.qUOCTICHDataGridViewTextBoxColumn.Name = "qUOCTICHDataGridViewTextBoxColumn";
            this.qUOCTICHDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tHOIDAIDataGridViewTextBoxColumn
            // 
            this.tHOIDAIDataGridViewTextBoxColumn.DataPropertyName = "THOIDAI";
            this.tHOIDAIDataGridViewTextBoxColumn.HeaderText = "THOIDAI";
            this.tHOIDAIDataGridViewTextBoxColumn.Name = "tHOIDAIDataGridViewTextBoxColumn";
            this.tHOIDAIDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pHONGCACHCHINHDataGridViewTextBoxColumn
            // 
            this.pHONGCACHCHINHDataGridViewTextBoxColumn.DataPropertyName = "PHONGCACHCHINH";
            this.pHONGCACHCHINHDataGridViewTextBoxColumn.HeaderText = "PHONGCACHCHINH";
            this.pHONGCACHCHINHDataGridViewTextBoxColumn.Name = "pHONGCACHCHINHDataGridViewTextBoxColumn";
            this.pHONGCACHCHINHDataGridViewTextBoxColumn.ReadOnly = true;
            this.pHONGCACHCHINHDataGridViewTextBoxColumn.Width = 150;
            // 
            // dIENGIAIDataGridViewTextBoxColumn
            // 
            this.dIENGIAIDataGridViewTextBoxColumn.DataPropertyName = "DIENGIAI";
            this.dIENGIAIDataGridViewTextBoxColumn.HeaderText = "DIENGIAI";
            this.dIENGIAIDataGridViewTextBoxColumn.Name = "dIENGIAIDataGridViewTextBoxColumn";
            this.dIENGIAIDataGridViewTextBoxColumn.ReadOnly = true;
            this.dIENGIAIDataGridViewTextBoxColumn.Width = 150;
            // 
            // tACGIABindingSource
            // 
            this.tACGIABindingSource.DataMember = "TACGIA";
            this.tACGIABindingSource.DataSource = this.qL_BAOTANGDataSet;
            // 
            // qL_BAOTANGDataSet
            // 
            this.qL_BAOTANGDataSet.DataSetName = "QL_BAOTANGDataSet";
            this.qL_BAOTANGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tACGIATableAdapter
            // 
            this.tACGIATableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BOSUUTAPTableAdapter = null;
            this.tableAdapterManager.CT_TRIENLAMTableAdapter = null;
            this.tableAdapterManager.HOIHOATableAdapter = null;
            this.tableAdapterManager.KHACTableAdapter = null;
            this.tableAdapterManager.LOAIMUONTableAdapter = null;
            this.tableAdapterManager.LOAIRIENGTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.TACGIATableAdapter = this.tACGIATableAdapter;
            this.tableAdapterManager.TACTUONGTableAdapter = null;
            this.tableAdapterManager.TPNTTableAdapter = null;
            this.tableAdapterManager.TRIENLAMTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = LOGIN.QL_BAOTANGDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // textMaTacGia
            // 
            this.textMaTacGia.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tACGIABindingSource, "MATACGIA", true));
            this.textMaTacGia.Location = new System.Drawing.Point(291, 124);
            this.textMaTacGia.Name = "textMaTacGia";
            this.textMaTacGia.Size = new System.Drawing.Size(139, 20);
            this.textMaTacGia.TabIndex = 2;
            // 
            // textTen
            // 
            this.textTen.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tACGIABindingSource, "TEN", true));
            this.textTen.Location = new System.Drawing.Point(529, 124);
            this.textTen.Name = "textTen";
            this.textTen.Size = new System.Drawing.Size(135, 20);
            this.textTen.TabIndex = 4;
            // 
            // textNgaySinh
            // 
            this.textNgaySinh.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tACGIABindingSource, "NGAYSINH", true));
            this.textNgaySinh.EditValue = null;
            this.textNgaySinh.Location = new System.Drawing.Point(783, 150);
            this.textNgaySinh.Name = "textNgaySinh";
            this.textNgaySinh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.textNgaySinh.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.textNgaySinh.Size = new System.Drawing.Size(132, 20);
            this.textNgaySinh.TabIndex = 6;
            // 
            // textNgayMat
            // 
            this.textNgayMat.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.True;
            this.textNgayMat.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tACGIABindingSource, "NGAYMAT", true));
            this.textNgayMat.EditValue = null;
            this.textNgayMat.Location = new System.Drawing.Point(291, 150);
            this.textNgayMat.Name = "textNgayMat";
            this.textNgayMat.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.textNgayMat.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.textNgayMat.Size = new System.Drawing.Size(139, 20);
            this.textNgayMat.TabIndex = 8;
            // 
            // textQuocTich
            // 
            this.textQuocTich.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tACGIABindingSource, "QUOCTICH", true));
            this.textQuocTich.Location = new System.Drawing.Point(529, 150);
            this.textQuocTich.Name = "textQuocTich";
            this.textQuocTich.Size = new System.Drawing.Size(135, 20);
            this.textQuocTich.TabIndex = 10;
            // 
            // textThoiDai
            // 
            this.textThoiDai.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tACGIABindingSource, "THOIDAI", true));
            this.textThoiDai.Location = new System.Drawing.Point(783, 177);
            this.textThoiDai.Name = "textThoiDai";
            this.textThoiDai.Size = new System.Drawing.Size(132, 20);
            this.textThoiDai.TabIndex = 12;
            // 
            // textPhongCach
            // 
            this.textPhongCach.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tACGIABindingSource, "PHONGCACHCHINH", true));
            this.textPhongCach.Location = new System.Drawing.Point(291, 177);
            this.textPhongCach.Name = "textPhongCach";
            this.textPhongCach.Size = new System.Drawing.Size(139, 20);
            this.textPhongCach.TabIndex = 14;
            // 
            // textDenDai
            // 
            this.textDenDai.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tACGIABindingSource, "DIENGIAI", true));
            this.textDenDai.Location = new System.Drawing.Point(529, 177);
            this.textDenDai.Name = "textDenDai";
            this.textDenDai.Size = new System.Drawing.Size(135, 20);
            this.textDenDai.TabIndex = 16;
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
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem4});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 5;
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
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem3),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem4)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "ADD";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "DELETE";
            this.barButtonItem2.Id = 2;
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "UPDATE";
            this.barButtonItem3.Id = 3;
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "RELOAD";
            this.barButtonItem4.Id = 4;
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(997, 41);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 416);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(997, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 41);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 375);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(997, 41);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 375);
            // 
            // frmTacGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 436);
            this.Controls.Add(label1);
            this.Controls.Add(mATACGIALabel);
            this.Controls.Add(this.textMaTacGia);
            this.Controls.Add(tENLabel);
            this.Controls.Add(this.textTen);
            this.Controls.Add(nGAYSINHLabel);
            this.Controls.Add(this.textNgaySinh);
            this.Controls.Add(nGAYMATLabel);
            this.Controls.Add(this.textNgayMat);
            this.Controls.Add(qUOCTICHLabel);
            this.Controls.Add(this.textQuocTich);
            this.Controls.Add(tHOIDAILabel);
            this.Controls.Add(this.textThoiDai);
            this.Controls.Add(pHONGCACHCHINHLabel);
            this.Controls.Add(this.textPhongCach);
            this.Controls.Add(dIENGIAILabel);
            this.Controls.Add(this.textDenDai);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmTacGia";
            this.Text = "TÁC GIẢ";
            this.Load += new System.EventHandler(this.frmTacGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tACGIABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_BAOTANGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textMaTacGia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textNgaySinh.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textNgaySinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textNgayMat.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textNgayMat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textQuocTich.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textThoiDai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textPhongCach.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textDenDai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private QL_BAOTANGDataSet qL_BAOTANGDataSet;
        private System.Windows.Forms.BindingSource tACGIABindingSource;
        private QL_BAOTANGDataSetTableAdapters.TACGIATableAdapter tACGIATableAdapter;
        private QL_BAOTANGDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.TextEdit textMaTacGia;
        private DevExpress.XtraEditors.TextEdit textTen;
        private DevExpress.XtraEditors.DateEdit textNgaySinh;
        private DevExpress.XtraEditors.DateEdit textNgayMat;
        private DevExpress.XtraEditors.TextEdit textQuocTich;
        private DevExpress.XtraEditors.TextEdit textThoiDai;
        private DevExpress.XtraEditors.TextEdit textPhongCach;
        private DevExpress.XtraEditors.TextEdit textDenDai;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.DataGridViewTextBoxColumn MATACGIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nGAYSINHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nGAYMATDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qUOCTICHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tHOIDAIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pHONGCACHCHINHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIENGIAIDataGridViewTextBoxColumn;
    }
}