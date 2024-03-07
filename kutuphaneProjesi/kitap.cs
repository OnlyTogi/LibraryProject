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
    public partial class kitap : Form
    {
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=kutuphaneprojedb; user ID=postgres; password=1234");
        public kitap()
        {
            InitializeComponent();
        }

        private void klist_btn_Click(object sender, EventArgs e)
        {
            //Listeleme fonksiyonu, listele stringinden tablo adını değiştir.
            string listele = "select * from kitap";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(listele, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void kekle_btn_Click(object sender, EventArgs e)
        {
            kitapduzenle kitapduzenle = new kitapduzenle(0);
            kitapduzenle.ShowDialog();
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                int selectedId = Convert.ToInt32(selectedRow.Cells[0].Value);
                kitapduzenle kitapduzenle = new kitapduzenle(selectedId);
                kitapduzenle.ShowDialog();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                int KselectedId = Convert.ToInt32(selectedRow.Cells[0].Value);
                label1.Text = KselectedId.ToString();
            }

        }

        private void ksil_btn_Click(object sender, EventArgs e)
        {
            if (label1.Text != "label1")
            {
                //Silinecek tabloyu seç. 
                baglanti.Open();
                NpgsqlCommand ksilKomutu = new NpgsqlCommand("delete from kitap where kitapid=@p1", baglanti);
                ksilKomutu.Parameters.AddWithValue("@p1", Convert.ToInt32(label1.Text));
                ksilKomutu.ExecuteNonQuery();
                MessageBox.Show("Kitap başarıyla silindi");
                baglanti.Close();
            }
            else
            {
                MessageBox.Show("Hiç bir satır seçimi yapmadınız.");
            }
        }
    }
}
