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

namespace HastaneOtomasyonProjesi
{
    public partial class FrmBrans : Form
    {
        public FrmBrans()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        private void FrmBrans_Load(object sender, EventArgs e)
        {
            //DataTable da dataları gösterme
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Brans", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            //Yeni brans Ekleme
            SqlCommand komutEkle = new SqlCommand("insert into Tbl_Brans (BransAd) values (@b1)", bgl.baglanti());
            komutEkle.Parameters.AddWithValue("@b1", TxtBrans.Text);
            komutEkle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Successful");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //data yı TextBox a aktarma
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            TxtBrans.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            //Brans Silme işlemi
            SqlCommand komutSil = new SqlCommand("Delete from Tbl_Brans where BransId=@p1", bgl.baglanti());
            komutSil.Parameters.AddWithValue("@p1", TxtId.Text);
            komutSil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Deleted");
            TxtBrans.Clear();
            TxtId.Clear();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            //brans Guncelleme
            SqlCommand komutGuncelle = new SqlCommand("update Tbl_Brans set (bransAd=@p1) where (BransId=@p2)", bgl.baglanti());
            komutGuncelle.Parameters.AddWithValue("@p1", TxtBrans.Text);
            komutGuncelle.Parameters.AddWithValue("@p2", TxtId.Text);
            komutGuncelle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Updated");
        }
    }
}
