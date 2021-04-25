namespace XML_Cekme_Odev
{
    partial class Main
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbBasliklar = new System.Windows.Forms.ListBox();
            this.tbBaslik = new System.Windows.Forms.TextBox();
            this.btnXml = new System.Windows.Forms.Button();
            this.btnHaberGoster = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbBasliklar
            // 
            this.lbBasliklar.FormattingEnabled = true;
            this.lbBasliklar.Location = new System.Drawing.Point(12, 25);
            this.lbBasliklar.Name = "lbBasliklar";
            this.lbBasliklar.Size = new System.Drawing.Size(391, 329);
            this.lbBasliklar.TabIndex = 0;
            this.lbBasliklar.DoubleClick += new System.EventHandler(this.lbBasliklar_DoubleClick);
            // 
            // tbBaslik
            // 
            this.tbBaslik.Location = new System.Drawing.Point(435, 191);
            this.tbBaslik.Name = "tbBaslik";
            this.tbBaslik.Size = new System.Drawing.Size(328, 20);
            this.tbBaslik.TabIndex = 1;
            // 
            // btnXml
            // 
            this.btnXml.Location = new System.Drawing.Point(542, 62);
            this.btnXml.Name = "btnXml";
            this.btnXml.Size = new System.Drawing.Size(123, 53);
            this.btnXml.TabIndex = 2;
            this.btnXml.Text = "XML Cek";
            this.btnXml.UseVisualStyleBackColor = true;
            this.btnXml.Click += new System.EventHandler(this.btnXml_Click);
            // 
            // btnHaberGoster
            // 
            this.btnHaberGoster.Location = new System.Drawing.Point(435, 234);
            this.btnHaberGoster.Name = "btnHaberGoster";
            this.btnHaberGoster.Size = new System.Drawing.Size(328, 69);
            this.btnHaberGoster.TabIndex = 3;
            this.btnHaberGoster.Text = "Detay";
            this.btnHaberGoster.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Haber Başlıkları";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 361);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHaberGoster);
            this.Controls.Add(this.btnXml);
            this.Controls.Add(this.tbBaslik);
            this.Controls.Add(this.lbBasliklar);
            this.Name = "Main";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbBasliklar;
        private System.Windows.Forms.TextBox tbBaslik;
        private System.Windows.Forms.Button btnXml;
        private System.Windows.Forms.Button btnHaberGoster;
        private System.Windows.Forms.Label label1;
    }
}

