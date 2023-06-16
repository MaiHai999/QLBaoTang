namespace LOGIN.TPNT
{
    partial class frmLoaiMuon
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
            this.label1 = new System.Windows.Forms.Label();
            this.textEditMaTPNT = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonADD = new System.Windows.Forms.Button();
            this.textEditNgayTra = new DevExpress.XtraEditors.DateEdit();
            this.textEditNgayMuon = new DevExpress.XtraEditors.DateEdit();
            this.textEditBST = new System.Windows.Forms.ComboBox();
            this.bOSUUTAPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_BAOTANGDataSet = new LOGIN.QL_BAOTANGDataSet();
            this.bOSUUTAPTableAdapter = new LOGIN.QL_BAOTANGDataSetTableAdapters.BOSUUTAPTableAdapter();
            this.buttonUPDATE = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.textEditMaTPNT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditNgayTra.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditNgayTra.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditNgayMuon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditNgayMuon.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOSUUTAPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_BAOTANGDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "MA TPNT";
            // 
            // textEditMaTPNT
            // 
            this.textEditMaTPNT.Enabled = false;
            this.textEditMaTPNT.Location = new System.Drawing.Point(168, 126);
            this.textEditMaTPNT.Name = "textEditMaTPNT";
            this.textEditMaTPNT.Size = new System.Drawing.Size(117, 20);
            this.textEditMaTPNT.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(385, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bộ Sưu Tập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(385, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ngày Trả";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ngày Mượn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(204, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(301, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "THÔNG TIN VỀ TPNT ĐI MƯỢN";
            // 
            // buttonADD
            // 
            this.buttonADD.Location = new System.Drawing.Point(533, 242);
            this.buttonADD.Name = "buttonADD";
            this.buttonADD.Size = new System.Drawing.Size(89, 23);
            this.buttonADD.TabIndex = 9;
            this.buttonADD.Text = "ADD";
            this.buttonADD.UseVisualStyleBackColor = true;
            this.buttonADD.Click += new System.EventHandler(this.buttonADD_Click);
            // 
            // textEditNgayTra
            // 
            this.textEditNgayTra.EditValue = null;
            this.textEditNgayTra.Location = new System.Drawing.Point(470, 197);
            this.textEditNgayTra.Name = "textEditNgayTra";
            this.textEditNgayTra.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.textEditNgayTra.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.textEditNgayTra.Size = new System.Drawing.Size(130, 20);
            this.textEditNgayTra.TabIndex = 10;
            this.textEditNgayTra.EditValueChanged += new System.EventHandler(this.textEditNgayTra_EditValueChanged);
            // 
            // textEditNgayMuon
            // 
            this.textEditNgayMuon.EditValue = null;
            this.textEditNgayMuon.Location = new System.Drawing.Point(168, 200);
            this.textEditNgayMuon.Name = "textEditNgayMuon";
            this.textEditNgayMuon.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.textEditNgayMuon.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.textEditNgayMuon.Size = new System.Drawing.Size(117, 20);
            this.textEditNgayMuon.TabIndex = 11;
            // 
            // textEditBST
            // 
            this.textEditBST.DataSource = this.bOSUUTAPBindingSource;
            this.textEditBST.DisplayMember = "TENSUUTAP";
            this.textEditBST.FormattingEnabled = true;
            this.textEditBST.Location = new System.Drawing.Point(470, 129);
            this.textEditBST.Name = "textEditBST";
            this.textEditBST.Size = new System.Drawing.Size(130, 21);
            this.textEditBST.TabIndex = 12;
            this.textEditBST.ValueMember = "MASUUTAP";
            // 
            // bOSUUTAPBindingSource
            // 
            this.bOSUUTAPBindingSource.DataMember = "BOSUUTAP";
            this.bOSUUTAPBindingSource.DataSource = this.qL_BAOTANGDataSet;
            // 
            // qL_BAOTANGDataSet
            // 
            this.qL_BAOTANGDataSet.DataSetName = "QL_BAOTANGDataSet";
            this.qL_BAOTANGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bOSUUTAPTableAdapter
            // 
            this.bOSUUTAPTableAdapter.ClearBeforeFill = true;
            // 
            // buttonUPDATE
            // 
            this.buttonUPDATE.Location = new System.Drawing.Point(533, 271);
            this.buttonUPDATE.Name = "buttonUPDATE";
            this.buttonUPDATE.Size = new System.Drawing.Size(89, 22);
            this.buttonUPDATE.TabIndex = 13;
            this.buttonUPDATE.Text = "UPDATE";
            this.buttonUPDATE.UseVisualStyleBackColor = true;
            this.buttonUPDATE.Click += new System.EventHandler(this.buttonUPDATE_Click);
            // 
            // frmLoaiMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 330);
            this.Controls.Add(this.buttonUPDATE);
            this.Controls.Add(this.textEditBST);
            this.Controls.Add(this.textEditNgayMuon);
            this.Controls.Add(this.textEditNgayTra);
            this.Controls.Add(this.buttonADD);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textEditMaTPNT);
            this.Controls.Add(this.label1);
            this.Name = "frmLoaiMuon";
            this.Text = "LOẠI MƯỢN";
            this.Load += new System.EventHandler(this.frmLoaiMuon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textEditMaTPNT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditNgayTra.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditNgayTra.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditNgayMuon.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditNgayMuon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOSUUTAPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_BAOTANGDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Button buttonADD;
        private QL_BAOTANGDataSet qL_BAOTANGDataSet;
        private System.Windows.Forms.BindingSource bOSUUTAPBindingSource;
        private QL_BAOTANGDataSetTableAdapters.BOSUUTAPTableAdapter bOSUUTAPTableAdapter;
        public DevExpress.XtraEditors.DateEdit textEditNgayTra;
        public DevExpress.XtraEditors.DateEdit textEditNgayMuon;
        public System.Windows.Forms.ComboBox textEditBST;
        public DevExpress.XtraEditors.TextEdit textEditMaTPNT;
        public System.Windows.Forms.Button buttonUPDATE;
    }
}