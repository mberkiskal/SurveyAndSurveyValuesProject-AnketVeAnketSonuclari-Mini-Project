using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace p2SecimSistemi
{
    public partial class FormGrafikler : Form
    {
        public FormGrafikler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-23T2RIK\\SQLEXPRESS;Initial Catalog=p2SecimSistemi;Integrated Security=True");

        private void FormGrafikler_Load(object sender, EventArgs e)
        {
            //İLÇE ADLARINI KOMBOBOXA ÇEKME
            baglanti.Open();
            SqlCommand cmd1 = new SqlCommand("Select ILCEAD from Table_Partiler",baglanti);
            SqlDataReader reader = cmd1.ExecuteReader();
            while(reader.Read())
            {
                comboBox1.Items.Add(reader[0]);
            }
            baglanti.Close();


            //GRAFİĞE SONUÇ GETİRME 

            baglanti.Open();
            SqlCommand cmd2 = new SqlCommand("Select SUM(BIRINCIPARTI),SUM(IKINCIPARTI),SUM(UCUNCUPARTI),SUM(DORDUNCUPARTI),SUM(BESINCIPARTI) from Table_Partiler ", baglanti);
            SqlDataReader sqlDataReader = cmd2.ExecuteReader();
            while(sqlDataReader.Read())
            {
                chart1.Series["Partiler"].Points.AddXY("Birinci Parti", sqlDataReader[0]);
                chart1.Series["Partiler"].Points.AddXY("İkinci Parti", sqlDataReader[1]);
                chart1.Series["Partiler"].Points.AddXY("Üçüncü Parti", sqlDataReader[2]);
                chart1.Series["Partiler"].Points.AddXY("Dördüncü Parti", sqlDataReader[3]);
                chart1.Series["Partiler"].Points.AddXY("Beşinci Parti", sqlDataReader[4]);
            }
            baglanti.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd3 = new SqlCommand("select * from Table_Partiler where ILCEAD=@p1", baglanti);
            cmd3.Parameters.AddWithValue("@p1", comboBox1.Text);
            SqlDataReader rdr2 = cmd3.ExecuteReader();
            while(rdr2.Read())
            {
                pBirinci.Value= int.Parse(rdr2[2].ToString());
                pİkinci.Value = int.Parse(rdr2[3].ToString());
                pUcuncu.Value = int.Parse(rdr2[4].ToString());
                pDorduncu.Value = int.Parse(rdr2[5].ToString());
                pBesinci.Value = int.Parse(rdr2[6].ToString());

                lblBirinci.Text= rdr2[2].ToString();
                lblIkinci.Text = rdr2[3].ToString();
                lblUcuncu.Text = rdr2[4].ToString();
                lblDorduncu.Text = rdr2[5].ToString();
                lblBesinci.Text = rdr2[6].ToString();
            }
            baglanti.Close();
        }
    }
}
