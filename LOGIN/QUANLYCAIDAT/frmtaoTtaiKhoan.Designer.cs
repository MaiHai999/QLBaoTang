namespace LOGIN.QUANLYCAIDAT
{
    partial class frmtaoTtaiKhoan
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
            System.Windows.Forms.Label label2;
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MANV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tENDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMNDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIACHIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHUCDANH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nHANVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_BAOTANGDataSet = new LOGIN.QL_BAOTANGDataSet();
            this.nHANVIENTableAdapter = new LOGIN.QL_BAOTANGDataSetTableAdapters.NHANVIENTableAdapter();
            this.l = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textLoginName = new DevExpress.XtraEditors.TextEdit();
            this.buttonTaoTK = new System.Windows.Forms.Button();
            this.buttonXoaTK = new System.Windows.Forms.Button();
            this.textPassWord = new DevExpress.XtraEditors.TextEdit();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_BAOTANGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textLoginName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textPassWord.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MANV,
            this.hODataGridViewTextBoxColumn,
            this.tENDataGridViewTextBoxColumn,
            this.cMNDDataGridViewTextBoxColumn,
            this.dIACHIDataGridViewTextBoxColumn,
            this.sDTDataGridViewTextBoxColumn,
            this.CHUCDANH});
            this.dataGridView1.DataSource = this.nHANVIENBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(39, 253);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1001, 188);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // MANV
            // 
            this.MANV.DataPropertyName = "MANV";
            this.MANV.HeaderText = "MANV";
            this.MANV.Name = "MANV";
            // 
            // hODataGridViewTextBoxColumn
            // 
            this.hODataGridViewTextBoxColumn.DataPropertyName = "HO";
            this.hODataGridViewTextBoxColumn.HeaderText = "HO";
            this.hODataGridViewTextBoxColumn.Name = "hODataGridViewTextBoxColumn";
            this.hODataGridViewTextBoxColumn.Width = 150;
            // 
            // tENDataGridViewTextBoxColumn
            // 
            this.tENDataGridViewTextBoxColumn.DataPropertyName = "TEN";
            this.tENDataGridViewTextBoxColumn.HeaderText = "TEN";
            this.tENDataGridViewTextBoxColumn.Name = "tENDataGridViewTextBoxColumn";
            this.tENDataGridViewTextBoxColumn.Width = 150;
            // 
            // cMNDDataGridViewTextBoxColumn
            // 
            this.cMNDDataGridViewTextBoxColumn.DataPropertyName = "CMND";
            this.cMNDDataGridViewTextBoxColumn.HeaderText = "CMND";
            this.cMNDDataGridViewTextBoxColumn.Name = "cMNDDataGridViewTextBoxColumn";
            this.cMNDDataGridViewTextBoxColumn.Width = 150;
            // 
            // dIACHIDataGridViewTextBoxColumn
            // 
            this.dIACHIDataGridViewTextBoxColumn.DataPropertyName = "DIACHI";
            this.dIACHIDataGridViewTextBoxColumn.HeaderText = "DIACHI";
            this.dIACHIDataGridViewTextBoxColumn.Name = "dIACHIDataGridViewTextBoxColumn";
            this.dIACHIDataGridViewTextBoxColumn.Width = 150;
            // 
            // sDTDataGridViewTextBoxColumn
            // 
            this.sDTDataGridViewTextBoxColumn.DataPropertyName = "SDT";
            this.sDTDataGridViewTextBoxColumn.HeaderText = "SDT";
            this.sDTDataGridViewTextBoxColumn.Name = "sDTDataGridViewTextBoxColumn";
            this.sDTDataGridViewTextBoxColumn.Width = 150;
            // 
            // CHUCDANH
            // 
            this.CHUCDANH.DataPropertyName = "CHUCDANH";
            this.CHUCDANH.HeaderText = "CHUCDANH";
            this.CHUCDANH.Name = "CHUCDANH";
            // 
            // nHANVIENBindingSource
            // 
            this.nHANVIENBindingSource.DataMember = "NHANVIEN";
            this.nHANVIENBindingSource.DataSource = this.qL_BAOTANGDataSet;
            // 
            // qL_BAOTANGDataSet
            // 
            this.qL_BAOTANGDataSet.DataSetName = "QL_BAOTANGDataSet";
            this.qL_BAOTANGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nHANVIENTableAdapter
            // 
            this.nHANVIENTableAdapter.ClearBeforeFill = true;
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.Location = new System.Drawing.Point(122, 123);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(76, 13);
            this.l.TabIndex = 1;
            this.l.Text = "LOGIN NAME :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "PASS WORD:";
            // 
            // textLoginName
            // 
            this.textLoginName.Location = new System.Drawing.Point(213, 120);
            this.textLoginName.Name = "textLoginName";
            this.textLoginName.Size = new System.Drawing.Size(162, 20);
            this.textLoginName.TabIndex = 3;
            // 
            // buttonTaoTK
            // 
            this.buttonTaoTK.Location = new System.Drawing.Point(151, 194);
            this.buttonTaoTK.Name = "buttonTaoTK";
            this.buttonTaoTK.Size = new System.Drawing.Size(106, 23);
            this.buttonTaoTK.TabIndex = 5;
            this.buttonTaoTK.Text = "TẠO TÀI KHOẢN";
            this.buttonTaoTK.UseVisualStyleBackColor = true;
            this.buttonTaoTK.Click += new System.EventHandler(this.buttonTaoTK_Click);
            // 
            // buttonXoaTK
            // 
            this.buttonXoaTK.Location = new System.Drawing.Point(308, 194);
            this.buttonXoaTK.Name = "buttonXoaTK";
            this.buttonXoaTK.Size = new System.Drawing.Size(98, 23);
            this.buttonXoaTK.TabIndex = 6;
            this.buttonXoaTK.Text = "XÓA TÀI KHOẢN";
            this.buttonXoaTK.UseVisualStyleBackColor = true;
            this.buttonXoaTK.Click += new System.EventHandler(this.buttonXoaTK_Click);
            // 
            // textPassWord
            // 
            this.textPassWord.Location = new System.Drawing.Point(213, 156);
            this.textPassWord.Name = "textPassWord";
            this.textPassWord.Size = new System.Drawing.Size(162, 20);
            this.textPassWord.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(431, 39);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(164, 22);
            label2.TabIndex = 11;
            label2.Text = "TẠO TÀI KHOẢN";
            // 
            // frmtaoTtaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 503);
            this.Controls.Add(label2);
            this.Controls.Add(this.buttonXoaTK);
            this.Controls.Add(this.buttonTaoTK);
            this.Controls.Add(this.textPassWord);
            this.Controls.Add(this.textLoginName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.l);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmtaoTtaiKhoan";
            this.Text = "TẠO TÀI KHOẢN";
            this.Load += new System.EventHandler(this.frmtaoTtaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_BAOTANGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textLoginName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textPassWord.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private QL_BAOTANGDataSet qL_BAOTANGDataSet;
        private System.Windows.Forms.BindingSource nHANVIENBindingSource;
        private QL_BAOTANGDataSetTableAdapters.NHANVIENTableAdapter nHANVIENTableAdapter;
        private System.Windows.Forms.Label l;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit textLoginName;
        private System.Windows.Forms.Button buttonTaoTK;
        private System.Windows.Forms.Button buttonXoaTK;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANV;
        private System.Windows.Forms.DataGridViewTextBoxColumn hODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMNDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIACHIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHUCDANH;
        private DevExpress.XtraEditors.TextEdit textPassWord;
    }
}