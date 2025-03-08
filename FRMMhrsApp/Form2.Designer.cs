namespace FRMMhrsApp
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            mskTelefon = new MaskedTextBox();
            cmbeklenenBolum = new ComboBox();
            txtDoktorAdi = new TextBox();
            lstDoktorlar = new ListBox();
            btnGuncelle = new Button();
            btnEkle = new Button();
            btnSil = new Button();
            btnGec = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(12, 84);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 0;
            label1.Text = "Bölüm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(12, 36);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 0;
            label2.Text = "Doktor Adı";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(12, 123);
            label3.Name = "label3";
            label3.Size = new Size(59, 20);
            label3.TabIndex = 0;
            label3.Text = "Telefon";
            // 
            // mskTelefon
            // 
            mskTelefon.Location = new Point(103, 120);
            mskTelefon.Mask = "(999) 000-0000";
            mskTelefon.Name = "mskTelefon";
            mskTelefon.Size = new Size(357, 27);
            mskTelefon.TabIndex = 1;
            // 
            // cmbeklenenBolum
            // 
            cmbeklenenBolum.FormattingEnabled = true;
            cmbeklenenBolum.Location = new Point(103, 76);
            cmbeklenenBolum.Name = "cmbeklenenBolum";
            cmbeklenenBolum.Size = new Size(357, 28);
            cmbeklenenBolum.TabIndex = 2;
            // 
            // txtDoktorAdi
            // 
            txtDoktorAdi.Location = new Point(103, 33);
            txtDoktorAdi.Name = "txtDoktorAdi";
            txtDoktorAdi.Size = new Size(357, 27);
            txtDoktorAdi.TabIndex = 3;
            // 
            // lstDoktorlar
            // 
            lstDoktorlar.FormattingEnabled = true;
            lstDoktorlar.Location = new Point(12, 163);
            lstDoktorlar.Name = "lstDoktorlar";
            lstDoktorlar.Size = new Size(448, 124);
            lstDoktorlar.TabIndex = 4;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnGuncelle.Location = new Point(329, 297);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(131, 45);
            btnGuncelle.TabIndex = 5;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnEkle
            // 
            btnEkle.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnEkle.Location = new Point(12, 297);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(131, 45);
            btnEkle.TabIndex = 5;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnSil
            // 
            btnSil.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSil.Location = new Point(170, 297);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(131, 45);
            btnSil.TabIndex = 5;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnGec
            // 
            btnGec.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnGec.Location = new Point(12, 348);
            btnGec.Name = "btnGec";
            btnGec.Size = new Size(448, 37);
            btnGec.TabIndex = 6;
            btnGec.Text = "Sonraki";
            btnGec.UseVisualStyleBackColor = true;
            btnGec.Click += btnGec_Click_1;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(480, 391);
            Controls.Add(btnGec);
            Controls.Add(btnSil);
            Controls.Add(btnEkle);
            Controls.Add(btnGuncelle);
            Controls.Add(lstDoktorlar);
            Controls.Add(txtDoktorAdi);
            Controls.Add(cmbeklenenBolum);
            Controls.Add(mskTelefon);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.ActiveCaptionText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Doktor";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private MaskedTextBox mskTelefon;
        private ComboBox cmbeklenenBolum;
        private TextBox txtDoktorAdi;
        private ListBox lstDoktorlar;
        private Button btnGuncelle;
        private Button btnEkle;
        private Button btnSil;
        private Button btnGec;
    }
}