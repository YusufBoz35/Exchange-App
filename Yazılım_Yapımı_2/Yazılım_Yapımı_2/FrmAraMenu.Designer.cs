
namespace Yazılım_Yapımı_2
{
    partial class FrmAraMenu
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
            this.BtnUrunEkle = new System.Windows.Forms.Button();
            this.BtnAlim = new System.Windows.Forms.Button();
            this.BtnParaEkle = new System.Windows.Forms.Button();
            this.BtnKapat = new System.Windows.Forms.Button();
            this.BtnRapor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnUrunEkle
            // 
            this.BtnUrunEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnUrunEkle.Location = new System.Drawing.Point(35, 351);
            this.BtnUrunEkle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnUrunEkle.Name = "BtnUrunEkle";
            this.BtnUrunEkle.Size = new System.Drawing.Size(212, 59);
            this.BtnUrunEkle.TabIndex = 5;
            this.BtnUrunEkle.Text = "Hesabınıza Ürün Ekleme";
            this.BtnUrunEkle.UseVisualStyleBackColor = true;
            this.BtnUrunEkle.Click += new System.EventHandler(this.BtnUrunEkle_Click);
            // 
            // BtnAlim
            // 
            this.BtnAlim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnAlim.Location = new System.Drawing.Point(35, 223);
            this.BtnAlim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnAlim.Name = "BtnAlim";
            this.BtnAlim.Size = new System.Drawing.Size(212, 59);
            this.BtnAlim.TabIndex = 4;
            this.BtnAlim.Text = "Alım Yapma";
            this.BtnAlim.UseVisualStyleBackColor = true;
            this.BtnAlim.Click += new System.EventHandler(this.BtnAlim_Click);
            // 
            // BtnParaEkle
            // 
            this.BtnParaEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnParaEkle.Location = new System.Drawing.Point(35, 287);
            this.BtnParaEkle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnParaEkle.Name = "BtnParaEkle";
            this.BtnParaEkle.Size = new System.Drawing.Size(212, 59);
            this.BtnParaEkle.TabIndex = 3;
            this.BtnParaEkle.Text = "Hesabınıza Para Ekleme";
            this.BtnParaEkle.UseVisualStyleBackColor = true;
            this.BtnParaEkle.Click += new System.EventHandler(this.BtnParaEkle_Click);
            // 
            // BtnKapat
            // 
            this.BtnKapat.BackColor = System.Drawing.Color.Maroon;
            this.BtnKapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKapat.Location = new System.Drawing.Point(558, 11);
            this.BtnKapat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnKapat.Name = "BtnKapat";
            this.BtnKapat.Size = new System.Drawing.Size(149, 62);
            this.BtnKapat.TabIndex = 6;
            this.BtnKapat.Text = "Güvenli Çıkış";
            this.BtnKapat.UseVisualStyleBackColor = false;
            this.BtnKapat.Click += new System.EventHandler(this.BtnKapat_Click);
            // 
            // BtnRapor
            // 
            this.BtnRapor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnRapor.Location = new System.Drawing.Point(35, 415);
            this.BtnRapor.Name = "BtnRapor";
            this.BtnRapor.Size = new System.Drawing.Size(212, 59);
            this.BtnRapor.TabIndex = 7;
            this.BtnRapor.Text = "İşlem Geçmişi";
            this.BtnRapor.UseVisualStyleBackColor = true;
            this.BtnRapor.Click += new System.EventHandler(this.BtnRapor_Click);
            // 
            // FrmAraMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(719, 493);
            this.Controls.Add(this.BtnRapor);
            this.Controls.Add(this.BtnKapat);
            this.Controls.Add(this.BtnUrunEkle);
            this.Controls.Add(this.BtnAlim);
            this.Controls.Add(this.BtnParaEkle);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAraMenu";
            this.Text = "İşlemler Menüsü";
            this.Load += new System.EventHandler(this.FrmAraMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnUrunEkle;
        private System.Windows.Forms.Button BtnAlim;
        private System.Windows.Forms.Button BtnParaEkle;
        private System.Windows.Forms.Button BtnKapat;
        private System.Windows.Forms.Button BtnRapor;
    }
}