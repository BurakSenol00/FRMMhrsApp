using FRMMhrsApp.Models;

namespace FRMMhrsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtBolumAdi.Text)||string.IsNullOrWhiteSpace(txtBolumAciklamasi.Text))
            {
                MessageBox.Show("Lütfen Boþluklarý Doldurunuz");
                return;
            }
            Bolum bolum = new Bolum()
            {
                Adi = txtBolumAdi.Text,
                Aciklama = txtBolumAciklamasi.Text

            };
            lstBolumler.Items.Add(bolum);
            Temizle();
            MessageBox.Show("Bölüm Eklendi");
        }
        public void Temizle()
        {
            txtBolumAdi.Text = string.Empty;
            txtBolumAciklamasi.Text = string.Empty;
        }
    }
}
