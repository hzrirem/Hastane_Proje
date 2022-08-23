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
    public partial class FrmHastaDetay : Form
    {
        public FrmHastaDetay()
        {
            InitializeComponent();
        }
        public string tc;
        SqlBaglantisi sqlBaglantisi = new SqlBaglantisi();
        private void FrmHastaDetay_Load(object sender, EventArgs e)
        {
            //ad soyad çekme
            lblTCHasta.Text = tc;

            SqlCommand sqlCommand = new SqlCommand("select ad,soyad from Tbl_Hastalar where tc=@p1",sqlBaglantisi.sqlconnection());
            sqlCommand.Parameters.AddWithValue("@p1", lblTCHasta.Text);
            SqlDataReader dr = sqlCommand.ExecuteReader();
            while (dr.Read())
            {
                lblAdSoyadHastaDetay.Text = dr[0] + " " + dr[1];
            }
            sqlBaglantisi.sqlconnection().Close();

            //randevu çekme
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select *from Tbl_Randevular where hastaTc=" + tc, sqlBaglantisi.sqlconnection());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            // branşları çekme

            SqlCommand sqlCommand1 = new SqlCommand("select branşad from tbl_branşlar",sqlBaglantisi.sqlconnection());
            SqlDataReader dr2 = sqlCommand1.ExecuteReader();
            while (dr2.Read())
            {
                cmbBrans.Items.Add(dr2[0]);
            }
            sqlBaglantisi.sqlconnection().Close();
        }

        private void cmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDoktor.Items.Clear();

            SqlCommand sqlCommand = new SqlCommand("select ad, soyad from Tbl_Doktorlar where branş=@p1", sqlBaglantisi.sqlconnection());
            sqlCommand.Parameters.AddWithValue("@p1", cmbBrans.Text);
            SqlDataReader dr3 = sqlCommand.ExecuteReader();
            while (dr3.Read())
            {
                cmbDoktor.Items.Add(dr3[0] + " " + dr3[1]);
            }
            sqlBaglantisi.sqlconnection().Close();
        }

        private void cmbDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select*from Tbl_randevular where brans='" + cmbBrans.Text + "'"+" and doktor= '"+cmbDoktor.Text+"' and durum=0", sqlBaglantisi.sqlconnection());
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void lnkBilgiDüzenle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Bilgi_Güncelle bilgi_Güncelle = new Bilgi_Güncelle();
            bilgi_Güncelle.Show();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            txtId.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
        }

        private void btnRandevuAl_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("update tbl_randevular set durum=1,hastaTc=@p1,hastasikayet=@p2 where ıd=@p3", sqlBaglantisi.sqlconnection());
            sqlCommand.Parameters.AddWithValue("@p1", lblTCHasta.Text);
            sqlCommand.Parameters.AddWithValue("@p2", rchSikayet.Text);
            sqlCommand.Parameters.AddWithValue("@p3", txtId.Text);
            sqlCommand.ExecuteNonQuery();
            sqlBaglantisi.sqlconnection().Close();
            MessageBox.Show("Randevu oluşturuldu.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
    }
}
