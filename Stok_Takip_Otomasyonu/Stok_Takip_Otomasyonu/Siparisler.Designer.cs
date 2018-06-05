namespace Stok_Takip_Otomasyonu
{
    partial class Siparisler
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
            this.dataGridViewsiparis = new System.Windows.Forms.DataGridView();
            this.kategoriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.markaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teslimYeriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siparisTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siparisDurumuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siparislerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stokVeriDataSet2 = new Stok_Takip_Otomasyonu.StokVeriDataSet2();
            this.btngeri = new System.Windows.Forms.Button();
            this.btntemizle = new System.Windows.Forms.Button();
            this.siparislerTableAdapter = new Stok_Takip_Otomasyonu.StokVeriDataSet2TableAdapters.SiparislerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewsiparis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siparislerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokVeriDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewsiparis
            // 
            this.dataGridViewsiparis.AutoGenerateColumns = false;
            this.dataGridViewsiparis.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewsiparis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewsiparis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kategoriDataGridViewTextBoxColumn,
            this.markaDataGridViewTextBoxColumn,
            this.stokNoDataGridViewTextBoxColumn,
            this.adetDataGridViewTextBoxColumn,
            this.teslimYeriDataGridViewTextBoxColumn,
            this.siparisTarihiDataGridViewTextBoxColumn,
            this.siparisDurumuDataGridViewTextBoxColumn});
            this.dataGridViewsiparis.DataSource = this.siparislerBindingSource;
            this.dataGridViewsiparis.Location = new System.Drawing.Point(1, 1);
            this.dataGridViewsiparis.Name = "dataGridViewsiparis";
            this.dataGridViewsiparis.Size = new System.Drawing.Size(749, 337);
            this.dataGridViewsiparis.TabIndex = 5;
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
            // adetDataGridViewTextBoxColumn
            // 
            this.adetDataGridViewTextBoxColumn.DataPropertyName = "Adet";
            this.adetDataGridViewTextBoxColumn.HeaderText = "Adet";
            this.adetDataGridViewTextBoxColumn.Name = "adetDataGridViewTextBoxColumn";
            this.adetDataGridViewTextBoxColumn.Width = 50;
            // 
            // teslimYeriDataGridViewTextBoxColumn
            // 
            this.teslimYeriDataGridViewTextBoxColumn.DataPropertyName = "Teslim_Yeri";
            this.teslimYeriDataGridViewTextBoxColumn.HeaderText = "Teslim_Yeri";
            this.teslimYeriDataGridViewTextBoxColumn.Name = "teslimYeriDataGridViewTextBoxColumn";
            // 
            // siparisTarihiDataGridViewTextBoxColumn
            // 
            this.siparisTarihiDataGridViewTextBoxColumn.DataPropertyName = "Siparis_Tarihi";
            this.siparisTarihiDataGridViewTextBoxColumn.HeaderText = "Siparis_Tarihi";
            this.siparisTarihiDataGridViewTextBoxColumn.Name = "siparisTarihiDataGridViewTextBoxColumn";
            this.siparisTarihiDataGridViewTextBoxColumn.Width = 125;
            // 
            // siparisDurumuDataGridViewTextBoxColumn
            // 
            this.siparisDurumuDataGridViewTextBoxColumn.DataPropertyName = "Siparis_Durumu";
            this.siparisDurumuDataGridViewTextBoxColumn.HeaderText = "Siparis_Durumu";
            this.siparisDurumuDataGridViewTextBoxColumn.Name = "siparisDurumuDataGridViewTextBoxColumn";
            this.siparisDurumuDataGridViewTextBoxColumn.Width = 125;
            // 
            // siparislerBindingSource
            // 
            this.siparislerBindingSource.DataMember = "Siparisler";
            this.siparislerBindingSource.DataSource = this.stokVeriDataSet2;
            // 
            // stokVeriDataSet2
            // 
            this.stokVeriDataSet2.DataSetName = "StokVeriDataSet2";
            this.stokVeriDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btngeri
            // 
            this.btngeri.BackColor = System.Drawing.Color.Transparent;
            this.btngeri.BackgroundImage = global::Stok_Takip_Otomasyonu.Properties.Resources.geri_buton;
            this.btngeri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btngeri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btngeri.Location = new System.Drawing.Point(1, 357);
            this.btngeri.Name = "btngeri";
            this.btngeri.Size = new System.Drawing.Size(43, 35);
            this.btngeri.TabIndex = 4;
            this.btngeri.UseVisualStyleBackColor = false;
            this.btngeri.Click += new System.EventHandler(this.btngeri_Click);
            // 
            // btntemizle
            // 
            this.btntemizle.BackColor = System.Drawing.Color.Transparent;
            this.btntemizle.BackgroundImage = global::Stok_Takip_Otomasyonu.Properties.Resources._077427_black_inlay_crystal_clear_bubble_icon_business_trashcan31;
            this.btntemizle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btntemizle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btntemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btntemizle.Location = new System.Drawing.Point(683, 350);
            this.btntemizle.Name = "btntemizle";
            this.btntemizle.Size = new System.Drawing.Size(52, 42);
            this.btntemizle.TabIndex = 6;
            this.btntemizle.UseVisualStyleBackColor = false;
            this.btntemizle.Click += new System.EventHandler(this.btntemizle_Click);
            // 
            // siparislerTableAdapter
            // 
            this.siparislerTableAdapter.ClearBeforeFill = true;
            // 
            // Siparisler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(747, 400);
            this.Controls.Add(this.btntemizle);
            this.Controls.Add(this.dataGridViewsiparis);
            this.Controls.Add(this.btngeri);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Siparisler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Siparişler";
            this.Load += new System.EventHandler(this.Siparisler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewsiparis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siparislerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokVeriDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btntemizle;
        public System.Windows.Forms.DataGridView dataGridViewsiparis;
        private System.Windows.Forms.Button btngeri;
        private StokVeriDataSet2 stokVeriDataSet2;
        private System.Windows.Forms.BindingSource siparislerBindingSource;
        private StokVeriDataSet2TableAdapters.SiparislerTableAdapter siparislerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategoriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn markaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teslimYeriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn siparisTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn siparisDurumuDataGridViewTextBoxColumn;
    }
}