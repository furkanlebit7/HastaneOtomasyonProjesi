namespace HastaneOtomasyonProjesi
{
    partial class FrmGirisler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGirisler));
            this.BtnHastaGirisi = new System.Windows.Forms.Button();
            this.BtnDoktorGirisi = new System.Windows.Forms.Button();
            this.BtnSekreterGirisi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnSekreter = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnHastaGirisi
            // 
            this.BtnHastaGirisi.BackColor = System.Drawing.Color.White;
            this.BtnHastaGirisi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnHastaGirisi.BackgroundImage")));
            this.BtnHastaGirisi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnHastaGirisi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnHastaGirisi.Location = new System.Drawing.Point(57, 179);
            this.BtnHastaGirisi.Name = "BtnHastaGirisi";
            this.BtnHastaGirisi.Size = new System.Drawing.Size(118, 133);
            this.BtnHastaGirisi.TabIndex = 0;
            this.BtnHastaGirisi.UseVisualStyleBackColor = false;
            this.BtnHastaGirisi.Click += new System.EventHandler(this.BtnHastaGirisi_Click);
            // 
            // BtnDoktorGirisi
            // 
            this.BtnDoktorGirisi.BackColor = System.Drawing.Color.Transparent;
            this.BtnDoktorGirisi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnDoktorGirisi.BackgroundImage")));
            this.BtnDoktorGirisi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnDoktorGirisi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDoktorGirisi.Location = new System.Drawing.Point(223, 179);
            this.BtnDoktorGirisi.Name = "BtnDoktorGirisi";
            this.BtnDoktorGirisi.Size = new System.Drawing.Size(122, 133);
            this.BtnDoktorGirisi.TabIndex = 1;
            this.BtnDoktorGirisi.UseVisualStyleBackColor = false;
            this.BtnDoktorGirisi.Click += new System.EventHandler(this.BtnDoktorGirisi_Click);
            // 
            // BtnSekreterGirisi
            // 
            this.BtnSekreterGirisi.BackColor = System.Drawing.Color.White;
            this.BtnSekreterGirisi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSekreterGirisi.BackgroundImage")));
            this.BtnSekreterGirisi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSekreterGirisi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSekreterGirisi.Location = new System.Drawing.Point(393, 179);
            this.BtnSekreterGirisi.Name = "BtnSekreterGirisi";
            this.BtnSekreterGirisi.Size = new System.Drawing.Size(120, 133);
            this.BtnSekreterGirisi.TabIndex = 2;
            this.BtnSekreterGirisi.UseVisualStyleBackColor = false;
            this.BtnSekreterGirisi.Click += new System.EventHandler(this.BtnSekreterGirisi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(76, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Patient";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(247, 327);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Doctor";
            // 
            // BtnSekreter
            // 
            this.BtnSekreter.AutoSize = true;
            this.BtnSekreter.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSekreter.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnSekreter.Location = new System.Drawing.Point(419, 327);
            this.BtnSekreter.Name = "BtnSekreter";
            this.BtnSekreter.Size = new System.Drawing.Size(92, 25);
            this.BtnSekreter.TabIndex = 5;
            this.BtnSekreter.Text = "Secretery";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MV Boli", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(42, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(471, 85);
            this.label4.TabIndex = 6;
            this.label4.Text = "Lebit Hospital";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(154, 109);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // FrmGirisler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(571, 409);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnSekreter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSekreterGirisi);
            this.Controls.Add(this.BtnDoktorGirisi);
            this.Controls.Add(this.BtnHastaGirisi);
            this.MaximizeBox = false;
            this.Name = "FrmGirisler";
            this.Text = "Lebit Hospital";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnHastaGirisi;
        private System.Windows.Forms.Button BtnDoktorGirisi;
        private System.Windows.Forms.Button BtnSekreterGirisi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label BtnSekreter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

