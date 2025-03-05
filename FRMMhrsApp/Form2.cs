using FRMMhrsApp.Models;

namespace FRMMhrsApp
{
    public partial class Form2 : Form
    {
        Bolum[] bolumleriTasi;
        public Form2(Bolum[] bolumler)
        {
            InitializeComponent();
            bolumleriTasi = bolumler;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            cmbeklenenBolum.DataSource = bolumleriTasi;
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDoktorAdi.Text) || string.IsNullOrWhiteSpace(mskTelefon.Text))
            {
                MessageBox.Show("Boşlukları Doldurunuz!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtDoktorAdi.Text.All(char.IsDigit))
            {
                MessageBox.Show("Ad Soyad Sadece Harflerden Oluşmalıdır", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cmbeklenenBolum.SelectedItem == null)
            {
                MessageBox.Show("Lütfen Bölüm Seçiniz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Doktor doktor = new Doktor()
            {
                AdSoyad = txtDoktorAdi.Text,
                Telefon = mskTelefon.Text,
                Bolum = (Bolum)cmbeklenenBolum.SelectedItem
            };
            lstDoktorlar.Items.Add(doktor);
            Temizle();
            MessageBox.Show("Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void Temizle()
        {
            txtDoktorAdi.Text = mskTelefon.Text = cmbeklenenBolum.Text = string.Empty;
        }
    }
}
