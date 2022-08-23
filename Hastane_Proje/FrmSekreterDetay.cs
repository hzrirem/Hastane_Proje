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
    public partial class FrmSekreterDetay : Form
    {
        public FrmSekreterDetay()
        {
            InitializeComponent();
        }
        public string TCNo;
        SqlBaglantisi sqlBaglantisi = new SqlBaglantisi();
        private void FrmSekreterDetay_Load(object sender, EventArgs e)
        {
            //Ad Soyad Çekme
            lblTC.Text = TCNo; 
            SqlCommand komut = new SqlCommand("select Ad_Soyad from tbl_sekreter where tc=@p1", sqlBaglantisi.sqlconnection());
            komut.Parameters.AddWithValue("@p1", lblTC.Text); 
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblAdSoyad.Text = dr[0].ToString();
            }
            sqlBaglantisi.sqlconnection().Close();

            //Branşları DataGride çekme

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select BranşAd from Tbl_Branşlar ", sqlBaglantisi.sqlconnection());
            da.Fill(dt);
            dataGridView2.DataSource=(dt);

            //Doktorları listeye aktarma
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select (Ad+' '+Soyad) as 'Doktorlar',Branş From Tbl_Doktorlar",sqlBaglantisi.sqlconnection());
            da1.Fill(dt1);
            dataGridView1.DataSource = (dt1);

            //Branş Çekme
            SqlCommand komut1 = new SqlCommand("select BranşAd from Tbl_Branşlar ",sqlBaglantisi.sqlconnection());
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                cmbBrans.Items.Add (dr1[0]);
            }
            sqlBaglantisi.sqlconnection().Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komutkaydet = new SqlCommand("insert into tbl_randevular (Tarih,Saat,Brans,Doktor)values (@r1,@r2,@r3,@r4)", sqlBaglantisi.sqlconnection());
            komutkaydet.Parameters.AddWithValue("@r1", mskTarih.Text);
            komutkaydet.Parameters.AddWithValue("@r2", mskSaat.Text);
            komutkaydet.Parameters.AddWithValue("@r3", cmbBrans.Text);
            komutkaydet.Parameters.AddWithValue("@r4", cmbDoktor.Text);
            komutkaydet.ExecuteNonQuery();
            sqlBaglantisi.sqlconnection().Close();
            MessageBox.Show("Randevu Oluşturuldu.");

        }

        //Doktorları comboboxa çekme
        private void cmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDoktor.Items.Clear();
            SqlCommand komut = new SqlCommand("select ad,soyad from tbl_doktorlar where branş=@p1", sqlBaglantisi.sqlconnection());
            komut.Parameters.AddWithValue("@p1", cmbBrans.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbDoktor.Items.Add(dr[0] + " " + dr[1]);
            }
            sqlBaglantisi.sqlconnection().Close();

        }

        private void btnyayınla_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("insert into Tbl_Duyurular (Duyuru) values (@d1)", sqlBaglantisi.sqlconnection());
            sqlCommand.Parameters.AddWithValue("@d1", rchDuyuru.Text);
            sqlCommand.ExecuteNonQuery();
            sqlBaglantisi.sqlconnection().Close();
            MessageBox.Show("Duyuru Yayınlandı.");

        }

        private void btnDoktorPaneli_Click(object sender, EventArgs e)
        {
            FrmDoktorPaneli frmDoktorPaneli = new FrmDoktorPaneli();
            frmDoktorPaneli.Show();
        }

        private void btnBransPaneli_Click(object sender, EventArgs e)
        {
            FrmBrans frmBrans = new FrmBrans();
            frmBrans.Show();
        }

        private void btnRandevuListe_Click(object sender, EventArgs e)
        {
            FrmRandevuListesi frmRandevuListesi = new FrmRandevuListesi();
            frmRandevuListesi.Show();
        }

        private void btnduyurular_Click(object sender, EventArgs e)
        {
            FrmDuyurular frmDuyurular = new FrmDuyurular();
            frmDuyurular.Show();
        }
    }
}
