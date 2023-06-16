namespace LOGIN.TRIENLAM
{
    partial class frmTPNT
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.qL_BAOTANGDataSet = new LOGIN.QL_BAOTANGDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textMaTrienLam = new DevExpress.XtraEditors.TextEdit();
            this.textTenTL = new DevExpress.XtraEditors.TextEdit();
            this.dateEditNgayBD = new DevExpress.XtraEditors.DateEdit();
            this.dateEditNgayKT = new DevExpress.XtraEditors.DateEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.vIEW_GETTPNTTableAdapter = new LOGIN.QL_BAOTANGDataSetTableAdapters.VIEW_GETTPNTTableAdapter();
            this.vIEWGETTPNTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.vIEWGETTPNTBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MATPNT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tENTPNTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tENTACGIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mOTADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vIEWGETTPNTBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.qL_BAOTANGDataSet1 = new LOGIN.QL_BAOTANGDataSet();
            this.MATPNT1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENTPNT1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TACGIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MOTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_BAOTANGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textMaTrienLam.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textTenTL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditNgayBD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditNgayBD.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditNgayKT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditNgayKT.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vIEWGETTPNTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vIEWGETTPNTBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vIEWGETTPNTBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_BAOTANGDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MATPNT1,
            this.TENTPNT1,
            this.TACGIA,
            this.MOTA});
            this.dataGridView2.Location = new System.Drawing.Point(115, 327);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(997, 150);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // qL_BAOTANGDataSet
            // 
            this.qL_BAOTANGDataSet.DataSetName = "QL_BAOTANGDataSet";
            this.qL_BAOTANGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(770, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã Triển Lãm:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(766, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên Triển Lãm:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(766, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ngày Bắt Đầu:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(766, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ngày Bắt Đầu:";
            // 
            // textMaTrienLam
            // 
            this.textMaTrienLam.Location = new System.Drawing.Point(869, 127);
            this.textMaTrienLam.Name = "textMaTrienLam";
            this.textMaTrienLam.Size = new System.Drawing.Size(201, 20);
            this.textMaTrienLam.TabIndex = 7;
            // 
            // textTenTL
            // 
            this.textTenTL.Location = new System.Drawing.Point(869, 166);
            this.textTenTL.Name = "textTenTL";
            this.textTenTL.Size = new System.Drawing.Size(201, 20);
            this.textTenTL.TabIndex = 8;
            // 
            // dateEditNgayBD
            // 
            this.dateEditNgayBD.EditValue = null;
            this.dateEditNgayBD.Location = new System.Drawing.Point(869, 204);
            this.dateEditNgayBD.Name = "dateEditNgayBD";
            this.dateEditNgayBD.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditNgayBD.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditNgayBD.Size = new System.Drawing.Size(201, 20);
            this.dateEditNgayBD.TabIndex = 9;
            this.dateEditNgayBD.EditValueChanged += new System.EventHandler(this.dateEdit1_EditValueChanged);
            // 
            // dateEditNgayKT
            // 
            this.dateEditNgayKT.EditValue = null;
            this.dateEditNgayKT.Location = new System.Drawing.Point(869, 241);
            this.dateEditNgayKT.Name = "dateEditNgayKT";
            this.dateEditNgayKT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditNgayKT.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditNgayKT.Size = new System.Drawing.Size(201, 20);
            this.dateEditNgayKT.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(520, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(233, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "CHI TIẾT TPNT CỦA CUỘC TRIỂN LÃM";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(308, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(262, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "DANH SÁCH CÁC TÁC PHẨM NGHỆ THUẬT";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(825, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(197, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "CHI TIẾT CỦA CUỘC TRIỂN LÃM";
            // 
            // vIEW_GETTPNTTableAdapter
            // 
            this.vIEW_GETTPNTTableAdapter.ClearBeforeFill = true;
            // 
            // vIEWGETTPNTBindingSource
            // 
            this.vIEWGETTPNTBindingSource.DataMember = "VIEW_GETTPNT";
            this.vIEWGETTPNTBindingSource.DataSource = this.qL_BAOTANGDataSet;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(912, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "TẠO TRIỂN LÃM";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.barButtonItem2});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 2;
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
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem2)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "THÊM TPNT VÀO TRIỂN LÃM";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "XÓA TPNT VÀO TRIỂN LÃM";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(1384, 41);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 736);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1384, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 41);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 695);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1384, 41);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 695);
            // 
            // vIEWGETTPNTBindingSource1
            // 
            this.vIEWGETTPNTBindingSource1.DataMember = "VIEW_GETTPNT";
            this.vIEWGETTPNTBindingSource1.DataSource = this.qL_BAOTANGDataSet;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MATPNT,
            this.tENTPNTDataGridViewTextBoxColumn,
            this.tENTACGIADataGridViewTextBoxColumn,
            this.mOTADataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vIEWGETTPNTBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(115, 130);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(638, 150);
            this.dataGridView1.TabIndex = 28;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            // 
            // MATPNT
            // 
            this.MATPNT.DataPropertyName = "MATPNT";
            this.MATPNT.HeaderText = "MATPNT";
            this.MATPNT.Name = "MATPNT";
            // 
            // tENTPNTDataGridViewTextBoxColumn
            // 
            this.tENTPNTDataGridViewTextBoxColumn.DataPropertyName = "TENTPNT";
            this.tENTPNTDataGridViewTextBoxColumn.HeaderText = "TENTPNT";
            this.tENTPNTDataGridViewTextBoxColumn.Name = "tENTPNTDataGridViewTextBoxColumn";
            this.tENTPNTDataGridViewTextBoxColumn.Width = 150;
            // 
            // tENTACGIADataGridViewTextBoxColumn
            // 
            this.tENTACGIADataGridViewTextBoxColumn.DataPropertyName = "TENTACGIA";
            this.tENTACGIADataGridViewTextBoxColumn.HeaderText = "TENTACGIA";
            this.tENTACGIADataGridViewTextBoxColumn.Name = "tENTACGIADataGridViewTextBoxColumn";
            this.tENTACGIADataGridViewTextBoxColumn.ReadOnly = true;
            this.tENTACGIADataGridViewTextBoxColumn.Width = 150;
            // 
            // mOTADataGridViewTextBoxColumn
            // 
            this.mOTADataGridViewTextBoxColumn.DataPropertyName = "MOTA";
            this.mOTADataGridViewTextBoxColumn.HeaderText = "MOTA";
            this.mOTADataGridViewTextBoxColumn.Name = "mOTADataGridViewTextBoxColumn";
            this.mOTADataGridViewTextBoxColumn.Width = 150;
            // 
            // vIEWGETTPNTBindingSource2
            // 
            this.vIEWGETTPNTBindingSource2.DataMember = "VIEW_GETTPNT";
            this.vIEWGETTPNTBindingSource2.DataSource = this.qL_BAOTANGDataSet1;
            // 
            // qL_BAOTANGDataSet1
            // 
            this.qL_BAOTANGDataSet1.DataSetName = "QL_BAOTANGDataSet";
            this.qL_BAOTANGDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // MATPNT1
            // 
            this.MATPNT1.DataPropertyName = "MATPNT";
            this.MATPNT1.HeaderText = "MÃ TPNT";
            this.MATPNT1.Name = "MATPNT1";
            this.MATPNT1.ReadOnly = true;
            this.MATPNT1.Width = 200;
            // 
            // TENTPNT1
            // 
            this.TENTPNT1.DataPropertyName = "TENTPNT";
            this.TENTPNT1.HeaderText = "TÊN TPNT";
            this.TENTPNT1.Name = "TENTPNT1";
            this.TENTPNT1.ReadOnly = true;
            this.TENTPNT1.Width = 250;
            // 
            // TACGIA
            // 
            this.TACGIA.DataPropertyName = "TENTACGIA";
            this.TACGIA.HeaderText = "TÁC GIẢ";
            this.TACGIA.Name = "TACGIA";
            this.TACGIA.ReadOnly = true;
            this.TACGIA.Width = 250;
            // 
            // MOTA
            // 
            this.MOTA.DataPropertyName = "CTMOTA";
            this.MOTA.HeaderText = "MÔ TẢ";
            this.MOTA.Name = "MOTA";
            this.MOTA.ReadOnly = true;
            this.MOTA.Width = 250;
            // 
            // frmTPNT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 756);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateEditNgayKT);
            this.Controls.Add(this.dateEditNgayBD);
            this.Controls.Add(this.textTenTL);
            this.Controls.Add(this.textMaTrienLam);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmTPNT";
            this.Text = "TẠO TRIỂN LÃM";
            this.Load += new System.EventHandler(this.frmTPNT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_BAOTANGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textMaTrienLam.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textTenTL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditNgayBD.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditNgayBD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditNgayKT.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditNgayKT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vIEWGETTPNTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vIEWGETTPNTBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vIEWGETTPNTBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_BAOTANGDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit textMaTrienLam;
        private DevExpress.XtraEditors.TextEdit textTenTL;
        private DevExpress.XtraEditors.DateEdit dateEditNgayBD;
        private DevExpress.XtraEditors.DateEdit dateEditNgayKT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private QL_BAOTANGDataSet qL_BAOTANGDataSet;
        private QL_BAOTANGDataSetTableAdapters.VIEW_GETTPNTTableAdapter vIEW_GETTPNTTableAdapter;
        private System.Windows.Forms.BindingSource vIEWGETTPNTBindingSource;
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTMOTADataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource vIEWGETTPNTBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private QL_BAOTANGDataSet qL_BAOTANGDataSet1;
        private System.Windows.Forms.BindingSource vIEWGETTPNTBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MATPNT;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENTPNTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENTACGIADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mOTADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MATPNT1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENTPNT1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TACGIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn MOTA;
    }
}