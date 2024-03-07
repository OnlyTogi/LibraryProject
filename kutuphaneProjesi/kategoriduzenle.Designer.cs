namespace kutuphaneProjesi
{
    partial class kategoriduzenle
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
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.txt_kategoriid = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_kategoriad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Location = new System.Drawing.Point(177, 109);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(115, 76);
            this.btn_guncelle.TabIndex = 1027;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(12, 109);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(115, 76);
            this.btn_ekle.TabIndex = 1026;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // txt_kategoriid
            // 
            this.txt_kategoriid.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_kategoriid.Location = new System.Drawing.Point(133, 40);
            this.txt_kategoriid.Name = "txt_kategoriid";
            this.txt_kategoriid.ReadOnly = true;
            this.txt_kategoriid.Size = new System.Drawing.Size(120, 20);
            this.txt_kategoriid.TabIndex = 1025;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("MV Boli", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(33, 42);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 17);
            this.label11.TabIndex = 1024;
            this.label11.Text = "Kategori ID:";
            // 
            // txt_kategoriad
            // 
            this.txt_kategoriad.Location = new System.Drawing.Point(133, 64);
            this.txt_kategoriad.Name = "txt_kategoriad";
            this.txt_kategoriad.Size = new System.Drawing.Size(120, 20);
            this.txt_kategoriad.TabIndex = 1021;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 1020;
            this.label2.Text = "Kategori Ad:";
            // 
            // kategoriduzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkMagenta;
            this.ClientSize = new System.Drawing.Size(311, 205);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.txt_kategoriid);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_kategoriad);
            this.Controls.Add(this.label2);
            this.Name = "kategoriduzenle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "kategoriduzenle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.TextBox txt_kategoriid;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_kategoriad;
        private System.Windows.Forms.Label label2;
    }
}