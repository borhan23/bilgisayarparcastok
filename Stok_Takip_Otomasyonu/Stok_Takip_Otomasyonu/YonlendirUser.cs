using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stok_Takip_Otomasyonu
{
    public partial class YonlendirUser : Form
    {
        public YonlendirUser()
        {
            InitializeComponent();
        }

        private void YonlendirUser_Load(object sender, EventArgs e)
        {
            labeluyarı.Text = "Giriş işlemi başarılı.\nYönlendiriliyorsunuz...";
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(+5);
            if (progressBar1.Value == 100)
            {
                KullaniciPaneli user = new KullaniciPaneli();
                user.Show();
                this.Close();
            }
        }
    }
}
