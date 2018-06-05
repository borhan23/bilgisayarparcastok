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
    public partial class Siparisler : Form
    {
        OleDbConnection con = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data Source =StokVeri.mdb");
        DataSet dset = new DataSet();
        DataTable tablo = new DataTable();
        public Siparisler()
        {
            InitializeComponent();
        }
        private void Siparisler_Load(object sender, EventArgs e)
        {
            dset.Clear();
            OleDbDataAdapter ada = new OleDbDataAdapter("Select * From Siparisler", con);
            ada.Fill(dset, "Siparisler");
            dataGridViewsiparis.DataSource = dset.Tables["Siparisler"];
        }
        public void listele()
        {
            tablo.Clear();
            OleDbDataAdapter ada = new OleDbDataAdapter("Select * From Siparisler", con);
            ada.Fill(tablo);
            dataGridViewsiparis.DataSource = tablo;
        }
        private void btntemizle_Click(object sender, EventArgs e)
        {
            DialogResult cevap;
            cevap = MessageBox.Show("Sipariş kaydını silmek istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                con.Open();
                string sil = "Delete from Siparisler where Stok_No=@no";
                OleDbCommand command = new OleDbCommand(sil, con);
                command.Parameters.AddWithValue("@no", dataGridViewsiparis.CurrentRow.Cells[2].Value.ToString());
                command.ExecuteNonQuery();
                con.Close();
                listele();
            }
        }
        private void btngeri_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
