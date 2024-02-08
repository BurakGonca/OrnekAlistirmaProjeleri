using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace OtoGaleri_OOP_OrnekKonsolUygulamasi
{
    public class Galeri
    {
        private List<Araba> _tumArabaListesi = new List<Araba>();
        private List<Araba> _kiradakiArabaListesi = new List<Araba>();
        private List<Araba> _galeridekiArabaListesi = new List<Araba>();
        

        public void TumArabalariListele()
        {
            Console.WriteLine("\nPlaka".PadRight(11)+"Marka".PadRight(10)+"K.Bedeli".PadRight(12)+"Araba Tipi".PadRight(16)+"K. Sayısı".PadRight(15)+                "Durum".PadRight(10));
            Console.WriteLine("-----------------------------------------------------------------------");
            foreach (var item in _tumArabaListesi)
            {
                Console.WriteLine(item.Plaka.PadRight(10) + item.Marka.PadRight(10) + item.KiralamaBedeli.ToString().PadRight(12) + item.ArabaTipi.ToString().PadRight(10));
            }
        }
        public void GaleridekiArabalariListele()
        {
            Console.WriteLine("\nPlaka".PadRight(11) + "Marka".PadRight(10) + "K.Bedeli".PadRight(12) + "Araba Tipi".PadRight(16) + "K. Sayısı".PadRight(15) + "Durum".PadRight(10));
            Console.WriteLine("-----------------------------------------------------------------------");
            foreach (var item in _galeridekiArabaListesi)
            {
                Console.WriteLine(item.Plaka.PadRight(10) + item.Marka.PadRight(10) + item.KiralamaBedeli.ToString().PadRight(12) + item.ArabaTipi.ToString().PadRight(10));
            }
        }
        public void KiradakiArabalariListele()
        {
            Console.WriteLine("\nPlaka".PadRight(11) + "Marka".PadRight(10) + "K.Bedeli".PadRight(12) + "Araba Tipi".PadRight(16) + "K. Sayısı".PadRight(15) + "Durum".PadRight(10));
            Console.WriteLine("-----------------------------------------------------------------------");
            foreach (var item in _kiradakiArabaListesi)
            {
                Console.WriteLine(item.Plaka.PadRight(10) + item.Marka.PadRight(10) + item.KiralamaBedeli.ToString().PadRight(12) + item.ArabaTipi.ToString().PadRight(10));
            }
        }
        public void GaleriArabaEkle(Araba araba)
        {
            _tumArabaListesi.Add(araba);
        }
        public void GaleriArabaSil(Araba araba)
        {
            _tumArabaListesi.Remove(araba);
        }

        public void SahteVeriEkle()
        {
            Araba fiat = new Araba("06TPN30", "FIAT", 200, Araba.ArabaTip.SUV);
            Araba renault = new Araba("35KB0441", "RENAULT", 300, Araba.ArabaTip.Hatchback);
            Araba citroen = new Araba("34T3434", "CITROEN", 250, Araba.ArabaTip.Sedan);
            Araba opel = new Araba("06VHA27", "OPEL", 200, Araba.ArabaTip.Hatchback);

            GaleriArabaEkle(fiat);
            GaleriArabaEkle(renault);
            GaleriArabaEkle(citroen);
            GaleriArabaEkle(opel);
        }

    }
}


