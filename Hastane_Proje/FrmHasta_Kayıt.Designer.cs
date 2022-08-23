
namespace Hastane_Proje
{
    partial class FrmHasta_Kayıt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHasta_Kayıt));
            this.lblHastaAd = new System.Windows.Forms.Label();
            this.lblHastaSoyad = new System.Windows.Forms.Label();
            this.lblHastaTC = new System.Windows.Forms.Label();
            this.lblHastaTel = new System.Windows.Forms.Label();
            this.txtHastaAd = new System.Windows.Forms.TextBox();
            this.txtHastaSoyad = new System.Windows.Forms.TextBox();
            this.mskHastaTC = new System.Windows.Forms.MaskedTextBox();
            this.mskHastaTel = new System.Windows.Forms.MaskedTextBox();
            this.lblHastaSifre = new System.Windows.Forms.Label();
            this.lblHastaCinsiyet = new System.Windows.Forms.Label();
            this.txtHastaSifre = new System.Windows.Forms.TextBox();
            this.cmbHastaCinsiyet = new System.Windows.Forms.ComboBox();
            this.btnHastaKayıtol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHastaAd
            // 
            this.lblHastaAd.AutoSize = true;
            this.lblHastaAd.Location = new System.Drawing.Point(97, 50);
            this.lblHastaAd.Name = "lblHastaAd";
            this.lblHastaAd.Size = new System.Drawing.Size(23, 13);
            this.lblHastaAd.TabIndex = 0;
            this.lblHastaAd.Text = "Ad:";
            // 
            // lblHastaSoyad
            // 
            this.lblHastaSoyad.AutoSize = true;
            this.lblHastaSoyad.Location = new System.Drawing.Point(80, 92);
            this.lblHastaSoyad.Name = "lblHastaSoyad";
            this.lblHastaSoyad.Size = new System.Drawing.Size(40, 13);
            this.lblHastaSoyad.TabIndex = 1;
            this.lblHastaSoyad.Text = "Soyad:";
            // 
            // lblHastaTC
            // 
            this.lblHastaTC.AutoSize = true;
            this.lblHastaTC.Location = new System.Drawing.Point(79, 130);
            this.lblHastaTC.Name = "lblHastaTC";
            this.lblHastaTC.Size = new System.Drawing.Size(41, 13);
            this.lblHastaTC.TabIndex = 2;
            this.lblHastaTC.Text = "TC No:";
            // 
            // lblHastaTel
            // 
            this.lblHastaTel.AutoSize = true;
            this.lblHastaTel.Location = new System.Drawing.Point(74, 167);
            this.lblHastaTel.Name = "lblHastaTel";
            this.lblHastaTel.Size = new System.Drawing.Size(46, 13);
            this.lblHastaTel.TabIndex = 3;
            this.lblHastaTel.Text = "Telefon:";
            // 
            // txtHastaAd
            // 
            this.txtHastaAd.Location = new System.Drawing.Point(128, 50);
            this.txtHastaAd.Name = "txtHastaAd";
            this.txtHastaAd.Size = new System.Drawing.Size(121, 20);
            this.txtHastaAd.TabIndex = 1;
            // 
            // txtHastaSoyad
            // 
            this.txtHastaSoyad.Location = new System.Drawing.Point(128, 85);
            this.txtHastaSoyad.Name = "txtHastaSoyad";
            this.txtHastaSoyad.Size = new System.Drawing.Size(121, 20);
            this.txtHastaSoyad.TabIndex = 2;
            // 
            // mskHastaTC
            // 
            this.mskHastaTC.Location = new System.Drawing.Point(128, 123);
            this.mskHastaTC.Mask = "00000000000";
            this.mskHastaTC.Name = "mskHastaTC";
            this.mskHastaTC.Size = new System.Drawing.Size(121, 20);
            this.mskHastaTC.TabIndex = 3;
            this.mskHastaTC.ValidatingType = typeof(int);
            // 
            // mskHastaTel
            // 
            this.mskHastaTel.Location = new System.Drawing.Point(128, 160);
            this.mskHastaTel.Mask = "(999) 000-0000";
            this.mskHastaTel.Name = "mskHastaTel";
            this.mskHastaTel.Size = new System.Drawing.Size(121, 20);
            this.mskHastaTel.TabIndex = 4;
            // 
            // lblHastaSifre
            // 
            this.lblHastaSifre.AutoSize = true;
            this.lblHastaSifre.Location = new System.Drawing.Point(89, 200);
            this.lblHastaSifre.Name = "lblHastaSifre";
            this.lblHastaSifre.Size = new System.Drawing.Size(31, 13);
            this.lblHastaSifre.TabIndex = 8;
            this.lblHastaSifre.Text = "Şifre:";
            // 
            // lblHastaCinsiyet
            // 
            this.lblHastaCinsiyet.AutoSize = true;
            this.lblHastaCinsiyet.Location = new System.Drawing.Point(77, 233);
            this.lblHastaCinsiyet.Name = "lblHastaCinsiyet";
            this.lblHastaCinsiyet.Size = new System.Drawing.Size(43, 13);
            this.lblHastaCinsiyet.TabIndex = 9;
            this.lblHastaCinsiyet.Text = "Cinsiyet";
            // 
            // txtHastaSifre
            // 
            this.txtHastaSifre.Location = new System.Drawing.Point(128, 200);
            this.txtHastaSifre.Name = "txtHastaSifre";
            this.txtHastaSifre.Size = new System.Drawing.Size(121, 20);
            this.txtHastaSifre.TabIndex = 5;
            this.txtHastaSifre.UseSystemPasswordChar = true;
            // 
            // cmbHastaCinsiyet
            // 
            this.cmbHastaCinsiyet.FormattingEnabled = true;
            this.cmbHastaCinsiyet.Items.AddRange(new object[] {
            "Kadın",
            "Erkek"});
            this.cmbHastaCinsiyet.Location = new System.Drawing.Point(128, 233);
            this.cmbHastaCinsiyet.Name = "cmbHastaCinsiyet";
            this.cmbHastaCinsiyet.Size = new System.Drawing.Size(121, 21);
            this.cmbHastaCinsiyet.TabIndex = 6;
            // 
            // btnHastaKayıtol
            // 
            this.btnHastaKayıtol.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHastaKayıtol.Location = new System.Drawing.Point(148, 272);
            this.btnHastaKayıtol.Name = "btnHastaKayıtol";
            this.btnHastaKayıtol.Size = new System.Drawing.Size(75, 23);
            this.btnHastaKayıtol.TabIndex = 12;
            this.btnHastaKayıtol.Text = "Kayıt Ol";
            this.btnHastaKayıtol.UseVisualStyleBackColor = true;
            this.btnHastaKayıtol.Click += new System.EventHandler(this.btnHastaKayıtol_Click);
            // 
            // FrmHasta_Kayıt
            // 
            this.AcceptButton = this.btnHastaKayıtol;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(367, 324);
            this.Controls.Add(this.btnHastaKayıtol);
            this.Controls.Add(this.cmbHastaCinsiyet);
            this.Controls.Add(this.txtHastaSifre);
            this.Controls.Add(this.lblHastaCinsiyet);
            this.Controls.Add(this.lblHastaSifre);
            this.Controls.Add(this.mskHastaTel);
            this.Controls.Add(this.mskHastaTC);
            this.Controls.Add(this.txtHastaSoyad);
            this.Controls.Add(this.txtHastaAd);
            this.Controls.Add(this.lblHastaTel);
            this.Controls.Add(this.lblHastaTC);
            this.Controls.Add(this.lblHastaSoyad);
            this.Controls.Add(this.lblHastaAd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmHasta_Kayıt";
            this.Text = "Hasta Kayıt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHastaAd;
        private System.Windows.Forms.Label lblHastaSoyad;
        private System.Windows.Forms.Label lblHastaTC;
        private System.Windows.Forms.Label lblHastaTel;
        private System.Windows.Forms.TextBox txtHastaAd;
        private System.Windows.Forms.TextBox txtHastaSoyad;
        private System.Windows.Forms.MaskedTextBox mskHastaTC;
        private System.Windows.Forms.MaskedTextBox mskHastaTel;
        private System.Windows.Forms.Label lblHastaSifre;
        private System.Windows.Forms.Label lblHastaCinsiyet;
        private System.Windows.Forms.TextBox txtHastaSifre;
        private System.Windows.Forms.ComboBox cmbHastaCinsiyet;
        private System.Windows.Forms.Button btnHastaKayıtol;
    }
}