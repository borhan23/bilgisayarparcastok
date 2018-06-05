namespace Stok_Takip_Otomasyonu
{
    partial class KontrolPaneli
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
            this.btngeri = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtsayi = new System.Windows.Forms.TextBox();
            this.btnsiparis = new System.Windows.Forms.Button();
            this.dataGridViewstoklar = new System.Windows.Forms.DataGridView();
            this.kategoriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.markaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokAdediDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sehirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kayıtYapanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stokVeriDataSet3 = new Stok_Takip_Otomasyonu.StokVeriDataSet3();
            this.urunlerTableAdapter = new Stok_Takip_Otomasyonu.StokVeriDataSet3TableAdapters.UrunlerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewstoklar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokVeriDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // btngeri
            // 
            this.btngeri.BackgroundImage = global::Stok_Takip_Otomasyonu.Properties.Resources.geri_buton;
            this.btngeri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btngeri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btngeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngeri.Location = new System.Drawing.Point(11, 340);
            this.btngeri.Name = "btngeri";
            this.btngeri.Size = new System.Drawing.Size(41, 34);
            this.btngeri.TabIndex = 49;
            this.btngeri.UseVisualStyleBackColor = true;
            this.btngeri.Click += new System.EventHandler(this.btngeri_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(400, 344);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 15);
            this.label1.TabIndex = 48;
            this.label1.Text = "Sipariş Adedi";
            // 
            // txtsayi
            // 
            this.txtsayi.BackColor = System.Drawing.Color.LightCyan;
            this.txtsayi.Location = new System.Drawing.Point(498, 343);
            this.txtsayi.Name = "txtsayi";
            this.txtsayi.Size = new System.Drawing.Size(100, 20);
            this.txtsayi.TabIndex = 47;
            // 
            // btnsiparis
            // 
            this.btnsiparis.BackColor = System.Drawing.SystemColors.Control;
            this.btnsiparis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsiparis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsiparis.Image = global::Stok_Takip_Otomasyonu.Properties.Resources.delivery_food;
            this.btnsiparis.Location = new System.Drawing.Point(644, 329);
            this.btnsiparis.Name = "btnsiparis";
            this.btnsiparis.Size = new System.Drawing.Size(90, 45);
            this.btnsiparis.TabIndex = 46;
            this.btnsiparis.Text = "Sipariş Ver";
            this.btnsiparis.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnsiparis.UseCompatibleTextRendering = true;
            this.btnsiparis.UseVisualStyleBackColor = false;
            this.btnsiparis.Click += new System.EventHandler(this.btnsiparis_Click);
            // 
            // dataGridViewstoklar
            // 
            this.dataGridViewstoklar.AutoGenerateColumns = false;
            this.dataGridViewstoklar.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewstoklar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewstoklar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kategoriDataGridViewTextBoxColumn,
            this.markaDataGridViewTextBoxColumn,
            this.stokNoDataGridViewTextBoxColumn,
            this.stokAdediDataGridViewTextBoxColumn,
            this.sehirDataGridViewTextBoxColumn,
            this.stokTarihiDataGridViewTextBoxColumn,
            this.kayıtYapanDataGridViewTextBoxColumn});
            this.dataGridViewstoklar.DataSource = this.urunlerBindingSource;
            this.dataGridViewstoklar.Location = new System.Drawing.Point(-1, 0);
            this.dataGridViewstoklar.Name = "dataGridViewstoklar";
            this.dataGridViewstoklar.Size = new System.Drawing.Size(750, 323);
            this.dataGridViewstoklar.TabIndex = 45;
            this.dataGridViewstoklar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewstoklar_CellClick);
            this.dataGridViewstoklar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewstoklar_CellContentClick);
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
            // 
            // kayıtYapanDataGridViewTextBoxColumn
            // 
            this.kayıtYapanDataGridViewTextBoxColumn.DataPropertyName = "Kayıt_Yapan";
            this.kayıtYapanDataGridViewTextBoxColumn.HeaderText = "Kayıt_Yapan";
            this.kayıtYapanDataGridViewTextBoxColumn.Name = "kayıtYapanDataGridViewTextBoxColumn";
            // 
            // urunlerBindingSource
            // 
            this.urunlerBindingSource.DataMember = "Urunler";
            this.urunlerBindingSource.DataSource = this.stokVeriDataSet3;
            // 
            // stokVeriDataSet3
            // 
            this.stokVeriDataSet3.DataSetName = "StokVeriDataSet3";
            this.stokVeriDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // urunlerTableAdapter
            // 
            this.urunlerTableAdapter.ClearBeforeFill = true;
            // 
            // KontrolPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(747, 387);
            this.Controls.Add(this.btngeri);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtsayi);
            this.Controls.Add(this.btnsiparis);
            this.Controls.Add(this.dataGridViewstoklar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "KontrolPaneli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kontrol Paneli";
            this.Load += new System.EventHandler(this.KontrolPaneli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewstoklar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokVeriDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btngeri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsayi;
        private System.Windows.Forms.Button btnsiparis;
        public System.Windows.Forms.DataGridView dataGridViewstoklar;
        private StokVeriDataSet3 stokVeriDataSet3;
        private System.Windows.Forms.BindingSource urunlerBindingSource;
        private StokVeriDataSet3TableAdapters.UrunlerTableAdapter urunlerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategoriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn markaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokAdediDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sehirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kayıtYapanDataGridViewTextBoxColumn;
    }
}