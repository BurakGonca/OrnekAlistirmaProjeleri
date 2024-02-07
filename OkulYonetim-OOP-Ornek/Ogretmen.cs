using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulYonetim_OOP_Ornek
{
    internal class Ogretmen : IKisi
    {
        private string _Ad;
        private string _Soyad;
        private ushort _Yas;
        private Brans _Brans;
        private bool _Tecrube;

        public IKisi.Cinsiyeti Cinsiyet { get; set; }

        public Ogretmen(string ad, string soyad, ushort yas, Brans ogretmenBrans)
        {
            _Ad = ad;
            _Soyad = soyad;
            _Yas = yas;
            _Brans = ogretmenBrans;
            if (30 <= _Yas && _Yas <= 60)
            {
                _Tecrube = true;
            }

        }

        public bool OgretmenTecrube => _Tecrube;
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
                if (18 <= _Yas && _Yas <= 60)
                {
                    _Yas = value;
                }
                else throw new Exception("Ogretmen 18-60 yas aralaginda olmalidir");
            }
        }



        public Brans OgretmenBransi => _Brans;
    }
}
