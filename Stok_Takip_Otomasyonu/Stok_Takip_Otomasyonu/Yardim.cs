using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Stok_Takip_Otomasyonu
{
    public partial class Yardim : Form
    {
        public Yardim()
        {
            InitializeComponent();
        }

        private void Yardim_Load(object sender, EventArgs e)
        {
            // Listbox'ı temizle
            listBoxKilavuz.Items.Clear();


            StreamReader oku;


            oku = File.OpenText("Yardim.txt");

            string yazi;


            while ((yazi = oku.ReadLine()) != null)
            {

                listBoxKilavuz.Items.Add(yazi.ToString());
            }


            oku.Close();
        }
    }
}
