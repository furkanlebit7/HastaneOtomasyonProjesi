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
    public partial class FrmDoktorPaneli : Form
    {
        public FrmDoktorPaneli()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        private void FrmDoktorPaneli_Load(object sender, EventArgs e)
        {

            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select  DoktorId,DoktorAd,DoktorSoyad,DoktorBrans,DoktorTC,DoktorSifre from Tbl_Doktor", bgl.baglanti());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;

            //Branşı ComboBox'a Aktarma
            SqlCommand komut2 = new SqlCommand("Select BransAd from Tbl_Brans", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                CmbBrans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komutEkle = new SqlCommand("insert into Tbl_Doktor (DoktorAd,DoktorSoyad,DoktorBrans,DoktorTC,DoktorSifre) values (@dr1,@dr2,@dr3,@dr4,@dr5)", bgl.baglanti());
            komutEkle.Parameters.AddWithValue("@dr1", TxtAd.Text);
            komutEkle.Parameters.AddWithValue("@dr2", TxtSoyad.Text);
            komutEkle.Parameters.AddWithValue("@dr3", CmbBrans.Text);
            komutEkle.Parameters.AddWithValue("@dr4", MskTC.Text);
            komutEkle.Parameters.AddWithValue("@dr5", TxtSifre.Text);
            komutEkle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Successful");

            TxtAd.Clear();
            TxtSoyad.Clear();
            CmbBrans.Items.Clear();
            MskTC.Clear();
            TxtSifre.Clear();




        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            CmbBrans.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            MskTC.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            TxtSifre.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komutSil = new SqlCommand("Delete from Tbl_Doktor where DoktorTc=@p1", bgl.baglanti());
            komutSil.Parameters.AddWithValue("@p1", MskTC.Text);
            komutSil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Deleted");
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komutGuncelle = new SqlCommand("update Tbl_Doktor set DoktorAd=@p1,DoktorSoyad=@p2,DoktorBrans=@p3,DoktorSifre=@p5 where DoktorTc=@p4", bgl.baglanti());
            komutGuncelle.Parameters.AddWithValue("@p1", TxtAd.Text);
            komutGuncelle.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            komutGuncelle.Parameters.AddWithValue("@p3", CmbBrans.Text);
            komutGuncelle.Parameters.AddWithValue("@p4", MskTC.Text);
            komutGuncelle.Parameters.AddWithValue("@p5", TxtSifre.Text);
            komutGuncelle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Updated");

        }

        
    }
}
