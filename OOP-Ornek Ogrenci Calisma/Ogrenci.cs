using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Ornek_Ogrenci_Calisma
{
    internal class Ogrenci
    {
        private int ogrenciNo;
        private string isim;
        private string soyIsim;
        private ushort vize1;
        private ushort vize2;
        private ushort final;
        private string okulIsmi;

        public Ogrenci(int ogrenciNo, string isim, string soyIsim, ushort vize1, ushort vize2, ushort final, string okulIsmi)
        {
            this.ogrenciNo = ogrenciNo;
            this.isim = isim;
            this.soyIsim = soyIsim;
            this.vize1 = vize1;
            this.vize2 = vize2;
            this.final = final;
            this.okulIsmi = okulIsmi;
        }

        public void OgrenciBilgileriGoster()
        {
            Console.WriteLine("Ogrenci No: " + ogrenciNo);
            Console.WriteLine($"Isim/Soyisim: {isim} {soyIsim}");
            Console.WriteLine($"Vize1: {vize1} , Vize2: {vize2} ");
            Console.WriteLine("Final: " + final);
            Console.WriteLine("Okul ismi: " + okulIsmi);

        }

        public int OgrenciOrtalamasiBul()
        {
            int ortalamaNot = (int)(((vize1 + vize2) * 0.4) + (final * 0.6));

            return ortalamaNot;

        }

        public void okulGetir()
        {
            Console.WriteLine("Okul ismi: " + okulIsmi);
        }
    }
}
