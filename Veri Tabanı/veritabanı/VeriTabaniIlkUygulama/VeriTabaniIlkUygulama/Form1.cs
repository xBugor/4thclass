using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VeriTabaniIlkUygulama
{
    public partial class Form1 : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-45FRA94;Initial Catalog=OgrenciEvDataBase;Integrated Security=True;");
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'ogrenciEvDataBaseDataSet.Tbl_Ogrenci' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txt_no.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txt_ad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txt_soyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txt_burs.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txt_bolum.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();

        }

        private void btn_listele_Click(object sender, EventArgs e)
        {
            this.tbl_OgrenciTableAdapter.Fill(this.ogrenciEvDataBaseDataSet.Tbl_Ogrenci);

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        void temizle()
        {
            txt_ad.Text = " ";
            txt_soyad.Text = " ";
            txt_bolum.Text = " ";
            txt_burs.Text = " ";
            comboBox1.Text = " ";

        }
        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutekleme = new SqlCommand("insert into Tbl_Ogrenci(Ad,Soyad,Sehir,Burs,Bolum)values(@k1,@k2,@k3,@k4,@k5)", baglanti);
            komutekleme.Parameters.AddWithValue("@k1", txt_ad.Text);
            komutekleme.Parameters.AddWithValue("@k2", txt_soyad.Text);
            komutekleme.Parameters.AddWithValue("@k3", comboBox1.Text);
            komutekleme.Parameters.AddWithValue("@k4", txt_burs.Text);
            komutekleme.Parameters.AddWithValue("@k5", txt_bolum.Text);
            komutekleme.ExecuteNonQuery();

            baglanti.Close();
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            temizle();
            txt_ad.Focus();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutsilme = new SqlCommand("delete from Tbl_Ogrenci where OgranciNumarası=@s1",baglanti);
            komutsilme.Parameters.AddWithValue("@s1", txt_no.Text);
            komutsilme.ExecuteNonQuery();

            baglanti.Close();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutc1 = new SqlCommand("Update Tbl_Ogrenci Set Ad=@g1,Soyad=@g2,sehir=@g3,burs=@g4,bolum=@g5 where OgranciNumarası=@s1",baglanti);
            komutc1.Parameters.AddWithValue("@g1", txt_ad.Text);
            komutc1.Parameters.AddWithValue("@g2", txt_soyad.Text);
            komutc1.Parameters.AddWithValue("@g3", comboBox1.Text);
            komutc1.Parameters.AddWithValue("@g4", txt_burs.Text);
            komutc1.Parameters.AddWithValue("@g5", txt_bolum.Text);
            komutc1.Parameters.AddWithValue("s1", txt_no.Text);
            komutc1.ExecuteNonQuery();
            baglanti.Close();
        }
    }
}
