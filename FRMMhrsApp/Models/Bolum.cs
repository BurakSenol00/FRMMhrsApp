using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FRMMhrsApp.Models
{
    public class Bolum
    {
        private string _adi;

        public string Adi
        {
            get { return _adi; }
            set
            {
                if (!Regex.IsMatch(value, @"^[a-zA-ZĞÜŞİÖÇğüşıöç]+$"))
                {
                    MessageBox.Show("Sadece Harflerden Oluşmalıdır", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

               _adi = value;
            }            
        }
        private string _aciklama;

        public string Aciklama
        {
            get { return _aciklama; }
            set
            {
                if (!Regex.IsMatch(value, @"^[a-zA-ZĞÜŞİÖÇğüşıöç]+$"))
                {
                    MessageBox.Show("Sadece Harflerden Oluşmalıdır", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                
                _aciklama = value;
            }
        }
        public override string ToString()
        {
            return Adi;
        }
    }
}
