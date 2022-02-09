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
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
            //textBoxlaraEkle();

           
        }
 

        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;

        //void textBoxlaraEkle()
        //{
        //    baglanti = new SqlConnection("server=.; Initial Catalog=Hotel;Integrated Security=SSPI");
        //    baglanti.Open();
        //    SqlCommand komut = new SqlCommand("select * from HotellerTablosu where otelAd='VARNA İSTANBUL'", baglanti);

        //    SqlDataReader read1 = komut.ExecuteReader();
        //    while (read1.Read())
        //    { otel1ad.Text = read1["otelAd"].ToString();
        //        otel1adres.Text = read1["otelAdres"].ToString();
        //        otel1telefon.Text = read1["otelTelefon"].ToString();
        //    }
        //    baglanti.Close();

        //}

     
        private void btnMüsteriler_Click(object sender, EventArgs e)
        {
            MüsteriSayfasi an1 = new MüsteriSayfasi();
            an1.Show();
        }

        private void btnRezervasyon_Click(object sender, EventArgs e)
        {
            Form1 an2= new Form1();
            an2.Show();
     
        }
    }
}
