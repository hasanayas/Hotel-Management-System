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

    //internal class d { }
   




    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
    }

        public static string odaAd = null;
        public static int fiyat = 0;
        public static string odaID = null;

        private void button1_Click(object sender, EventArgs e)
        {
            odaAd = label1.Text;
            fiyat = 25;
            odaID = "Oda 101";
            Form3 an2 = new Form3();
            an2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            odaAd = label2.Text;
            fiyat = 50;
            odaID = "Oda 201";
            Form3 an2 = new Form3();
            an2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            odaAd = label3.Text;
            fiyat = 150;
            odaID = "Oda 301";
            Form3 an2 = new Form3();
            an2.Show();
        }
    }
}
