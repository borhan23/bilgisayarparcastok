namespace Stok_Takip_Otomasyonu
{
    partial class YoneticiPaneli
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
            this.components = new System.ComponentModel.Container();
            this.labelsoyad = new System.Windows.Forms.Label();
            this.labelad = new System.Windows.Forms.Label();
            this.labelsaat1 = new System.Windows.Forms.Label();
            this.labeltarih1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnisci = new System.Windows.Forms.Button();
            this.btnquit = new System.Windows.Forms.Button();
            this.btnsiparis = new System.Windows.Forms.Button();
            this.btnkontrol = new System.Windows.Forms.Button();
            this.btnislem = new System.Windows.Forms.Button();
            this.btnbildirim = new System.Windows.Forms.Button();
            this.btnprofil = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelsoyad
            // 
            this.labelsoyad.AutoSize = true;
            this.labelsoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelsoyad.Location = new System.Drawing.Point(13, 163);
            this.labelsoyad.Name = "labelsoyad";
            this.labelsoyad.Size = new System.Drawing.Size(60, 15);
            this.labelsoyad.TabIndex = 36;
            this.labelsoyad.Text = "labelsoy";
            // 
            // labelad
            // 
            this.labelad.AutoSize = true;
            this.labelad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelad.Location = new System.Drawing.Point(13, 148);
            this.labelad.Name = "labelad";
            this.labelad.Size = new System.Drawing.Size(55, 15);
            this.labelad.TabIndex = 35;
            this.labelad.Text = "labelad";
            // 
            // labelsaat1
            // 
            this.labelsaat1.AutoSize = true;
            this.labelsaat1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelsaat1.Location = new System.Drawing.Point(292, 42);
            this.labelsaat1.Name = "labelsaat1";
            this.labelsaat1.Size = new System.Drawing.Size(38, 16);
            this.labelsaat1.TabIndex = 28;
            this.labelsaat1.Text = "saat";
            // 
            // labeltarih1
            // 
            this.labeltarih1.AutoSize = true;
            this.labeltarih1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labeltarih1.Location = new System.Drawing.Point(253, 26);
            this.labeltarih1.Name = "labeltarih1";
            this.labeltarih1.Size = new System.Drawing.Size(38, 16);
            this.labeltarih1.TabIndex = 26;
            this.labeltarih1.Text = "tarih";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Stok_Takip_Otomasyonu.Properties.Resources._16762_illustration_of_a_clock_pv;
            this.pictureBox2.Location = new System.Drawing.Point(170, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(86, 60);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 38;
            this.pictureBox2.TabStop = false;
            // 
            // btnisci
            // 
            this.btnisci.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnisci.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnisci.Image = global::Stok_Takip_Otomasyonu.Properties.Resources._3fb7138447319ae92edb05df91e70360_users;
            this.btnisci.Location = new System.Drawing.Point(181, 246);
            this.btnisci.Name = "btnisci";
            this.btnisci.Size = new System.Drawing.Size(127, 46);
            this.btnisci.TabIndex = 37;
            this.btnisci.Text = "Çalışan Bilgileri";
            this.btnisci.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnisci.UseVisualStyleBackColor = true;
            this.btnisci.Click += new System.EventHandler(this.btnisci_Click);
            // 
            // btnquit
            // 
            this.btnquit.BackColor = System.Drawing.Color.Transparent;
            this.btnquit.BackgroundImage = global::Stok_Takip_Otomasyonu.Properties.Resources.exit1;
            this.btnquit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnquit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnquit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnquit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnquit.ForeColor = System.Drawing.Color.CadetBlue;
            this.btnquit.Location = new System.Drawing.Point(11, 308);
            this.btnquit.Name = "btnquit";
            this.btnquit.Size = new System.Drawing.Size(35, 33);
            this.btnquit.TabIndex = 34;
            this.btnquit.Text = "\r\n";
            this.btnquit.UseVisualStyleBackColor = false;
            this.btnquit.Click += new System.EventHandler(this.btnquit_Click);
            // 
            // btnsiparis
            // 
            this.btnsiparis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsiparis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsiparis.Image = global::Stok_Takip_Otomasyonu.Properties.Resources.delivery_food;
            this.btnsiparis.Location = new System.Drawing.Point(344, 246);
            this.btnsiparis.Name = "btnsiparis";
            this.btnsiparis.Size = new System.Drawing.Size(127, 46);
            this.btnsiparis.TabIndex = 33;
            this.btnsiparis.Text = "Siparişler";
            this.btnsiparis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsiparis.UseVisualStyleBackColor = true;
            this.btnsiparis.Click += new System.EventHandler(this.btnsiparis_Click_1);
            // 
            // btnkontrol
            // 
            this.btnkontrol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnkontrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkontrol.Image = global::Stok_Takip_Otomasyonu.Properties.Resources.todo_list_5121;
            this.btnkontrol.Location = new System.Drawing.Point(344, 179);
            this.btnkontrol.Name = "btnkontrol";
            this.btnkontrol.Size = new System.Drawing.Size(127, 46);
            this.btnkontrol.TabIndex = 32;
            this.btnkontrol.Text = "Stok Kontrol";
            this.btnkontrol.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnkontrol.UseVisualStyleBackColor = true;
            this.btnkontrol.Click += new System.EventHandler(this.btnkontrol_Click);
            // 
            // btnislem
            // 
            this.btnislem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnislem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnislem.Image = global::Stok_Takip_Otomasyonu.Properties.Resources.tools;
            this.btnislem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnislem.Location = new System.Drawing.Point(344, 110);
            this.btnislem.Name = "btnislem";
            this.btnislem.Size = new System.Drawing.Size(127, 46);
            this.btnislem.TabIndex = 31;
            this.btnislem.Text = "İşlemler";
            this.btnislem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnislem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnislem.UseVisualStyleBackColor = true;
            this.btnislem.Click += new System.EventHandler(this.btnislem_Click);
            // 
            // btnbildirim
            // 
            this.btnbildirim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbildirim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnbildirim.Image = global::Stok_Takip_Otomasyonu.Properties.Resources.Messaging_Message_icon;
            this.btnbildirim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnbildirim.Location = new System.Drawing.Point(181, 179);
            this.btnbildirim.Name = "btnbildirim";
            this.btnbildirim.Size = new System.Drawing.Size(127, 46);
            this.btnbildirim.TabIndex = 30;
            this.btnbildirim.Text = "Bildirimler";
            this.btnbildirim.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnbildirim.UseVisualStyleBackColor = true;
            this.btnbildirim.Click += new System.EventHandler(this.btnbildirim_Click);
            // 
            // btnprofil
            // 
            this.btnprofil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnprofil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnprofil.Image = global::Stok_Takip_Otomasyonu.Properties.Resources._74472;
            this.btnprofil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnprofil.Location = new System.Drawing.Point(181, 110);
            this.btnprofil.Name = "btnprofil";
            this.btnprofil.Size = new System.Drawing.Size(127, 46);
            this.btnprofil.TabIndex = 29;
            this.btnprofil.Text = "Profil Bilgileri";
            this.btnprofil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnprofil.UseVisualStyleBackColor = true;
            this.btnprofil.Click += new System.EventHandler(this.btnprofil_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Stok_Takip_Otomasyonu.Properties.Resources._1460923275_administrator;
            this.pictureBox1.Location = new System.Drawing.Point(1, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 129);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // YoneticiPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(509, 353);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnisci);
            this.Controls.Add(this.labelsoyad);
            this.Controls.Add(this.labelad);
            this.Controls.Add(this.btnquit);
            this.Controls.Add(this.btnsiparis);
            this.Controls.Add(this.btnkontrol);
            this.Controls.Add(this.btnislem);
            this.Controls.Add(this.btnbildirim);
            this.Controls.Add(this.btnprofil);
            this.Controls.Add(this.labelsaat1);
            this.Controls.Add(this.labeltarih1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "YoneticiPaneli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yönetici Paneli";
            this.Load += new System.EventHandler(this.YoneticiPaneli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnisci;
        private System.Windows.Forms.Label labelsoyad;
        private System.Windows.Forms.Label labelad;
        private System.Windows.Forms.Button btnquit;
        private System.Windows.Forms.Button btnsiparis;
        private System.Windows.Forms.Button btnkontrol;
        private System.Windows.Forms.Button btnislem;
        private System.Windows.Forms.Button btnbildirim;
        private System.Windows.Forms.Button btnprofil;
        private System.Windows.Forms.Label labelsaat1;
        private System.Windows.Forms.Label labeltarih1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
    }
}