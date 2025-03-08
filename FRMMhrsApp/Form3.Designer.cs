namespace FRMMhrsApp
{
    partial class Form3
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtAdSoyad = new TextBox();
            dtpTarih = new DateTimePicker();
            btnTumRandevular = new Button();
            btnRandevuOlustur = new Button();
            cmbDoktor = new ComboBox();
            lstRandevular = new ListBox();
            txtSikayet = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(24, 18);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 0;
            label1.Text = "Ad Soyad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(53, 114);
            label2.Name = "label2";
            label2.Size = new Size(43, 20);
            label2.TabIndex = 0;
            label2.Text = "Tarih";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(39, 63);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 0;
            label3.Text = "Doktor";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(9, 152);
            label4.Name = "label4";
            label4.Size = new Size(104, 20);
            label4.TabIndex = 0;
            label4.Text = "Hasta Şikayeti";
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(117, 18);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(250, 27);
            txtAdSoyad.TabIndex = 1;
            // 
            // dtpTarih
            // 
            dtpTarih.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            dtpTarih.Location = new Point(117, 107);
            dtpTarih.Name = "dtpTarih";
            dtpTarih.Size = new Size(250, 27);
            dtpTarih.TabIndex = 2;
            // 
            // btnTumRandevular
            // 
            btnTumRandevular.BackColor = SystemColors.ButtonFace;
            btnTumRandevular.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnTumRandevular.Location = new Point(9, 413);
            btnTumRandevular.Name = "btnTumRandevular";
            btnTumRandevular.Size = new Size(358, 43);
            btnTumRandevular.TabIndex = 3;
            btnTumRandevular.Text = "Randevuları Görüntüle";
            btnTumRandevular.UseVisualStyleBackColor = false;
            btnTumRandevular.Click += btnTumRandevular_Click;
            // 
            // btnRandevuOlustur
            // 
            btnRandevuOlustur.BackColor = SystemColors.ButtonFace;
            btnRandevuOlustur.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnRandevuOlustur.Location = new Point(117, 262);
            btnRandevuOlustur.Name = "btnRandevuOlustur";
            btnRandevuOlustur.Size = new Size(257, 35);
            btnRandevuOlustur.TabIndex = 4;
            btnRandevuOlustur.Text = "Randevu Oluştur";
            btnRandevuOlustur.UseVisualStyleBackColor = false;
            btnRandevuOlustur.Click += btnRandevuOlustur_Click;
            // 
            // cmbDoktor
            // 
            cmbDoktor.FormattingEnabled = true;
            cmbDoktor.Location = new Point(117, 63);
            cmbDoktor.Name = "cmbDoktor";
            cmbDoktor.Size = new Size(250, 28);
            cmbDoktor.TabIndex = 5;
            // 
            // lstRandevular
            // 
            lstRandevular.FormattingEnabled = true;
            lstRandevular.Location = new Point(12, 303);
            lstRandevular.Name = "lstRandevular";
            lstRandevular.Size = new Size(362, 104);
            lstRandevular.TabIndex = 6;
            // 
            // txtSikayet
            // 
            txtSikayet.Location = new Point(117, 152);
            txtSikayet.Multiline = true;
            txtSikayet.Name = "txtSikayet";
            txtSikayet.Size = new Size(257, 104);
            txtSikayet.TabIndex = 1;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(388, 468);
            Controls.Add(lstRandevular);
            Controls.Add(cmbDoktor);
            Controls.Add(btnRandevuOlustur);
            Controls.Add(btnTumRandevular);
            Controls.Add(dtpTarih);
            Controls.Add(txtSikayet);
            Controls.Add(txtAdSoyad);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlText;
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtAdSoyad;
        private DateTimePicker dtpTarih;
        private Button btnTumRandevular;
        private Button btnRandevuOlustur;
        private ComboBox cmbDoktor;
        private ListBox lstRandevular;
        private TextBox txtSikayet;
    }
}