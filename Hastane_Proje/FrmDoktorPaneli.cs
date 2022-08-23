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
    public partial class FrmDoktorPaneli : Form
    {
        public FrmDoktorPaneli()
        {
            InitializeComponent();
        }
        SqlBaglantisi sqlBaglantisi = new SqlBaglantisi();
        private void FrmDoktorPaneli_Load(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select * From Tbl_Doktorlar", sqlBaglantisi.sqlconnection());
            da1.Fill(dt1);
            dataGridView1.DataSource = (dt1);


            //Branş Çekme 
            SqlCommand komut1 = new SqlCommand("select BranşAd from Tbl_Branşlar ", sqlBaglantisi.sqlconnection());
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                cmbbrans.Items.Add(dr1[0]);
            }
            sqlBaglantisi.sqlconnection().Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into tbl_doktorlar(ad,soyad,branş,tc,şifre) values (@p1,@p2,@p3,@p4,@p5)",sqlBaglantisi.sqlconnection());
            komut.Parameters.AddWithValue("@p1", txtad.Text);
            komut.Parameters.AddWithValue("@p2", txtsoyad.Text);
            komut.Parameters.AddWithValue("@p3", cmbbrans.Text);
            komut.Parameters.AddWithValue("@p4", msktc.Text);
            komut.Parameters.AddWithValue("@p5", txtsifre.Text);
            komut.ExecuteNonQuery();
            sqlBaglantisi.sqlconnection().Close();
            MessageBox.Show("Doktor eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtsoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            msktc.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtsifre.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            cmbbrans.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from Tbl_Doktorlar where tc=@p1", sqlBaglantisi.sqlconnection());
            komut.Parameters.AddWithValue("@p1", msktc.Text);
            komut.ExecuteNonQuery();
            sqlBaglantisi.sqlconnection().Close();
            MessageBox.Show("Kayıt Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update tbl_doktorlar set ad=@d1,soyad=@d2,şifre=@d4,branş=@d5 where tc=@d3", sqlBaglantisi.sqlconnection());
            komut.Parameters.AddWithValue("@d1", txtad.Text);
            komut.Parameters.AddWithValue("@d2", txtsoyad.Text);
            komut.Parameters.AddWithValue("@d3", msktc.Text);
            komut.Parameters.AddWithValue("@d4", txtsifre.Text);
            komut.Parameters.AddWithValue("@d5", cmbbrans.Text);
            komut.ExecuteNonQuery();
            sqlBaglantisi.sqlconnection().Close();
            MessageBox.Show("Doktor güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
