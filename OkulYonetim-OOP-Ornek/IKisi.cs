using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulYonetim_OOP_Ornek
{
    internal interface IKisi
    {
        public string Ad { get; }
        public string SoyAd { get; }
        public ushort Yas { get; set; }
        public Cinsiyeti Cinsiyet { get; set; }

        public enum Cinsiyeti
        {
            Kadın = 1,
            Erkek
        }
    }
}
