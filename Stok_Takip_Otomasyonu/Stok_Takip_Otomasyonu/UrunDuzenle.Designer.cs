namespace Stok_Takip_Otomasyonu
{
    partial class UrunDuzenle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnkayit = new System.Windows.Forms.Button();
            this.cmbsehir2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtadet2 = new System.Windows.Forms.TextBox();
            this.txtno2 = new System.Windows.Forms.TextBox();
            this.txtmarka2 = new System.Windows.Forms.TextBox();
            this.txtkategori2 = new System.Windows.Forms.TextBox();
            this.tarih = new System.Windows.Forms.Label();
            this.stokadedi = new System.Windows.Forms.Label();
            this.stokno = new System.Windows.Forms.Label();
            this.marka = new System.Windows.Forms.Label();
            this.kategori = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnkayit
            // 
            this.btnkayit.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnkayit.BackgroundImage = global::Stok_Takip_Otomasyonu.Properties.Resources.Save_icon;
            this.btnkayit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnkayit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnkayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkayit.Location = new System.Drawing.Point(211, 226);
            this.btnkayit.Name = "btnkayit";
            this.btnkayit.Size = new System.Drawing.Size(41, 38);
            this.btnkayit.TabIndex = 88;
            this.btnkayit.UseVisualStyleBackColor = false;
            this.btnkayit.Click += new System.EventHandler(this.btnkayit_Click);
            // 
            // cmbsehir2
            // 
            this.cmbsehir2.BackColor = System.Drawing.Color.LightCyan;
            this.cmbsehir2.Enabled = false;
            this.cmbsehir2.FormattingEnabled = true;
            this.cmbsehir2.Location = new System.Drawing.Point(122, 192);
            this.cmbsehir2.Name = "cmbsehir2";
            this.cmbsehir2.Size = new System.Drawing.Size(114, 21);
            this.cmbsehir2.TabIndex = 87;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(29, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 86;
            this.label1.Text = "Şehir";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.LightCyan;
            this.dateTimePicker1.CustomFormat = "dd.MM.yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(122, 156);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(114, 20);
            this.dateTimePicker1.TabIndex = 85;
            // 
            // txtadet2
            // 
            this.txtadet2.BackColor = System.Drawing.Color.LightCyan;
            this.txtadet2.Location = new System.Drawing.Point(122, 119);
            this.txtadet2.Name = "txtadet2";
            this.txtadet2.Size = new System.Drawing.Size(114, 20);
            this.txtadet2.TabIndex = 84;
            // 
            // txtno2
            // 
            this.txtno2.BackColor = System.Drawing.Color.LightCyan;
            this.txtno2.Enabled = false;
            this.txtno2.Location = new System.Drawing.Point(122, 84);
            this.txtno2.Name = "txtno2";
            this.txtno2.Size = new System.Drawing.Size(114, 20);
            this.txtno2.TabIndex = 83;
            // 
            // txtmarka2
            // 
            this.txtmarka2.BackColor = System.Drawing.Color.LightCyan;
            this.txtmarka2.Location = new System.Drawing.Point(122, 51);
            this.txtmarka2.Name = "txtmarka2";
            this.txtmarka2.Size = new System.Drawing.Size(114, 20);
            this.txtmarka2.TabIndex = 82;
            // 
            // txtkategori2
            // 
            this.txtkategori2.BackColor = System.Drawing.Color.LightCyan;
            this.txtkategori2.Location = new System.Drawing.Point(122, 19);
            this.txtkategori2.Name = "txtkategori2";
            this.txtkategori2.Size = new System.Drawing.Size(114, 20);
            this.txtkategori2.TabIndex = 81;
            // 
            // tarih
            // 
            this.tarih.AutoSize = true;
            this.tarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tarih.Location = new System.Drawing.Point(26, 160);
            this.tarih.Name = "tarih";
            this.tarih.Size = new System.Drawing.Size(80, 16);
            this.tarih.TabIndex = 80;
            this.tarih.Text = "Kayıt tarihi";
            // 
            // stokadedi
            // 
            this.stokadedi.AutoSize = true;
            this.stokadedi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stokadedi.Location = new System.Drawing.Point(26, 123);
            this.stokadedi.Name = "stokadedi";
            this.stokadedi.Size = new System.Drawing.Size(84, 16);
            this.stokadedi.TabIndex = 79;
            this.stokadedi.Text = "Stok Adedi";
            // 
            // stokno
            // 
            this.stokno.AutoSize = true;
            this.stokno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stokno.Location = new System.Drawing.Point(26, 88);
            this.stokno.Name = "stokno";
            this.stokno.Size = new System.Drawing.Size(63, 16);
            this.stokno.TabIndex = 78;
            this.stokno.Text = "Stok No";
            // 
            // marka
            // 
            this.marka.AutoSize = true;
            this.marka.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.marka.Location = new System.Drawing.Point(26, 55);
            this.marka.Name = "marka";
            this.marka.Size = new System.Drawing.Size(51, 16);
            this.marka.TabIndex = 77;
            this.marka.Text = "Marka";
            // 
            // kategori
            // 
            this.kategori.AutoSize = true;
            this.kategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kategori.Location = new System.Drawing.Point(26, 23);
            this.kategori.Name = "kategori";
            this.kategori.Size = new System.Drawing.Size(66, 16);
            this.kategori.TabIndex = 76;
            this.kategori.Text = "Kategori";
            // 
            // UrunDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(278, 283);
            this.Controls.Add(this.btnkayit);
            this.Controls.Add(this.cmbsehir2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtadet2);
            this.Controls.Add(this.txtno2);
            this.Controls.Add(this.txtmarka2);
            this.Controls.Add(this.txtkategori2);
            this.Controls.Add(this.tarih);
            this.Controls.Add(this.stokadedi);
            this.Controls.Add(this.stokno);
            this.Controls.Add(this.marka);
            this.Controls.Add(this.kategori);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "UrunDuzenle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Düzenleme";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UrunDuzenle_FormClosed);
            this.Load += new System.EventHandler(this.UrunDuzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnkayit;
        private System.Windows.Forms.ComboBox cmbsehir2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtadet2;
        private System.Windows.Forms.TextBox txtno2;
        private System.Windows.Forms.TextBox txtmarka2;
        private System.Windows.Forms.TextBox txtkategori2;
        private System.Windows.Forms.Label tarih;
        private System.Windows.Forms.Label stokadedi;
        private System.Windows.Forms.Label stokno;
        private System.Windows.Forms.Label marka;
        private System.Windows.Forms.Label kategori;
    }
}