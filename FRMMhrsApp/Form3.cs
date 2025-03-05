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
    public partial class Form3: Form
    {
        Doktor[] doktor;
        public Form3(Doktor[]doktorlarDizisi):this()
        {
            foreach (Doktor item in doktorlarDizisi)
            {

            }
        }
        public Form3()
        {
            InitializeComponent();

        }
            

    }
}
