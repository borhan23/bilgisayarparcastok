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
    public partial class Yonetici : Form
    {
        public static string veritut2;
        OleDbConnection con = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data Source =StokVeri.mdb");
        public Yonetici()
        {
            InitializeComponent();
        }

        private void btngeri_Click(object sender, EventArgs e)
        {
            this.Close();
            Giris giris = new Giris();
            giris.Show();
        }

        private void btngiris_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand command = new OleDbCommand("SELECT * From Mudur WHERE KullanıcıAdı = '" + txtad.Text + "' AND Şifre = '" + txtsifre.Text + "'", con);
            OleDbDataReader oku = command.ExecuteReader();
            if (oku.Read())
            {
                YonlendirMudur yon = new YonlendirMudur();
                veritut2 = txtad.Text;
                yon.Show();
                this.Hide();
            }
            else if (txtad.Text == "")
            {
                MessageBox.Show("Kullanıcı adı boş bırakılamaz.");
            }
            else if (txtsifre.Text == "")
            {
                MessageBox.Show("Şifre kısmı boş bırakılamaz.");
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre geçersiz.");
            }
            con.Close();
        }
    }
}
