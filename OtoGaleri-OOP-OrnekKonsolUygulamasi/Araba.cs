using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoGaleri_OOP_OrnekKonsolUygulamasi
{
    public class Araba
    {
        private string _Plaka;
        private string _Marka;
        private int _KiralamaBedeli;
        private ArabaTip _ArabaTipi;

        public Araba(string plaka, string marka, int kiralamaBedeli, ArabaTip arabaTipi)
        {
            _Plaka = plaka;
            _Marka = marka;
            _KiralamaBedeli = kiralamaBedeli;
            _ArabaTipi = arabaTipi;
        }

        public int KiralamaBedeli => _KiralamaBedeli;
        public string Plaka => _Plaka;
        public string Marka => _Marka;
        public ArabaTip ArabaTipi => _ArabaTipi;
        public enum ArabaTip
        {
            SUV = 1,
            Hatchback,
            Sedan
        }

        //henüz kullanmadım
        public Araba VeriEkle(string sahtePlaka, string sahteMarka, int sahteKiralamaBedeli, ArabaTip sahteArabaTipi)
        {
            string plaka = sahtePlaka;
            string marka = sahteMarka;
            int kiralamaBedeli = sahteKiralamaBedeli;
            ArabaTip arabaTipi = sahteArabaTipi;
            Araba araba = new Araba(plaka,marka, kiralamaBedeli,arabaTipi);
            return araba;
        }

    }
}
