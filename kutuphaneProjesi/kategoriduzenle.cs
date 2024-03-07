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
    public partial class kategoriduzenle : Form
    {
        NpgsqlConnection baglan = new NpgsqlConnection("server=localHost; port=5432; Database=kutuphaneprojedb; user ID=postgres; password=1234");
        public kategoriduzenle(int id)
        {
            InitializeComponent();
            int selectedID = id;

            if (selectedID != 0)
            {
                //Önceki sayfadan id çektiği ve textboxları doldurduğu kısım. Textboxların isimlerini,tabloyu,çekilecek verileri güncelle.
                baglan.Open();
                string vericek = "select kategoriad from kategori where kategoriid = @kid";
                NpgsqlCommand cmd = new NpgsqlCommand(vericek, baglan);
                cmd.Parameters.AddWithValue("@kid", selectedID);
                NpgsqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    //sol taraftaki textboxların içinin dolduğu kısım. Textboxların hepsini buraya ekle ve içini doldur.
                    txt_kategoriid.Text = selectedID.ToString();
                    txt_kategoriad.Text = Convert.ToString(reader["kategoriad"]);
                }
                baglan.Close();
            }
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            //Boş geçilemez alanları düzenle
            if (string.IsNullOrWhiteSpace(txt_kategoriad.Text))
            {
                MessageBox.Show("Lutfen Boş Alan Bırakmayınız!");
                return;
            }
            else
            {
                baglan.Open();
                //Diğer ekleme kısmı tablo adı ve textbox isimlerini düzenle
                NpgsqlCommand kategoriEkle = new NpgsqlCommand("insert into kategori(kategoriad) values(@p1)", baglan);
                kategoriEkle.Parameters.AddWithValue("@p1", txt_kategoriad.Text);
                kategoriEkle.ExecuteNonQuery();

                MessageBox.Show("Kategori Başarıyla Eklendi!");
                textbox_clear();
            }
        }

        public void textbox_clear()
        {
            //textbox temizleme kısmı. textboxları düzenle.
            txt_kategoriad.Clear();
            txt_kategoriid.Clear();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            baglan.Open();
            //Diğer verileri güncelleme kısmı. Başka veriler güncellenecekse değiştir.
            string guncelleme2 = "update kategori set kategoriad=@p1 where kategoriid=@p2";
            NpgsqlCommand updatecommand2 = new NpgsqlCommand(guncelleme2, baglan);
            updatecommand2.Parameters.AddWithValue("@p1", txt_kategoriad.Text);
            updatecommand2.Parameters.AddWithValue("@p2", Convert.ToInt32(txt_kategoriid.Text));
            updatecommand2.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Kategori Başarıyla Güncellendi!");
            textbox_clear();
        }
    }
}
