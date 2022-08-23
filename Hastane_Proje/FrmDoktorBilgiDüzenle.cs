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
    public partial class FrmDoktorBilgiDüzenle : Form
    {
        public FrmDoktorBilgiDüzenle()
        {
            InitializeComponent();
        }
        SqlBaglantisi sqlBaglantisi = new SqlBaglantisi();
        public string TcNo;
        private void FrmDoktorBilgiDüzenle_Load(object sender, EventArgs e)
        {
            mskDoktorTC.Text = TcNo;


            SqlCommand sqlCommand = new SqlCommand("select * from tbl_doktorlar where tc=@p1", sqlBaglantisi.sqlconnection());
            sqlCommand.Parameters.AddWithValue("@p1", mskDoktorTC.Text);
            SqlDataReader dr = sqlCommand.ExecuteReader();
            while (dr.Read())
            {
                txtAd.Text = dr[1].ToString();
                txtSoyad.Text = dr[2].ToString();
                cmbBrans.Text = dr[5].ToString();
                txtşifre.Text = dr[4].ToString();

            }
            sqlBaglantisi.sqlconnection().Close();
        }

        private void btnBilgiGüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("update tbl_doktorlar set ad=@p1,soyad=@p2, şifre=@p3,branş=@p4 where tc=@p5", sqlBaglantisi.sqlconnection());
            sqlCommand.Parameters.AddWithValue("@p1", txtAd.Text);
            sqlCommand.Parameters.AddWithValue("@p2", txtSoyad.Text);
            sqlCommand.Parameters.AddWithValue("@p3", txtşifre.Text);
            sqlCommand.Parameters.AddWithValue("@p4", cmbBrans.Text);
            sqlCommand.Parameters.AddWithValue("@p5", mskDoktorTC.Text);
            sqlCommand.ExecuteNonQuery();
            sqlBaglantisi.sqlconnection().Close();
            MessageBox.Show("Bilgiler Güncellendi.");



        }
    }
}
