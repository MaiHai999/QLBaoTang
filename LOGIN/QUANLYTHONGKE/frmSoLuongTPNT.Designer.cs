namespace LOGIN.QUANLYTHONGKE
{
    partial class frmSoLuongTPNT
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
            this.qL_BAOTANGDataSet = new LOGIN.QL_BAOTANGDataSet();
            this.bdsTacGia = new System.Windows.Forms.BindingSource(this.components);
            this.tACGIATableAdapter = new LOGIN.QL_BAOTANGDataSetTableAdapters.TACGIATableAdapter();
            this.tableAdapterManager = new LOGIN.QL_BAOTANGDataSetTableAdapters.TableAdapterManager();
            this.button1 = new System.Windows.Forms.Button();
            this.cbMatg = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            mATACGIALabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qL_BAOTANGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTacGia)).BeginInit();
            this.SuspendLayout();
            // 
            // mATACGIALabel
            // 
            mATACGIALabel.AutoSize = true;
            mATACGIALabel.Location = new System.Drawing.Point(235, 201);
            mATACGIALabel.Name = "mATACGIALabel";
            mATACGIALabel.Size = new System.Drawing.Size(64, 13);
            mATACGIALabel.TabIndex = 4;
            mATACGIALabel.Text = "MATACGIA:";
            // 
            // qL_BAOTANGDataSet
            // 
            this.qL_BAOTANGDataSet.DataSetName = "QL_BAOTANGDataSet";
            this.qL_BAOTANGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsTacGia
            // 
            this.bdsTacGia.DataMember = "TACGIA";
            this.bdsTacGia.DataSource = this.qL_BAOTANGDataSet;
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(305, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 59);
            this.button1.TabIndex = 4;
            this.button1.Text = "IN";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbMatg
            // 
            this.cbMatg.DataSource = this.bdsTacGia;
            this.cbMatg.DisplayMember = "MATACGIA";
            this.cbMatg.FormattingEnabled = true;
            this.cbMatg.Location = new System.Drawing.Point(314, 198);
            this.cbMatg.Name = "cbMatg";
            this.cbMatg.Size = new System.Drawing.Size(167, 21);
            this.cbMatg.TabIndex = 5;
            this.cbMatg.ValueMember = "TEN";
            this.cbMatg.SelectedIndexChanged += new System.EventHandler(this.cbMatg_SelectedIndexChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(258, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(408, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "DANH SÁCH TÁC PHẨM NGHỆ THUẬT CỦA TÁC GIẢ ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // frmSoLuongTPNT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 466);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbMatg);
            this.Controls.Add(mATACGIALabel);
            this.Controls.Add(this.button1);
            this.Name = "frmSoLuongTPNT";
            this.Text = "SO LƯƠNG TPNT";
            this.Load += new System.EventHandler(this.frmSoLuongTPNT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qL_BAOTANGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTacGia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QL_BAOTANGDataSet qL_BAOTANGDataSet;
        private System.Windows.Forms.BindingSource bdsTacGia;
        private QL_BAOTANGDataSetTableAdapters.TACGIATableAdapter tACGIATableAdapter;
        private QL_BAOTANGDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbMatg;
        private System.Windows.Forms.Label label1;
    }
}