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
    public partial class CalisanBilgi : Form
    {
        OleDbConnection con = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data Source =StokVeri.mdb");
        DataSet dset = new DataSet();
        OleDbDataAdapter ada = new OleDbDataAdapter();
        public CalisanBilgi()
        {
            InitializeComponent();
        }

        private void CalisanBilgi_Load(object sender, EventArgs e)
        {
            dset.Clear();
            con.Open();
            ada = new OleDbDataAdapter("Select *From Kullanicilar", con);
            ada.Fill(dset, "Kullanicilar");
            dataGridView1.DataSource = dset.Tables["Kullanicilar"];
            con.Close();
        }

        private void btngeri_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
