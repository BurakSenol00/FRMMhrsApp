using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FRMMhrsApp.Models
{
    public class Randevu
    {
        public DateTime Tarih { get; set; }
        public Hasta Hasta { get; set; }
        public override string ToString()
        {
            return  Tarih+" "+Hasta;
        }
    }
}
