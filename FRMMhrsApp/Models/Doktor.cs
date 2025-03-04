using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FRMMhrsApp.Models
{
    public class Doktor
    {
        public string AdSoyad { get; set; }
        public string Telefon { get; set; }
        public Bolum Bolum { get; set; }

        public override string ToString()
        {
            return "Doktor Adı: " + AdSoyad + " Bölüm: " + Bolum + "Telefon: " + Telefon + " ";
        }
    }
}
