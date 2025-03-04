using FRMMhrsApp.Models;

namespace FRMMhrsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           

        }
        //public void ButonlarAktif()
        //{

        //    btnEkle.Enabled = true;
        //    btnSil.Enabled = true;
        //    btnGuncelle.Enabled = true;
        //    //if (string.IsNullOrWhiteSpace(txtBolumAdi.Text) || string.IsNullOrWhiteSpace(txtBolumAciklamasi.Text))
        //    //{
        //    //    btnEkle.Enabled = false;
        //    //}
        //    //else
        //    //{
        //    //    btnEkle.Enabled = true;
        //    //}
        //}
        //public void ButonlarPasif()
        //{

        //    btnEkle.Enabled = false;
        //    btnSil.Enabled = false;
        //    btnGuncelle.Enabled = false;
        //}

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
                //KontrolEt();
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

    }
}
