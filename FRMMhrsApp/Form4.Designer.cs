namespace FRMMhrsApp
{
    partial class Form4
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
            dtpBaslangic = new DateTimePicker();
            dtpBitis = new DateTimePicker();
            lvRaporListesi = new ListView();
            SuspendLayout();
            // 
            // dtpBaslangic
            // 
            dtpBaslangic.Location = new Point(12, 35);
            dtpBaslangic.Name = "dtpBaslangic";
            dtpBaslangic.Size = new Size(250, 27);
            dtpBaslangic.TabIndex = 0;
            dtpBaslangic.ValueChanged += dtpBaslangic_ValueChanged;
            // 
            // dtpBitis
            // 
            dtpBitis.Location = new Point(318, 35);
            dtpBitis.Name = "dtpBitis";
            dtpBitis.Size = new Size(250, 27);
            dtpBitis.TabIndex = 0;
            dtpBitis.ValueChanged += dtpBitis_ValueChanged;
            // 
            // lvRaporListesi
            // 
            lvRaporListesi.Location = new Point(12, 83);
            lvRaporListesi.Name = "lvRaporListesi";
            lvRaporListesi.Size = new Size(556, 222);
            lvRaporListesi.TabIndex = 1;
            lvRaporListesi.UseCompatibleStateImageBehavior = false;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(586, 322);
            Controls.Add(lvRaporListesi);
            Controls.Add(dtpBitis);
            Controls.Add(dtpBaslangic);
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            ResumeLayout(false);
        }

        #endregion

        private DateTimePicker dtpBaslangic;
        private DateTimePicker dtpBitis;
        private ListView lvRaporListesi;
    }
}