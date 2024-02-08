using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoGaleri_OOP_OrnekKonsolUygulamasi
{
    public class Galeri 
    {
        List<Araba> _ArabaList = new List<Araba>();
        public List<Araba> ArabaList => _ArabaList;
        public Galeri(List<Araba> arabaListesi)
        {
            _ArabaList=arabaListesi;
        }

        public Galeri(string plaka, string marka, int kiralamaBedeli)
        {
            Plaka = plaka;
            Marka = marka;
            KiralamaBedeli = kiralamaBedeli;
        }

        public string Plaka { get; set; }

        public string Marka { get; set; }

        public int KiralamaBedeli { get; set; }

        
        public void ArabaEkle(List<Araba> list ,Araba araba)
        {
            list.Add(araba);
        }
    }
}
