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
    public partial class KontrolPaneli : Form
    {
        OleDbConnection con = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data Source =StokVeri.mdb");
        DataSet dset = new DataSet();
        Siparisler siparis = new Siparisler();
        public KontrolPaneli()
        {
            InitializeComponent();
        }
        public void Renklendir()
        {
            for (int i = 0; i < dataGridViewstoklar.Rows.Count - 1; i++)
            {
                if (Convert.ToInt32(dataGridViewstoklar.Rows[i].Cells[3].Value) < 20)
                {
                    dataGridViewstoklar.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }
        static string tutkategori, tutmarka, tutno, tutsehir;
        private void btnsiparis_Click(object sender, EventArgs e)
        {
            if (txtsayi.Text != "")
            {
                string durum = "Sipariş alındı.";
                DateTime tarih = DateTime.Now; con.Open();
                OleDbCommand command = new OleDbCommand("insert into Siparisler (Kategori,Marka,Stok_No,Adet,Teslim_Yeri,Siparis_Tarihi,Siparis_Durumu) values (@kategori,@marka,@no,@adet,@sehir,@tarih,@durum)  ", con);
                command.Parameters.AddWithValue("@kategori", tutkategori);
                command.Parameters.AddWithValue("@marka", tutmarka);
                command.Parameters.AddWithValue("@no", tutno);
                command.Parameters.AddWithValue("@adet", txtsayi.Text);
                command.Parameters.AddWithValue("@sehir", tutsehir);
                command.Parameters.AddWithValue("@tarih", tarih.ToString());
                command.Parameters.AddWithValue("@durum", durum);
                command.ExecuteNonQuery();
                command.Dispose();
                con.Close();
                MessageBox.Show("Sipariş verildi.");
                txtsayi.Clear();
            } else
            {
                MessageBox.Show("Sipariş adedi boş bırakılamaz.");
            }
        }
        private void dataGridViewstoklar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Renklendir();
        }
        private void dataGridViewstoklar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tutkategori = dataGridViewstoklar.CurrentRow.Cells[0].Value.ToString();
            tutmarka = dataGridViewstoklar.CurrentRow.Cells[1].Value.ToString();
            tutno = dataGridViewstoklar.CurrentRow.Cells[2].Value.ToString();
            tutsehir = dataGridViewstoklar.CurrentRow.Cells[4].Value.ToString();
        }
        private void KontrolPaneli_Load(object sender, EventArgs e)
        {
            OleDbDataAdapter ada = new OleDbDataAdapter("Select *From Urunler", con);
            ada.Fill(dset, "Urunler");
            dataGridViewstoklar.DataSource = dset.Tables["Urunler"];
            Renklendir();
        }
        private void btngeri_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
