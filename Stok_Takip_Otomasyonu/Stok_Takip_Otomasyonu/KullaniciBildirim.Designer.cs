namespace Stok_Takip_Otomasyonu
{
    partial class KullaniciBildirim
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewmesaj = new System.Windows.Forms.DataGridView();
            this.mesajDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullaniciMesajBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stokVeriDataSet = new Stok_Takip_Otomasyonu.StokVeriDataSet();
            this.btngeri = new System.Windows.Forms.Button();
            this.btntemiz = new System.Windows.Forms.Button();
            this.kullaniciMesajTableAdapter = new Stok_Takip_Otomasyonu.StokVeriDataSetTableAdapters.KullaniciMesajTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewmesaj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciMesajBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokVeriDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewmesaj
            // 
            this.dataGridViewmesaj.AutoGenerateColumns = false;
            this.dataGridViewmesaj.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewmesaj.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewmesaj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewmesaj.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mesajDataGridViewTextBoxColumn,
            this.tarihDataGridViewTextBoxColumn});
            this.dataGridViewmesaj.DataSource = this.kullaniciMesajBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewmesaj.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewmesaj.Location = new System.Drawing.Point(-1, 0);
            this.dataGridViewmesaj.Name = "dataGridViewmesaj";
            this.dataGridViewmesaj.Size = new System.Drawing.Size(578, 282);
            this.dataGridViewmesaj.TabIndex = 46;
            // 
            // mesajDataGridViewTextBoxColumn
            // 
            this.mesajDataGridViewTextBoxColumn.DataPropertyName = "Mesaj";
            this.mesajDataGridViewTextBoxColumn.HeaderText = "Mesaj";
            this.mesajDataGridViewTextBoxColumn.Name = "mesajDataGridViewTextBoxColumn";
            this.mesajDataGridViewTextBoxColumn.Width = 400;
            // 
            // tarihDataGridViewTextBoxColumn
            // 
            this.tarihDataGridViewTextBoxColumn.DataPropertyName = "Tarih";
            this.tarihDataGridViewTextBoxColumn.HeaderText = "Tarih";
            this.tarihDataGridViewTextBoxColumn.Name = "tarihDataGridViewTextBoxColumn";
            this.tarihDataGridViewTextBoxColumn.Width = 125;
            // 
            // kullaniciMesajBindingSource
            // 
            this.kullaniciMesajBindingSource.DataMember = "KullaniciMesaj";
            this.kullaniciMesajBindingSource.DataSource = this.stokVeriDataSet;
            // 
            // stokVeriDataSet
            // 
            this.stokVeriDataSet.DataSetName = "StokVeriDataSet";
            this.stokVeriDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btngeri
            // 
            this.btngeri.BackgroundImage = global::Stok_Takip_Otomasyonu.Properties.Resources.geri_buton;
            this.btngeri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btngeri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btngeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngeri.Location = new System.Drawing.Point(12, 294);
            this.btngeri.Name = "btngeri";
            this.btngeri.Size = new System.Drawing.Size(41, 36);
            this.btngeri.TabIndex = 47;
            this.btngeri.UseVisualStyleBackColor = true;
            this.btngeri.Click += new System.EventHandler(this.btngeri_Click);
            // 
            // btntemiz
            // 
            this.btntemiz.BackColor = System.Drawing.Color.Transparent;
            this.btntemiz.BackgroundImage = global::Stok_Takip_Otomasyonu.Properties.Resources._077427_black_inlay_crystal_clear_bubble_icon_business_trashcan3;
            this.btntemiz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btntemiz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btntemiz.Location = new System.Drawing.Point(507, 294);
            this.btntemiz.Name = "btntemiz";
            this.btntemiz.Size = new System.Drawing.Size(55, 42);
            this.btntemiz.TabIndex = 45;
            this.btntemiz.UseVisualStyleBackColor = false;
            this.btntemiz.Click += new System.EventHandler(this.btntemiz_Click);
            // 
            // kullaniciMesajTableAdapter
            // 
            this.kullaniciMesajTableAdapter.ClearBeforeFill = true;
            // 
            // KullaniciBildirim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(574, 341);
            this.Controls.Add(this.btngeri);
            this.Controls.Add(this.dataGridViewmesaj);
            this.Controls.Add(this.btntemiz);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "KullaniciBildirim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mesajlar";
            this.Load += new System.EventHandler(this.KullaniciBildirim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewmesaj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciMesajBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokVeriDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btngeri;
        private System.Windows.Forms.DataGridView dataGridViewmesaj;
        private System.Windows.Forms.Button btntemiz;
        private StokVeriDataSet stokVeriDataSet;
        private System.Windows.Forms.BindingSource kullaniciMesajBindingSource;
        private StokVeriDataSetTableAdapters.KullaniciMesajTableAdapter kullaniciMesajTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mesajDataGridViewTextBoxColumn;
    }
}