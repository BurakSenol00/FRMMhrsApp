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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            listBox1 = new ListBox();
            btnGec = new Button();
            btnEkle = new Button();
            btnGuncelle = new Button();
            btnSil = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 25);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 0;
            label1.Text = "Bölüm Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 78);
            label2.Name = "label2";
            label2.Size = new Size(127, 20);
            label2.TabIndex = 0;
            label2.Text = "Bölüm Açıklaması";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(157, 25);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(438, 27);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(157, 71);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(438, 27);
            textBox2.TabIndex = 1;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(3, 201);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(592, 124);
            listBox1.TabIndex = 2;
            // 
            // btnGec
            // 
            btnGec.Location = new Point(3, 341);
            btnGec.Name = "btnGec";
            btnGec.Size = new Size(592, 43);
            btnGec.TabIndex = 3;
            btnGec.Text = "Sonraki";
            btnGec.UseVisualStyleBackColor = true;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(157, 117);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(132, 38);
            btnEkle.TabIndex = 3;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(463, 117);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(132, 38);
            btnGuncelle.TabIndex = 3;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(317, 117);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(132, 38);
            btnSil.TabIndex = 3;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(612, 392);
            Controls.Add(btnSil);
            Controls.Add(btnGuncelle);
            Controls.Add(btnEkle);
            Controls.Add(btnGec);
            Controls.Add(listBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private ListBox listBox1;
        private Button btnGec;
        private Button btnEkle;
        private Button btnGuncelle;
        private Button btnSil;
    }
}
