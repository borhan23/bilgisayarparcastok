using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Stok_Takip_Otomasyonu
{
    public partial class YoneticiPaneli : Form
    {
        OleDbConnection con = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data Source =StokVeri.mdb");
        Siparisler siparis = new Siparisler();
        public YoneticiPaneli()
        {
            InitializeComponent();
        }

        private void btnquit_Click(object sender, EventArgs e)
        {
            this.Close();
            Giris giris = new Giris(); giris.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            labeltarih1.Text = dt.ToLongDateString();
            labelsaat1.Text = dt.ToLongTimeString();
        }

        private void btnislem_Click(object sender, EventArgs e)
        {
            islemPaneli islem = new islemPaneli();
            islem.ShowDialog();
        }

        private void btnprofil_Click(object sender, EventArgs e)
        {
            YoneticiBilgi id = new YoneticiBilgi();
            con.Open();
            OleDbCommand command = new OleDbCommand("Select * From Mudur where KullanıcıAdı='" + Yonetici.veritut2 + "'", con);
            command.ExecuteNonQuery();
            OleDbDataReader oku = command.ExecuteReader();
            if (oku.Read())
            {
                id.idad.Text = oku["Ad"].ToString();
                id.idsoyad.Text = oku["Soyad"].ToString();
                id.idkullaniciadi.Text = oku["KullanıcıAdı"].ToString();
                id.idsifre.Text = oku["Şifre"].ToString();
                id.idtel.Text = oku["Telefon"].ToString();
                id.idposta.Text = oku["Eposta"].ToString();
            }
            con.Close(); id.Show(); this.Hide();
        }

        private void btnkontrol_Click(object sender, EventArgs e)
        {
            KontrolPaneli skontrol = new KontrolPaneli();
            skontrol.ShowDialog();
        }

        private void YoneticiPaneli_Load(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand command = new OleDbCommand("Select * From Mudur where KullanıcıAdı='" + Yonetici.veritut2 + "'", con);
            command.ExecuteNonQuery();
            OleDbDataReader oku = command.ExecuteReader();
            if (oku.Read())
            {
                labelad.Text = oku["Ad"].ToString();
                labelsoyad.Text = oku["Soyad"].ToString();
            }
            con.Close();
        }

        private void btnisci_Click(object sender, EventArgs e)
        {
            CalisanBilgi kadro = new CalisanBilgi();
            kadro.Show();
        }

        private void btnbildirim_Click(object sender, EventArgs e)
        {
            YoneticiBildirim bildirim = new YoneticiBildirim();
            bildirim.ShowDialog();
        }

        private void btnsiparis_Click_1(object sender, EventArgs e)
        {
            Siparisler siparis = new Siparisler();
            siparis.Show();
        }
    }
}
