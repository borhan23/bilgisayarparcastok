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
    public partial class islemPaneli : Form
    {
        OleDbConnection con = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data Source =StokVeri.mdb");
        OleDbCommand command = new OleDbCommand();
        DataSet dset = new DataSet();
        DataTable tablo = new DataTable();
        KullaniciPaneli userpanel = new KullaniciPaneli();
        static string k, m, sno, sadet, sehir, date;
        public void listele()
        {
            tablo.Clear();
            OleDbDataAdapter ada = new OleDbDataAdapter("Select * From Urunler", con);
            ada.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }

        private void btngeri_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            if (txtkategori.Text != "" && txtmarka.Text != "" && txtno.Text != "" && txtadet.Text != "")
            {
                con.Open();
                string sorgu = "Select * From Urunler Where Stok_No='" + txtno.Text + "'";
                command = new OleDbCommand(sorgu, con);
                OleDbDataReader oku = command.ExecuteReader();
                if (oku.Read())
                {
                    MessageBox.Show("Bu Stok Numarasına ait bir kayıt bulunmaktadır.");
                }
                else
                {
                    con.Close(); con.Open();
                    string ekle = "insert into Urunler(Kategori,Marka,Stok_No,Stok_Adedi,Sehir,Stok_Tarihi,Kayıt_Yapan) values (@kategori,@marka,@no,@adet,@sehir,@tarih,@kisi) ";
                    command = new OleDbCommand(ekle, con);
                    command.Parameters.AddWithValue("@kategori", txtkategori.Text);
                    command.Parameters.AddWithValue("@marka", txtmarka.Text);
                    command.Parameters.AddWithValue("@no", txtno.Text);
                    command.Parameters.AddWithValue("@adet", txtadet.Text);
                    command.Parameters.AddWithValue("@sehir", cmbsehir.Text);
                    command.Parameters.AddWithValue("@tarih", dateTimePicker1.Value.ToString());
                    command.Parameters.AddWithValue("@kisi", KullaniciPaneli.tutad + " " + KullaniciPaneli.tutsoyad);
                    char[] dizino = txtno.Text.ToCharArray();
                    char[] dizimarka = txtmarka.Text.ToCharArray();
                    char[] dizisehir = cmbsehir.Text.ToCharArray();
                    if (dizino[0] == dizimarka[0] && dizino[1] == dizisehir[0] && dizino[2] == dizisehir[1])
                    {
                        command.ExecuteNonQuery();
                        command.Dispose();
                        con.Close();
                        MessageBox.Show("Kayıt işlemi başarılı.");
                        dset.Clear();
                        Doldur();
                        txtkategori.Clear();
                        txtmarka.Clear();
                        txtno.Clear();
                        txtadet.Clear();
                        cmbsehir.Text = "";
                        aratemizle();
                        con.Close();
                    }
                    else if (dizino[0] != dizimarka[0] | dizino[1] != dizisehir[0] | dizino[2] != dizisehir[1])
                    {
                        MessageBox.Show("Girmiş olduğunuz stok numarası hatalı.");
                    }
                }
                sort();
            }
            else if (txtkategori.Text == "" && txtmarka.Text == "" && txtno.Text == "" && txtadet.Text == "")
            {
                MessageBox.Show("Lütfen boş alan bırakmayınız");
            }
            con.Close();
        }

        public string uyarıno;
        public string uyarımarka;
        public string uyarıkategori;
        string tutmarka;
        string tutno;
        string tutadet;
        string tutsehir;
        string tutzaman;
        private void btnsil_Click(object sender, EventArgs e)
        {
            DialogResult cevap;
            cevap = MessageBox.Show("Kaydı silmek istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                uyarıno = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                uyarımarka = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                uyarıkategori = dataGridView1.CurrentRow.Cells[0].Value.ToString();

                DateTime tarih = DateTime.Now;
                con.Open();
                string sil = "Delete from Urunler where Stok_No=@no";
                OleDbCommand command = new OleDbCommand(sil, con);
                command.Parameters.AddWithValue("@no", dataGridView1.CurrentRow.Cells[2].Value.ToString());
                command.ExecuteNonQuery();
                MessageBox.Show("Silme işlemi başarılı.");
                listele();
                aratemizle();
                string tutbildirim = uyarıkategori + " kategorisinde" + uyarıno + " Nolu " + uyarımarka + " marka stok kaydı " + KullaniciPaneli.tutad + "" + KullaniciPaneli.tutsoyad + " tarafından silinmiştir.";
                OleDbCommand command2 = new OleDbCommand("insert into KullaniciBildirim(Bildirim,Tarih) Values (@bildirim,@tarih) ", con);
                command2.Parameters.AddWithValue("@bildirim", tutbildirim);
                command2.Parameters.AddWithValue("@tarih", tarih.ToString());
                command2.ExecuteNonQuery();
                command2.Dispose();
                con.Close();
            }
        }
        public void Doldur()
        {
            dset.Clear();
            con.Open();
            OleDbDataAdapter ada = new OleDbDataAdapter("Select *From Urunler", con);
            ada.Fill(dset, "Urunler");
            dataGridView1.DataSource = dset.Tables["Urunler"];
            con.Close();
        }
        public void aratemizle()
        {
            arakategori.Clear();
            aramarka.Clear();
            arano.Clear();
            araadet.Clear();
        }
        public void sort()
        {
            dataGridView1.Sort(dataGridView1.Columns[3], ListSortDirection.Ascending);
        }

        private void arakategori_TextChanged(object sender, EventArgs e)
        {
            dset.Clear();
            if (arakategori.Text == String.Empty & tutmarka == String.Empty & tutno == String.Empty & tutadet == String.Empty & tutsehir == String.Empty & tutzaman == String.Empty)
            {

                OleDbDataAdapter ada = new OleDbDataAdapter("Select *From Urunler", con);
                ada.Fill(dset, "Urunler");
                dataGridView1.DataSource = dset.Tables["Urunler"];
                tutkategori = arakategori.Text;

            }
            else
            {
                OleDbDataAdapter ada = new OleDbDataAdapter("Select *From Urunler where Kategori like'" + arakategori.Text + "%' and Marka like '" + tutmarka + "%'and Stok_No like '" + tutno + "%'and Stok_Adedi like '" + tutadet + "%'and Sehir like '" + tutsehir + "%'and Stok_Tarihi like '" + tutzaman + "%'", con);
                ada.Fill(dset, "Urunler");
                dataGridView1.DataSource = dset.Tables["Urunler"];
                tutkategori = arakategori.Text;

            }
        }

        private void aramarka_TextChanged(object sender, EventArgs e)
        {
            dset.Clear();
            if (tutkategori == String.Empty & aramarka.Text == String.Empty & tutno == String.Empty & tutadet == String.Empty & tutsehir == String.Empty & tutzaman == String.Empty)
            {
                OleDbDataAdapter ada = new OleDbDataAdapter("Select *From Urunler", con);
                ada.Fill(dset, "Urunler");
                dataGridView1.DataSource = dset.Tables["Urunler"];
            }
            else
            {
                OleDbDataAdapter ada = new OleDbDataAdapter("Select *From Urunler where Kategori like'" + tutkategori + "%' and Marka like '" + aramarka.Text + "%'and Stok_No like '" + tutno + "%'and Stok_Adedi like '" + tutadet + "%'and Sehir like '" + tutsehir + "%'and Stok_Tarihi like '" + tutzaman + "%'", con);
                ada.Fill(dset, "Urunler");
                dataGridView1.DataSource = dset.Tables["Urunler"];
                tutmarka = aramarka.Text;

            }
        }

        private void arano_TextChanged(object sender, EventArgs e)
        {
            dset.Clear();
            if (tutkategori == String.Empty & tutmarka == String.Empty & arano.Text == String.Empty & tutadet == String.Empty & tutsehir == String.Empty & tutzaman == String.Empty)
            {

                OleDbDataAdapter ada = new OleDbDataAdapter("Select *From Urunler", con);
                ada.Fill(dset, "Urunler");
                dataGridView1.DataSource = dset.Tables["Urunler"];
            }
            else
            {
                OleDbDataAdapter ada = new OleDbDataAdapter("Select *From Urunler where Kategori like'" + tutkategori + "%' and Marka like '" + tutmarka + "%'and Stok_No like '" + arano.Text + "%'and Stok_Adedi like '" + tutadet + "%'and Sehir like '" + tutsehir + "%'and Stok_Tarihi like '" + tutzaman + "%'", con);
                ada.Fill(dset, "Urunler");
                dataGridView1.DataSource = dset.Tables["Urunler"];
                tutno = arano.Text;
            }
        }

        private void araadet_TextChanged(object sender, EventArgs e)
        {
            dset.Clear();
            if (tutkategori == String.Empty & tutmarka == String.Empty & tutno == String.Empty & araadet.Text == String.Empty & tutsehir == String.Empty & tutzaman == String.Empty)
            {

                OleDbDataAdapter ada = new OleDbDataAdapter("Select *From Urunler", con);
                ada.Fill(dset, "Urunler");
                dataGridView1.DataSource = dset.Tables["Urunler"];
            }
            else
            {
                OleDbDataAdapter ada = new OleDbDataAdapter("Select *From Urunler where Kategori like'" + tutkategori + "%' and Marka like '" + tutmarka + "%'and Stok_No like '" + tutno + "%'and Stok_Adedi like '" + araadet.Text + "%'and Sehir like '" + tutsehir + "%'and Stok_Tarihi like '" + tutzaman + "%'", con);
                ada.Fill(dset, "Urunler");
                dataGridView1.DataSource = dset.Tables["Urunler"];
                tutadet = araadet.Text;
            }
        }

        private void arasehir_TextChanged(object sender, EventArgs e)
        {
            dset.Clear();
            if (tutkategori == String.Empty & tutmarka == String.Empty & tutno == String.Empty & tutadet == String.Empty & arasehir.Text == String.Empty & tutzaman == String.Empty)
            {

                OleDbDataAdapter ada = new OleDbDataAdapter("Select *From Urunler", con);
                ada.Fill(dset, "Urunler");
                dataGridView1.DataSource = dset.Tables["Urunler"];
            }
            else
            {
                OleDbDataAdapter ada = new OleDbDataAdapter("Select *From Urunler where Kategori like'" + tutkategori + "%' and Marka like '" + tutmarka + "%'and Stok_No like '" + tutno + "%'and Stok_Adedi like '" + tutadet + "%'and Sehir like '" + arasehir.Text + "%' and Stok_Tarihi like '" + tutzaman + "%'", con);
                ada.Fill(dset, "Urunler");
                dataGridView1.DataSource = dset.Tables["Urunler"];
                tutsehir = arasehir.Text;
            }
        }

        private void aratarih_TextChanged(object sender, EventArgs e)
        {
            dset.Clear();
            if (tutkategori == String.Empty & tutmarka == String.Empty & tutno == String.Empty & tutadet == String.Empty & tutsehir == String.Empty & aratarih.Text == String.Empty)
            {

                OleDbDataAdapter ada = new OleDbDataAdapter("Select *From Urunler", con);
                ada.Fill(dset, "Urunler");
                dataGridView1.DataSource = dset.Tables["Urunler"];
            }
            else
            {
                OleDbDataAdapter ada = new OleDbDataAdapter("Select *From Urunler where Kategori like'" + tutkategori + "%' and Marka like '" + tutmarka + "%'and Stok_No like '" + tutno + "%'and Stok_Adedi like '" + tutadet + "%'and Sehir like '" + tutsehir + "%'and Stok_Tarihi like '" + aratarih.Text + "%'", con);
                ada.Fill(dset, "Urunler");
                dataGridView1.DataSource = dset.Tables["Urunler"];
                tutzaman = aratarih.Text;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            k = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            m = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            sno = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            sadet = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            sehir = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            date = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Yardim help = new Yardim();
            help.Show();
        }

        private void txtkategori_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == false && e.KeyChar != (char)08 && e.KeyChar != (char)44)
            {
                e.Handled = true;
                MessageBox.Show("Sadece Harf Girişi Yapabilirsiniz ! ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtadet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != (char)08 && e.KeyChar != (char)44)
            {
                e.Handled = true;
                MessageBox.Show("Sadece Sayı Girişi Yapabilirsiniz ! ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public islemPaneli()
        {
            tablo.Clear();
            InitializeComponent();
        }

        private void islemPaneli_Load(object sender, EventArgs e)
        {

            tablo.Clear();
            Doldur();
            aratemizle();
            cmbsehir.Items.Add("ELAZIĞ");
            cmbsehir.Items.Add("MALATYA");
            cmbsehir.Items.Add("ERZURUM");
            cmbsehir.Items.Add("KAYSERİ");
            cmbsehir.Items.Add("ANKARA");
            cmbsehir.Items.Add("İSTANBUL");
            sort();
        }
        string tutkategori;

        private void btnduzenle_Click(object sender, EventArgs e)
        {
            uyarıno = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            uyarımarka = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            uyarıkategori = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            duzenle();
            sort();
            DateTime tarih = DateTime.Now;
            con.Open();
            string tutbildirim = uyarıkategori + " kategorisinde" + uyarıno + " Nolu " + uyarımarka + " marka stok kaydı " + KullaniciPaneli.tutad + "" + KullaniciPaneli.tutsoyad + " tarafından düzenlenmiştir.";
            OleDbCommand command2 = new OleDbCommand("insert into KullaniciBildirim(Bildirim,Tarih) Values (@bildirim,@tarih) ", con);
            command2.Parameters.AddWithValue("@bildirim", tutbildirim);
            command2.Parameters.AddWithValue("@tarih", tarih.ToString());
            command2.ExecuteNonQuery();
            command2.Dispose();
            con.Close();
            aratemizle();
        }

        
        public static void duzenle()
        {
            UrunDuzenle edit = new UrunDuzenle(k, m, sno, sadet, sehir, date);
            edit.ShowDialog();
        }
    }
}
