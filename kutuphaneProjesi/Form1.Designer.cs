namespace kutuphaneProjesi
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_kutup = new System.Windows.Forms.Button();
            this.btn_cikis = new System.Windows.Forms.Button();
            this.btn_uye = new System.Windows.Forms.Button();
            this.btn_emanet = new System.Windows.Forms.Button();
            this.btn_yayinevi = new System.Windows.Forms.Button();
            this.btn_yazar = new System.Windows.Forms.Button();
            this.btn_kategori = new System.Windows.Forms.Button();
            this.btn_kitap = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_kutup
            // 
            this.btn_kutup.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_kutup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kutup.Font = new System.Drawing.Font("MV Boli", 19.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_kutup.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_kutup.Image = ((System.Drawing.Image)(resources.GetObject("btn_kutup.Image")));
            this.btn_kutup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_kutup.Location = new System.Drawing.Point(3, 3);
            this.btn_kutup.Name = "btn_kutup";
            this.btn_kutup.Size = new System.Drawing.Size(208, 102);
            this.btn_kutup.TabIndex = 0;
            this.btn_kutup.Text = "Kütüphane";
            this.btn_kutup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_kutup.UseVisualStyleBackColor = false;
            this.btn_kutup.Click += new System.EventHandler(this.btn_kutup_Click);
            // 
            // btn_cikis
            // 
            this.btn_cikis.BackColor = System.Drawing.Color.Red;
            this.btn_cikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cikis.Font = new System.Drawing.Font("MV Boli", 19.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_cikis.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_cikis.Image = ((System.Drawing.Image)(resources.GetObject("btn_cikis.Image")));
            this.btn_cikis.Location = new System.Drawing.Point(431, 219);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(208, 102);
            this.btn_cikis.TabIndex = 1;
            this.btn_cikis.Text = "Çıkış";
            this.btn_cikis.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cikis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cikis.UseVisualStyleBackColor = false;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
            // 
            // btn_uye
            // 
            this.btn_uye.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_uye.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_uye.Font = new System.Drawing.Font("MV Boli", 19.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_uye.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_uye.Image = ((System.Drawing.Image)(resources.GetObject("btn_uye.Image")));
            this.btn_uye.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_uye.Location = new System.Drawing.Point(217, 3);
            this.btn_uye.Name = "btn_uye";
            this.btn_uye.Size = new System.Drawing.Size(208, 102);
            this.btn_uye.TabIndex = 2;
            this.btn_uye.Text = "Üyeler";
            this.btn_uye.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_uye.UseVisualStyleBackColor = false;
            this.btn_uye.Click += new System.EventHandler(this.btn_uye_Click);
            // 
            // btn_emanet
            // 
            this.btn_emanet.BackColor = System.Drawing.Color.Crimson;
            this.btn_emanet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_emanet.Font = new System.Drawing.Font("MV Boli", 19.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_emanet.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_emanet.Image = ((System.Drawing.Image)(resources.GetObject("btn_emanet.Image")));
            this.btn_emanet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_emanet.Location = new System.Drawing.Point(431, 3);
            this.btn_emanet.Name = "btn_emanet";
            this.btn_emanet.Size = new System.Drawing.Size(208, 102);
            this.btn_emanet.TabIndex = 3;
            this.btn_emanet.Text = "Emanetler";
            this.btn_emanet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_emanet.UseVisualStyleBackColor = false;
            this.btn_emanet.Click += new System.EventHandler(this.btn_emanet_Click);
            // 
            // btn_yayinevi
            // 
            this.btn_yayinevi.BackColor = System.Drawing.Color.Orange;
            this.btn_yayinevi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_yayinevi.Font = new System.Drawing.Font("MV Boli", 19.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_yayinevi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_yayinevi.Image = ((System.Drawing.Image)(resources.GetObject("btn_yayinevi.Image")));
            this.btn_yayinevi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_yayinevi.Location = new System.Drawing.Point(3, 111);
            this.btn_yayinevi.Name = "btn_yayinevi";
            this.btn_yayinevi.Size = new System.Drawing.Size(208, 102);
            this.btn_yayinevi.TabIndex = 4;
            this.btn_yayinevi.Text = "Yayın Evi";
            this.btn_yayinevi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_yayinevi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_yayinevi.UseVisualStyleBackColor = false;
            this.btn_yayinevi.Click += new System.EventHandler(this.btn_yayinevi_Click);
            // 
            // btn_yazar
            // 
            this.btn_yazar.BackColor = System.Drawing.Color.BlueViolet;
            this.btn_yazar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_yazar.Font = new System.Drawing.Font("MV Boli", 19.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_yazar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_yazar.Image = ((System.Drawing.Image)(resources.GetObject("btn_yazar.Image")));
            this.btn_yazar.Location = new System.Drawing.Point(217, 219);
            this.btn_yazar.Name = "btn_yazar";
            this.btn_yazar.Size = new System.Drawing.Size(208, 102);
            this.btn_yazar.TabIndex = 5;
            this.btn_yazar.Text = "Yazarlar";
            this.btn_yazar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_yazar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_yazar.UseVisualStyleBackColor = false;
            this.btn_yazar.Click += new System.EventHandler(this.btn_yazar_Click);
            // 
            // btn_kategori
            // 
            this.btn_kategori.BackColor = System.Drawing.Color.DarkMagenta;
            this.btn_kategori.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kategori.Font = new System.Drawing.Font("MV Boli", 18.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_kategori.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_kategori.Image = ((System.Drawing.Image)(resources.GetObject("btn_kategori.Image")));
            this.btn_kategori.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_kategori.Location = new System.Drawing.Point(431, 111);
            this.btn_kategori.Name = "btn_kategori";
            this.btn_kategori.Size = new System.Drawing.Size(208, 102);
            this.btn_kategori.TabIndex = 6;
            this.btn_kategori.Text = "Kategoriler";
            this.btn_kategori.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_kategori.UseVisualStyleBackColor = false;
            this.btn_kategori.Click += new System.EventHandler(this.btn_kategori_Click);
            // 
            // btn_kitap
            // 
            this.btn_kitap.BackColor = System.Drawing.Color.DarkSalmon;
            this.btn_kitap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kitap.Font = new System.Drawing.Font("MV Boli", 19.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_kitap.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_kitap.Image = ((System.Drawing.Image)(resources.GetObject("btn_kitap.Image")));
            this.btn_kitap.Location = new System.Drawing.Point(3, 219);
            this.btn_kitap.Name = "btn_kitap";
            this.btn_kitap.Size = new System.Drawing.Size(208, 102);
            this.btn_kitap.TabIndex = 7;
            this.btn_kitap.Text = "Kitaplar";
            this.btn_kitap.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_kitap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_kitap.UseVisualStyleBackColor = false;
            this.btn_kitap.Click += new System.EventHandler(this.btn_kitap_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Black;
            this.flowLayoutPanel1.Controls.Add(this.btn_kutup);
            this.flowLayoutPanel1.Controls.Add(this.btn_uye);
            this.flowLayoutPanel1.Controls.Add(this.btn_emanet);
            this.flowLayoutPanel1.Controls.Add(this.btn_yayinevi);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.btn_kategori);
            this.flowLayoutPanel1.Controls.Add(this.btn_kitap);
            this.flowLayoutPanel1.Controls.Add(this.btn_yazar);
            this.flowLayoutPanel1.Controls.Add(this.btn_cikis);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(82, 89);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(645, 328);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Enabled = false;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("MV Boli", 19.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(217, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 102);
            this.button1.TabIndex = 8;
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(21, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 34);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tolga Fatih Deveci";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(818, 497);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_kutup;
        private System.Windows.Forms.Button btn_cikis;
        private System.Windows.Forms.Button btn_uye;
        private System.Windows.Forms.Button btn_emanet;
        private System.Windows.Forms.Button btn_yayinevi;
        private System.Windows.Forms.Button btn_yazar;
        private System.Windows.Forms.Button btn_kategori;
        private System.Windows.Forms.Button btn_kitap;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

