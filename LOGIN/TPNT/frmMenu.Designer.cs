namespace LOGIN.TPNT
{
    partial class frmMenu
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
            this.buttonLoaiMuon = new System.Windows.Forms.Button();
            this.buttonLoaiRieng = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonLoaiMuon
            // 
            this.buttonLoaiMuon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoaiMuon.Location = new System.Drawing.Point(61, 125);
            this.buttonLoaiMuon.Name = "buttonLoaiMuon";
            this.buttonLoaiMuon.Size = new System.Drawing.Size(175, 29);
            this.buttonLoaiMuon.TabIndex = 0;
            this.buttonLoaiMuon.Text = "TPNT ĐI MƯỢN";
            this.buttonLoaiMuon.UseVisualStyleBackColor = true;
            // 
            // buttonLoaiRieng
            // 
            this.buttonLoaiRieng.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoaiRieng.Location = new System.Drawing.Point(306, 125);
            this.buttonLoaiRieng.Name = "buttonLoaiRieng";
            this.buttonLoaiRieng.Size = new System.Drawing.Size(202, 29);
            this.buttonLoaiRieng.TabIndex = 1;
            this.buttonLoaiRieng.Text = "TPNT CỦA BẢO TÀNG";
            this.buttonLoaiRieng.UseVisualStyleBackColor = true;
            this.buttonLoaiRieng.Click += new System.EventHandler(this.buttonLoaiRieng_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "LỰA CHỌN LOẠI TÀI SẢN CỦA TPNT";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 268);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonLoaiRieng);
            this.Controls.Add(this.buttonLoaiMuon);
            this.Name = "frmMenu";
            this.Text = "frmMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button buttonLoaiMuon;
        public System.Windows.Forms.Button buttonLoaiRieng;
        private System.Windows.Forms.Label label1;
    }
}