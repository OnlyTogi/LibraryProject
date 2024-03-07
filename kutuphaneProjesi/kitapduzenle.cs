using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kutuphaneProjesi
{
    public partial class kitapduzenle : Form
    {
        NpgsqlConnection baglan = new NpgsqlConnection("server=localHost; port=5432; Database=kutuphaneprojedb; user ID=postgres; password=1234");
        public kitapduzenle(int id)
        {
            InitializeComponent();
            int selectedID = id;
            cmbFill();
            cmb_gun.DataSource = Enumerable.Range(1,31).ToList();
            cmb_ay.DataSource = Enumerable.Range(1,12).ToList();
            cmb_yil.DataSource = Enumerable.Range(DateTime.Now.Year - 100, 101).ToList();

            if (selectedID != 0)
            {
                //Önceki sayfadan id çektiği ve textboxları doldurduğu kısım. Textboxların isimlerini,tabloyu,çekilecek verileri güncelle.
                baglan.Open();
                string vericek = "select kitapad,sayfasayisi,yayintarihi,isbn,yazarid,kategoriid,kutuphaneid,yayineviid from kitap where kitapid = @kid";
                NpgsqlCommand cmd = new NpgsqlCommand(vericek, baglan);
                cmd.Parameters.AddWithValue("@kid", selectedID);
                NpgsqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    //sol taraftaki textboxların içinin dolduğu kısım. Textboxların hepsini buraya ekle ve içini doldur.
                    txt_kitapid.Text = selectedID.ToString();
                    txt_kitapad.Text = Convert.ToString(reader["kitapad"]);
                    txt_sayfasayisi.Text = (reader["sayfasayisi"]).ToString();
                    txt_isbn.Text = (reader["isbn"]).ToString();
                    string dateText = Convert.ToString(reader["yayintarihi"]);
                    FillComboBoxes(dateText);
                    label6.Text = Convert.ToString(reader["yazarid"]);
                    label7.Text = Convert.ToString(reader["kategoriid"]);
                    label8.Text = Convert.ToString(reader["kutuphaneid"]);
                    label9.Text = Convert.ToString(reader["yayineviid"]);

                }
                baglan.Close();

                baglan.Open();
                string yazarverisi = "select yazarad,yazarsoyad from yazar where yazarid = @yid";
                NpgsqlCommand cmd3 = new NpgsqlCommand(yazarverisi, baglan);
                int yazarid = Convert.ToInt32(label6.Text);
                cmd3.Parameters.AddWithValue("@yid" , yazarid);
                NpgsqlDataReader okuyucu2 = cmd3.ExecuteReader();
                if (okuyucu2.Read())
                {
                    string yazarad = Convert.ToString(okuyucu2["yazarad"]);
                    string yazarsoyad = Convert.ToString(okuyucu2["yazarsoyad"]);
                    string yazaradsoyad = yazarad+" "+yazarsoyad+" "+yazarid;

                    cmb_yazar.SelectedItem = yazaradsoyad;
                }
                baglan.Close();

                baglan.Open();
                string kategoriverisi = "select kategoriad from kategori where kategoriid = @kid";
                NpgsqlCommand cmd4 = new NpgsqlCommand(kategoriverisi, baglan);
                int kategoriid = Convert.ToInt32(label7.Text);
                cmd4.Parameters.AddWithValue("@kid", kategoriid);
                NpgsqlDataReader okuyucu3 = cmd4.ExecuteReader();
                if (okuyucu3.Read())
                {
                    string kategoriad = Convert.ToString(okuyucu3["kategoriad"]);
                    cmb_kategori.SelectedItem = kategoriad;
                }
                baglan.Close();

                baglan.Open();
                string kutuphaneverisi = "select kutuphanead from kutuphane where kutuphaneid = @kid";
                NpgsqlCommand cmd5 = new NpgsqlCommand(kutuphaneverisi, baglan);
                int kutuphaneid = Convert.ToInt32(label8.Text);
                cmd5.Parameters.AddWithValue("@kid", kutuphaneid);
                NpgsqlDataReader okuyucu4 = cmd5.ExecuteReader();
                if (okuyucu4.Read())
                {
                    string kutuphanead = Convert.ToString(okuyucu4["kutuphanead"]);
                    cmb_kutuphane.SelectedItem = kutuphanead;
                }
                baglan.Close();

                baglan.Open();
                string yayinverisi = "select yayineviad from yayinevi where yayineviid = @yid";
                NpgsqlCommand cmd6 = new NpgsqlCommand(yayinverisi, baglan);
                int yayineviid = Convert.ToInt32(label9.Text);
                cmd6.Parameters.AddWithValue("@yid", yayineviid);
                NpgsqlDataReader okuyucu5 = cmd6.ExecuteReader();
                if (okuyucu5.Read())
                {
                    string yayineviad = Convert.ToString(okuyucu5["yayineviad"]);
                    cmb_yayinevi.SelectedItem = yayineviad;
                }
                baglan.Close();
            }
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            //Boş geçilemez alanları düzenle
            if (string.IsNullOrWhiteSpace(txt_kitapad.Text) || string.IsNullOrWhiteSpace(txt_sayfasayisi.Text) || string.IsNullOrWhiteSpace(txt_isbn.Text) ||
                string.IsNullOrWhiteSpace(cmb_gun.Text) || string.IsNullOrWhiteSpace(cmb_ay.Text) || string.IsNullOrWhiteSpace(cmb_yil.Text)
                || string.IsNullOrWhiteSpace(cmb_yazar.Text) || string.IsNullOrWhiteSpace(cmb_kategori.Text) || string.IsNullOrWhiteSpace(cmb_kutuphane.Text)|| string.IsNullOrWhiteSpace(cmb_yayinevi.Text))
            {
                MessageBox.Show("Lutfen Boş Alan Bırakmayınız!");
                return;
            }
            else
            {
                baglan.Open();
                NpgsqlCommand ekleme = new NpgsqlCommand("insert into kitap (kitapad,sayfasayisi,yayintarihi,isbn,yazarid,kategoriid,kutuphaneid,yayineviid) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", baglan);
                ekleme.Parameters.AddWithValue("@p1", txt_kitapad.Text);
                ekleme.Parameters.AddWithValue("@p2", Convert.ToInt32(txt_sayfasayisi.Text));
                DateTime result;
                DateTime.TryParse(cmb_yil.Text +"-"+ cmb_ay.Text +"-"+ cmb_gun.Text, out result);
                ekleme.Parameters.AddWithValue("@p3", result);
                ekleme.Parameters.AddWithValue("@p4", txt_isbn.Text);
                baglan.Close();
                baglan.Open();
                string[] yazarisim = cmb_yazar.Text.Split();  
                ekleme.Parameters.AddWithValue("@p5", Convert.ToInt32(yazarisim[2]));
                baglan.Close();
                baglan.Open();
                int kategoriid = kategoriidbul(cmb_kategori.Text);
                
                if (kategoriid != 0)
                {
                    ekleme.Parameters.AddWithValue("@p6", kategoriid);
                }
                baglan.Close();
                baglan.Open();
                int kutuphaneid = kutuphaneidbul(cmb_kutuphane.Text);
                if (kutuphaneid != 0)
                {
                    ekleme.Parameters.AddWithValue("@p7", kutuphaneid);
                }
                baglan.Close();
                baglan.Open();
                int yayineviid = yayineviidbul(cmb_yayinevi.Text);
                if (yayineviid != 0)
                {
                    ekleme.Parameters.AddWithValue("@p8", yayineviid);
                }
                baglan.Close();
                baglan.Open();
                ekleme.ExecuteNonQuery();
                baglan.Close();
                
                MessageBox.Show("Kitap Başarıyla Eklendi!");
                textbox_clear();
            }
        }

        public void textbox_clear()
        {
            //textbox temizleme kısmı. textboxları düzenle.
            txt_isbn.Clear();
            txt_sayfasayisi.Clear();
            txt_kitapad.Clear();
            txt_kitapid.Clear();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            baglan.Open();
            //Adres düzenleme kısmı,adres düzenlenecekse eğer buraya dokunma
            string guncelleme1 = "update kitap set kitapad=@p1,sayfasayisi=@p2,yayintarihi=@p3,isbn=@p4,yazarid=@p5,kategoriid=@p6,kutuphaneid=@p7,yayineviid=@p8 where kitapid=@p9";
            NpgsqlCommand updatecommand = new NpgsqlCommand(guncelleme1, baglan);
            updatecommand.Parameters.AddWithValue("@p1", txt_kitapad.Text);
            updatecommand.Parameters.AddWithValue("@p2", Convert.ToInt32(txt_sayfasayisi.Text));
            DateTime result;
            DateTime.TryParse(cmb_yil.Text + "-" + cmb_ay.Text + "-" + cmb_gun.Text, out result);
            updatecommand.Parameters.AddWithValue("@p3", result);
            updatecommand.Parameters.AddWithValue("@p4", txt_isbn.Text);
            baglan.Close();
            string[] yazarisim = cmb_yazar.Text.Split();
            updatecommand.Parameters.AddWithValue("@p5", Convert.ToInt32(yazarisim[2]));

            baglan.Open();
            int kategoriid = kategoriidbul(cmb_kategori.Text);
            baglan.Close();
            if(kategoriid!=0 )
                updatecommand.Parameters.AddWithValue("@p6", kategoriid);
            baglan.Open();
            int kutuphaneid = kutuphaneidbul(cmb_kutuphane.Text);
            baglan.Close();
            if(kutuphaneid!=0 )
                updatecommand.Parameters.AddWithValue("@p7", kutuphaneid);
            baglan.Open();
            int yayineviid = yayineviidbul(cmb_yayinevi.Text);
            baglan.Close();
            baglan.Open();
            if(yayineviid!=0 )
                updatecommand.Parameters.AddWithValue("@p8", yayineviid);
            updatecommand.Parameters.AddWithValue("@p9", Convert.ToInt32(txt_kitapid.Text));
            updatecommand.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Kitap Başarıyla Güncellendi!");
            textbox_clear();
        }
        private void FillComboBoxes(string date)
        {
            DateTime DateData;
            DateTime.TryParse(date, out DateData);
            int year = DateData.Year;
            int month = DateData.Month;
            int day = DateData.Day;

            cmb_gun.SelectedItem = day;
            cmb_ay.SelectedItem = month;
            cmb_yil.SelectedItem = year;

        }
        void cmbFill()
        {
            baglan.Open();
            string yazarverileri = "select yazarid,yazarad,yazarsoyad from yazar";
            NpgsqlCommand cmd10 = new NpgsqlCommand(yazarverileri, baglan);
            NpgsqlDataReader okuyucu10 = cmd10.ExecuteReader();
            while (okuyucu10.Read())
            {
                string yazaradsoyad = Convert.ToString(okuyucu10["yazarad"]) + " " +Convert.ToString(okuyucu10["yazarsoyad"]+" "+ Convert.ToString(okuyucu10["yazarid"]));
                cmb_yazar.Items.Add(yazaradsoyad);
            }
            baglan.Close();

            baglan.Open();
            string kategoriverileri = "select kategoriad from kategori";
            NpgsqlCommand cmd11 = new NpgsqlCommand(kategoriverileri, baglan);
            NpgsqlDataReader okuyucu11 = cmd11.ExecuteReader();
            while (okuyucu11.Read())
            {
                cmb_kategori.Items.Add(Convert.ToString(okuyucu11["kategoriad"]));
            }
            baglan.Close();

            baglan.Open();
            string kutuphaneverileri = "select kutuphanead from kutuphane";
            NpgsqlCommand cmd12 = new NpgsqlCommand(kutuphaneverileri, baglan);
            NpgsqlDataReader okuyucu12 = cmd12.ExecuteReader();
            while (okuyucu12.Read())
            {
                cmb_kutuphane.Items.Add(Convert.ToString(okuyucu12["kutuphanead"]));
            }
            baglan.Close();

            baglan.Open();
            string yayineviverileri = "select yayineviad from yayinevi";
            NpgsqlCommand cmd13 = new NpgsqlCommand(yayineviverileri, baglan);
            NpgsqlDataReader okuyucu13 = cmd13.ExecuteReader();
            while (okuyucu13.Read())
            {
                cmb_yayinevi.Items.Add(Convert.ToString(okuyucu13["yayineviad"]));
            }
            baglan.Close();
        }
        private int yazaridbul(string ad)
        {
            string sorgu1 = "select yazarid from yazar where yazarad=@ad";
            NpgsqlCommand komut1 = new NpgsqlCommand(sorgu1,baglan);
            komut1.Parameters.AddWithValue("@ad", ad);
            NpgsqlDataReader reader1 = komut1.ExecuteReader();
            if (reader1.Read())
            {
                int yazarid = Convert.ToInt32(reader1["yazarid"]);
                return yazarid;
            }
            
            return 0;
        }
        
        private int kategoriidbul(string ad)
        {
            
            string sorgu2 = "select kategoriid from kategori where kategoriad=@ad";
            NpgsqlCommand komut2 = new NpgsqlCommand(sorgu2, baglan);
            komut2.Parameters.AddWithValue("@ad", ad);
            NpgsqlDataReader reader2 = komut2.ExecuteReader();
            if (reader2.Read())
            {
                int kategoriid = Convert.ToInt32(reader2["kategoriid"]);
                return kategoriid;
            }
            return 0;
            

        }
        

        private int kutuphaneidbul(string ad)
        {
            
            string sorgu3 = "select kutuphaneid from kutuphane where kutuphanead=@ad";
            NpgsqlCommand komut3 = new NpgsqlCommand(sorgu3, baglan);
            komut3.Parameters.AddWithValue("@ad", ad);
            NpgsqlDataReader reader3 = komut3.ExecuteReader();
            if (reader3.Read())
            {
                int kutuphaneid = Convert.ToInt32(reader3["kutuphaneid"]);
                return kutuphaneid;
            }
            return 0;
            
        }
        private int yayineviidbul(string ad)
        {
            
            string sorgu3 = "select yayineviid from yayinevi where yayineviad=@ad";
            NpgsqlCommand komut3 = new NpgsqlCommand(sorgu3, baglan);
            komut3.Parameters.AddWithValue("@ad", ad);
            NpgsqlDataReader reader3 = komut3.ExecuteReader();
            if (reader3.Read())
            {
                int yayineviid = Convert.ToInt32(reader3["yayineviid"]);
                return yayineviid;
            }
            return 0;
            
        }
          
    }
}
