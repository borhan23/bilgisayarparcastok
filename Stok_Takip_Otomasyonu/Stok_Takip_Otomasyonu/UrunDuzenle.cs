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
    public partial class UrunDuzenle : Form
    {
        public UrunDuzenle()
        {
            InitializeComponent();
        }
        public UrunDuzenle(string kategori, string marka, string stokno, string stokadet, string sehir, string tarih)
        {
            k = kategori;
            m = marka;
            sno = stokno;
            sadet = stokadet;
            s = sehir;
            date = tarih;
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data Source =StokVeri.mdb");
        string k, m, sno, sadet, s, date;

        private void UrunDuzenle_FormClosed(object sender, FormClosedEventArgs e)
        {
            islemPaneli userpanel = (islemPaneli)Application.OpenForms["islemPaneli"];

            userpanel.Doldur();
        }

        private void UrunDuzenle_Load(object sender, EventArgs e)
        {
            cmbsehir2.Items.Add("ELAZIĞ");
            cmbsehir2.Items.Add("MALATYA");
            cmbsehir2.Items.Add("ERZURUM");
            cmbsehir2.Items.Add("KAYSERİ");
            cmbsehir2.Items.Add("ANKARA");
            cmbsehir2.Items.Add("İSTANBUL");
            txtkategori2.Text = k;
            txtmarka2.Text = m;
            txtno2.Text = sno;
            txtadet2.Text = sadet;
            cmbsehir2.Text = s;
            dateTimePicker1.Text = date;
        }

        private void btnkayit_Click(object sender, EventArgs e)
        {
            DialogResult cevap;
            cevap = MessageBox.Show("Kaydı güncellemek istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                string duzenle = "Update Urunler set Kategori=@kategori,Marka=@marka,Stok_Adedi=@adet,Sehir=@sehir,Stok_Tarihi=@tarih where Stok_No='" + txtno2.Text + "' ";
                con.Open();
                OleDbCommand command = new OleDbCommand(duzenle, con);
                command.Parameters.AddWithValue("@kategori", txtkategori2.Text);
                command.Parameters.AddWithValue("@marka", txtmarka2.Text);
                command.Parameters.AddWithValue("@adet", txtadet2.Text);
                command.Parameters.AddWithValue("@sehir", cmbsehir2.Text);
                command.Parameters.AddWithValue("@tarih", dateTimePicker1.Text);
                command.ExecuteNonQuery();
                MessageBox.Show("Güncelleme işlemi başarılı");
                con.Close();
                this.Close();

            }
        }
    }
}
