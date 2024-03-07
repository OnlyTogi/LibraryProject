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
    public partial class yazarduzenle : Form
    {
        NpgsqlConnection baglan = new NpgsqlConnection("server=localHost; port=5432; Database=kutuphaneprojedb; user ID=postgres; password=1234");
        public yazarduzenle(int id)
        {
            InitializeComponent();
            int selectedID = id;

            if (selectedID != 0)
            {
                //Önceki sayfadan id çektiği ve textboxları doldurduğu kısım. Textboxların isimlerini,tabloyu,çekilecek verileri güncelle.
                baglan.Open();
                string vericek = "select yazarad,yazarsoyad from yazar where yazarid = @yid";
                NpgsqlCommand cmd = new NpgsqlCommand(vericek, baglan);
                cmd.Parameters.AddWithValue("@yid", selectedID);
                NpgsqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    //sol taraftaki textboxların içinin dolduğu kısım. Textboxların hepsini buraya ekle ve içini doldur.
                    txt_yazarid.Text = selectedID.ToString();
                    txt_yazarad.Text = Convert.ToString(reader["yazarad"]);
                    txt_yazarsoyad.Text = (reader["yazarsoyad"]).ToString();
                }
                baglan.Close();
            }
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            //Boş geçilemez alanları düzenle
            if (string.IsNullOrWhiteSpace(txt_yazarad.Text) || string.IsNullOrWhiteSpace(txt_yazarsoyad.Text))
            {
                MessageBox.Show("Lutfen Boş Alan Bırakmayınız!");
                return;
            }
            else
            {
                baglan.Open();
                //Diğer ekleme kısmı tablo adı ve textbox isimlerini düzenle
                NpgsqlCommand yazarEkle = new NpgsqlCommand("insert into yazar(yazarad,yazarsoyad) values(@p1,@p2)", baglan);
                yazarEkle.Parameters.AddWithValue("@p1", txt_yazarad.Text);
                yazarEkle.Parameters.AddWithValue("@p2", txt_yazarsoyad.Text);
                yazarEkle.ExecuteNonQuery();

                MessageBox.Show("Yazar Başarıyla Eklendi!");
                textbox_clear();
            }
        }

        public void textbox_clear()
        {
            //textbox temizleme kısmı. textboxları düzenle.
            txt_yazarsoyad.Clear();
            txt_yazarad.Clear();
            txt_yazarid.Clear();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            baglan.Open();
            //Diğer verileri güncelleme kısmı. Başka veriler güncellenecekse değiştir.
            string guncelleme2 = "update yazar set yazarad=@p1,yazarsoyad=@p2 where yazarid=@p3";
            NpgsqlCommand updatecommand2 = new NpgsqlCommand(guncelleme2, baglan);
            updatecommand2.Parameters.AddWithValue("@p1", txt_yazarad.Text);
            updatecommand2.Parameters.AddWithValue("@p2", txt_yazarsoyad.Text);
            updatecommand2.Parameters.AddWithValue("@p3", Convert.ToInt32(txt_yazarid.Text));
            updatecommand2.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Yazar Başarıyla Güncellendi!");
            textbox_clear();
        }
    }
}
