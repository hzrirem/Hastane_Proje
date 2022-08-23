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
    public partial class FrmDoktorGiris : Form
    {
        public FrmDoktorGiris()
        {
            InitializeComponent();
        }
        SqlBaglantisi sqlBaglantisi = new SqlBaglantisi();

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("select*from tbl_doktorlar where tc=@p1 and şifre=@p2", sqlBaglantisi.sqlconnection());
            sqlCommand.Parameters.AddWithValue("@p1", mskTC.Text);
            sqlCommand.Parameters.AddWithValue("@p2", txtSifre.Text);
            SqlDataReader dr = sqlCommand.ExecuteReader();
            if (dr.Read())
            {
                FrmDoktorDetay frmDoktorDetay = new FrmDoktorDetay();
                frmDoktorDetay.Tc = mskTC.Text;
                frmDoktorDetay.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre.");
            }
            sqlBaglantisi.sqlconnection().Close();

        }
    }
}
