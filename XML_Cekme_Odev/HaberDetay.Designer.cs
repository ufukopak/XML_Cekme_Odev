namespace XML_Cekme_Odev
{
    partial class HaberDetay
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtDetay = new System.Windows.Forms.TextBox();
            this.lblDetay = new System.Windows.Forms.Label();
            this.txtBaslik = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(412, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(273, 246);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtDetay
            // 
            this.txtDetay.Location = new System.Drawing.Point(12, 100);
            this.txtDetay.Multiline = true;
            this.txtDetay.Name = "txtDetay";
            this.txtDetay.ReadOnly = true;
            this.txtDetay.Size = new System.Drawing.Size(394, 246);
            this.txtDetay.TabIndex = 1;
            // 
            // lblDetay
            // 
            this.lblDetay.AutoSize = true;
            this.lblDetay.Location = new System.Drawing.Point(12, 84);
            this.lblDetay.Name = "lblDetay";
            this.lblDetay.Size = new System.Drawing.Size(35, 13);
            this.lblDetay.TabIndex = 3;
            this.lblDetay.Text = "Detay";
            // 
            // txtBaslik
            // 
            this.txtBaslik.Location = new System.Drawing.Point(15, 33);
            this.txtBaslik.Name = "txtBaslik";
            this.txtBaslik.ReadOnly = true;
            this.txtBaslik.Size = new System.Drawing.Size(673, 20);
            this.txtBaslik.TabIndex = 4;
            this.txtBaslik.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // HaberDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 358);
            this.Controls.Add(this.txtBaslik);
            this.Controls.Add(this.lblDetay);
            this.Controls.Add(this.txtDetay);
            this.Controls.Add(this.pictureBox1);
            this.Name = "HaberDetay";
            this.Text = "HaberDetay";
            this.Load += new System.EventHandler(this.HaberDetay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtDetay;
        private System.Windows.Forms.Label lblDetay;
        private System.Windows.Forms.TextBox txtBaslik;
    }
}