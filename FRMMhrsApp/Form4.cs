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

    public partial class Form4 : Form
    {
        private Randevu[] randevular;
        public Form4(Randevu[] randevuDizisi)
        {
            InitializeComponent();
            randevular = randevuDizisi;
            ListeyiGuncelle(DateTime.Today, DateTime.Today);
        }
        private void ListeyiGuncelle(DateTime baslangicTarihi, DateTime bitisTarihi)
        {
            lvRaporListesi.Items.Clear();

            var filtrelenmisRandevu = randevular.Where(r => r.Tarih.Date >= baslangicTarihi && r.Tarih.Date <= bitisTarihi).ToList();

            foreach (var item in filtrelenmisRandevu)
            {
                ListViewItem listViewItem = new ListViewItem(item.Hasta.AdSoyad);
                listViewItem.SubItems.Add(item.Hasta.Doktor.Bolum.ToString());
                listViewItem.SubItems.Add(item.Hasta.Doktor.ToString());
                listViewItem.SubItems.Add(item.Hasta.Sikayet.ToString());
                listViewItem.SubItems.Add(item.Tarih.ToShortTimeString());
                lvRaporListesi.Items.Add(listViewItem);
            }
        }

        private void dtpBaslangic_ValueChanged(object sender, EventArgs e)
        {
            ListeyiGuncelle(dtpBaslangic.Value.Date, dtpBitis.Value.Date);
        }

        private void dtpBitis_ValueChanged(object sender, EventArgs e)
        {
            ListeyiGuncelle(dtpBaslangic.Value.Date, dtpBitis.Value.Date);
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            lvRaporListesi.View = View.Details;
            lvRaporListesi.GridLines = true;
            lvRaporListesi.Columns.Add("Hasta Adı Soyadı", 160);
            lvRaporListesi.Columns.Add("Bölüm Adı ", 160);
            lvRaporListesi.Columns.Add("Doktor Adı Soyadı", 160);
            lvRaporListesi.Columns.Add("Şikayet", 160);
            lvRaporListesi.Columns.Add("Tarih", 160);
        }
    }

}
