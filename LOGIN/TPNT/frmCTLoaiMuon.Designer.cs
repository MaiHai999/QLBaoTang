namespace LOGIN.TPNT
{
    partial class frmCTLoaiMuon
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
            System.Windows.Forms.Label mATPNTLabel;
            System.Windows.Forms.Label nGAYSOHUULabel;
            System.Windows.Forms.Label tINHTRANGLabel;
            System.Windows.Forms.Label vITRILabel;
            this.textViTri = new DevExpress.XtraEditors.TextEdit();
            this.textMaBoSuTap = new DevExpress.XtraEditors.TextEdit();
            this.textNgaySoHuu = new DevExpress.XtraEditors.TextEdit();
            this.textMATPNT = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            mATPNTLabel = new System.Windows.Forms.Label();
            nGAYSOHUULabel = new System.Windows.Forms.Label();
            tINHTRANGLabel = new System.Windows.Forms.Label();
            vITRILabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.textViTri.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textMaBoSuTap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textNgaySoHuu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textMATPNT.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // textViTri
            // 
            this.textViTri.Location = new System.Drawing.Point(552, 207);
            this.textViTri.Name = "textViTri";
            this.textViTri.Size = new System.Drawing.Size(152, 20);
            this.textViTri.TabIndex = 26;
            // 
            // textMaBoSuTap
            // 
            this.textMaBoSuTap.Location = new System.Drawing.Point(552, 148);
            this.textMaBoSuTap.Name = "textMaBoSuTap";
            this.textMaBoSuTap.Size = new System.Drawing.Size(152, 20);
            this.textMaBoSuTap.TabIndex = 25;
            this.textMaBoSuTap.EditValueChanged += new System.EventHandler(this.textTINHTRANG_EditValueChanged);
            // 
            // textNgaySoHuu
            // 
            this.textNgaySoHuu.Location = new System.Drawing.Point(163, 207);
            this.textNgaySoHuu.Name = "textNgaySoHuu";
            this.textNgaySoHuu.Size = new System.Drawing.Size(152, 20);
            this.textNgaySoHuu.TabIndex = 24;
            // 
            // textMATPNT
            // 
            this.textMATPNT.Location = new System.Drawing.Point(163, 148);
            this.textMATPNT.Name = "textMATPNT";
            this.textMATPNT.Size = new System.Drawing.Size(152, 20);
            this.textMATPNT.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(191, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 19);
            this.label1.TabIndex = 22;
            this.label1.Text = "THÔNG TIN CHI TIẾT VỀ LOẠI TÀI SẢN CỦA TPNT";
            // 
            // mATPNTLabel
            // 
            mATPNTLabel.AutoSize = true;
            mATPNTLabel.Location = new System.Drawing.Point(83, 151);
            mATPNTLabel.Name = "mATPNTLabel";
            mATPNTLabel.Size = new System.Drawing.Size(51, 13);
            mATPNTLabel.TabIndex = 17;
            mATPNTLabel.Text = "MATPNT:";
            // 
            // nGAYSOHUULabel
            // 
            nGAYSOHUULabel.AutoSize = true;
            nGAYSOHUULabel.Location = new System.Drawing.Point(83, 210);
            nGAYSOHUULabel.Name = "nGAYSOHUULabel";
            nGAYSOHUULabel.Size = new System.Drawing.Size(72, 13);
            nGAYSOHUULabel.TabIndex = 18;
            nGAYSOHUULabel.Text = "NGÀY MƯỢN:";
            // 
            // tINHTRANGLabel
            // 
            tINHTRANGLabel.AutoSize = true;
            tINHTRANGLabel.Location = new System.Drawing.Point(434, 151);
            tINHTRANGLabel.Name = "tINHTRANGLabel";
            tINHTRANGLabel.Size = new System.Drawing.Size(89, 13);
            tINHTRANGLabel.TabIndex = 19;
            tINHTRANGLabel.Text = "MÃ BỘ SƯU TẬP:";
            // 
            // vITRILabel
            // 
            vITRILabel.AutoSize = true;
            vITRILabel.Location = new System.Drawing.Point(434, 210);
            vITRILabel.Name = "vITRILabel";
            vITRILabel.Size = new System.Drawing.Size(61, 13);
            vITRILabel.TabIndex = 20;
            vITRILabel.Text = "NGÀY TRẢ:";
            // 
            // frmCTLoaiMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 310);
            this.Controls.Add(this.textViTri);
            this.Controls.Add(this.textMaBoSuTap);
            this.Controls.Add(this.textNgaySoHuu);
            this.Controls.Add(this.textMATPNT);
            this.Controls.Add(this.label1);
            this.Controls.Add(mATPNTLabel);
            this.Controls.Add(nGAYSOHUULabel);
            this.Controls.Add(tINHTRANGLabel);
            this.Controls.Add(vITRILabel);
            this.Name = "frmCTLoaiMuon";
            this.Text = "frmCTLoaiMuon";
            ((System.ComponentModel.ISupportInitialize)(this.textViTri.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textMaBoSuTap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textNgaySoHuu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textMATPNT.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.TextEdit textViTri;
        private DevExpress.XtraEditors.TextEdit textMaBoSuTap;
        private DevExpress.XtraEditors.TextEdit textNgaySoHuu;
        private DevExpress.XtraEditors.TextEdit textMATPNT;
        private System.Windows.Forms.Label label1;
    }
}