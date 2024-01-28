using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ogrenci_Yonetim_Ornegi
{
    internal class Ogrenci
    {
        public string Ad;
        public string Soyad;
        public string Sube;
        public int No;

        public Ogrenci(string ad, string soyad, string sube, int no)
        {
            Ad = ad;
            Soyad = soyad;
            Sube = sube;
            No = no;
        }
    }
}
