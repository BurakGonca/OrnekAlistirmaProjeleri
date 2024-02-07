using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulYonetim_OOP_Ornek
{
    internal class Ogrenci : IKisi
    {
        private string _Ad;
        private string _Soyad;
        private ushort _Yas;
        public IKisi.Cinsiyeti Cinsiyet { get; set; }

        public Ogrenci(string ad, string soyad, ushort yas)
        {
            _Ad = ad;
            _Soyad = soyad;
            _Yas = yas;

        }

        public string Ad
        {
            get
            {
                return _Ad;
            }

            set
            {
                if (_Ad == null || _Ad == string.Empty)
                {
                    _Ad = value;
                }
                else throw new ArgumentException("Ad zaten dolu");

            }
        }

        public string SoyAd
        {
            get
            {
                return _Soyad;
            }

            set
            {
                if (_Soyad == null || _Soyad == string.Empty)
                {
                    _Soyad = value;
                }
                else throw new ArgumentException("Soyad zaten dolu");

            }
        }
        public ushort Yas
        {
            get
            {
                return _Yas;
            }
            set
            {
                if (7 <= _Yas && _Yas <= 18)
                {
                    _Yas = value;
                }
                else throw new Exception("Ogrenci 7-18 yas aralaginda olmalidir");
            }
        }
    }
}
