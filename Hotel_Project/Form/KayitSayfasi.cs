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

namespace Hotel_Project
{
    public partial class Form3 : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;

        public static string odemeYontemi = "";

        void Ekle()
        {
            baglanti = new SqlConnection("server=.; Initial Catalog = Hotel; Integrated Security=SSPI");

            string sorgu = "Insert into MüsteriTablosu (tc,Ad,Soyad,Ülke,Telefon,Email,DoğumTarihi,GirişTarihi,ÇıkışTarihi)  values     (@tc,@Ad,@Soyad,@Ülke,@Telefon,@Email,@DoğumTarihi,@GirişTarihi,@ÇıkışTarihi) ";

            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@tc", textBox1.Text);
            komut.Parameters.AddWithValue("@Ad", textBox2.Text);
            komut.Parameters.AddWithValue("@Soyad", textBox3.Text);
            komut.Parameters.AddWithValue("@Ülke", textBox4.Text);
            komut.Parameters.AddWithValue("@Telefon", textBox5.Text);
            komut.Parameters.AddWithValue("@Email", textBox6.Text);
            komut.Parameters.AddWithValue("@DoğumTarihi", dateTimePicker1.Value.ToString("dd/MM/yyyy"));
            komut.Parameters.AddWithValue("@GirişTarihi", dateTimePicker2.Value.ToString("dd/MM/yyyy"));
            komut.Parameters.AddWithValue("@ÇıkışTarihi", dateTimePicker3.Value.ToString("dd/MM/yyyy"));

            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();

        }

        void EkleOdeme()
        {

            baglanti = new SqlConnection("server=.; Initial Catalog=Hotel; Integrated Security=SSPI");

            string sorgu = " Insert into OdemeTablosu (tc,odaID,ödemeTürü,ödemeTarihi,ödemeTutari) values  (@tc,@odaID,@ödemeTürü,@ödemeTarihi,@ödemeTutari) ";
            komut = new SqlCommand(sorgu, baglanti);

            komut.Parameters.AddWithValue("tc", textBox1.Text);
            komut.Parameters.AddWithValue("odaID", textBox11.Text);
            komut.Parameters.AddWithValue("ödemeTürü", odemeYontemi);
            komut.Parameters.AddWithValue("ödemeTarihi", dateTimePicker4.Value.ToString("dd/MM/yyyy"));
            komut.Parameters.AddWithValue("ödemeTutari", textBox12.Text);

            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();

        }

        

        public Form3()
        {
           
            InitializeComponent();
            textBox11.Text = Form1.odaID.ToString();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            DateTime gTarih = Convert.ToDateTime(dateTimePicker2.Text);
            DateTime cTarih = Convert.ToDateTime(dateTimePicker3.Text);
            TimeSpan Sonuc = cTarih - gTarih;
            textBox12.Text = (Sonuc.TotalDays * Form1.fiyat).ToString();


        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            odemeYontemi = "Nakit";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            odemeYontemi = "Kredi Kartı";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Ekle();
            EkleOdeme();
            MessageBox.Show("Müşteri Kayıt Edildi");


        }
        //private void button1_Click(object sender, EventArgs e)
        //{
        //    //tablo.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text);
        //    //dataGridView1.DataSource = tablo;

        //    verilerigöster();

        //}






        //private void button2_Click(object sender, EventArgs e)
        //{
        //    baglan.Open();
        //    SqlCommand komut = new SqlCommand("Insert into MüsteriKayit(tc,ad,soyad,ülke,telefon,email,cinsiyet,yas,giristarihi,cikistarihi) Values ('" + textBox1.Text.ToString() + "' ,'" + textBox2.Text.ToString() + "')", baglan);
        //    komut.ExecuteNonQuery();
        //    baglan.Close(); 
        //    verilerigöster();
        //}
    }
}
