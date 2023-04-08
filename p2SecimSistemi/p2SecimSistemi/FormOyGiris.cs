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
namespace p2SecimSistemi
{
    public partial class FormOyGiris : Form
    {
        public FormOyGiris()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-23T2RIK\\SQLEXPRESS;Initial Catalog=p2SecimSistemi;Integrated Security=True");

        private void btnOy_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("insert into Table_Partiler (ILCEAD,BIRINCIPARTI,IKINCIPARTI,UCUNCUPARTI,DORDUNCUPARTI,BESINCIPARTI) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
            cmd.Parameters.AddWithValue("@p1", txtIlceAd.Text);
            cmd.Parameters.AddWithValue("@p2", txtBir.Text);
            cmd.Parameters.AddWithValue("@p3", txtIki.Text);
            cmd.Parameters.AddWithValue("@p4", txtUc.Text);
            cmd.Parameters.AddWithValue("@p5", txtDort.Text);
            cmd.Parameters.AddWithValue("@p6", txtBes.Text);
            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Oy Girişi Gerçekleşti!", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGrafikler_Click(object sender, EventArgs e)
        {
            FormGrafikler formGrafikler = new FormGrafikler();
            formGrafikler.Show();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
