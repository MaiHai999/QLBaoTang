namespace LOGIN.TRIENLAM
{
    partial class frmTrienLam
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
            this.qL_BAOTANGDataSet = new LOGIN.QL_BAOTANGDataSet();
            this.sPDANGNHAPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_DANGNHAPTableAdapter = new LOGIN.QL_BAOTANGDataSetTableAdapters.SP_DANGNHAPTableAdapter();
            this.tRIENLAMTableAdapter = new LOGIN.QL_BAOTANGDataSetTableAdapters.TRIENLAMTableAdapter();
            this.tPNTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tPNTTableAdapter = new LOGIN.QL_BAOTANGDataSetTableAdapters.TPNTTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.label7 = new System.Windows.Forms.Label();
            this.dateEditNgayKT = new DevExpress.XtraEditors.DateEdit();
            this.dateEditNgayBD = new DevExpress.XtraEditors.DateEdit();
            this.textTenTL = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textMATL = new DevExpress.XtraEditors.TextEdit();
            this.sPDANGNHAPBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.vIEWGETTPNTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vIEW_GETTPNTTableAdapter = new LOGIN.QL_BAOTANGDataSetTableAdapters.VIEW_GETTPNTTableAdapter();
            this.tRIENLAMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MATRIENLAM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENTRIENLAM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYBD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYKT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tRIENLAMBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.MATPNT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.qL_BAOTANGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPDANGNHAPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPNTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditNgayKT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditNgayKT.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditNgayBD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditNgayBD.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textTenTL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textMATL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPDANGNHAPBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vIEWGETTPNTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRIENLAMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRIENLAMBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // qL_BAOTANGDataSet
            // 
            this.qL_BAOTANGDataSet.DataSetName = "QL_BAOTANGDataSet";
            this.qL_BAOTANGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sPDANGNHAPBindingSource
            // 
            this.sPDANGNHAPBindingSource.DataMember = "SP_DANGNHAP";
            this.sPDANGNHAPBindingSource.DataSource = this.qL_BAOTANGDataSet;
            // 
            // sP_DANGNHAPTableAdapter
            // 
            this.sP_DANGNHAPTableAdapter.ClearBeforeFill = true;
            // 
            // tRIENLAMTableAdapter
            // 
            this.tRIENLAMTableAdapter.ClearBeforeFill = true;
            // 
            // tPNTBindingSource
            // 
            this.tPNTBindingSource.DataMember = "TPNT";
            this.tPNTBindingSource.DataSource = this.qL_BAOTANGDataSet;
            // 
            // tPNTTableAdapter
            // 
            this.tPNTTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(256, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "CÁC CUỘC TRIỂN LÃM";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MATPNT,
            this.Column1,
            this.Column2,
            this.Column4});
            this.dataGridView2.Location = new System.Drawing.Point(134, 320);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(874, 143);
            this.dataGridView2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(462, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "CHI TIẾT TÁC PHẨM NGHỆ THUẬT";
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
            this.barButtonItem3});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 3;
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
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem3)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "UPDATE";
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
            this.barButtonItem3.Caption = "RELOAD";
            this.barButtonItem3.Id = 2;
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(1109, 41);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 425);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1109, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 41);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 384);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1109, 41);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 384);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(763, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(197, 15);
            this.label7.TabIndex = 26;
            this.label7.Text = "CHI TIẾT CỦA CUỘC TRIỂN LÃM";
            // 
            // dateEditNgayKT
            // 
            this.dateEditNgayKT.EditValue = null;
            this.dateEditNgayKT.Location = new System.Drawing.Point(807, 233);
            this.dateEditNgayKT.Name = "dateEditNgayKT";
            this.dateEditNgayKT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditNgayKT.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditNgayKT.Size = new System.Drawing.Size(201, 20);
            this.dateEditNgayKT.TabIndex = 25;
            // 
            // dateEditNgayBD
            // 
            this.dateEditNgayBD.EditValue = null;
            this.dateEditNgayBD.Location = new System.Drawing.Point(807, 198);
            this.dateEditNgayBD.Name = "dateEditNgayBD";
            this.dateEditNgayBD.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditNgayBD.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditNgayBD.Size = new System.Drawing.Size(201, 20);
            this.dateEditNgayBD.TabIndex = 24;
            // 
            // textTenTL
            // 
            this.textTenTL.Location = new System.Drawing.Point(807, 165);
            this.textTenTL.Name = "textTenTL";
            this.textTenTL.Size = new System.Drawing.Size(201, 20);
            this.textTenTL.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(704, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Ngày Bắt Đầu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(704, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Ngày Bắt Đầu:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(704, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Tên Triển Lãm:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(704, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Mã Triển Lãm:";
            // 
            // textMATL
            // 
            this.textMATL.Enabled = false;
            this.textMATL.Location = new System.Drawing.Point(807, 133);
            this.textMATL.Name = "textMATL";
            this.textMATL.Size = new System.Drawing.Size(201, 20);
            this.textMATL.TabIndex = 32;
            // 
            // sPDANGNHAPBindingSource1
            // 
            this.sPDANGNHAPBindingSource1.DataMember = "SP_DANGNHAP";
            this.sPDANGNHAPBindingSource1.DataSource = this.qL_BAOTANGDataSet;
            // 
            // vIEWGETTPNTBindingSource
            // 
            this.vIEWGETTPNTBindingSource.DataMember = "VIEW_GETTPNT";
            this.vIEWGETTPNTBindingSource.DataSource = this.qL_BAOTANGDataSet;
            // 
            // vIEW_GETTPNTTableAdapter
            // 
            this.vIEW_GETTPNTTableAdapter.ClearBeforeFill = true;
            // 
            // tRIENLAMBindingSource
            // 
            this.tRIENLAMBindingSource.DataMember = "TRIENLAM";
            this.tRIENLAMBindingSource.DataSource = this.qL_BAOTANGDataSet;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MATRIENLAM,
            this.TENTRIENLAM,
            this.NGAYBD,
            this.NGAYKT});
            this.dataGridView1.DataSource = this.tRIENLAMBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(134, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(524, 150);
            this.dataGridView1.TabIndex = 37;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // MATRIENLAM
            // 
            this.MATRIENLAM.DataPropertyName = "MATRIENLAM";
            this.MATRIENLAM.HeaderText = "MATRIENLAM";
            this.MATRIENLAM.Name = "MATRIENLAM";
            this.MATRIENLAM.ReadOnly = true;
            // 
            // TENTRIENLAM
            // 
            this.TENTRIENLAM.DataPropertyName = "TENTRIENLAM";
            this.TENTRIENLAM.HeaderText = "TENTRIENLAM";
            this.TENTRIENLAM.Name = "TENTRIENLAM";
            this.TENTRIENLAM.ReadOnly = true;
            this.TENTRIENLAM.Width = 150;
            // 
            // NGAYBD
            // 
            this.NGAYBD.DataPropertyName = "NGAYBD";
            this.NGAYBD.HeaderText = "NGAYBD";
            this.NGAYBD.Name = "NGAYBD";
            this.NGAYBD.ReadOnly = true;
            this.NGAYBD.Width = 110;
            // 
            // NGAYKT
            // 
            this.NGAYKT.DataPropertyName = "NGAYKT";
            this.NGAYKT.HeaderText = "NGAYKT";
            this.NGAYKT.Name = "NGAYKT";
            this.NGAYKT.ReadOnly = true;
            this.NGAYKT.Width = 110;
            // 
            // tRIENLAMBindingSource1
            // 
            this.tRIENLAMBindingSource1.DataMember = "TRIENLAM";
            this.tRIENLAMBindingSource1.DataSource = this.qL_BAOTANGDataSet;
            // 
            // MATPNT
            // 
            this.MATPNT.DataPropertyName = "MATPNT";
            this.MATPNT.HeaderText = "Mã TPNT";
            this.MATPNT.Name = "MATPNT";
            this.MATPNT.ReadOnly = true;
            this.MATPNT.Width = 200;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "TENTPNT";
            this.Column1.HeaderText = "Tên TPNT";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 200;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TENTACGIA";
            this.Column2.HeaderText = "Tên Tác Giả";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 200;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "CTMOTA";
            this.Column4.HeaderText = "Mô Tả";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 200;
            // 
            // frmTrienLam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 445);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textMATL);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateEditNgayKT);
            this.Controls.Add(this.dateEditNgayBD);
            this.Controls.Add(this.textTenTL);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmTrienLam";
            this.Text = "TRIỂN LÃM";
            this.Load += new System.EventHandler(this.frmTrienLam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qL_BAOTANGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPDANGNHAPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPNTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditNgayKT.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditNgayKT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditNgayBD.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditNgayBD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textTenTL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textMATL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPDANGNHAPBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vIEWGETTPNTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRIENLAMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRIENLAMBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource sPDANGNHAPBindingSource;
        private QL_BAOTANGDataSet qL_BAOTANGDataSet;
        private QL_BAOTANGDataSetTableAdapters.SP_DANGNHAPTableAdapter sP_DANGNHAPTableAdapter;
        private QL_BAOTANGDataSetTableAdapters.TRIENLAMTableAdapter tRIENLAMTableAdapter;
        private System.Windows.Forms.BindingSource tPNTBindingSource;
        private QL_BAOTANGDataSetTableAdapters.TPNTTableAdapter tPNTTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.DateEdit dateEditNgayKT;
        private DevExpress.XtraEditors.DateEdit dateEditNgayBD;
        private DevExpress.XtraEditors.TextEdit textTenTL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.TextEdit textMATL;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource sPDANGNHAPBindingSource1;
        private System.Windows.Forms.BindingSource vIEWGETTPNTBindingSource;
        private QL_BAOTANGDataSetTableAdapters.VIEW_GETTPNTTableAdapter vIEW_GETTPNTTableAdapter;
        private System.Windows.Forms.BindingSource tRIENLAMBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource tRIENLAMBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MATRIENLAM;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENTRIENLAM;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYBD;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYKT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MATPNT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}