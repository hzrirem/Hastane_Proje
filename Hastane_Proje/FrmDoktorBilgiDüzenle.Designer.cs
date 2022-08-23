
namespace Hastane_Proje
{
    partial class FrmDoktorBilgiDüzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoktorBilgiDüzenle));
            this.mskDoktorTC = new System.Windows.Forms.MaskedTextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.lblHastaTC = new System.Windows.Forms.Label();
            this.lblHastaSoyad = new System.Windows.Forms.Label();
            this.lblHastaAd = new System.Windows.Forms.Label();
            this.txtşifre = new System.Windows.Forms.TextBox();
            this.lblHastaSifre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBrans = new System.Windows.Forms.ComboBox();
            this.btnBilgiGüncelle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mskDoktorTC
            // 
            this.mskDoktorTC.BackColor = System.Drawing.Color.White;
            this.mskDoktorTC.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mskDoktorTC.Location = new System.Drawing.Point(107, 130);
            this.mskDoktorTC.Mask = "00000000000";
            this.mskDoktorTC.Name = "mskDoktorTC";
            this.mskDoktorTC.Size = new System.Drawing.Size(121, 23);
            this.mskDoktorTC.TabIndex = 25;
            this.mskDoktorTC.ValidatingType = typeof(int);
            // 
            // txtSoyad
            // 
            this.txtSoyad.BackColor = System.Drawing.Color.White;
            this.txtSoyad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtSoyad.Location = new System.Drawing.Point(107, 92);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(121, 23);
            this.txtSoyad.TabIndex = 24;
            // 
            // txtAd
            // 
            this.txtAd.BackColor = System.Drawing.Color.White;
            this.txtAd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtAd.Location = new System.Drawing.Point(107, 57);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(121, 23);
            this.txtAd.TabIndex = 23;
            // 
            // lblHastaTC
            // 
            this.lblHastaTC.AutoSize = true;
            this.lblHastaTC.BackColor = System.Drawing.Color.White;
            this.lblHastaTC.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblHastaTC.Location = new System.Drawing.Point(53, 137);
            this.lblHastaTC.Name = "lblHastaTC";
            this.lblHastaTC.Size = new System.Drawing.Size(48, 17);
            this.lblHastaTC.TabIndex = 22;
            this.lblHastaTC.Text = "TC No:";
            // 
            // lblHastaSoyad
            // 
            this.lblHastaSoyad.AutoSize = true;
            this.lblHastaSoyad.BackColor = System.Drawing.Color.White;
            this.lblHastaSoyad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblHastaSoyad.Location = new System.Drawing.Point(54, 99);
            this.lblHastaSoyad.Name = "lblHastaSoyad";
            this.lblHastaSoyad.Size = new System.Drawing.Size(47, 17);
            this.lblHastaSoyad.TabIndex = 21;
            this.lblHastaSoyad.Text = "Soyad:";
            // 
            // lblHastaAd
            // 
            this.lblHastaAd.AutoSize = true;
            this.lblHastaAd.BackColor = System.Drawing.Color.White;
            this.lblHastaAd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblHastaAd.Location = new System.Drawing.Point(74, 57);
            this.lblHastaAd.Name = "lblHastaAd";
            this.lblHastaAd.Size = new System.Drawing.Size(27, 17);
            this.lblHastaAd.TabIndex = 20;
            this.lblHastaAd.Text = "Ad:";
            // 
            // txtşifre
            // 
            this.txtşifre.BackColor = System.Drawing.Color.White;
            this.txtşifre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtşifre.Location = new System.Drawing.Point(107, 218);
            this.txtşifre.Name = "txtşifre";
            this.txtşifre.Size = new System.Drawing.Size(121, 23);
            this.txtşifre.TabIndex = 27;
            // 
            // lblHastaSifre
            // 
            this.lblHastaSifre.AutoSize = true;
            this.lblHastaSifre.BackColor = System.Drawing.Color.White;
            this.lblHastaSifre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblHastaSifre.Location = new System.Drawing.Point(64, 218);
            this.lblHastaSifre.Name = "lblHastaSifre";
            this.lblHastaSifre.Size = new System.Drawing.Size(37, 17);
            this.lblHastaSifre.TabIndex = 26;
            this.lblHastaSifre.Text = "Şifre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 28;
            this.label1.Text = "Branş:";
            // 
            // cmbBrans
            // 
            this.cmbBrans.FormattingEnabled = true;
            this.cmbBrans.Location = new System.Drawing.Point(107, 173);
            this.cmbBrans.Name = "cmbBrans";
            this.cmbBrans.Size = new System.Drawing.Size(121, 25);
            this.cmbBrans.TabIndex = 29;
            // 
            // btnBilgiGüncelle
            // 
            this.btnBilgiGüncelle.BackColor = System.Drawing.Color.White;
            this.btnBilgiGüncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBilgiGüncelle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBilgiGüncelle.Location = new System.Drawing.Point(122, 260);
            this.btnBilgiGüncelle.Name = "btnBilgiGüncelle";
            this.btnBilgiGüncelle.Size = new System.Drawing.Size(75, 23);
            this.btnBilgiGüncelle.TabIndex = 30;
            this.btnBilgiGüncelle.Text = "Güncelle";
            this.btnBilgiGüncelle.UseVisualStyleBackColor = false;
            this.btnBilgiGüncelle.Click += new System.EventHandler(this.btnBilgiGüncelle_Click);
            // 
            // FrmDoktorBilgiDüzenle
            // 
            this.AcceptButton = this.btnBilgiGüncelle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(301, 307);
            this.Controls.Add(this.btnBilgiGüncelle);
            this.Controls.Add(this.cmbBrans);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtşifre);
            this.Controls.Add(this.lblHastaSifre);
            this.Controls.Add(this.mskDoktorTC);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.lblHastaTC);
            this.Controls.Add(this.lblHastaSoyad);
            this.Controls.Add(this.lblHastaAd);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FrmDoktorBilgiDüzenle";
            this.Text = "FrmDoktorBilgiDüzenle";
            this.Load += new System.EventHandler(this.FrmDoktorBilgiDüzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mskDoktorTC;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label lblHastaTC;
        private System.Windows.Forms.Label lblHastaSoyad;
        private System.Windows.Forms.Label lblHastaAd;
        private System.Windows.Forms.TextBox txtşifre;
        private System.Windows.Forms.Label lblHastaSifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBrans;
        private System.Windows.Forms.Button btnBilgiGüncelle;
    }
}