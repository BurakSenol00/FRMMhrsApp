using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FRMMhrsApp.Models;

namespace FRMMhrsApp
{
    public partial class Form3 : Form
    {
        Doktor[] doktor;
        public Form3(Doktor[] doktorlarDizisi) : this()
        {
            foreach (Doktor item in doktorlarDizisi)
            {
                cmbDoktor.Items.Add(item);
            }
        }
        public Form3()
        {
            InitializeComponent();
        }
        private void btnRandevuOlustur_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAdSoyad.Text) || string.IsNullOrWhiteSpace(txtSikayet.Text))
            {
                MessageBox.Show("Boşlukları Doldurunuz!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (dtpTarih.Value < DateTime.Today)
            {
                MessageBox.Show("Geçersiz Tarih", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Hasta hasta = new Hasta()
            {
                AdSoyad = txtAdSoyad.Text,
                Sikayet = txtSikayet.Text,
                Doktor = cmbDoktor.SelectedItem as Doktor
            };
            Randevu randevu = new Randevu()
            {
                Hasta = hasta,
                Tarih = dtpTarih.Value.Date
            };
            lstRandevular.Items.Add(randevu);
            MessageBox.Show("Randevu Oluşturuldu", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Temizle();
        }

        private void Temizle()
        {
            txtAdSoyad.Text = txtSikayet.Text = string.Empty;
        }

        private void btnTumRandevular_Click(object sender, EventArgs e)
        {
            Randevu[] randevu = new Randevu[lstRandevular.Items.Count];
            lstRandevular.Items.CopyTo(randevu, 0);

            Form4 form4 = new Form4(randevu);
            form4.ShowDialog();
            
        }
    }
}
