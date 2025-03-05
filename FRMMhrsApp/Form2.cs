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
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lstDoktorlar.SelectedItem == null)
            {
                MessageBox.Show("Lütfen Seçim Yapınız!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            lstDoktorlar.Items.Remove(lstDoktorlar.SelectedItem);
            MessageBox.Show("Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (lstDoktorlar.SelectedItem == null)
            {
                MessageBox.Show("Lütfen Seçim Yapınız", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtDoktorAdi.Text))
            {
                MessageBox.Show("Doktor Adı Boş Olamaz!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtDoktorAdi.Text.All(char.IsDigit))
            {
                MessageBox.Show("Lütfen Sadece Harf Giriniz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Doktor doktor = lstDoktorlar.SelectedItem as Doktor;
            doktor.AdSoyad = txtDoktorAdi.Text;
            doktor.Telefon = mskTelefon.Text;
            lstDoktorlar.Items[lstDoktorlar.SelectedIndex] = doktor;
            Temizle();
            MessageBox.Show("Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGec_Click(object sender, EventArgs e)
        {
            Doktor[] doktorlar = new Doktor[0];
            foreach (Doktor item in lstDoktorlar.Items)
            {
                Array.Resize(ref doktorlar, doktorlar.Length + 1);
                doktorlar[doktorlar.Length - 1] = item;
            }
            Form3 form3 = new Form3(doktorlar);
            form3.Show();

        }
    }
}
