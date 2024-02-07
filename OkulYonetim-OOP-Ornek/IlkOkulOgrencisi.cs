using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulYonetim_OOP_Ornek
{
    internal class IlkOkulOgrencisi : Ogrenci
    {
        public ushort Not1 { get; } //kurucu metodla baslangicta verilir sonradan degistirilemez,set kapalı
        public ushort Not2 { get; } //kurucu metodla baslangicta verilir sonradan degistirilemez,set kapalı


        public IKisi.Cinsiyeti IlkOkulOgrenciCinsiyeti { get; set; }


        public IlkOkulOgrencisi(string ad, string soyad, ushort yas, ushort not1, ushort not2) : base(ad, soyad, yas)
        {
            if (7 <= base.Yas && base.Yas <= 11)
                yas = base.Yas;
            else
                throw new ArgumentException("Ilkokul ogrencisi 7-11 yas araliginda olmalidir");
            if (0 <= not1 && not1 <= 100)
                Not1 = not1;
            else
                throw new ArgumentException("Not aralıgı 0-100 arasindadir");
            if (0 <= not2 && not2 <= 100)
                Not2 = not2;
            else
                throw new ArgumentException("Not aralıgı 0-100 arasindadir");


        }

        public float NotOrtalama()
        {
            float notOrtalama = (Not1 + Not2) / 2;
            return notOrtalama;
        }

    }
}
