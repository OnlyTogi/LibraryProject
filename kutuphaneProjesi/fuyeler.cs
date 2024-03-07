﻿using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kutuphaneProjesi
{
    public partial class fuyeler : Form
    {
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=kutuphaneprojedb; user ID=postgres; password=1234");
        public fuyeler()
        {
            InitializeComponent();
        }

        private void kekle_btn_Click(object sender, EventArgs e)
        {
            fuyeduzenle fuyeduzenle = new fuyeduzenle(0);
            fuyeduzenle.ShowDialog();
        }

        private void klist_btn_Click(object sender, EventArgs e)
        {
            string listele = "select * from uye";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(listele, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                int selectedId = Convert.ToInt32(selectedRow.Cells[0].Value);
                fuyeduzenle fuyeduzenle = new fuyeduzenle(selectedId);
                fuyeduzenle.ShowDialog();
            }
                
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                int KselectedId = Convert.ToInt32(selectedRow.Cells[0].Value);
                int selectedId = Convert.ToInt32(selectedRow.Cells[6].Value);
                label1.Text = KselectedId.ToString();
                label2.Text = selectedId.ToString();

            }
                
            
                
        }

        private void ksil_btn_Click(object sender, EventArgs e)
        {
            if (label1.Text != "label1" && label2.Text != "label2")
            {
                baglanti.Open();
                NpgsqlCommand usilKomutu = new NpgsqlCommand("delete from uye where uyeid=@p1", baglanti);
                usilKomutu.Parameters.AddWithValue("@p1", Convert.ToInt32(label1.Text));
                NpgsqlCommand AsilKomutu = new NpgsqlCommand("delete from adres where adresid=@p1", baglanti);
                AsilKomutu.Parameters.AddWithValue("@p1", Convert.ToInt32(label2.Text));
                usilKomutu.ExecuteNonQuery();
                AsilKomutu.ExecuteNonQuery();
                MessageBox.Show("Üye başarıyla silindi");
                baglanti.Close();
            }
            else
            {
                MessageBox.Show("Hiç bir satır seçimi yapmadınız.");
            }
        }
    }
}
