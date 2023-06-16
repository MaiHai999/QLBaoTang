namespace LOGIN.QUANLYTHONGKE
{
    partial class frmTpntOfTrienLam
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
            System.Windows.Forms.Label nGAYBDLabel;
            System.Windows.Forms.Label nGAYKTLabel;
            this.button1 = new System.Windows.Forms.Button();
            this.qL_BAOTANGDataSet = new LOGIN.QL_BAOTANGDataSet();
            this.tRIENLAMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tRIENLAMTableAdapter = new LOGIN.QL_BAOTANGDataSetTableAdapters.TRIENLAMTableAdapter();
            this.tableAdapterManager = new LOGIN.QL_BAOTANGDataSetTableAdapters.TableAdapterManager();
            this.txtNgayBd = new DevExpress.XtraEditors.DateEdit();
            this.txtNgayKt = new DevExpress.XtraEditors.DateEdit();
            this.label1 = new System.Windows.Forms.Label();
            nGAYBDLabel = new System.Windows.Forms.Label();
            nGAYKTLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qL_BAOTANGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRIENLAMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayBd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayBd.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayKt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayKt.Properties.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // nGAYBDLabel
            // 
            nGAYBDLabel.AutoSize = true;
            nGAYBDLabel.Location = new System.Drawing.Point(250, 135);
            nGAYBDLabel.Name = "nGAYBDLabel";
            nGAYBDLabel.Size = new System.Drawing.Size(51, 13);
            nGAYBDLabel.TabIndex = 7;
            nGAYBDLabel.Text = "NGAYBD:";
            // 
            // nGAYKTLabel
            // 
            nGAYKTLabel.AutoSize = true;
            nGAYKTLabel.Location = new System.Drawing.Point(251, 177);
            nGAYKTLabel.Name = "nGAYKTLabel";
            nGAYKTLabel.Size = new System.Drawing.Size(50, 13);
            nGAYKTLabel.TabIndex = 8;
            nGAYKTLabel.Text = "NGAYKT:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(438, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 59);
            this.button1.TabIndex = 6;
            this.button1.Text = "IN";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // qL_BAOTANGDataSet
            // 
            this.qL_BAOTANGDataSet.DataSetName = "QL_BAOTANGDataSet";
            this.qL_BAOTANGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tRIENLAMBindingSource
            // 
            this.tRIENLAMBindingSource.DataMember = "TRIENLAM";
            this.tRIENLAMBindingSource.DataSource = this.qL_BAOTANGDataSet;
            // 
            // tRIENLAMTableAdapter
            // 
            this.tRIENLAMTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.TACGIATableAdapter = null;
            this.tableAdapterManager.TACTUONGTableAdapter = null;
            this.tableAdapterManager.TPNTTableAdapter = null;
            this.tableAdapterManager.TRIENLAMTableAdapter = this.tRIENLAMTableAdapter;
            this.tableAdapterManager.UpdateOrder = LOGIN.QL_BAOTANGDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // txtNgayBd
            // 
            this.txtNgayBd.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tRIENLAMBindingSource, "NGAYBD", true));
            this.txtNgayBd.EditValue = null;
            this.txtNgayBd.Location = new System.Drawing.Point(307, 132);
            this.txtNgayBd.Name = "txtNgayBd";
            this.txtNgayBd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNgayBd.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNgayBd.Size = new System.Drawing.Size(100, 20);
            this.txtNgayBd.TabIndex = 8;
            // 
            // txtNgayKt
            // 
            this.txtNgayKt.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tRIENLAMBindingSource, "NGAYKT", true));
            this.txtNgayKt.EditValue = null;
            this.txtNgayKt.Location = new System.Drawing.Point(307, 174);
            this.txtNgayKt.Name = "txtNgayKt";
            this.txtNgayKt.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNgayKt.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNgayKt.Size = new System.Drawing.Size(100, 20);
            this.txtNgayKt.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(303, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "BÁO CÁO CÁC CUỘC TRIỂN LÃM ";
            // 
            // frmTpntOfTrienLam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 447);
            this.Controls.Add(this.label1);
            this.Controls.Add(nGAYKTLabel);
            this.Controls.Add(this.txtNgayKt);
            this.Controls.Add(nGAYBDLabel);
            this.Controls.Add(this.txtNgayBd);
            this.Controls.Add(this.button1);
            this.Name = "frmTpntOfTrienLam";
            this.Text = "BÁO CÁO TRIỂN LÃM";
            this.Load += new System.EventHandler(this.frmTpntOfTrienLam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qL_BAOTANGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRIENLAMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayBd.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayBd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayKt.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayKt.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private QL_BAOTANGDataSet qL_BAOTANGDataSet;
        private System.Windows.Forms.BindingSource tRIENLAMBindingSource;
        private QL_BAOTANGDataSetTableAdapters.TRIENLAMTableAdapter tRIENLAMTableAdapter;
        private QL_BAOTANGDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.DateEdit txtNgayBd;
        private DevExpress.XtraEditors.DateEdit txtNgayKt;
        private System.Windows.Forms.Label label1;
    }
}