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
    public partial class FrmSekreterGiris : Form
    {
        public FrmSekreterGiris()
        {
            InitializeComponent();
        }
        SqlBaglantisi sqlBaglantisi = new SqlBaglantisi();
        private void btnGirisyap_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("select*from tbl_sekreter where tc=@p1 and şifre=@p2", sqlBaglantisi.sqlconnection());
            sqlCommand.Parameters.AddWithValue("@p1", mskTC.Text);
            sqlCommand.Parameters.AddWithValue("@p2", txtSifre.Text);
            SqlDataReader dr = sqlCommand.ExecuteReader();
            if (dr.Read())
            {
                FrmSekreterDetay frmSekreterDetay = new FrmSekreterDetay();
                frmSekreterDetay.TCNo = mskTC.Text; // burda sen sekreter detayın  formundaki TCNo ya değeri atmışsın evet
                frmSekreterDetay.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı TC veya Şifre");
            }
            sqlBaglantisi.sqlconnection().Close();
        }
        
    }
}
