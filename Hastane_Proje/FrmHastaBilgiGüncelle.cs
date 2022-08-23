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

namespace Hastane_Proje
{
    public partial class Bilgi_Güncelle : Form
    {
        public Bilgi_Güncelle()
        {
            InitializeComponent();
        }
        public string TCno;
        SqlBaglantisi sqlBaglantisi = new SqlBaglantisi();
        private void Bilgi_Güncelle_Load(object sender, EventArgs e)
        {
            mskHastaTC.Text = TCno;
            SqlCommand sqlCommand = new SqlCommand("select*from Tbl_hastalar where tc=@p1", sqlBaglantisi.sqlconnection());
            sqlCommand.Parameters.AddWithValue("@p1", mskHastaTC.Text);
            SqlDataReader dr = sqlCommand.ExecuteReader();
            while (dr.Read())
            {
                txtHastaAd.Text = dr[1].ToString();
                txtHastaSoyad.Text = dr[2].ToString();
                mskTelefon.Text = dr[4].ToString();
                txtSifre.Text = dr[5].ToString();
                cmbCinsiyet.Text = dr[6].ToString();
            }
            sqlBaglantisi.sqlconnection().Close();

        }

        private void btnBilgiGüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("update Tbl_Hastalar set ad=@p1,soyad=@p2,telefon=@p3,sifre=@p4,cinsiyet=@p5 where tc=@p6", sqlBaglantisi.sqlconnection());
            sqlCommand.Parameters.AddWithValue("@p1", txtHastaAd.Text);
            sqlCommand.Parameters.AddWithValue("@p2", txtHastaSoyad.Text);
            sqlCommand.Parameters.AddWithValue("@p3", mskTelefon.Text);
            sqlCommand.Parameters.AddWithValue("@p4", txtSifre.Text);
            sqlCommand.Parameters.AddWithValue("@p5", cmbCinsiyet.Text);
            sqlCommand.Parameters.AddWithValue("@p6", mskHastaTC.Text);
            sqlCommand.ExecuteNonQuery();
            sqlBaglantisi.sqlconnection().Close();
            MessageBox.Show("Bilgileriniz Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
