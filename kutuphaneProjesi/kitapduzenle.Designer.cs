namespace kutuphaneProjesi
{
    partial class kitapduzenle
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
            this.txt_kitapid = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_kitapad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_sayfasayisi = new System.Windows.Forms.TextBox();
            this.txt_isbn = new System.Windows.Forms.TextBox();
            this.cmb_yazar = new System.Windows.Forms.ComboBox();
            this.cmb_kategori = new System.Windows.Forms.ComboBox();
            this.cmb_kutuphane = new System.Windows.Forms.ComboBox();
            this.cmb_yayinevi = new System.Windows.Forms.ComboBox();
            this.cmb_gun = new System.Windows.Forms.ComboBox();
            this.cmb_ay = new System.Windows.Forms.ComboBox();
            this.cmb_yil = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Location = new System.Drawing.Point(253, 273);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(115, 76);
            this.btn_guncelle.TabIndex = 1012;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(101, 273);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(115, 76);
            this.btn_ekle.TabIndex = 1011;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // txt_kitapid
            // 
            this.txt_kitapid.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_kitapid.Location = new System.Drawing.Point(221, 25);
            this.txt_kitapid.Name = "txt_kitapid";
            this.txt_kitapid.ReadOnly = true;
            this.txt_kitapid.Size = new System.Drawing.Size(154, 20);
            this.txt_kitapid.TabIndex = 1010;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("MV Boli", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(126, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 21);
            this.label10.TabIndex = 1009;
            this.label10.Text = "Kitap ID:";
            // 
            // txt_kitapad
            // 
            this.txt_kitapad.Location = new System.Drawing.Point(221, 50);
            this.txt_kitapad.Name = "txt_kitapad";
            this.txt_kitapad.Size = new System.Drawing.Size(154, 20);
            this.txt_kitapad.TabIndex = 1008;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(117, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 21);
            this.label1.TabIndex = 1007;
            this.label1.Text = "Kitap Adı:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("MV Boli", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(97, 75);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(118, 21);
            this.label12.TabIndex = 1013;
            this.label12.Text = "Sayfa Sayısı:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("MV Boli", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(96, 100);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(119, 21);
            this.label13.TabIndex = 1014;
            this.label13.Text = "Yayın Tarihi:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("MV Boli", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(156, 125);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 21);
            this.label14.TabIndex = 1015;
            this.label14.Text = "ISBN:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(151, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 21);
            this.label2.TabIndex = 1016;
            this.label2.Text = "Yazar:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(128, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 21);
            this.label3.TabIndex = 1017;
            this.label3.Text = "Kategori:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MV Boli", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 21);
            this.label4.TabIndex = 1018;
            this.label4.Text = "Bulunduğu Kütüphane:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MV Boli", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(119, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 21);
            this.label5.TabIndex = 1019;
            this.label5.Text = "Yayın Evi:";
            // 
            // txt_sayfasayisi
            // 
            this.txt_sayfasayisi.Location = new System.Drawing.Point(221, 75);
            this.txt_sayfasayisi.Name = "txt_sayfasayisi";
            this.txt_sayfasayisi.Size = new System.Drawing.Size(154, 20);
            this.txt_sayfasayisi.TabIndex = 1020;
            // 
            // txt_isbn
            // 
            this.txt_isbn.Location = new System.Drawing.Point(221, 125);
            this.txt_isbn.Name = "txt_isbn";
            this.txt_isbn.Size = new System.Drawing.Size(154, 20);
            this.txt_isbn.TabIndex = 1022;
            // 
            // cmb_yazar
            // 
            this.cmb_yazar.FormattingEnabled = true;
            this.cmb_yazar.Location = new System.Drawing.Point(221, 150);
            this.cmb_yazar.Name = "cmb_yazar";
            this.cmb_yazar.Size = new System.Drawing.Size(154, 21);
            this.cmb_yazar.TabIndex = 1027;
            // 
            // cmb_kategori
            // 
            this.cmb_kategori.FormattingEnabled = true;
            this.cmb_kategori.Location = new System.Drawing.Point(221, 175);
            this.cmb_kategori.Name = "cmb_kategori";
            this.cmb_kategori.Size = new System.Drawing.Size(154, 21);
            this.cmb_kategori.TabIndex = 1028;
            // 
            // cmb_kutuphane
            // 
            this.cmb_kutuphane.FormattingEnabled = true;
            this.cmb_kutuphane.Location = new System.Drawing.Point(221, 200);
            this.cmb_kutuphane.Name = "cmb_kutuphane";
            this.cmb_kutuphane.Size = new System.Drawing.Size(154, 21);
            this.cmb_kutuphane.TabIndex = 1029;
            // 
            // cmb_yayinevi
            // 
            this.cmb_yayinevi.FormattingEnabled = true;
            this.cmb_yayinevi.Location = new System.Drawing.Point(221, 225);
            this.cmb_yayinevi.Name = "cmb_yayinevi";
            this.cmb_yayinevi.Size = new System.Drawing.Size(154, 21);
            this.cmb_yayinevi.TabIndex = 1030;
            // 
            // cmb_gun
            // 
            this.cmb_gun.FormattingEnabled = true;
            this.cmb_gun.Location = new System.Drawing.Point(222, 100);
            this.cmb_gun.Name = "cmb_gun";
            this.cmb_gun.Size = new System.Drawing.Size(39, 21);
            this.cmb_gun.TabIndex = 1032;
            // 
            // cmb_ay
            // 
            this.cmb_ay.FormattingEnabled = true;
            this.cmb_ay.Location = new System.Drawing.Point(267, 100);
            this.cmb_ay.Name = "cmb_ay";
            this.cmb_ay.Size = new System.Drawing.Size(39, 21);
            this.cmb_ay.TabIndex = 1033;
            // 
            // cmb_yil
            // 
            this.cmb_yil.FormattingEnabled = true;
            this.cmb_yil.Location = new System.Drawing.Point(312, 101);
            this.cmb_yil.Name = "cmb_yil";
            this.cmb_yil.Size = new System.Drawing.Size(63, 21);
            this.cmb_yil.TabIndex = 1034;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 1035;
            this.label6.Text = "label6";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 1036;
            this.label7.Text = "label7";
            this.label7.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 1037;
            this.label8.Text = "label8";
            this.label8.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 1038;
            this.label9.Text = "label9";
            this.label9.Visible = false;
            // 
            // kitapduzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(405, 370);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmb_yil);
            this.Controls.Add(this.cmb_ay);
            this.Controls.Add(this.cmb_gun);
            this.Controls.Add(this.cmb_yayinevi);
            this.Controls.Add(this.cmb_kutuphane);
            this.Controls.Add(this.cmb_kategori);
            this.Controls.Add(this.cmb_yazar);
            this.Controls.Add(this.txt_isbn);
            this.Controls.Add(this.txt_sayfasayisi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txt_kitapad);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txt_kitapid);
            this.Name = "kitapduzenle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "kitapduzenle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.TextBox txt_kitapid;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_kitapad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_sayfasayisi;
        private System.Windows.Forms.TextBox txt_isbn;
        private System.Windows.Forms.ComboBox cmb_yazar;
        private System.Windows.Forms.ComboBox cmb_kategori;
        private System.Windows.Forms.ComboBox cmb_kutuphane;
        private System.Windows.Forms.ComboBox cmb_yayinevi;
        private System.Windows.Forms.ComboBox cmb_gun;
        private System.Windows.Forms.ComboBox cmb_ay;
        private System.Windows.Forms.ComboBox cmb_yil;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}