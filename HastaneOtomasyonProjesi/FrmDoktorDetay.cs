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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string TC;
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void BtnCıkıs_Click(object sender, EventArgs e)
        {
            FrmGirisler frg = new FrmGirisler();
            frg.Show();
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Tc Tasıma
            LblTC.Text = TC;

            //Ad tasıma
            SqlCommand komut = new SqlCommand("Select DoktorAd,DoktorSoyad From Tbl_Doktor where DoktorTC=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TC);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblAdSoyad.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();

            //DataShow
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Randevu where RandevuDoktor='" + LblAdSoyad.Text + "'", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource= dt;
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            FrmDoktorBilgiDuzenle drb = new FrmDoktorBilgiDuzenle();
            drb.TC = LblTC.Text;
            drb.Show();
        }

        private void BtnDuyurular_Click(object sender, EventArgs e)
        {
            FrmDuyurular frd = new FrmDuyurular();
            frd.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            RchSikayet.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
        }
    }
}
