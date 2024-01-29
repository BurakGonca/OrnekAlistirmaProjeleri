using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaKonsolUygulamasi_OOP_Ornek
{
    internal class Sinema
    {
        public Sinema(string filmAdi, short kapasite, int tamBiletFiyati, int yarimBiletFiyati)
        {
            FilmAdi = filmAdi;
            Kapasite = kapasite;
            TamBiletFiyati = tamBiletFiyati;
            YarimBiletFiyati = yarimBiletFiyati;

        }

        public string FilmAdi { get; set; }
        public short Kapasite { get; set; }
        public int TamBiletFiyati { get; set; }
        public int YarimBiletFiyati { get; set; }


        public short TamBiletAdeti { get; set; }
        public short YarimBiletAdeti { get; set; }
        public float Ciro
        {
            get { return this.TamBiletAdeti * this.TamBiletFiyati + this.YarimBiletAdeti * this.YarimBiletFiyati; }

        }


        public short BosKoltukHesaplama()
        {
            return (short)(this.Kapasite - this.TamBiletAdeti - this.YarimBiletAdeti);
        }


        public void BiletSat(short _tamBilet, short _yarimBilet)
        {
            if (_tamBilet + _yarimBilet <= BosKoltukHesaplama())
            {
                this.TamBiletAdeti += _tamBilet;
                this.YarimBiletAdeti += _yarimBilet;
                Console.WriteLine("İslem gerceklestirildi");
            }
            else Console.WriteLine(BosKoltukHesaplama() + " adet bos koltuk oldugundan isleminiz gerceklestirilemiyor");
        }

        public void BiletIade(short _tamBilet, short _yarimBilet)
        {
            if (_tamBilet <= TamBiletAdeti && _yarimBilet <= YarimBiletAdeti)
            {
                this.TamBiletAdeti -= _tamBilet;
                this.YarimBiletAdeti -= _yarimBilet;
                Console.WriteLine("İslem gerceklestirildi");

            }
            else Console.WriteLine("Satılmış bilet adetinden fazla iade işlemi yapılamaz.");
        }


    }
}
