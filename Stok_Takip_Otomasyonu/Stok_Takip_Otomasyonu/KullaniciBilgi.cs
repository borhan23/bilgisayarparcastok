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
    public partial class KullaniciBilgi : Form
    {
        OleDbConnection con = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data Source =StokVeri.mdb");
        public KullaniciBilgi()
        {
            InitializeComponent();
        }

        private void KullaniciBilgi_Load(object sender, EventArgs e)
        {
            idsifre.PasswordChar = (char)42;
        }

        private void btnduz_Click(object sender, EventArgs e)
        {
            btnkayit.Visible = true;
            idsifre.Enabled = true;
            idtel.Enabled = true;
            idposta.Enabled = true;
        }

        private void btngeri_Click(object sender, EventArgs e)
        {

            this.Close();
            KullaniciPaneli user = new KullaniciPaneli();
            user.Show();
        }

        private void btnkayit_Click(object sender, EventArgs e)
        {
            DialogResult cevap;
            cevap = MessageBox.Show("Kaydı güncellemek istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                KullaniciPaneli user = new KullaniciPaneli();                
                string edit = "UPDATE Kullanicilar SET Şifre=@Şifre,Telefon=@Telefon,Eposta=@posta WHERE KullanıcıAdı='" + Kullanici.veritut + "'";
                con.Open();
                OleDbCommand command = new OleDbCommand(edit, con);
                command.Parameters.AddWithValue("@Şifre", idsifre.Text);
                command.Parameters.AddWithValue("@Telefon", idtel.Text);
                command.Parameters.AddWithValue("@posta", idposta.Text);
                command.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Güncelleme işlemi başarılı");
                btnkayit.Visible = false;
                idsifre.Enabled = false;
                idtel.Enabled = false;
                idposta.Enabled = false;

            }
        }
    }
}
