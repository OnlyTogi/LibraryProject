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
    public partial class yayineviduzenle : Form
    {
        NpgsqlConnection baglan = new NpgsqlConnection("server=localHost; port=5432; Database=kutuphaneprojedb; user ID=postgres; password=1234");
        public yayineviduzenle(int id)
        {
            InitializeComponent();
            int selectedID = id;

            if (selectedID != 0)
            {
                //Önceki sayfadan id çektiği ve textboxları doldurduğu kısım. Textboxların isimlerini,tabloyu,çekilecek verileri güncelle.
                baglan.Open();
                string vericek = "select yayineviad, adresid from yayinevi where yayineviid = @yid";
                NpgsqlCommand cmd = new NpgsqlCommand(vericek, baglan);
                cmd.Parameters.AddWithValue("@yid", selectedID);
                NpgsqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    //sol taraftaki textboxların içinin dolduğu kısım. Textboxların hepsini buraya ekle ve içini doldur.
                    txt_yayinid.Text = selectedID.ToString();
                    txt_yayinad.Text = Convert.ToString(reader["yayineviad"]);
                    txt_adresid.Text = (reader["adresid"]).ToString();
                }
                baglan.Close();
                baglan.Open();
                string AdresVeriCek = "select il,ilce,mahalle,cadde,sokak,binano,kat,postakodu from adres where adresid=@aid";
                NpgsqlCommand cmd2 = new NpgsqlCommand(AdresVeriCek, baglan);
                int adresid = Convert.ToInt32(txt_adresid.Text);
                cmd2.Parameters.AddWithValue("@aid", adresid);
                NpgsqlDataReader okuyucu = cmd2.ExecuteReader();
                if (okuyucu.Read())
                {
                    txt_adresil.Text = Convert.ToString(okuyucu["il"]);
                    txt_adresilce.Text = Convert.ToString(okuyucu["ilce"]);
                    txt_adresmah.Text = Convert.ToString(okuyucu["mahalle"]);
                    txt_adrescad.Text = Convert.ToString(okuyucu["cadde"]);
                    txt_adressok.Text = Convert.ToString(okuyucu["sokak"]);
                    txt_adresbina.Text = Convert.ToString(okuyucu["binano"]);
                    txt_adreskat.Text = Convert.ToString(okuyucu["kat"]);
                    txt_adresposta.Text = Convert.ToString(okuyucu["postakodu"]);
                }


                baglan.Close();
            }
            }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            //Boş geçilemez alanları düzenle
            if (string.IsNullOrWhiteSpace(txt_yayinad.Text) || string.IsNullOrWhiteSpace(txt_adresil.Text) || string.IsNullOrWhiteSpace(txt_adresilce.Text) ||
                string.IsNullOrWhiteSpace(txt_adresmah.Text) || string.IsNullOrWhiteSpace(txt_adrescad.Text) || string.IsNullOrWhiteSpace(txt_adressok.Text)
                || string.IsNullOrWhiteSpace(txt_adresbina.Text) || string.IsNullOrWhiteSpace(txt_adreskat.Text) || string.IsNullOrWhiteSpace(txt_adresposta.Text))
            {
                MessageBox.Show("Lutfen Boş Alan Bırakmayınız!");
                return;
            }
            else
            {
                //Adres ekleme kısmı. Adres ekleneceğinde dokunmaya gerek yok.
                baglan.Open();
                NpgsqlCommand ekleme = new NpgsqlCommand("insert into adres (il,ilce,mahalle,cadde,sokak,binano,kat,postakodu) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8) RETURNING adresid", baglan);
                ekleme.Parameters.AddWithValue("@p1", txt_adresil.Text);
                ekleme.Parameters.AddWithValue("@p2", txt_adresilce.Text);
                ekleme.Parameters.AddWithValue("@p3", txt_adresmah.Text);
                ekleme.Parameters.AddWithValue("@p4", txt_adrescad.Text);
                ekleme.Parameters.AddWithValue("@p5", txt_adressok.Text);
                ekleme.Parameters.AddWithValue("@p6", txt_adresbina.Text);
                ekleme.Parameters.AddWithValue("@p7", txt_adreskat.Text);
                ekleme.Parameters.AddWithValue("@p8", txt_adresposta.Text);

                int adresID = (int)ekleme.ExecuteScalar();
                //Diğer ekleme kısmı tablo adı ve textbox isimlerini düzenle
                NpgsqlCommand ktphaneEkle = new NpgsqlCommand("insert into yayinevi(yayineviad,adresid) values(@p1,@p2)", baglan);
                ktphaneEkle.Parameters.AddWithValue("@p1", txt_yayinad.Text);
                ktphaneEkle.Parameters.AddWithValue("@p2", adresID);
                ktphaneEkle.ExecuteNonQuery();

                MessageBox.Show("Yayın Evi Başarıyla Eklendi!");
                textbox_clear();
            }
        }

        public void textbox_clear()
        {
            //textbox temizleme kısmı. textboxları düzenle.
            txt_adresbina.Clear();
            txt_adreskat.Clear();
            txt_adresposta.Clear();
            txt_adrescad.Clear();
            txt_adresid.Clear();
            txt_adresil.Clear();
            txt_adresilce.Clear();
            txt_adresmah.Clear();
            txt_adressok.Clear();
            txt_yayinad.Clear();
            txt_yayinid.Clear();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            baglan.Open();
            //Adres düzenleme kısmı,adres düzenlenecekse eğer buraya dokunma
            string guncelleme1 = "update adres set il=@p1,ilce=@p2,mahalle=@p3,cadde=@p4,sokak=@p5,binano=@p6,kat=@p7,postakodu=@p8 where adresid=@p9";
            NpgsqlCommand updatecommand = new NpgsqlCommand(guncelleme1, baglan);
            updatecommand.Parameters.AddWithValue("@p1", txt_adresil.Text);
            updatecommand.Parameters.AddWithValue("@p2", txt_adresilce.Text);
            updatecommand.Parameters.AddWithValue("@p3", txt_adresmah.Text);
            updatecommand.Parameters.AddWithValue("@p4", txt_adrescad.Text);
            updatecommand.Parameters.AddWithValue("@p5", txt_adressok.Text);
            updatecommand.Parameters.AddWithValue("@p6", txt_adresbina.Text);
            updatecommand.Parameters.AddWithValue("@p7", txt_adreskat.Text);
            updatecommand.Parameters.AddWithValue("@p8", txt_adresposta.Text);
            updatecommand.Parameters.AddWithValue("@p9", Convert.ToInt32(txt_adresid.Text));
            //Diğer verileri güncelleme kısmı. Başka veriler güncellenecekse değiştir.
            string guncelleme2 = "update yayinevi set yayineviad=@p1 where yayineviid=@p2";
            NpgsqlCommand updatecommand2 = new NpgsqlCommand(guncelleme2, baglan);
            updatecommand2.Parameters.AddWithValue("@p1", txt_yayinad.Text);
            updatecommand2.Parameters.AddWithValue("@p2", Convert.ToInt32(txt_yayinid.Text));
            updatecommand.ExecuteNonQuery();
            updatecommand2.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Yayın Evi Başarıyla Güncellendi!");
            textbox_clear();
        }
    }
}
