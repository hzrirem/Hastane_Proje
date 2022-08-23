
namespace Hastane_Proje
{
    partial class Bilgi_Güncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bilgi_Güncelle));
            this.btnBilgiGüncelle = new System.Windows.Forms.Button();
            this.cmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.lblHastaCinsiyet = new System.Windows.Forms.Label();
            this.lblHastaSifre = new System.Windows.Forms.Label();
            this.mskTelefon = new System.Windows.Forms.MaskedTextBox();
            this.mskHastaTC = new System.Windows.Forms.MaskedTextBox();
            this.txtHastaSoyad = new System.Windows.Forms.TextBox();
            this.txtHastaAd = new System.Windows.Forms.TextBox();
            this.lblHastaTel = new System.Windows.Forms.Label();
            this.lblHastaTC = new System.Windows.Forms.Label();
            this.lblHastaSoyad = new System.Windows.Forms.Label();
            this.lblHastaAd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBilgiGüncelle
            // 
            this.btnBilgiGüncelle.BackColor = System.Drawing.Color.White;
            this.btnBilgiGüncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBilgiGüncelle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBilgiGüncelle.Location = new System.Drawing.Point(123, 259);
            this.btnBilgiGüncelle.Name = "btnBilgiGüncelle";
            this.btnBilgiGüncelle.Size = new System.Drawing.Size(75, 23);
            this.btnBilgiGüncelle.TabIndex = 25;
            this.btnBilgiGüncelle.Text = "Güncelle";
            this.btnBilgiGüncelle.UseVisualStyleBackColor = false;
            this.btnBilgiGüncelle.Click += new System.EventHandler(this.btnBilgiGüncelle_Click);
            // 
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.BackColor = System.Drawing.Color.White;
            this.cmbCinsiyet.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmbCinsiyet.FormattingEnabled = true;
            this.cmbCinsiyet.Items.AddRange(new object[] {
            "Kadın",
            "Erkek"});
            this.cmbCinsiyet.Location = new System.Drawing.Point(103, 220);
            this.cmbCinsiyet.Name = "cmbCinsiyet";
            this.cmbCinsiyet.Size = new System.Drawing.Size(121, 21);
            this.cmbCinsiyet.TabIndex = 6;
            // 
            // txtSifre
            // 
            this.txtSifre.BackColor = System.Drawing.Color.White;
            this.txtSifre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtSifre.Location = new System.Drawing.Point(103, 187);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(121, 20);
            this.txtSifre.TabIndex = 5;
            // 
            // lblHastaCinsiyet
            // 
            this.lblHastaCinsiyet.AutoSize = true;
            this.lblHastaCinsiyet.BackColor = System.Drawing.Color.White;
            this.lblHastaCinsiyet.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblHastaCinsiyet.Location = new System.Drawing.Point(52, 220);
            this.lblHastaCinsiyet.Name = "lblHastaCinsiyet";
            this.lblHastaCinsiyet.Size = new System.Drawing.Size(43, 13);
            this.lblHastaCinsiyet.TabIndex = 22;
            this.lblHastaCinsiyet.Text = "Cinsiyet";
            // 
            // lblHastaSifre
            // 
            this.lblHastaSifre.AutoSize = true;
            this.lblHastaSifre.BackColor = System.Drawing.Color.White;
            this.lblHastaSifre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblHastaSifre.Location = new System.Drawing.Point(64, 187);
            this.lblHastaSifre.Name = "lblHastaSifre";
            this.lblHastaSifre.Size = new System.Drawing.Size(31, 13);
            this.lblHastaSifre.TabIndex = 21;
            this.lblHastaSifre.Text = "Şifre:";
            // 
            // mskTelefon
            // 
            this.mskTelefon.BackColor = System.Drawing.Color.White;
            this.mskTelefon.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mskTelefon.Location = new System.Drawing.Point(103, 147);
            this.mskTelefon.Mask = "(999) 000-0000";
            this.mskTelefon.Name = "mskTelefon";
            this.mskTelefon.Size = new System.Drawing.Size(121, 20);
            this.mskTelefon.TabIndex = 4;
            // 
            // mskHastaTC
            // 
            this.mskHastaTC.BackColor = System.Drawing.Color.White;
            this.mskHastaTC.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mskHastaTC.Location = new System.Drawing.Point(103, 110);
            this.mskHastaTC.Mask = "00000000000";
            this.mskHastaTC.Name = "mskHastaTC";
            this.mskHastaTC.Size = new System.Drawing.Size(121, 20);
            this.mskHastaTC.TabIndex = 3;
            this.mskHastaTC.ValidatingType = typeof(int);
            // 
            // txtHastaSoyad
            // 
            this.txtHastaSoyad.BackColor = System.Drawing.Color.White;
            this.txtHastaSoyad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtHastaSoyad.Location = new System.Drawing.Point(103, 72);
            this.txtHastaSoyad.Name = "txtHastaSoyad";
            this.txtHastaSoyad.Size = new System.Drawing.Size(121, 20);
            this.txtHastaSoyad.TabIndex = 2;
            // 
            // txtHastaAd
            // 
            this.txtHastaAd.BackColor = System.Drawing.Color.White;
            this.txtHastaAd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtHastaAd.Location = new System.Drawing.Point(103, 37);
            this.txtHastaAd.Name = "txtHastaAd";
            this.txtHastaAd.Size = new System.Drawing.Size(121, 20);
            this.txtHastaAd.TabIndex = 1;
            // 
            // lblHastaTel
            // 
            this.lblHastaTel.AutoSize = true;
            this.lblHastaTel.BackColor = System.Drawing.Color.White;
            this.lblHastaTel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblHastaTel.Location = new System.Drawing.Point(49, 154);
            this.lblHastaTel.Name = "lblHastaTel";
            this.lblHastaTel.Size = new System.Drawing.Size(46, 13);
            this.lblHastaTel.TabIndex = 16;
            this.lblHastaTel.Text = "Telefon:";
            // 
            // lblHastaTC
            // 
            this.lblHastaTC.AutoSize = true;
            this.lblHastaTC.BackColor = System.Drawing.Color.White;
            this.lblHastaTC.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblHastaTC.Location = new System.Drawing.Point(54, 117);
            this.lblHastaTC.Name = "lblHastaTC";
            this.lblHastaTC.Size = new System.Drawing.Size(41, 13);
            this.lblHastaTC.TabIndex = 15;
            this.lblHastaTC.Text = "TC No:";
            // 
            // lblHastaSoyad
            // 
            this.lblHastaSoyad.AutoSize = true;
            this.lblHastaSoyad.BackColor = System.Drawing.Color.White;
            this.lblHastaSoyad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblHastaSoyad.Location = new System.Drawing.Point(55, 79);
            this.lblHastaSoyad.Name = "lblHastaSoyad";
            this.lblHastaSoyad.Size = new System.Drawing.Size(40, 13);
            this.lblHastaSoyad.TabIndex = 14;
            this.lblHastaSoyad.Text = "Soyad:";
            // 
            // lblHastaAd
            // 
            this.lblHastaAd.AutoSize = true;
            this.lblHastaAd.BackColor = System.Drawing.Color.White;
            this.lblHastaAd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblHastaAd.Location = new System.Drawing.Point(72, 37);
            this.lblHastaAd.Name = "lblHastaAd";
            this.lblHastaAd.Size = new System.Drawing.Size(23, 13);
            this.lblHastaAd.TabIndex = 13;
            this.lblHastaAd.Text = "Ad:";
            // 
            // Bilgi_Güncelle
            // 
            this.AcceptButton = this.btnBilgiGüncelle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(284, 332);
            this.Controls.Add(this.btnBilgiGüncelle);
            this.Controls.Add(this.cmbCinsiyet);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.lblHastaCinsiyet);
            this.Controls.Add(this.lblHastaSifre);
            this.Controls.Add(this.mskTelefon);
            this.Controls.Add(this.mskHastaTC);
            this.Controls.Add(this.txtHastaSoyad);
            this.Controls.Add(this.txtHastaAd);
            this.Controls.Add(this.lblHastaTel);
            this.Controls.Add(this.lblHastaTC);
            this.Controls.Add(this.lblHastaSoyad);
            this.Controls.Add(this.lblHastaAd);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Bilgi_Güncelle";
            this.Text = "Bilgi_Güncelle";
            this.Load += new System.EventHandler(this.Bilgi_Güncelle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBilgiGüncelle;
        private System.Windows.Forms.ComboBox cmbCinsiyet;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label lblHastaCinsiyet;
        private System.Windows.Forms.Label lblHastaSifre;
        private System.Windows.Forms.MaskedTextBox mskTelefon;
        private System.Windows.Forms.MaskedTextBox mskHastaTC;
        private System.Windows.Forms.TextBox txtHastaSoyad;
        private System.Windows.Forms.TextBox txtHastaAd;
        private System.Windows.Forms.Label lblHastaTel;
        private System.Windows.Forms.Label lblHastaTC;
        private System.Windows.Forms.Label lblHastaSoyad;
        private System.Windows.Forms.Label lblHastaAd;
    }
}