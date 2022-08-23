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
    public partial class FrmHastaGiris : Form
    {
        public FrmHastaGiris()
        {
            InitializeComponent();
        }
        SqlBaglantisi sqlBaglantisi = new SqlBaglantisi();

        private void lnkGirisYap_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmHasta_Kayıt frmHasta_Kayıt = new FrmHasta_Kayıt();
            frmHasta_Kayıt.Show();
        }

        private void btnGirişyap_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("select * from Tbl_Hastalar where TC=@p1 and Sifre=@p2 ", sqlBaglantisi.sqlconnection());
            sqlCommand.Parameters.AddWithValue("@p1", mskTC.Text);
            sqlCommand.Parameters.AddWithValue("@p2", txtSifre.Text);
            SqlDataReader dr = sqlCommand.ExecuteReader();
            if (dr.Read())
            {
                FrmHastaDetay frmHastaDetay = new FrmHastaDetay();
                frmHastaDetay.tc = mskTC.Text;
                frmHastaDetay.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı TC veya şifre.");
            }
            sqlBaglantisi.sqlconnection().Close();
        }
    }
}
