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
    public partial class KullaniciBildirim : Form
    {
        OleDbConnection con = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data Source =StokVeri.mdb");
        OleDbCommand command = new OleDbCommand();
        DataSet dset = new DataSet();
        DataTable tablo = new DataTable();
        public KullaniciBildirim()
        {
            InitializeComponent();
        }
        public void listele()
        {
            tablo.Clear();
            OleDbDataAdapter ada = new OleDbDataAdapter("Select * From KullaniciMesaj", con);
            ada.Fill(tablo);
            dataGridViewmesaj.DataSource = tablo;

        }
        private void btntemiz_Click(object sender, EventArgs e)
        {
            DialogResult cevap;
            cevap = MessageBox.Show("Mesajı silmek istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                con.Open();
                string sil = "Delete from KullaniciMesaj where Mesaj=@mesaj";
                OleDbCommand command = new OleDbCommand(sil, con);
                command.Parameters.AddWithValue("@mesaj", dataGridViewmesaj.CurrentRow.Cells[0].Value.ToString());
                command.ExecuteNonQuery();
                listele();
                con.Close();
            }
        }

        private void KullaniciBildirim_Load(object sender, EventArgs e)
        {
           
            con.Open();
            OleDbDataAdapter ada = new OleDbDataAdapter("select * from KullaniciMesaj", con);
            ada.Fill(dset, "KullaniciMesaj");
            dataGridViewmesaj.DataSource = dset.Tables["KullaniciMesaj"];
            con.Close();
        }

        private void btngeri_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
