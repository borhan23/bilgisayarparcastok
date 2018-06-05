namespace Stok_Takip_Otomasyonu
{
    partial class Yardim
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
            this.listBoxKilavuz = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBoxKilavuz
            // 
            this.listBoxKilavuz.BackColor = System.Drawing.SystemColors.Menu;
            this.listBoxKilavuz.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxKilavuz.FormattingEnabled = true;
            this.listBoxKilavuz.Location = new System.Drawing.Point(0, 4);
            this.listBoxKilavuz.Name = "listBoxKilavuz";
            this.listBoxKilavuz.Size = new System.Drawing.Size(431, 208);
            this.listBoxKilavuz.TabIndex = 1;
            // 
            // Yardim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 216);
            this.Controls.Add(this.listBoxKilavuz);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Yardim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yardım";
            this.Load += new System.EventHandler(this.Yardim_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxKilavuz;
    }
}