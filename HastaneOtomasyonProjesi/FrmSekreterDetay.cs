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
    public partial class FrmSekreterDetay : Form
    {
        public FrmSekreterDetay()
        {
            InitializeComponent();
        }

        public string TCnumara;
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void FrmSekreterDetay_Load(object sender, EventArgs e)
        {
            LblTC.Text = TCnumara;

            //Ad Soyad
            SqlCommand komut = new SqlCommand("Select SekreterAdSoyad from Tbl_Sekreter where SekreterTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TCnumara);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblAdSoyad.Text = dr[0].ToString();
            }
            bgl.baglanti().Close();

            //Branşları DataGride Aktarma
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select * from Tbl_Brans", bgl.baglanti());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;

            //Doktorları DataGride Aktarma
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select  DoktorId,DoktorAd,DoktorSoyad,DoktorBrans,DoktorTC from Tbl_Doktor",bgl.baglanti());
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;

            //Branşı ComboBox'a Aktarma
            SqlCommand komut2 = new SqlCommand("Select BransAd from Tbl_Brans", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                CmbBrans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();


        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            //Randevu Olusturma
            SqlCommand komutKaydet = new SqlCommand("insert into Tbl_Randevu (RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor) values(@v1,@v2,@v3,@v4)", bgl.baglanti());
            komutKaydet.Parameters.AddWithValue("@v1", MskTarih.Text);
            komutKaydet.Parameters.AddWithValue("@v2", MskSaat.Text);
            komutKaydet.Parameters.AddWithValue("@v3", CmbBrans.Text);
            komutKaydet.Parameters.AddWithValue("@v4", CmbDoktor.Text); 
            komutKaydet.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Successful");
        }

        private void CmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbDoktor.Items.Clear();
            SqlCommand komut3 = new SqlCommand("Select DoktorAd,DoktorSoyad from Tbl_Doktor where DoktorBrans=@db1", bgl.baglanti());
            komut3.Parameters.AddWithValue("@db1", CmbBrans.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                CmbDoktor.Items.Add(dr3[0]+" "+dr3[1]);
                bgl.baglanti().Close();
            }
            

        }

        private void BtnDuyuruOlustur_Click(object sender, EventArgs e)
        {
            SqlCommand komut4 = new SqlCommand("insert into Tbl_Duyuru (duyuru) values (@d1)", bgl.baglanti());
            komut4.Parameters.AddWithValue("@d1", RchDuyuru.Text);
            komut4.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Successful");
            RchDuyuru.Clear();
        }
        
        private void BtnDoktorPanel_Click(object sender, EventArgs e)
        {
            FrmDoktorPaneli drp = new FrmDoktorPaneli();
            drp.Show();

        }

        private void BtnBransPanel_Click(object sender, EventArgs e)
        {
            FrmBrans frb = new FrmBrans();
            frb.Show();
        }

        private void BtnListe_Click(object sender, EventArgs e)
        {
            FrmRandevuListesi frr = new FrmRandevuListesi();
            frr.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmDuyurular frd = new FrmDuyurular();
            frd.Show();
        }
    }
}












