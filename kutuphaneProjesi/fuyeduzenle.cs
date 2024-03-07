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
    public partial class fuyeduzenle : Form
    {
        NpgsqlConnection baglan = new NpgsqlConnection("server=localHost; port=5432; Database=kutuphaneprojedb; user ID=postgres; password=1234");
        public fuyeduzenle(int id)
        {
            InitializeComponent();
            int selectedID = id;

            if (selectedID != 0)
            {
                baglan.Open();
                txt_uyeid.Text = selectedID.ToString();
                string vericek = "select uyead,uyesoyad,uyecinsiyet,uyetelefonno,uyeeposta,adresid from uye where uyeid = @uid";
                NpgsqlCommand cmd = new NpgsqlCommand(vericek, baglan);
                cmd.Parameters.AddWithValue("@uid", selectedID);
                NpgsqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txt_uyead.Text = Convert.ToString(reader["uyead"]);
                    txt_uyesoyad.Text = Convert.ToString(reader["uyesoyad"]);
                    txt_uyetel.Text = Convert.ToString(reader["uyetelefonno"]);
                    txt_uyeeposta.Text = Convert.ToString(reader["uyeeposta"]);
                    string cinsiyet = Convert.ToString(reader["uyecinsiyet"]);
                    if (cinsiyet == "Erkek")
                    {
                        cmb_uyecinsiyet.SelectedIndex = 0;
                    }
                    else if (cinsiyet == "Kadın")
                    {
                        cmb_uyecinsiyet.SelectedIndex = 1;
                    }
                    int AId = Convert.ToInt32(reader["adresid"]);
                    txt_adresid.Text = AId.ToString();
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
            if (string.IsNullOrWhiteSpace(txt_uyead.Text) || string.IsNullOrWhiteSpace(txt_uyesoyad.Text) || string.IsNullOrWhiteSpace(txt_uyetel.Text) || string.IsNullOrWhiteSpace(txt_uyeeposta.Text) ||
                string.IsNullOrWhiteSpace(cmb_uyecinsiyet.Text) || string.IsNullOrWhiteSpace(txt_adresil.Text) || string.IsNullOrWhiteSpace(txt_adresilce.Text) ||
                string.IsNullOrWhiteSpace(txt_adresmah.Text) || string.IsNullOrWhiteSpace(txt_adrescad.Text) || string.IsNullOrWhiteSpace(txt_adressok.Text)
                || string.IsNullOrWhiteSpace(txt_adresbina.Text) || string.IsNullOrWhiteSpace(txt_adreskat.Text) || string.IsNullOrWhiteSpace(txt_adresposta.Text))
            {
                MessageBox.Show("Lutfen Boş Alan Bırakmayınız!");
                return;
            }
            else
            {
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

                NpgsqlCommand uyeEkle = new NpgsqlCommand("insert into uye(uyead,uyesoyad,uyecinsiyet,uyetelefonno,uyeeposta,adresid) values(@p1,@p2,@p3,@p4,@p5,@p6)", baglan);
                uyeEkle.Parameters.AddWithValue("@p1", txt_uyead.Text);
                uyeEkle.Parameters.AddWithValue("@p2", txt_uyesoyad.Text);
                uyeEkle.Parameters.AddWithValue("@p3", cmb_uyecinsiyet.Text);
                uyeEkle.Parameters.AddWithValue("@p4", txt_uyetel.Text);
                uyeEkle.Parameters.AddWithValue("@p5", txt_uyeeposta.Text);
                uyeEkle.Parameters.AddWithValue("@p6", adresID);
                uyeEkle.ExecuteNonQuery();

                MessageBox.Show("Üye Başarıyla Eklendi!");
                textbox_clear();
            }
        }

        public void textbox_clear()
        {
            txt_adresbina.Clear();
            txt_adreskat.Clear();
            txt_adresposta.Clear();
            txt_adrescad.Clear();
            txt_adresid.Clear();
            txt_adresil.Clear();
            txt_adresilce.Clear();
            txt_adresmah.Clear();
            txt_adressok.Clear();
            txt_uyead.Clear();
            txt_uyesoyad.Clear();
            txt_uyetel.Clear();
            txt_uyeeposta.Clear();
            txt_uyeid.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglan.Open();
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

            string guncelleme2 = "update uye set uyead=@p1,uyesoyad=@p2,uyecinsiyet=@p3,uyetelefonno=@p4,uyeeposta=@p5 where uyeid=@p6";
            NpgsqlCommand updatecommand2 = new NpgsqlCommand(guncelleme2, baglan);
            updatecommand2.Parameters.AddWithValue("@p1", txt_uyead.Text);
            updatecommand2.Parameters.AddWithValue("@p2", txt_uyesoyad.Text);
            updatecommand2.Parameters.AddWithValue("@p3", cmb_uyecinsiyet.Text);
            updatecommand2.Parameters.AddWithValue("@p4", txt_uyetel.Text);
            updatecommand2.Parameters.AddWithValue("@p5", txt_uyeeposta.Text);
            updatecommand2.Parameters.AddWithValue("@p6", Convert.ToInt32(txt_uyeid.Text));
            updatecommand.ExecuteNonQuery();
            updatecommand2.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Üye Başarıyla Güncellendi!");
            textbox_clear();
        }
    }
}

