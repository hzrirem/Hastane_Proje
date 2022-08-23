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
    public partial class FrmHasta_Kayıt : Form
    {
        public FrmHasta_Kayıt()
        {
            InitializeComponent();
        }

        SqlBaglantisi sqlBaglantisi = new SqlBaglantisi();

        private void btnHastaKayıtol_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("insert into Tbl_Hastalar(Ad, Soyad,TC,Telefon,Sifre,Cinsiyet) values(@p1,@p2,@p3,@p4,@p5,@p6)", sqlBaglantisi.sqlconnection());
            sqlCommand.Parameters.AddWithValue("@p1", txtHastaAd.Text);
            sqlCommand.Parameters.AddWithValue("@p2", txtHastaSoyad.Text);
            sqlCommand.Parameters.AddWithValue("@p3", mskHastaTC.Text);
            sqlCommand.Parameters.AddWithValue("@p4", mskHastaTel.Text);
            sqlCommand.Parameters.AddWithValue("@p5", txtHastaSifre.Text);
            sqlCommand.Parameters.AddWithValue("@p6", cmbHastaCinsiyet.Text);
            sqlCommand.ExecuteNonQuery();
            sqlBaglantisi.sqlconnection().Close();
            MessageBox.Show("Kaydınız başarı ile gerçekleştirilmiştir. Şifreniz" + txtHastaSifre.Text, "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
