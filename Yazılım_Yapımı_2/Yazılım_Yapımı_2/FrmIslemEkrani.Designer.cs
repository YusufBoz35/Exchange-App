
namespace Yazılım_Yapımı_2
{
    partial class FrmIslemEkrani
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
            this.GrpBoxIslem = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtBirimFiyat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnIslem = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TabloAlimEmirlerim = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtTutar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtAlimMiktari = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbIslem = new System.Windows.Forms.ComboBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.GrpBoxTablo = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CmbUrun = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.GrpBoxIslem.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabloAlimEmirlerim)).BeginInit();
            this.GrpBoxTablo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // GrpBoxIslem
            // 
            this.GrpBoxIslem.Controls.Add(this.label7);
            this.GrpBoxIslem.Controls.Add(this.TxtBirimFiyat);
            this.GrpBoxIslem.Controls.Add(this.label6);
            this.GrpBoxIslem.Controls.Add(this.BtnIslem);
            this.GrpBoxIslem.Controls.Add(this.groupBox2);
            this.GrpBoxIslem.Controls.Add(this.label4);
            this.GrpBoxIslem.Controls.Add(this.TxtTutar);
            this.GrpBoxIslem.Controls.Add(this.label3);
            this.GrpBoxIslem.Controls.Add(this.label2);
            this.GrpBoxIslem.Controls.Add(this.TxtAlimMiktari);
            this.GrpBoxIslem.Controls.Add(this.label1);
            this.GrpBoxIslem.Controls.Add(this.CmbIslem);
            this.GrpBoxIslem.Controls.Add(this.radioButton2);
            this.GrpBoxIslem.Controls.Add(this.radioButton1);
            this.GrpBoxIslem.Controls.Add(this.GrpBoxTablo);
            this.GrpBoxIslem.Location = new System.Drawing.Point(70, 132);
            this.GrpBoxIslem.Name = "GrpBoxIslem";
            this.GrpBoxIslem.Size = new System.Drawing.Size(1242, 707);
            this.GrpBoxIslem.TabIndex = 0;
            this.GrpBoxIslem.TabStop = false;
            this.GrpBoxIslem.Text = "Bugday";
            this.GrpBoxIslem.Enter += new System.EventHandler(this.GrpBoxIslem_Enter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(305, 527);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 24);
            this.label7.TabIndex = 14;
            this.label7.Text = "TL";
            // 
            // TxtBirimFiyat
            // 
            this.TxtBirimFiyat.Location = new System.Drawing.Point(185, 524);
            this.TxtBirimFiyat.Name = "TxtBirimFiyat";
            this.TxtBirimFiyat.Size = new System.Drawing.Size(114, 32);
            this.TxtBirimFiyat.TabIndex = 13;
            this.TxtBirimFiyat.TextChanged += new System.EventHandler(this.TxtBirimFiyat_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 527);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "İşlem Birim Fiyatı : ";
            // 
            // BtnIslem
            // 
            this.BtnIslem.Location = new System.Drawing.Point(185, 623);
            this.BtnIslem.Name = "BtnIslem";
            this.BtnIslem.Size = new System.Drawing.Size(308, 45);
            this.BtnIslem.TabIndex = 11;
            this.BtnIslem.UseVisualStyleBackColor = true;
            this.BtnIslem.Click += new System.EventHandler(this.BtnIslem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TabloAlimEmirlerim);
            this.groupBox2.Location = new System.Drawing.Point(607, 34);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(636, 320);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Alım Emirleri";
            // 
            // TabloAlimEmirlerim
            // 
            this.TabloAlimEmirlerim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TabloAlimEmirlerim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabloAlimEmirlerim.Location = new System.Drawing.Point(3, 28);
            this.TabloAlimEmirlerim.Name = "TabloAlimEmirlerim";
            this.TabloAlimEmirlerim.RowHeadersWidth = 51;
            this.TabloAlimEmirlerim.RowTemplate.Height = 24;
            this.TabloAlimEmirlerim.Size = new System.Drawing.Size(630, 289);
            this.TabloAlimEmirlerim.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(305, 579);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "TL";
            // 
            // TxtTutar
            // 
            this.TxtTutar.Location = new System.Drawing.Point(185, 575);
            this.TxtTutar.Name = "TxtTutar";
            this.TxtTutar.Size = new System.Drawing.Size(114, 32);
            this.TxtTutar.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 579);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tutar : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 471);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Miktar : ";
            // 
            // TxtAlimMiktari
            // 
            this.TxtAlimMiktari.Location = new System.Drawing.Point(185, 468);
            this.TxtAlimMiktari.Name = "TxtAlimMiktari";
            this.TxtAlimMiktari.Size = new System.Drawing.Size(308, 32);
            this.TxtAlimMiktari.TabIndex = 6;
            this.TxtAlimMiktari.TextChanged += new System.EventHandler(this.TxtAlimMiktari_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 418);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "İşlem Tipi :";
            // 
            // CmbIslem
            // 
            this.CmbIslem.FormattingEnabled = true;
            this.CmbIslem.Items.AddRange(new object[] {
            "Piyasa Emri",
            "Teklif Oluştur"});
            this.CmbIslem.Location = new System.Drawing.Point(185, 415);
            this.CmbIslem.Name = "CmbIslem";
            this.CmbIslem.Size = new System.Drawing.Size(308, 32);
            this.CmbIslem.TabIndex = 4;
            this.CmbIslem.TextChanged += new System.EventHandler(this.CmbBugday_TextChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(374, 360);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(65, 28);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "SAT";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(229, 360);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(54, 28);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "AL";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // GrpBoxTablo
            // 
            this.GrpBoxTablo.Controls.Add(this.dataGridView1);
            this.GrpBoxTablo.Location = new System.Drawing.Point(0, 31);
            this.GrpBoxTablo.Name = "GrpBoxTablo";
            this.GrpBoxTablo.Size = new System.Drawing.Size(565, 323);
            this.GrpBoxTablo.TabIndex = 1;
            this.GrpBoxTablo.TabStop = false;
            this.GrpBoxTablo.Text = "Satış Emirleri";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(559, 292);
            this.dataGridView1.TabIndex = 0;
            // 
            // CmbUrun
            // 
            this.CmbUrun.FormattingEnabled = true;
            this.CmbUrun.Items.AddRange(new object[] {
            "bugday",
            "arpa",
            "Yulaf",
            "Petrol",
            "Pamuk"});
            this.CmbUrun.Location = new System.Drawing.Point(147, 64);
            this.CmbUrun.Name = "CmbUrun";
            this.CmbUrun.Size = new System.Drawing.Size(281, 32);
            this.CmbUrun.TabIndex = 2;
            this.CmbUrun.TextChanged += new System.EventHandler(this.CmbUrun_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ürün :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(601, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 60);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(974, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 24);
            this.label8.TabIndex = 5;
            this.label8.Text = "label8";
            // 
            // FrmIslemEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1400, 967);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CmbUrun);
            this.Controls.Add(this.GrpBoxIslem);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmIslemEkrani";
            this.Text = "FrmIslemEkrani";
            this.Load += new System.EventHandler(this.FrmIslemEkrani_Load);
            this.GrpBoxIslem.ResumeLayout(false);
            this.GrpBoxIslem.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TabloAlimEmirlerim)).EndInit();
            this.GrpBoxTablo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GrpBoxIslem;
        private System.Windows.Forms.Button BtnIslem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtTutar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtAlimMiktari;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbIslem;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox GrpBoxTablo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox CmbUrun;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView TabloAlimEmirlerim;
        private System.Windows.Forms.TextBox TxtBirimFiyat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
    }
}