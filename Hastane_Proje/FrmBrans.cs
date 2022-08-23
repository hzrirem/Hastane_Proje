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
    public partial class FrmBrans : Form
    {
        public FrmBrans()
        {
            InitializeComponent();
        }

        SqlBaglantisi sqlBaglantisi = new SqlBaglantisi();
        private void FrmBrans_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_branşlar", sqlBaglantisi.sqlconnection());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into tbl_branşlar (BranşAd) values (@b1)", sqlBaglantisi.sqlconnection());
            komut.Parameters.AddWithValue("@b1", txtbransadı.Text);
            komut.ExecuteNonQuery();
            sqlBaglantisi.sqlconnection().Close();
            MessageBox.Show("Branş Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtıd.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtbransadı.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from tbl_branşlar where ıd=@b1", sqlBaglantisi.sqlconnection());
            komut.Parameters.AddWithValue("@b1", txtıd.Text);
            komut.ExecuteNonQuery();
            sqlBaglantisi.sqlconnection().Close();
            MessageBox.Show("Branş Silindi.");

        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update tbl_branşlar set branşad=@p1 where ıd=@p2", sqlBaglantisi.sqlconnection());
            komut.Parameters.AddWithValue("@p1", txtbransadı.Text);
            komut.Parameters.AddWithValue("@p2", txtıd.Text);
            komut.ExecuteNonQuery();
            sqlBaglantisi.sqlconnection();
            MessageBox.Show("Branş Güncellendi");
        }
    }
}
