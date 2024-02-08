using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoGaleri_OOP_OrnekKonsolUygulamasi
{
    public class Araba : Galeri
    {
        private string _Plaka;
        private string _Marka;
        private int _KiralamaBedeli;
        private ArabaTip _ArabaTipi;

        public Araba(List<Araba> arabaListesi , string plaka) : base(arabaListesi)
        {
            List<Araba> ArabaListesi = arabaListesi;
            _Plaka
        } //devam et

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
    }
}
