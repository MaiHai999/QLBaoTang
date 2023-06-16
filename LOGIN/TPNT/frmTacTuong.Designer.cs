namespace LOGIN.TPNT
{
    partial class frmTacTuong
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
            System.Windows.Forms.Label mÃ_TPNTLabel;
            System.Windows.Forms.Label tÊN_TPNTLabel;
            System.Windows.Forms.Label tÁC_GIẢLabel;
            System.Windows.Forms.Label cHIỀU_CAO_Label;
            System.Windows.Forms.Label kHỐI_LƯỢNGLabel;
            System.Windows.Forms.Label pHONG_CÁCH_Label;
            System.Windows.Forms.Label vẬT_LIỆULabel;
            System.Windows.Forms.Label mÔ_TẢLabel;
            System.Windows.Forms.Label label1;
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MATPNT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENTPNT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MOTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TACGIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHIEUCAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KHOILUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PHONGCACH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VATLIEU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vIEWTACTUONG1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_BAOTANGDataSet = new LOGIN.QL_BAOTANGDataSet();
            this.vIEW_TACTUONG1TableAdapter = new LOGIN.QL_BAOTANGDataSetTableAdapters.VIEW_TACTUONG1TableAdapter();
            this.tableAdapterManager = new LOGIN.QL_BAOTANGDataSetTableAdapters.TableAdapterManager();
            this.tACGIATableAdapter = new LOGIN.QL_BAOTANGDataSetTableAdapters.TACGIATableAdapter();
            this.textMATPNT = new DevExpress.XtraEditors.TextEdit();
            this.textTENTPNT = new DevExpress.XtraEditors.TextEdit();
            this.textChieuCao = new DevExpress.XtraEditors.SpinEdit();
            this.textKhoiLuong = new DevExpress.XtraEditors.SpinEdit();
            this.textPhongCach = new DevExpress.XtraEditors.TextEdit();
            this.textVatLieu = new DevExpress.XtraEditors.TextEdit();
            this.textBoxMoTa = new System.Windows.Forms.RichTextBox();
            this.textTacGia = new System.Windows.Forms.ComboBox();
            this.tACGIABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            mÃ_TPNTLabel = new System.Windows.Forms.Label();
            tÊN_TPNTLabel = new System.Windows.Forms.Label();
            tÁC_GIẢLabel = new System.Windows.Forms.Label();
            cHIỀU_CAO_Label = new System.Windows.Forms.Label();
            kHỐI_LƯỢNGLabel = new System.Windows.Forms.Label();
            pHONG_CÁCH_Label = new System.Windows.Forms.Label();
            vẬT_LIỆULabel = new System.Windows.Forms.Label();
            mÔ_TẢLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vIEWTACTUONG1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_BAOTANGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textMATPNT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textTENTPNT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textChieuCao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textKhoiLuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textPhongCach.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textVatLieu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tACGIABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // mÃ_TPNTLabel
            // 
            mÃ_TPNTLabel.AutoSize = true;
            mÃ_TPNTLabel.Location = new System.Drawing.Point(155, 129);
            mÃ_TPNTLabel.Name = "mÃ_TPNTLabel";
            mÃ_TPNTLabel.Size = new System.Drawing.Size(54, 13);
            mÃ_TPNTLabel.TabIndex = 1;
            mÃ_TPNTLabel.Text = "MÃ TPNT:";
            // 
            // tÊN_TPNTLabel
            // 
            tÊN_TPNTLabel.AutoSize = true;
            tÊN_TPNTLabel.Location = new System.Drawing.Point(155, 155);
            tÊN_TPNTLabel.Name = "tÊN_TPNTLabel";
            tÊN_TPNTLabel.Size = new System.Drawing.Size(58, 13);
            tÊN_TPNTLabel.TabIndex = 3;
            tÊN_TPNTLabel.Text = "TÊN TPNT:";
            // 
            // tÁC_GIẢLabel
            // 
            tÁC_GIẢLabel.AutoSize = true;
            tÁC_GIẢLabel.Location = new System.Drawing.Point(872, 129);
            tÁC_GIẢLabel.Name = "tÁC_GIẢLabel";
            tÁC_GIẢLabel.Size = new System.Drawing.Size(52, 13);
            tÁC_GIẢLabel.TabIndex = 7;
            tÁC_GIẢLabel.Text = "TÁC GIẢ:";
            // 
            // cHIỀU_CAO_Label
            // 
            cHIỀU_CAO_Label.AutoSize = true;
            cHIỀU_CAO_Label.Location = new System.Drawing.Point(377, 129);
            cHIỀU_CAO_Label.Name = "cHIỀU_CAO_Label";
            cHIỀU_CAO_Label.Size = new System.Drawing.Size(70, 13);
            cHIỀU_CAO_Label.TabIndex = 9;
            cHIỀU_CAO_Label.Text = "CHIỀU CAO :";
            // 
            // kHỐI_LƯỢNGLabel
            // 
            kHỐI_LƯỢNGLabel.AutoSize = true;
            kHỐI_LƯỢNGLabel.Location = new System.Drawing.Point(377, 155);
            kHỐI_LƯỢNGLabel.Name = "kHỐI_LƯỢNGLabel";
            kHỐI_LƯỢNGLabel.Size = new System.Drawing.Size(74, 13);
            kHỐI_LƯỢNGLabel.TabIndex = 11;
            kHỐI_LƯỢNGLabel.Text = "KHỐI LƯỢNG:";
            // 
            // pHONG_CÁCH_Label
            // 
            pHONG_CÁCH_Label.AutoSize = true;
            pHONG_CÁCH_Label.Location = new System.Drawing.Point(603, 129);
            pHONG_CÁCH_Label.Name = "pHONG_CÁCH_Label";
            pHONG_CÁCH_Label.Size = new System.Drawing.Size(80, 13);
            pHONG_CÁCH_Label.TabIndex = 13;
            pHONG_CÁCH_Label.Text = "PHONG CÁCH :";
            // 
            // vẬT_LIỆULabel
            // 
            vẬT_LIỆULabel.AutoSize = true;
            vẬT_LIỆULabel.Location = new System.Drawing.Point(603, 155);
            vẬT_LIỆULabel.Name = "vẬT_LIỆULabel";
            vẬT_LIỆULabel.Size = new System.Drawing.Size(55, 13);
            vẬT_LIỆULabel.TabIndex = 15;
            vẬT_LIỆULabel.Text = "VẬT LIỆU:";
            // 
            // mÔ_TẢLabel
            // 
            mÔ_TẢLabel.AutoSize = true;
            mÔ_TẢLabel.Location = new System.Drawing.Point(157, 195);
            mÔ_TẢLabel.Name = "mÔ_TẢLabel";
            mÔ_TẢLabel.Size = new System.Drawing.Size(43, 13);
            mÔ_TẢLabel.TabIndex = 5;
            mÔ_TẢLabel.Text = "MÔ TẢ:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(353, 70);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(509, 22);
            label1.TabIndex = 23;
            label1.Text = "TÁC PHẨM NGHỆ THUẬT TẠC TƯỢNG VÀ ĐIÊU KHẮC";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MATPNT,
            this.TENTPNT,
            this.MOTA,
            this.TACGIA,
            this.CHIEUCAO,
            this.KHOILUONG,
            this.PHONGCACH,
            this.VATLIEU});
            this.dataGridView1.DataSource = this.vIEWTACTUONG1BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(78, 258);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(997, 173);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // MATPNT
            // 
            this.MATPNT.DataPropertyName = "MÃ TPNT";
            this.MATPNT.HeaderText = "MÃ TPNT";
            this.MATPNT.Name = "MATPNT";
            // 
            // TENTPNT
            // 
            this.TENTPNT.DataPropertyName = "TÊN TPNT";
            this.TENTPNT.HeaderText = "TÊN TPNT";
            this.TENTPNT.Name = "TENTPNT";
            this.TENTPNT.ReadOnly = true;
            this.TENTPNT.Width = 150;
            // 
            // MOTA
            // 
            this.MOTA.DataPropertyName = "MÔ TẢ";
            this.MOTA.HeaderText = "MÔ TẢ";
            this.MOTA.Name = "MOTA";
            this.MOTA.ReadOnly = true;
            this.MOTA.Width = 150;
            // 
            // TACGIA
            // 
            this.TACGIA.DataPropertyName = "TÁC GIẢ";
            this.TACGIA.HeaderText = "TÁC GIẢ";
            this.TACGIA.Name = "TACGIA";
            this.TACGIA.ReadOnly = true;
            // 
            // CHIEUCAO
            // 
            this.CHIEUCAO.DataPropertyName = "CHIỀU CAO ";
            this.CHIEUCAO.HeaderText = "CHIỀU CAO ";
            this.CHIEUCAO.Name = "CHIEUCAO";
            // 
            // KHOILUONG
            // 
            this.KHOILUONG.DataPropertyName = "KHỐI LƯỢNG";
            this.KHOILUONG.HeaderText = "KHỐI LƯỢNG";
            this.KHOILUONG.Name = "KHOILUONG";
            // 
            // PHONGCACH
            // 
            this.PHONGCACH.DataPropertyName = "PHONG CÁCH ";
            this.PHONGCACH.HeaderText = "PHONG CÁCH ";
            this.PHONGCACH.Name = "PHONGCACH";
            // 
            // VATLIEU
            // 
            this.VATLIEU.DataPropertyName = "VẬT LIỆU";
            this.VATLIEU.HeaderText = "VẬT LIỆU";
            this.VATLIEU.Name = "VATLIEU";
            this.VATLIEU.Width = 150;
            // 
            // vIEWTACTUONG1BindingSource
            // 
            this.vIEWTACTUONG1BindingSource.DataMember = "VIEW_TACTUONG1";
            this.vIEWTACTUONG1BindingSource.DataSource = this.qL_BAOTANGDataSet;
            // 
            // qL_BAOTANGDataSet
            // 
            this.qL_BAOTANGDataSet.DataSetName = "QL_BAOTANGDataSet";
            this.qL_BAOTANGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vIEW_TACTUONG1TableAdapter
            // 
            this.vIEW_TACTUONG1TableAdapter.ClearBeforeFill = true;
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
            // tACGIATableAdapter
            // 
            this.tACGIATableAdapter.ClearBeforeFill = true;
            // 
            // textMATPNT
            // 
            this.textMATPNT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.vIEWTACTUONG1BindingSource, "MÃ TPNT", true));
            this.textMATPNT.Location = new System.Drawing.Point(219, 126);
            this.textMATPNT.Name = "textMATPNT";
            this.textMATPNT.Size = new System.Drawing.Size(122, 20);
            this.textMATPNT.TabIndex = 2;
            // 
            // textTENTPNT
            // 
            this.textTENTPNT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.vIEWTACTUONG1BindingSource, "TÊN TPNT", true));
            this.textTENTPNT.Location = new System.Drawing.Point(219, 152);
            this.textTENTPNT.Name = "textTENTPNT";
            this.textTENTPNT.Size = new System.Drawing.Size(122, 20);
            this.textTENTPNT.TabIndex = 4;
            // 
            // textChieuCao
            // 
            this.textChieuCao.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.vIEWTACTUONG1BindingSource, "CHIỀU CAO ", true));
            this.textChieuCao.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.textChieuCao.Location = new System.Drawing.Point(463, 126);
            this.textChieuCao.Name = "textChieuCao";
            this.textChieuCao.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.textChieuCao.Size = new System.Drawing.Size(100, 20);
            this.textChieuCao.TabIndex = 10;
            // 
            // textKhoiLuong
            // 
            this.textKhoiLuong.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.vIEWTACTUONG1BindingSource, "KHỐI LƯỢNG", true));
            this.textKhoiLuong.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.textKhoiLuong.Location = new System.Drawing.Point(463, 152);
            this.textKhoiLuong.Name = "textKhoiLuong";
            this.textKhoiLuong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.textKhoiLuong.Size = new System.Drawing.Size(100, 20);
            this.textKhoiLuong.TabIndex = 12;
            // 
            // textPhongCach
            // 
            this.textPhongCach.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.vIEWTACTUONG1BindingSource, "PHONG CÁCH ", true));
            this.textPhongCach.Location = new System.Drawing.Point(689, 126);
            this.textPhongCach.Name = "textPhongCach";
            this.textPhongCach.Size = new System.Drawing.Size(151, 20);
            this.textPhongCach.TabIndex = 14;
            // 
            // textVatLieu
            // 
            this.textVatLieu.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.vIEWTACTUONG1BindingSource, "VẬT LIỆU", true));
            this.textVatLieu.Location = new System.Drawing.Point(689, 152);
            this.textVatLieu.Name = "textVatLieu";
            this.textVatLieu.Size = new System.Drawing.Size(151, 20);
            this.textVatLieu.TabIndex = 16;
            // 
            // textBoxMoTa
            // 
            this.textBoxMoTa.Location = new System.Drawing.Point(243, 192);
            this.textBoxMoTa.Name = "textBoxMoTa";
            this.textBoxMoTa.Size = new System.Drawing.Size(709, 60);
            this.textBoxMoTa.TabIndex = 17;
            this.textBoxMoTa.Text = "";
            // 
            // textTacGia
            // 
            this.textTacGia.DataSource = this.tACGIABindingSource;
            this.textTacGia.DisplayMember = "TEN";
            this.textTacGia.FormattingEnabled = true;
            this.textTacGia.Location = new System.Drawing.Point(930, 125);
            this.textTacGia.Name = "textTacGia";
            this.textTacGia.Size = new System.Drawing.Size(121, 21);
            this.textTacGia.TabIndex = 18;
            this.textTacGia.ValueMember = "MATACGIA";
            // 
            // tACGIABindingSource
            // 
            this.tACGIABindingSource.DataMember = "TACGIA";
            this.tACGIABindingSource.DataSource = this.qL_BAOTANGDataSet;
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
            this.barButtonItem4,
            this.barButtonItem5});
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
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem4),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem5)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "ADD";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "DELETE";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "UPDATE";
            this.barButtonItem3.Id = 2;
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "READ MORE";
            this.barButtonItem4.Id = 3;
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "RELOAD";
            this.barButtonItem5.Id = 4;
            this.barButtonItem5.Name = "barButtonItem5";
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
            this.barDockControlTop.Size = new System.Drawing.Size(1298, 41);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 430);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1298, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 41);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 389);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1298, 41);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 389);
            // 
            // frmTacTuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 450);
            this.Controls.Add(label1);
            this.Controls.Add(this.textTacGia);
            this.Controls.Add(this.textBoxMoTa);
            this.Controls.Add(mÃ_TPNTLabel);
            this.Controls.Add(this.textMATPNT);
            this.Controls.Add(tÊN_TPNTLabel);
            this.Controls.Add(this.textTENTPNT);
            this.Controls.Add(mÔ_TẢLabel);
            this.Controls.Add(tÁC_GIẢLabel);
            this.Controls.Add(cHIỀU_CAO_Label);
            this.Controls.Add(this.textChieuCao);
            this.Controls.Add(kHỐI_LƯỢNGLabel);
            this.Controls.Add(this.textKhoiLuong);
            this.Controls.Add(pHONG_CÁCH_Label);
            this.Controls.Add(this.textPhongCach);
            this.Controls.Add(vẬT_LIỆULabel);
            this.Controls.Add(this.textVatLieu);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmTacTuong";
            this.Text = "TẠC TƯỢNG ";
            this.Load += new System.EventHandler(this.frmTacTuong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vIEWTACTUONG1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_BAOTANGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textMATPNT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textTENTPNT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textChieuCao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textKhoiLuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textPhongCach.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textVatLieu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tACGIABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private QL_BAOTANGDataSet qL_BAOTANGDataSet;
        private System.Windows.Forms.BindingSource vIEWTACTUONG1BindingSource;
        private QL_BAOTANGDataSetTableAdapters.VIEW_TACTUONG1TableAdapter vIEW_TACTUONG1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn MATPNT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENTPNT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MOTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn TACGIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHIEUCAO;
        private System.Windows.Forms.DataGridViewTextBoxColumn KHOILUONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn PHONGCACH;
        private System.Windows.Forms.DataGridViewTextBoxColumn VATLIEU;
        private QL_BAOTANGDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.TextEdit textMATPNT;
        private DevExpress.XtraEditors.TextEdit textTENTPNT;
        private DevExpress.XtraEditors.SpinEdit textChieuCao;
        private DevExpress.XtraEditors.SpinEdit textKhoiLuong;
        private DevExpress.XtraEditors.TextEdit textPhongCach;
        private DevExpress.XtraEditors.TextEdit textVatLieu;
        private System.Windows.Forms.RichTextBox textBoxMoTa;
        private System.Windows.Forms.ComboBox textTacGia;
        private QL_BAOTANGDataSetTableAdapters.TACGIATableAdapter tACGIATableAdapter;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.BindingSource tACGIABindingSource;
    }
}