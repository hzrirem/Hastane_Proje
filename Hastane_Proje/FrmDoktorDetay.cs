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
    public partial class FrmDoktorDetay : Form
    {
        public FrmDoktorDetay()
        {
            InitializeComponent();
        }
        SqlBaglantisi SqlBaglantisi = new SqlBaglantisi();
        public string Tc;

        private void FrmDoktorDetay_Load(object sender, EventArgs e)
        {
            lblTC.Text = Tc;

            //Ad Soyad çekme
            SqlCommand sqlCommand = new SqlCommand("select ad,soyad from tbl_doktorlar where tc=@p1", SqlBaglantisi.sqlconnection());
            sqlCommand.Parameters.AddWithValue("@p1", lblTC.Text);
            SqlDataReader dr = sqlCommand.ExecuteReader();
            while (dr.Read())
            {
                lblAdSoyad.Text = dr[0] + " " + dr[1];
            }
            SqlBaglantisi.sqlconnection().Close();

            //Doktora ait Randevuları çekme
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_randevular where doktor='" + lblAdSoyad.Text + "'", SqlBaglantisi.sqlconnection());
            da.Fill(dt);
            dataGridView1.DataSource = dt;



        }

        private void btnBilgiDüzenle_Click(object sender, EventArgs e)
        {
            FrmDoktorBilgiDüzenle frmDoktorBilgiDüzenle = new FrmDoktorBilgiDüzenle();
            frmDoktorBilgiDüzenle.TcNo = lblTC.Text;
            frmDoktorBilgiDüzenle.Show();
        }

        private void btnDuyular_Click(object sender, EventArgs e)
        {
            FrmDuyurular frmDuyurular = new FrmDuyurular();
            frmDuyurular.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            richTextBox1.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
        }
    }
}
