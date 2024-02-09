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
        private ushort _KiralamaSayisi;
        private ArabaTip _ArabaTipi;

        public Araba(string plaka, string marka, int kiralamaBedeli, ArabaTip arabaTipi)
        {
            _Plaka = plaka;
            _Marka = marka;
            _KiralamaBedeli = kiralamaBedeli;
            _ArabaTipi = arabaTipi;
            ArabaDurumu = ArabaDurum.Galeride;
            _KiralamaSayisi = 0;
        }

        public string Plaka => _Plaka;
        public string Marka => _Marka;
        public int KiralamaBedeli => _KiralamaBedeli;
        public ushort KiralamaSayisi { get; set; }
        public ArabaTip ArabaTipi => _ArabaTipi;
        public ArabaDurum ArabaDurumu { get; set; }
        public enum ArabaTip
        {
            SUV = 1,
            Hatchback,
            Sedan
        }
        public enum ArabaDurum
        {
            Kirada,
            Galeride
        }
        
        

    }
}
