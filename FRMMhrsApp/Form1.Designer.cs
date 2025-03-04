namespace FRMMhrsApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            txtBolumAdi = new TextBox();
            txtBolumAciklamasi = new TextBox();
            lstBolumler = new ListBox();
            btnGec = new Button();
            btnEkle = new Button();
            btnGuncelle = new Button();
            btnSil = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(12, 26);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 0;
            label1.Text = "Bölüm Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(12, 79);
            label2.Name = "label2";
            label2.Size = new Size(129, 20);
            label2.TabIndex = 0;
            label2.Text = "Bölüm Açıklaması";
            // 
            // txtBolumAdi
            // 
            txtBolumAdi.Location = new Point(157, 25);
            txtBolumAdi.Name = "txtBolumAdi";
            txtBolumAdi.Size = new Size(438, 27);
            txtBolumAdi.TabIndex = 1;
            // 
            // txtBolumAciklamasi
            // 
            txtBolumAciklamasi.Location = new Point(157, 71);
            txtBolumAciklamasi.Name = "txtBolumAciklamasi";
            txtBolumAciklamasi.Size = new Size(438, 27);
            txtBolumAciklamasi.TabIndex = 1;
            // 
            // lstBolumler
            // 
            lstBolumler.ForeColor = SystemColors.Desktop;
            lstBolumler.FormattingEnabled = true;
            lstBolumler.Location = new Point(3, 181);
            lstBolumler.Name = "lstBolumler";
            lstBolumler.Size = new Size(592, 144);
            lstBolumler.TabIndex = 2;
            // 
            // btnGec
            // 
            btnGec.BackColor = SystemColors.ButtonFace;
            btnGec.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnGec.Location = new Point(3, 341);
            btnGec.Name = "btnGec";
            btnGec.Size = new Size(592, 43);
            btnGec.TabIndex = 3;
            btnGec.Text = "Sonraki";
            btnGec.UseVisualStyleBackColor = false;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = SystemColors.ButtonFace;
            btnEkle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnEkle.Location = new Point(157, 117);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(132, 38);
            btnEkle.TabIndex = 3;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = SystemColors.ButtonFace;
            btnGuncelle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnGuncelle.Location = new Point(463, 117);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(132, 38);
            btnGuncelle.TabIndex = 3;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = false;
            // 
            // btnSil
            // 
            btnSil.BackColor = SystemColors.ButtonFace;
            btnSil.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSil.Location = new Point(317, 117);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(132, 38);
            btnSil.TabIndex = 3;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(612, 392);
            Controls.Add(btnSil);
            Controls.Add(btnGuncelle);
            Controls.Add(btnEkle);
            Controls.Add(btnGec);
            Controls.Add(lstBolumler);
            Controls.Add(txtBolumAciklamasi);
            Controls.Add(txtBolumAdi);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MHRS";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtBolumAdi;
        private TextBox txtBolumAciklamasi;
        private ListBox lstBolumler;
        private Button btnGec;
        private Button btnEkle;
        private Button btnGuncelle;
        private Button btnSil;
    }
}
