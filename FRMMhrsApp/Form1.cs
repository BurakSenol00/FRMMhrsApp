using FRMMhrsApp.Models;

namespace FRMMhrsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtBolumAdi.Select();
            txtBolumAdi.Focus();
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtBolumAdi.Text) || string.IsNullOrWhiteSpace(txtBolumAciklamasi.Text))
                {
                    MessageBox.Show("Boþluklarý Doldurun!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Bolum bolum = new Bolum()
                {
                    Adi = txtBolumAdi.Text,
                    Aciklama = txtBolumAciklamasi.Text
                };
                lstBolumler.Items.Add(bolum);
                Temizle();

                MessageBox.Show("Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Temizle()
        {
            txtBolumAdi.Text = string.Empty;
            txtBolumAciklamasi.Text = string.Empty;
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstBolumler.SelectedItem == null)
                {
                    MessageBox.Show("Lütfen Seçim yapýnýz");
                }
                lstBolumler.Items.Remove(lstBolumler.SelectedItem);
                MessageBox.Show("Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (lstBolumler.SelectedItem == null)
            {
                MessageBox.Show("Lütfen Seçim Yapýnýz!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Bolum secilenBolum = lstBolumler.SelectedItem as Bolum;
            secilenBolum.Adi = txtBolumAdi.Text;
            secilenBolum.Aciklama = txtBolumAciklamasi.Text;
            lstBolumler.Items[lstBolumler.SelectedIndex] = secilenBolum;
            Temizle();
            MessageBox.Show("Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSonraki_Click(object sender, EventArgs e)
        {
            Bolum[] bolum = new Bolum[0];

            foreach (Bolum item in lstBolumler.Items)
            {
                Array.Resize(ref bolum, bolum.Length + 1);
                bolum[bolum.Length - 1] = item;
            }
            Form2 form2 = new Form2(bolum);
            form2.Show();
        }
    }
}
