
namespace Yazılım_Yapımı_2
{
    partial class FrmAdminPanel
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
            this.button1 = new System.Windows.Forms.Button();
            this.BtnUrunS = new System.Windows.Forms.Button();
            this.BtnUrunG = new System.Windows.Forms.Button();
            this.BtnParaS = new System.Windows.Forms.Button();
            this.BtnParaG = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtMuhasebe = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.Location = new System.Drawing.Point(950, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 45);
            this.button1.TabIndex = 14;
            this.button1.Text = "Çıkış";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnUrunS
            // 
            this.BtnUrunS.Location = new System.Drawing.Point(893, 421);
            this.BtnUrunS.Name = "BtnUrunS";
            this.BtnUrunS.Size = new System.Drawing.Size(152, 38);
            this.BtnUrunS.TabIndex = 13;
            this.BtnUrunS.Text = "Sil";
            this.BtnUrunS.UseVisualStyleBackColor = true;
            this.BtnUrunS.Click += new System.EventHandler(this.BtnUrunS_Click);
            // 
            // BtnUrunG
            // 
            this.BtnUrunG.Location = new System.Drawing.Point(534, 421);
            this.BtnUrunG.Name = "BtnUrunG";
            this.BtnUrunG.Size = new System.Drawing.Size(153, 38);
            this.BtnUrunG.TabIndex = 12;
            this.BtnUrunG.Text = "Güncelle";
            this.BtnUrunG.UseVisualStyleBackColor = true;
            this.BtnUrunG.Click += new System.EventHandler(this.BtnUrunG_Click);
            // 
            // BtnParaS
            // 
            this.BtnParaS.Location = new System.Drawing.Point(305, 421);
            this.BtnParaS.Name = "BtnParaS";
            this.BtnParaS.Size = new System.Drawing.Size(166, 38);
            this.BtnParaS.TabIndex = 11;
            this.BtnParaS.Text = "Sil";
            this.BtnParaS.UseVisualStyleBackColor = true;
            this.BtnParaS.Click += new System.EventHandler(this.BtnParaS_Click);
            // 
            // BtnParaG
            // 
            this.BtnParaG.Location = new System.Drawing.Point(40, 421);
            this.BtnParaG.Name = "BtnParaG";
            this.BtnParaG.Size = new System.Drawing.Size(166, 38);
            this.BtnParaG.TabIndex = 10;
            this.BtnParaG.Text = "Güncelle";
            this.BtnParaG.UseVisualStyleBackColor = true;
            this.BtnParaG.Click += new System.EventHandler(this.BtnParaG_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Location = new System.Drawing.Point(534, 108);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(514, 307);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ürün Ekleme İstekleri";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 28);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(508, 276);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(40, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(434, 307);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Para Ekleme İstekleri";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(428, 276);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 30);
            this.label1.TabIndex = 15;
            this.label1.Text = "Muhasebe Kasa : ";
            // 
            // TxtMuhasebe
            // 
            this.TxtMuhasebe.Enabled = false;
            this.TxtMuhasebe.Location = new System.Drawing.Point(206, 30);
            this.TxtMuhasebe.Name = "TxtMuhasebe";
            this.TxtMuhasebe.Size = new System.Drawing.Size(148, 32);
            this.TxtMuhasebe.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(360, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 30);
            this.label2.TabIndex = 17;
            this.label2.Text = "TL";
            // 
            // FrmAdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(882, 472);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtMuhasebe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnUrunS);
            this.Controls.Add(this.BtnUrunG);
            this.Controls.Add(this.BtnParaS);
            this.Controls.Add(this.BtnParaG);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAdminPanel";
            this.Text = "Admin Panel";
            this.Load += new System.EventHandler(this.FrmAdminPanel_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnUrunS;
        private System.Windows.Forms.Button BtnUrunG;
        private System.Windows.Forms.Button BtnParaS;
        private System.Windows.Forms.Button BtnParaG;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtMuhasebe;
        private System.Windows.Forms.Label label2;
    }
}