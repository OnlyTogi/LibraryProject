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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_kutup_Click(object sender, EventArgs e)
        {
            fkutuphane fkutuphane = new fkutuphane();
            fkutuphane.ShowDialog();
        }

        private void btn_uye_Click(object sender, EventArgs e)
        {
            fuyeler fuyeler = new fuyeler();
            fuyeler.ShowDialog();
        }

        private void btn_yayinevi_Click(object sender, EventArgs e)
        {
            yayinevi yayinevi= new yayinevi();
            yayinevi.ShowDialog();
        }

        private void btn_yazar_Click(object sender, EventArgs e)
        {
            yazar yazar = new yazar();
            yazar.ShowDialog();
        }

        private void btn_kategori_Click(object sender, EventArgs e)
        {
            kategoriler kategoriler = new kategoriler();
            kategoriler.ShowDialog();

        }

        private void btn_kitap_Click(object sender, EventArgs e)
        {
            kitap kitap = new kitap();
            kitap.ShowDialog();
        }

        private void btn_emanet_Click(object sender, EventArgs e)
        {
            emanetler emanetler = new emanetler();
            emanetler.ShowDialog();
        }
    }
}
