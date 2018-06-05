namespace Stok_Takip_Otomasyonu
{
    partial class YoneticiBildirim
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
            this.dataGridViewbildirim = new System.Windows.Forms.DataGridView();
            this.bildirimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullaniciBildirimBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stokVeriDataSet5 = new Stok_Takip_Otomasyonu.StokVeriDataSet5();
            this.txtmesaj = new System.Windows.Forms.TextBox();
            this.kullaniciBildirimTableAdapter = new Stok_Takip_Otomasyonu.StokVeriDataSet5TableAdapters.KullaniciBildirimTableAdapter();
            this.btngeri = new System.Windows.Forms.Button();
            this.btntemiz = new System.Windows.Forms.Button();
            this.btnmesaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewbildirim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciBildirimBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokVeriDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewbildirim
            // 
            this.dataGridViewbildirim.AutoGenerateColumns = false;
            this.dataGridViewbildirim.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewbildirim.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewbildirim.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewbildirim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewbildirim.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bildirimDataGridViewTextBoxColumn,
            this.tarihDataGridViewTextBoxColumn});
            this.dataGridViewbildirim.DataSource = this.kullaniciBildirimBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewbildirim.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewbildirim.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dataGridViewbildirim.Location = new System.Drawing.Point(250, 0);
            this.dataGridViewbildirim.Name = "dataGridViewbildirim";
            this.dataGridViewbildirim.Size = new System.Drawing.Size(523, 267);
            this.dataGridViewbildirim.TabIndex = 48;
            // 
            // bildirimDataGridViewTextBoxColumn
            // 
            this.bildirimDataGridViewTextBoxColumn.DataPropertyName = "Bildirim";
            this.bildirimDataGridViewTextBoxColumn.HeaderText = "Bildirim";
            this.bildirimDataGridViewTextBoxColumn.Name = "bildirimDataGridViewTextBoxColumn";
            this.bildirimDataGridViewTextBoxColumn.Width = 355;
            // 
            // tarihDataGridViewTextBoxColumn
            // 
            this.tarihDataGridViewTextBoxColumn.DataPropertyName = "Tarih";
            this.tarihDataGridViewTextBoxColumn.HeaderText = "Tarih";
            this.tarihDataGridViewTextBoxColumn.Name = "tarihDataGridViewTextBoxColumn";
            this.tarihDataGridViewTextBoxColumn.Width = 125;
            // 
            // kullaniciBildirimBindingSource
            // 
            this.kullaniciBildirimBindingSource.DataMember = "KullaniciBildirim";
            this.kullaniciBildirimBindingSource.DataSource = this.stokVeriDataSet5;
            // 
            // stokVeriDataSet5
            // 
            this.stokVeriDataSet5.DataSetName = "StokVeriDataSet5";
            this.stokVeriDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtmesaj
            // 
            this.txtmesaj.Location = new System.Drawing.Point(-1, 0);
            this.txtmesaj.Multiline = true;
            this.txtmesaj.Name = "txtmesaj";
            this.txtmesaj.Size = new System.Drawing.Size(254, 175);
            this.txtmesaj.TabIndex = 46;
            // 
            // kullaniciBildirimTableAdapter
            // 
            this.kullaniciBildirimTableAdapter.ClearBeforeFill = true;
            // 
            // btngeri
            // 
            this.btngeri.BackgroundImage = global::Stok_Takip_Otomasyonu.Properties.Resources.geri_buton;
            this.btngeri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btngeri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btngeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngeri.Location = new System.Drawing.Point(12, 273);
            this.btngeri.Name = "btngeri";
            this.btngeri.Size = new System.Drawing.Size(41, 34);
            this.btngeri.TabIndex = 50;
            this.btngeri.UseVisualStyleBackColor = true;
            this.btngeri.Click += new System.EventHandler(this.btngeri_Click);
            // 
            // btntemiz
            // 
            this.btntemiz.BackgroundImage = global::Stok_Takip_Otomasyonu.Properties.Resources._077427_black_inlay_crystal_clear_bubble_icon_business_trashcan31;
            this.btntemiz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btntemiz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btntemiz.Location = new System.Drawing.Point(717, 273);
            this.btntemiz.Name = "btntemiz";
            this.btntemiz.Size = new System.Drawing.Size(46, 42);
            this.btntemiz.TabIndex = 49;
            this.btntemiz.UseVisualStyleBackColor = true;
            this.btntemiz.Click += new System.EventHandler(this.btntemiz_Click);
            // 
            // btnmesaj
            // 
            this.btnmesaj.BackgroundImage = global::Stok_Takip_Otomasyonu.Properties.Resources.sending_e_mail_envelope_marketing_512;
            this.btnmesaj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnmesaj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmesaj.Location = new System.Drawing.Point(96, 181);
            this.btnmesaj.Name = "btnmesaj";
            this.btnmesaj.Size = new System.Drawing.Size(57, 43);
            this.btnmesaj.TabIndex = 47;
            this.btnmesaj.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnmesaj.UseVisualStyleBackColor = true;
            this.btnmesaj.Click += new System.EventHandler(this.btnmesaj_Click);
            // 
            // YoneticiBildirim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(775, 322);
            this.Controls.Add(this.btngeri);
            this.Controls.Add(this.btntemiz);
            this.Controls.Add(this.dataGridViewbildirim);
            this.Controls.Add(this.btnmesaj);
            this.Controls.Add(this.txtmesaj);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "YoneticiBildirim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bildirimler";
            this.Load += new System.EventHandler(this.YoneticiBildirim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewbildirim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciBildirimBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokVeriDataSet5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btngeri;
        private System.Windows.Forms.Button btntemiz;
        private System.Windows.Forms.DataGridView dataGridViewbildirim;
        private System.Windows.Forms.Button btnmesaj;
        public System.Windows.Forms.TextBox txtmesaj;
        private StokVeriDataSet5 stokVeriDataSet5;
        private System.Windows.Forms.BindingSource kullaniciBildirimBindingSource;
        private StokVeriDataSet5TableAdapters.KullaniciBildirimTableAdapter kullaniciBildirimTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bildirimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarihDataGridViewTextBoxColumn;
    }
}