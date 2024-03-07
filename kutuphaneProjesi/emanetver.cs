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
    public partial class emanetver : Form
    {
        NpgsqlConnection baglan = new NpgsqlConnection("server=localHost; port=5432; Database=kutuphaneprojedb; user ID=postgres; password=1234");
        public emanetver()
        {
            InitializeComponent();
        }

        private void btn_kutuphane_Click(object sender, EventArgs e)
        {
            fkutuphane fkutuphane = new fkutuphane();
            fkutuphane.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            kitap kitap = new kitap();
            kitap.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            fuyeler fuyeler = new fuyeler();
            fuyeler.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Lutfen Boş Alan Bırakmayınız!");
                return;
            }
            else
            {
                baglan.Open();
                string guncelleme1 = "update kitap set aktiflik=false where kitapid=@p1";
                NpgsqlCommand updatecommand = new NpgsqlCommand(guncelleme1, baglan);
                updatecommand.Parameters.AddWithValue("@p1", Convert.ToInt32(textBox3.Text)); 
                string yeniKayit = "insert into emanet (kutuphaneid,uyeid,kitapid) values (@p1,@p2,@p3)";
                NpgsqlCommand insertcommand = new NpgsqlCommand(yeniKayit, baglan);
                insertcommand.Parameters.AddWithValue("@p1" , Convert.ToInt32(textBox1.Text));
                insertcommand.Parameters.AddWithValue("@p2" , Convert.ToInt32(textBox2.Text));
                insertcommand.Parameters.AddWithValue("@p3" , Convert.ToInt32(textBox3.Text));
                
                insertcommand.ExecuteNonQuery();
                updatecommand.ExecuteNonQuery();
                MessageBox.Show("Emanet Verme İşlemi Başarılı");


            }
        }
    }
}
