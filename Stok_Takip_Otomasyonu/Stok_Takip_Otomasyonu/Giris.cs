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
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        private void btncikis_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void btnadmin_Click(object sender, EventArgs e)
        {
            Yonetici admin = new Yonetici();
            admin.Show();
            this.Hide();
        }

        private void btnuser_Click(object sender, EventArgs e)
        {
            Kullanici user = new Kullanici();
            user.Show();
            this.Hide();
        }
        private Point mouseOffset;
        private bool isMouseDown = false;
       
        private void Giriş_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void Giris_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)

            {
                isMouseDown = false;                                      //--------------------
            }
        }

        private void Giris_MouseDown(object sender, MouseEventArgs e)
        {
            int xOffset;
            int yOffset;
            if (e.Button == MouseButtons.Left)
            {
                xOffset = -e.X - SystemInformation.FrameBorderSize.Width / 600;
                yOffset = -e.Y - SystemInformation.CaptionHeight / 600 - SystemInformation.FrameBorderSize.Height / 600;  // Bu kısımlar monitörün konumunu değiştirebilmek için yazıldı
                mouseOffset = new Point(xOffset, yOffset);
                isMouseDown = true;
            }
        }

        private void Giris_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseOffset.X, mouseOffset.Y);
                Location = mousePos;                                        //------------------
            }
        }
    }
}
