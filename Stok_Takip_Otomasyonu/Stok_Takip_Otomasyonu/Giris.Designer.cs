namespace Stok_Takip_Otomasyonu
{
    partial class Giris
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
            this.btncikis = new System.Windows.Forms.Button();
            this.btnuser = new System.Windows.Forms.Button();
            this.btnadmin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btncikis
            // 
            this.btncikis.BackColor = System.Drawing.Color.Transparent;
            this.btncikis.BackgroundImage = global::Stok_Takip_Otomasyonu.Properties.Resources.exit1;
            this.btncikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncikis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btncikis.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btncikis.Location = new System.Drawing.Point(187, 240);
            this.btncikis.Name = "btncikis";
            this.btncikis.Size = new System.Drawing.Size(40, 32);
            this.btncikis.TabIndex = 3;
            this.btncikis.UseVisualStyleBackColor = false;
            this.btncikis.Click += new System.EventHandler(this.btncikis_Click);
            // 
            // btnuser
            // 
            this.btnuser.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnuser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnuser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnuser.Image = global::Stok_Takip_Otomasyonu.Properties.Resources._1460923265_User;
            this.btnuser.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnuser.Location = new System.Drawing.Point(230, 45);
            this.btnuser.Name = "btnuser";
            this.btnuser.Size = new System.Drawing.Size(128, 161);
            this.btnuser.TabIndex = 4;
            this.btnuser.Text = "Kullanıcı Girişi";
            this.btnuser.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnuser.UseVisualStyleBackColor = false;
            this.btnuser.Click += new System.EventHandler(this.btnuser_Click);
            // 
            // btnadmin
            // 
            this.btnadmin.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnadmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnadmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnadmin.Image = global::Stok_Takip_Otomasyonu.Properties.Resources._1460923275_administrator;
            this.btnadmin.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnadmin.Location = new System.Drawing.Point(42, 45);
            this.btnadmin.Name = "btnadmin";
            this.btnadmin.Size = new System.Drawing.Size(128, 161);
            this.btnadmin.TabIndex = 5;
            this.btnadmin.Text = "Yönetici Girişi";
            this.btnadmin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnadmin.UseVisualStyleBackColor = false;
            this.btnadmin.Click += new System.EventHandler(this.btnadmin_Click);
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Stok_Takip_Otomasyonu.Properties.Resources.monitor_160942_640;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(410, 319);
            this.Controls.Add(this.btnadmin);
            this.Controls.Add(this.btnuser);
            this.Controls.Add(this.btncikis);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş";
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Giris_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Giris_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Giris_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btncikis;
        private System.Windows.Forms.Button btnuser;
        private System.Windows.Forms.Button btnadmin;
    }
}

