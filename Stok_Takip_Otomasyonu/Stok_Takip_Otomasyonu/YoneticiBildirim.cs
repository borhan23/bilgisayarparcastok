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
    public partial class YoneticiBildirim : Form
    {
        OleDbConnection con = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data Source =StokVeri.mdb");
        OleDbCommand command = new OleDbCommand();
        DataSet dset = new DataSet();
        DataTable tablo = new DataTable();
        public YoneticiBildirim()
        {
            InitializeComponent();
        }
        public void listele()
        {
            tablo.Clear();
            OleDbDataAdapter ada = new OleDbDataAdapter("Select * From KullaniciBildirim", con);
            ada.Fill(tablo);
            dataGridViewbildirim.DataSource = tablo;
        }
        DateTime tarih = DateTime.Now;
        private void YoneticiBildirim_Load(object sender, EventArgs e)
        {
            con.Open();
            OleDbDataAdapter ada = new OleDbDataAdapter("select * from KullaniciBildirim", con);
            ada.Fill(dset, "KullaniciBildirim");
            dataGridViewbildirim.DataSource = dset.Tables["KullaniciBildirim"];
            con.Close();
        }
        private void btngeri_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnmesaj_Click(object sender, EventArgs e)
        {
            con.Open();
            command = new OleDbCommand("insert into KullaniciMesaj(Mesaj,Tarih) Values (@mesaj,@tarih) ", con);
            command.Parameters.AddWithValue("@mesaj", txtmesaj.Text);
            command.Parameters.AddWithValue("@tarih", tarih.ToString());
            command.ExecuteNonQuery();
            command.Dispose();
            con.Close();
            MessageBox.Show("Mesaj gönderildi");
            txtmesaj.Clear();
        }
        private void btntemiz_Click(object sender, EventArgs e)
        {
            DialogResult cevap;
            cevap = MessageBox.Show("Bildirimi silmek istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                con.Open();
                string sil = "Delete from KullaniciBildirim where Bildirim=@bildirim";
                OleDbCommand command = new OleDbCommand(sil, con);
                command.Parameters.AddWithValue("@bildirim", dataGridViewbildirim.CurrentRow.Cells[0].Value.ToString());
                command.ExecuteNonQuery();
                listele();
                con.Close();
            }
        }
    }
}
