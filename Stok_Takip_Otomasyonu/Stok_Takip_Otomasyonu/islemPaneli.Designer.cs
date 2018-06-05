namespace Stok_Takip_Otomasyonu
{
    partial class islemPaneli
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kategoriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.markaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokAdediDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sehirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stokVeriDataSet1 = new Stok_Takip_Otomasyonu.StokVeriDataSet1();
            this.grupara = new System.Windows.Forms.GroupBox();
            this.aratarih = new System.Windows.Forms.TextBox();
            this.arasehir = new System.Windows.Forms.TextBox();
            this.arakategori = new System.Windows.Forms.TextBox();
            this.aramarka = new System.Windows.Forms.TextBox();
            this.arano = new System.Windows.Forms.TextBox();
            this.araadet = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.grupislem = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cmbsehir = new System.Windows.Forms.ComboBox();
            this.kategori = new System.Windows.Forms.Label();
            this.marka = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.stokno = new System.Windows.Forms.Label();
            this.stokadedi = new System.Windows.Forms.Label();
            this.btnsil = new System.Windows.Forms.Button();
            this.tarih = new System.Windows.Forms.Label();
            this.btnduzenle = new System.Windows.Forms.Button();
            this.txtkategori = new System.Windows.Forms.TextBox();
            this.btnekle = new System.Windows.Forms.Button();
            this.txtmarka = new System.Windows.Forms.TextBox();
            this.txtno = new System.Windows.Forms.TextBox();
            this.txtadet = new System.Windows.Forms.TextBox();
            this.btngeri = new System.Windows.Forms.Button();
            this.urunlerTableAdapter = new Stok_Takip_Otomasyonu.StokVeriDataSet1TableAdapters.UrunlerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokVeriDataSet1)).BeginInit();
            this.grupara.SuspendLayout();
            this.grupislem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kategoriDataGridViewTextBoxColumn,
            this.markaDataGridViewTextBoxColumn,
            this.stokNoDataGridViewTextBoxColumn,
            this.stokAdediDataGridViewTextBoxColumn,
            this.sehirDataGridViewTextBoxColumn,
            this.stokTarihiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.urunlerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1, 296);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(657, 353);
            this.dataGridView1.TabIndex = 64;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // kategoriDataGridViewTextBoxColumn
            // 
            this.kategoriDataGridViewTextBoxColumn.DataPropertyName = "Kategori";
            this.kategoriDataGridViewTextBoxColumn.HeaderText = "Kategori";
            this.kategoriDataGridViewTextBoxColumn.Name = "kategoriDataGridViewTextBoxColumn";
            // 
            // markaDataGridViewTextBoxColumn
            // 
            this.markaDataGridViewTextBoxColumn.DataPropertyName = "Marka";
            this.markaDataGridViewTextBoxColumn.HeaderText = "Marka";
            this.markaDataGridViewTextBoxColumn.Name = "markaDataGridViewTextBoxColumn";
            // 
            // stokNoDataGridViewTextBoxColumn
            // 
            this.stokNoDataGridViewTextBoxColumn.DataPropertyName = "Stok_No";
            this.stokNoDataGridViewTextBoxColumn.HeaderText = "Stok_No";
            this.stokNoDataGridViewTextBoxColumn.Name = "stokNoDataGridViewTextBoxColumn";
            // 
            // stokAdediDataGridViewTextBoxColumn
            // 
            this.stokAdediDataGridViewTextBoxColumn.DataPropertyName = "Stok_Adedi";
            this.stokAdediDataGridViewTextBoxColumn.HeaderText = "Stok_Adedi";
            this.stokAdediDataGridViewTextBoxColumn.Name = "stokAdediDataGridViewTextBoxColumn";
            this.stokAdediDataGridViewTextBoxColumn.Width = 75;
            // 
            // sehirDataGridViewTextBoxColumn
            // 
            this.sehirDataGridViewTextBoxColumn.DataPropertyName = "Sehir";
            this.sehirDataGridViewTextBoxColumn.HeaderText = "Sehir";
            this.sehirDataGridViewTextBoxColumn.Name = "sehirDataGridViewTextBoxColumn";
            // 
            // stokTarihiDataGridViewTextBoxColumn
            // 
            this.stokTarihiDataGridViewTextBoxColumn.DataPropertyName = "Stok_Tarihi";
            this.stokTarihiDataGridViewTextBoxColumn.HeaderText = "Stok_Tarihi";
            this.stokTarihiDataGridViewTextBoxColumn.Name = "stokTarihiDataGridViewTextBoxColumn";
            this.stokTarihiDataGridViewTextBoxColumn.Width = 125;
            // 
            // urunlerBindingSource
            // 
            this.urunlerBindingSource.DataMember = "Urunler";
            this.urunlerBindingSource.DataSource = this.stokVeriDataSet1;
            // 
            // stokVeriDataSet1
            // 
            this.stokVeriDataSet1.DataSetName = "StokVeriDataSet1";
            this.stokVeriDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grupara
            // 
            this.grupara.BackColor = System.Drawing.Color.Transparent;
            this.grupara.Controls.Add(this.aratarih);
            this.grupara.Controls.Add(this.arasehir);
            this.grupara.Controls.Add(this.arakategori);
            this.grupara.Controls.Add(this.aramarka);
            this.grupara.Controls.Add(this.arano);
            this.grupara.Controls.Add(this.araadet);
            this.grupara.Controls.Add(this.label2);
            this.grupara.Controls.Add(this.label3);
            this.grupara.Controls.Add(this.label4);
            this.grupara.Controls.Add(this.label5);
            this.grupara.Controls.Add(this.label6);
            this.grupara.Controls.Add(this.label7);
            this.grupara.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grupara.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grupara.Location = new System.Drawing.Point(392, 7);
            this.grupara.Name = "grupara";
            this.grupara.Size = new System.Drawing.Size(256, 243);
            this.grupara.TabIndex = 63;
            this.grupara.TabStop = false;
            this.grupara.Text = "Arama İşlemleri";
            // 
            // aratarih
            // 
            this.aratarih.BackColor = System.Drawing.SystemColors.ControlLight;
            this.aratarih.Location = new System.Drawing.Point(114, 193);
            this.aratarih.Name = "aratarih";
            this.aratarih.Size = new System.Drawing.Size(114, 21);
            this.aratarih.TabIndex = 66;
            this.aratarih.TextChanged += new System.EventHandler(this.aratarih_TextChanged);
            // 
            // arasehir
            // 
            this.arasehir.BackColor = System.Drawing.SystemColors.ControlLight;
            this.arasehir.Location = new System.Drawing.Point(114, 158);
            this.arasehir.Name = "arasehir";
            this.arasehir.Size = new System.Drawing.Size(114, 21);
            this.arasehir.TabIndex = 65;
            this.arasehir.TextChanged += new System.EventHandler(this.arasehir_TextChanged);
            // 
            // arakategori
            // 
            this.arakategori.BackColor = System.Drawing.SystemColors.ControlLight;
            this.arakategori.Location = new System.Drawing.Point(114, 22);
            this.arakategori.Name = "arakategori";
            this.arakategori.Size = new System.Drawing.Size(114, 21);
            this.arakategori.TabIndex = 60;
            this.arakategori.TextChanged += new System.EventHandler(this.arakategori_TextChanged);
            // 
            // aramarka
            // 
            this.aramarka.BackColor = System.Drawing.SystemColors.ControlLight;
            this.aramarka.Location = new System.Drawing.Point(114, 54);
            this.aramarka.Name = "aramarka";
            this.aramarka.Size = new System.Drawing.Size(114, 21);
            this.aramarka.TabIndex = 61;
            this.aramarka.TextChanged += new System.EventHandler(this.aramarka_TextChanged);
            // 
            // arano
            // 
            this.arano.BackColor = System.Drawing.SystemColors.ControlLight;
            this.arano.Location = new System.Drawing.Point(114, 87);
            this.arano.Name = "arano";
            this.arano.Size = new System.Drawing.Size(114, 21);
            this.arano.TabIndex = 62;
            this.arano.TextChanged += new System.EventHandler(this.arano_TextChanged);
            // 
            // araadet
            // 
            this.araadet.BackColor = System.Drawing.SystemColors.ControlLight;
            this.araadet.Location = new System.Drawing.Point(114, 122);
            this.araadet.Name = "araadet";
            this.araadet.Size = new System.Drawing.Size(114, 21);
            this.araadet.TabIndex = 63;
            this.araadet.TextChanged += new System.EventHandler(this.araadet_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(15, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 18);
            this.label2.TabIndex = 54;
            this.label2.Text = "Kategori";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(15, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 18);
            this.label3.TabIndex = 55;
            this.label3.Text = "Marka";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(15, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 18);
            this.label4.TabIndex = 59;
            this.label4.Text = "Şehir";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(15, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 18);
            this.label5.TabIndex = 56;
            this.label5.Text = "Stok No";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(15, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 18);
            this.label6.TabIndex = 57;
            this.label6.Text = "Stok Adedi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(15, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 18);
            this.label7.TabIndex = 58;
            this.label7.Text = "Kayıt tarihi";
            // 
            // grupislem
            // 
            this.grupislem.BackColor = System.Drawing.Color.Transparent;
            this.grupislem.Controls.Add(this.pictureBox1);
            this.grupislem.Controls.Add(this.dateTimePicker1);
            this.grupislem.Controls.Add(this.cmbsehir);
            this.grupislem.Controls.Add(this.kategori);
            this.grupislem.Controls.Add(this.marka);
            this.grupislem.Controls.Add(this.label1);
            this.grupislem.Controls.Add(this.stokno);
            this.grupislem.Controls.Add(this.stokadedi);
            this.grupislem.Controls.Add(this.btnsil);
            this.grupislem.Controls.Add(this.tarih);
            this.grupislem.Controls.Add(this.btnduzenle);
            this.grupislem.Controls.Add(this.txtkategori);
            this.grupislem.Controls.Add(this.btnekle);
            this.grupislem.Controls.Add(this.txtmarka);
            this.grupislem.Controls.Add(this.txtno);
            this.grupislem.Controls.Add(this.txtadet);
            this.grupislem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grupislem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grupislem.Location = new System.Drawing.Point(12, 6);
            this.grupislem.Name = "grupislem";
            this.grupislem.Size = new System.Drawing.Size(374, 244);
            this.grupislem.TabIndex = 62;
            this.grupislem.TabStop = false;
            this.grupislem.Text = "Stok İşlemleri";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Stok_Takip_Otomasyonu.Properties.Resources.exclamation;
            this.pictureBox1.Location = new System.Drawing.Point(222, 85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 29);
            this.pictureBox1.TabIndex = 57;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.ControlLight;
            this.dateTimePicker1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePicker1.CustomFormat = "dd.MM.yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(108, 195);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(114, 21);
            this.dateTimePicker1.TabIndex = 51;
            // 
            // cmbsehir
            // 
            this.cmbsehir.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cmbsehir.FormattingEnabled = true;
            this.cmbsehir.Location = new System.Drawing.Point(108, 158);
            this.cmbsehir.Name = "cmbsehir";
            this.cmbsehir.Size = new System.Drawing.Size(114, 23);
            this.cmbsehir.TabIndex = 56;
            // 
            // kategori
            // 
            this.kategori.AutoSize = true;
            this.kategori.BackColor = System.Drawing.Color.Transparent;
            this.kategori.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.kategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kategori.ForeColor = System.Drawing.Color.White;
            this.kategori.Location = new System.Drawing.Point(12, 27);
            this.kategori.Name = "kategori";
            this.kategori.Size = new System.Drawing.Size(68, 18);
            this.kategori.TabIndex = 34;
            this.kategori.Text = "Kategori";
            // 
            // marka
            // 
            this.marka.AutoSize = true;
            this.marka.BackColor = System.Drawing.Color.Transparent;
            this.marka.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.marka.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.marka.ForeColor = System.Drawing.Color.White;
            this.marka.Location = new System.Drawing.Point(12, 59);
            this.marka.Name = "marka";
            this.marka.Size = new System.Drawing.Size(53, 18);
            this.marka.TabIndex = 35;
            this.marka.Text = "Marka";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 18);
            this.label1.TabIndex = 53;
            this.label1.Text = "Şehir";
            // 
            // stokno
            // 
            this.stokno.AutoSize = true;
            this.stokno.BackColor = System.Drawing.Color.Transparent;
            this.stokno.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.stokno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stokno.ForeColor = System.Drawing.Color.White;
            this.stokno.Location = new System.Drawing.Point(12, 92);
            this.stokno.Name = "stokno";
            this.stokno.Size = new System.Drawing.Size(65, 18);
            this.stokno.TabIndex = 36;
            this.stokno.Text = "Stok No";
            // 
            // stokadedi
            // 
            this.stokadedi.AutoSize = true;
            this.stokadedi.BackColor = System.Drawing.Color.Transparent;
            this.stokadedi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.stokadedi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stokadedi.ForeColor = System.Drawing.Color.White;
            this.stokadedi.Location = new System.Drawing.Point(12, 127);
            this.stokadedi.Name = "stokadedi";
            this.stokadedi.Size = new System.Drawing.Size(86, 18);
            this.stokadedi.TabIndex = 37;
            this.stokadedi.Text = "Stok Adedi";
            // 
            // btnsil
            // 
            this.btnsil.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnsil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsil.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnsil.Image = global::Stok_Takip_Otomasyonu.Properties.Resources.delete;
            this.btnsil.Location = new System.Drawing.Point(263, 168);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(100, 37);
            this.btnsil.TabIndex = 49;
            this.btnsil.Text = "Stok Sil";
            this.btnsil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsil.UseVisualStyleBackColor = false;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // tarih
            // 
            this.tarih.AutoSize = true;
            this.tarih.BackColor = System.Drawing.Color.Transparent;
            this.tarih.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tarih.ForeColor = System.Drawing.Color.White;
            this.tarih.Location = new System.Drawing.Point(12, 199);
            this.tarih.Name = "tarih";
            this.tarih.Size = new System.Drawing.Size(82, 18);
            this.tarih.TabIndex = 38;
            this.tarih.Text = "Kayıt tarihi";
            // 
            // btnduzenle
            // 
            this.btnduzenle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnduzenle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnduzenle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnduzenle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnduzenle.Image = global::Stok_Takip_Otomasyonu.Properties.Resources.Edit_validated_icon1;
            this.btnduzenle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnduzenle.Location = new System.Drawing.Point(263, 92);
            this.btnduzenle.Name = "btnduzenle";
            this.btnduzenle.Size = new System.Drawing.Size(100, 53);
            this.btnduzenle.TabIndex = 48;
            this.btnduzenle.Text = "Stok Düzenle";
            this.btnduzenle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnduzenle.UseCompatibleTextRendering = true;
            this.btnduzenle.UseVisualStyleBackColor = false;
            this.btnduzenle.Click += new System.EventHandler(this.btnduzenle_Click);
            // 
            // txtkategori
            // 
            this.txtkategori.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtkategori.Location = new System.Drawing.Point(108, 23);
            this.txtkategori.Name = "txtkategori";
            this.txtkategori.Size = new System.Drawing.Size(114, 21);
            this.txtkategori.TabIndex = 39;
            this.txtkategori.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtkategori_KeyPress);
            // 
            // btnekle
            // 
            this.btnekle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnekle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnekle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnekle.Image = global::Stok_Takip_Otomasyonu.Properties.Resources.symbol_add;
            this.btnekle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnekle.Location = new System.Drawing.Point(263, 27);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(100, 40);
            this.btnekle.TabIndex = 47;
            this.btnekle.Text = "Stok Ekle";
            this.btnekle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnekle.UseVisualStyleBackColor = false;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // txtmarka
            // 
            this.txtmarka.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtmarka.Location = new System.Drawing.Point(108, 55);
            this.txtmarka.Name = "txtmarka";
            this.txtmarka.Size = new System.Drawing.Size(114, 21);
            this.txtmarka.TabIndex = 40;
            // 
            // txtno
            // 
            this.txtno.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtno.Location = new System.Drawing.Point(108, 88);
            this.txtno.Name = "txtno";
            this.txtno.Size = new System.Drawing.Size(114, 21);
            this.txtno.TabIndex = 41;
            // 
            // txtadet
            // 
            this.txtadet.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtadet.Location = new System.Drawing.Point(108, 123);
            this.txtadet.Name = "txtadet";
            this.txtadet.Size = new System.Drawing.Size(114, 21);
            this.txtadet.TabIndex = 42;
            this.txtadet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtadet_KeyPress);
            // 
            // btngeri
            // 
            this.btngeri.BackgroundImage = global::Stok_Takip_Otomasyonu.Properties.Resources.geri_buton;
            this.btngeri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btngeri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btngeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngeri.Location = new System.Drawing.Point(12, 256);
            this.btngeri.Name = "btngeri";
            this.btngeri.Size = new System.Drawing.Size(41, 34);
            this.btngeri.TabIndex = 60;
            this.btngeri.UseVisualStyleBackColor = true;
            this.btngeri.Click += new System.EventHandler(this.btngeri_Click);
            // 
            // urunlerTableAdapter
            // 
            this.urunlerTableAdapter.ClearBeforeFill = true;
            // 
            // islemPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Stok_Takip_Otomasyonu.Properties.Resources._downloadfiles_wallpapers_1920_1200_widescreen_apple_keyboard_wallpaper_apple_computers_wallpaper_1920_1200_widescreen_2714;
            this.ClientSize = new System.Drawing.Size(658, 650);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.grupara);
            this.Controls.Add(this.grupislem);
            this.Controls.Add(this.btngeri);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "islemPaneli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İşlem Paneli";
            this.Load += new System.EventHandler(this.islemPaneli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokVeriDataSet1)).EndInit();
            this.grupara.ResumeLayout(false);
            this.grupara.PerformLayout();
            this.grupislem.ResumeLayout(false);
            this.grupislem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox grupara;
        private System.Windows.Forms.TextBox aratarih;
        private System.Windows.Forms.TextBox arasehir;
        private System.Windows.Forms.TextBox arakategori;
        private System.Windows.Forms.TextBox aramarka;
        private System.Windows.Forms.TextBox arano;
        private System.Windows.Forms.TextBox araadet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox grupislem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cmbsehir;
        private System.Windows.Forms.Label kategori;
        private System.Windows.Forms.Label marka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label stokno;
        private System.Windows.Forms.Label stokadedi;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Label tarih;
        private System.Windows.Forms.Button btnduzenle;
        private System.Windows.Forms.TextBox txtkategori;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.TextBox txtmarka;
        private System.Windows.Forms.TextBox txtno;
        private System.Windows.Forms.TextBox txtadet;
        private System.Windows.Forms.Button btngeri;
        private StokVeriDataSet1 stokVeriDataSet1;
        private System.Windows.Forms.BindingSource urunlerBindingSource;
        private StokVeriDataSet1TableAdapters.UrunlerTableAdapter urunlerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sehirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokAdediDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn markaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategoriDataGridViewTextBoxColumn;
    }
}