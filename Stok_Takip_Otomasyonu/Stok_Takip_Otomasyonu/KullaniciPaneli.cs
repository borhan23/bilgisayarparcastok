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
    public partial class KullaniciPaneli : Form
    {
        public static string tutad;
        public static string tutsoyad;
        OleDbConnection con = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data Source =StokVeri.mdb");
        public KullaniciPaneli()
        {
            InitializeComponent();
        }

        private void btngeri_Click(object sender, EventArgs e)
        {
            this.Close();
            Giris giris = new Giris();
            giris.Show();
        }

        private void btnprofil_Click(object sender, EventArgs e)
        {
            KullaniciBilgi id = new KullaniciBilgi();
            con.Open();
            OleDbCommand command = new OleDbCommand("Select * From Kullanicilar where KullanıcıAdı='" + Kullanici.veritut + "'", con);
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
            con.Close();
            id.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            labeltarih1.Text = dt.ToLongDateString();
            labelsaat1.Text = dt.ToLongTimeString();
        }

        private void KullaniciPaneli_Load(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand command = new OleDbCommand("Select * From Kullanicilar where KullanıcıAdı='" + Kullanici.veritut + "'", con);
            command.ExecuteNonQuery();
            OleDbDataReader oku = command.ExecuteReader();
            if (oku.Read())
            {
                labelad.Text = oku["Ad"].ToString();
                labelsoyad.Text = oku["Soyad"].ToString();
                tutad = labelad.Text;
                tutsoyad = labelsoyad.Text;
            }
            con.Close();
        }

        private void btnislem_Click(object sender, EventArgs e)
        {
            islemPaneli islem = new islemPaneli();
            islem.ShowDialog(); ;
        }

        private void btnbildirim_Click(object sender, EventArgs e)
        {
            KullaniciBildirim bildir = new KullaniciBildirim();
            bildir.Show();
        }
    }
}
