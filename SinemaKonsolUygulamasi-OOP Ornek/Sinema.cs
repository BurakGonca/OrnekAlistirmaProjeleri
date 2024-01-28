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

        public short BosKoltukSayisi()
        {
            return (short)(this.Kapasite - this.TamBiletAdeti - this.YarimBiletAdeti);
        }

        public float Ciro()
        {
            return (float)(this.TamBiletAdeti * this.TamBiletFiyati) + (this.YarimBiletAdeti * this.YarimBiletFiyati);
        }







    }
}
