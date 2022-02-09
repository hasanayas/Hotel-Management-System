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

//EXPORT İÇİN AKTİF EDİLMELİDİR
using System.IO;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;

//İMPORT İÇİN AKTİF EDİLMELİDİR
using ExcelDataReader;


//BackUP İÇİN AKTİF EDİLMELİDİR
//using Microsoft.SqlServer.Management.Smo;
//using Microsoft.SqlServer.Management.Common;




namespace Hotel_Project.User_Control
{
    public partial class UserControlSettings : UserControl
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;

        void MusteriGetir()
        {
            baglanti = new SqlConnection("server=.; Initial Catalog=Hotel;Integrated Security=SSPI");
            baglanti.Open();
            da = new SqlDataAdapter("Select * From MüsteriTablosu", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);

            dataGridView21.DataSource = tablo;
            dataGridView22.DataSource = tablo;
            dataGridView24.DataSource = tablo;
            baglanti.Close();
        }

        public void Clear()
        {
            textTCNO.Clear();
            textAD.Clear();
            textSOYAD.Clear();
            textULKE.Clear();
            textTEL.Clear();
            textMAİL.Clear();
            textBox5.Clear();
            textBox7.Clear();


        }

        public UserControlSettings()
        {
            InitializeComponent();
            MusteriGetir();
            StyleDatagridview();

        }


        void StyleDatagridview() //DATA GRİD STYLE
        {
            //İLK TABLO
            dataGridView22.BorderStyle = BorderStyle.None;
            dataGridView22.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView22.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView22.DefaultCellStyle.SelectionBackColor = Color.SeaGreen; // Çizgi Rengi
            dataGridView22.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView22.BackgroundColor = Color.FromArgb(30, 30, 30);
            dataGridView22.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;//optional
            dataGridView22.EnableHeadersVisualStyles = false;
            dataGridView22.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView22.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(37, 37, 38);
            dataGridView22.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            //İKİNCİ TABLO
            dataGridView21.BorderStyle = BorderStyle.None;
            dataGridView21.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView21.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView21.DefaultCellStyle.SelectionBackColor = Color.SeaGreen; // Çizgi Rengi
            dataGridView21.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView21.BackgroundColor = Color.FromArgb(30, 30, 30);
            dataGridView21.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;//optional
            dataGridView21.EnableHeadersVisualStyles = false;
            dataGridView21.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView21.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(37, 37, 38);
            dataGridView21.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            //DÖRDÜNCÜ TABLO
            dataGridView24.BorderStyle = BorderStyle.None;
            dataGridView24.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView24.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView24.DefaultCellStyle.SelectionBackColor = Color.SeaGreen; // Çizgi Rengi
            dataGridView24.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView24.BackgroundColor = Color.FromArgb(30, 30, 30);
            dataGridView24.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;//optional
            dataGridView24.EnableHeadersVisualStyles = false;
            dataGridView24.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView24.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(37, 37, 38);
            dataGridView24.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }




        //ATAMA
        private void dataGridView21_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textTCNO.Text = dataGridView21.CurrentRow.Cells[0].Value.ToString();
            textAD.Text = dataGridView21.CurrentRow.Cells[1].Value.ToString();
            textSOYAD.Text = dataGridView21.CurrentRow.Cells[2].Value.ToString();
            textULKE.Text = dataGridView21.CurrentRow.Cells[3].Value.ToString();
            textTEL.Text = dataGridView21.CurrentRow.Cells[4].Value.ToString();
            textMAİL.Text = dataGridView21.CurrentRow.Cells[5].Value.ToString();

            dateTimePicker1.Text = dataGridView21.CurrentRow.Cells[6].Value.ToString();
            dateTimePicker2.Text = dataGridView21.CurrentRow.Cells[7].Value.ToString();
            //dateTimePicker3.Text = dataGridView21.CurrentRow.Cells[8].Value.ToString();
        }


        //ARAMA
        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {
            baglanti.Open();
            DataTable tbl = new DataTable();
            SqlDataAdapter ara = new SqlDataAdapter("Select * From  MüsteriTablosu Where Ad like '%" + textBox5.Text + "%' or Soyad like '%" + textBox5.Text + "%'", baglanti);
            ara.Fill(tbl);
            baglanti.Close();
            dataGridView24.DataSource = tbl;
        }

        //spMüsteriGüncelle PROSODÜRÜ İLE TABLODAN KULLANICI Güncelleme İŞLEMİ
        private void buttonUpdate_Click(object sender, EventArgs e)
        {


            baglanti = new SqlConnection("server=.; Initial Catalog=Hotel;Integrated Security=SSPI");
            SqlCommand sorgu2 = new SqlCommand();
            baglanti.Open();
            sorgu2.Connection = baglanti;
            sorgu2.CommandType = CommandType.StoredProcedure;
            sorgu2.CommandText = "spMüsteriGüncelle";
            sorgu2.Parameters.AddWithValue("@tc", Convert.ToInt64(textTCNO.Text));
            sorgu2.Parameters.AddWithValue("@Ad", (textAD.Text));
            sorgu2.Parameters.AddWithValue("@Soyad", textSOYAD.Text);
            sorgu2.Parameters.AddWithValue("@Ülke", textULKE.Text);
            sorgu2.Parameters.AddWithValue("@Telefon", textTEL.Text);
            sorgu2.Parameters.AddWithValue("@Email", textMAİL.Text);
            sorgu2.Parameters.AddWithValue("@DoğumTarihi", dateTimePicker1.Text);
            sorgu2.Parameters.AddWithValue("@GirişTarihi", dateTimePicker2.Text);
            sorgu2.Parameters.AddWithValue("@ÇıkışTarihi", dateTimePicker3.Text);


            if (sorgu2.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Güncellendi");
            }

            baglanti.Close();
            MusteriGetir();
            Clear();

        }



        private void dataGridView22_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox7.Text = dataGridView22.CurrentRow.Cells[0].Value.ToString();
        }

        //spMüsteriSil PROSODÜRÜ İLE TABLODAN KULLANICI SİLME İŞLEMİ
        private void button1_Click_1(object sender, EventArgs e)
        {
            baglanti = new SqlConnection("server=.; Initial Catalog=Hotel;Integrated Security=SSPI");
            SqlCommand sorgu = new SqlCommand();
            baglanti.Open();
            sorgu.Connection = baglanti;
            sorgu.CommandType = CommandType.StoredProcedure;
            sorgu.CommandText = "spMüsteriSil";
            sorgu.Parameters.AddWithValue("@tc", Convert.ToInt64(textBox7.Text));

            if (sorgu.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Silindi");
            }

            MusteriGetir();
            baglanti.Close();


        }

        //EXPORT

        private void button5_Click(object sender, EventArgs e)
        {

            if (dataGridView24.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "FiltrelenmisVeriler.pdf";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("Verileri diske yazmak mümkün değil." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(dataGridView24.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn column in dataGridView24.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                pdfTable.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in dataGridView24.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    pdfTable.AddCell(cell.Value.ToString());
                                }
                            }

                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("Veri Aktarımı Başarılı", "Bilgi");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Hata :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Dışa Aktarılacak Kayıt Yok !!!", "Info");
            }

        }

        private void btnKaydet_Click_1(object sender, EventArgs e)
        {

            if (dataGridView21.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "Veriler.pdf";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("Verileri diske yazmak mümkün değil." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(dataGridView21.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn column in dataGridView21.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                pdfTable.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in dataGridView21.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    pdfTable.AddCell(cell.Value.ToString());
                                }
                            }

                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("Veri Aktarımı Başarılı", "Bilgi");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Hata :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Export Başarısız !!!", "Info");
            }

        }
 
      }
    }


////İMPORT

//DataTableCollection tableCollection;
//private void cboSheet_SelectedIndexChanged(object sender, EventArgs e)
//{
//    DataTable dt = tableCollection[cboSheet.SelectedItem.ToString()];
//    // dataGridView23.DataSource = dt;
//    if (dt != null)
//    {
//        List<MüsteriTablosu> list = new List<MüsteriTablosu>(); //adı list
//        for (int i = 0; i < dt.Rows.Count; i++)
//        {
//            MüsteriTablosu obj = new MüsteriTablosu();
//            obj.tc = dt.Rows[i]["tc"].ToString();
//            obj.Ad = dt.Rows[i]["Ad"].ToString();
//            obj.Soyad = dt.Rows[i]["Soyad"].ToString();
//            obj.Ülke = dt.Rows[i]["Ülke"].ToString();
//            obj.Telefon = dt.Rows[i]["Telefon"].ToString();
//            obj.Email = dt.Rows[i]["Email"].ToString();
//            obj.DoğumTarihi = dt.Rows[i]["DoğumTarihi"].ToString();
//            obj.GirişTarihi = dt.Rows[i]["GirişTarihi"].ToString();
//            obj.ÇıkışTarihi = dt.Rows[i]["ÇıkışTarihi"].ToString();
//            //obj.ÇıkışTarihi = dt.Rows[i]["odaID"].ToString();
//            //obj.ÇıkışTarihi = dt.Rows[i]["ödemeTürü"].ToString();
//            //obj.ÇıkışTarihi = dt.Rows[i]["ödemeTarihi"].ToString();
//            //obj.ÇıkışTarihi = dt.Rows[i]["ödemeTutari"].ToString();
//            list.Add(obj);
//        }
//        müsteriTablosuBindingSource.DataSource = list;
//    }
//}


//private void btnBrowse_Click_1(object sender, EventArgs e)
//{
//    using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Excel Workbook|*.xlsx|Excel Workbook|*.xlsx" })
//    {
//        if (ofd.ShowDialog() == DialogResult.OK)
//        {
//            txtFilename.Text = ofd.FileName;
//            using (var stream = File.Open(ofd.FileName, FileMode.Open, FileAccess.Read))
//            {
//                using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
//                {
//                    DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
//                    {
//                        ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
//                        {
//                            UseHeaderRow = true
//                        }
//                    });
//                    tableCollection = result.Tables;
//                    cboSheet.Items.Clear();
//                    foreach (DataTable table in tableCollection)
//                        cboSheet.Items.Add(table.TableName); //sheet'i combobox'a ekler
//                }
//            }
//        }
//    }
//}

//private void btnImport_Click_1(object sender, EventArgs e)
//{
//    baglanti = new SqlConnection("server=.; Initial Catalog=Hotel;Integrated Security=SSPI");
//    baglanti.Open();
//    for (int i = 0; i < dataGridView23.Rows.Count; i++)
//    {
//        SqlCommand cmd = new SqlCommand("Insert into MüsteriTablosu(tc,Ad,Soyad,Ülke,Telefon,Email,DoğumTarihi,GirişTarihi,ÇıkışTarihi) values ('" + dataGridView23.Rows[i].Cells[0].Value + "'," +
//            "'" + dataGridView23.Rows[i].Cells[1].Value + "','" + dataGridView23.Rows[i].Cells[2].Value + "'," +
//            "'" + dataGridView23.Rows[i].Cells[3].Value + "','" + dataGridView23.Rows[i].Cells[4].Value + "'," +
//            "'" + dataGridView23.Rows[i].Cells[5].Value + "'," +
//            "'" + dataGridView23.Rows[i].Cells[6].Value + "','" + dataGridView23.Rows[i].Cells[7].Value + "'," +
//            "'" + dataGridView23.Rows[i].Cells[8].Value + "')", baglanti);
//        cmd.ExecuteNonQuery();
//    }

//    //for (int i = 0; i < dataGridView23.Rows.Count; i++)
//    //{
//    //    SqlCommand cmdd = new SqlCommand("Insert into OdemeTablosu(tc,odaID,ödemeTürü,ödemeTarihi,ödemeTutari) values ('" + dataGridView23.Rows[i].Cells[0].Value + "'," +
//    //        "'" + dataGridView23.Rows[i].Cells[9].Value + "','" + dataGridView23.Rows[i].Cells[10].Value + "'," +
//    //        "'" + dataGridView23.Rows[i].Cells[11].Value + "','" + dataGridView23.Rows[i].Cells[12].Value + "')", baglanti);
//    //    cmdd.ExecuteNonQuery();
//    //}

//    MusteriGetir();
//    baglanti.Close();

//}

