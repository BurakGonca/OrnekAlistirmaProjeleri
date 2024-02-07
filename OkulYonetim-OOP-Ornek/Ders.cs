using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulYonetim_OOP_Ornek
{
    internal class Ders
    {
        public Ders(string dersAdi, ushort dersSuresiDk, Brans dersinBransi)
        {
            DersAdi = dersAdi;
            DersSuresiDk = dersSuresiDk;
            DersinBransi = dersinBransi;
        }

        public string DersAdi { get; set; }
        public ushort DersSuresiDk { get; set; }
        public Brans DersinBransi { get; set; }




        public bool DersOlusabilirMi(Ders ders, Ogretmen ogretmen)
        {
            if (ders.DersinBransi == ogretmen.OgretmenBransi)
            {
                return true;
            }

            return false;
        }
    }
}
