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
    public partial class YoneticiBilgi : Form
    {
        OleDbConnection con = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data Source =StokVeri.mdb");

        public YoneticiBilgi()
        {
            InitializeComponent();
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
            YoneticiPaneli YONET = new YoneticiPaneli();
            YONET.Show();
        }

        private void btnkayit_Click(object sender, EventArgs e)
        {
            DialogResult cevap;
            cevap = MessageBox.Show("Kaydı güncellemek istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                KullaniciPaneli user = new KullaniciPaneli();
                string edit = "UPDATE Mudur SET Şifre=@Şifre,Telefon=@Telefon,Eposta=@posta WHERE Kimlik=1";
                con.Open();
                OleDbCommand command = new OleDbCommand(edit, con);
                command.Parameters.AddWithValue("@Şifre", idsifre.Text);
                command.Parameters.AddWithValue("@Telefon", idtel.Text);
                command.Parameters.AddWithValue("@posta", idposta.Text);
                command.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Güncelleme işlemi başarılı");
                btnkayit.Visible = false;
                idkullaniciadi.Enabled = false;
                idsifre.Enabled = false;
                idtel.Enabled = false;
                idposta.Enabled = false;
            }
        }
        
    }
}
