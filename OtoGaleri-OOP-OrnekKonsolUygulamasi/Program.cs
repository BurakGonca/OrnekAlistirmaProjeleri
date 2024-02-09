using System.ComponentModel.Design;
using System.Runtime.CompilerServices;

namespace OtoGaleri_OOP_OrnekKonsolUygulamasi
{

    internal class Program
    {
        static Galeri galeri = new Galeri();
        static void Main(string[] args)
        {

            Calistir();

        }
        public static void Calistir()
        {
            galeri.SahteVeriEkle();
            bool kontrol = true;
            while (kontrol)
            {
                Menu();
                switch (SecimAl())
                {
                    case "1":
                    case "K":
                        ArabaKirala();
                        break;
                    case "2":
                    case "T":
                        ArabaTeslimAl();
                        break;
                    case "3":
                    case "R":
                        KiradakiArabalariListele();
                        break;
                    case "4":
                    case "M":
                        GaleridekiArabalariListele();
                        break;
                    case "5":
                    case "A":
                        TümArabalariListele();
                        break;
                    case "6":
                    case "I":
                        KiralamaIptali();
                        break;
                    case "7":
                    case "Y":
                        ArabaEkle();
                        break;
                    case "8":
                    case "S":
                        ArabaSil();
                        break;
                    case "9":
                    case "G":
                        BilgileriGoster();
                        break;
                    case "10":
                    case "X":
                        kontrol = false;
                        break;
                    default:

                        Console.WriteLine("Hatalı işlem gerçekleştirildi. Tekrar deneyin.");
                        break;
                }
            }


        }

        private static void ArabaTeslimAl()
        {
            throw new NotImplementedException();
        }
        private static void BilgileriGoster()
        {
            throw new NotImplementedException();
        }
        private static void ArabaSil()
        {
            throw new NotImplementedException();
        }
        private static void ArabaEkle()
        {
            Console.Write("Plaka: ");
            string plaka = Console.ReadLine();
            Console.Write("\nMarka: ");
            string marka = Console.ReadLine();
            Console.Write("\nKiralama Bedeli: ");
            int kiralamaBedeli = int.Parse(Console.ReadLine());

            Console.WriteLine("Araba Tipi (1: SUV, 2: Hatchback, 3: Sedan): ");
            byte secim = byte.Parse(Console.ReadLine());
            Araba.ArabaTip arabaTipi = Araba.ArabaTip.Sedan;
            switch (secim)
            {
                case 1:
                    arabaTipi = Araba.ArabaTip.SUV;
                    break;
                case 2:
                    arabaTipi = Araba.ArabaTip.Hatchback;
                    break;
                case 3:
                    arabaTipi = Araba.ArabaTip.Sedan;
                    break;
                default:
                    Console.WriteLine("Yanlis Araba Tipi Secimi Yaptiniz.");
                    break;
            }

            Araba yeniAraba = new Araba(plaka, marka, kiralamaBedeli, arabaTipi);
            galeri.GaleriArabaEkle(yeniAraba);

        }
        private static void KiralamaIptali()
        {
            throw new NotImplementedException();
        }
        private static void TümArabalariListele()
        {
            galeri.TumArabalariListele();
        }
        private static void GaleridekiArabalariListele()
        {
            galeri.GaleridekiArabalariListele();
        }
        private static void KiradakiArabalariListele()
        {
            galeri.KiradakiArabalariListele();
        }
        private static void ArabaKirala()
        {
            Console.WriteLine("-Araba Kirala-");
            Console.Write("\nKiralanacak arabanın plakası: ");
            string plaka = Console.ReadLine();

            Araba kiralanacakAraba = null;
            foreach (Araba araba in galeri.tumArabaListesi)
            {
                if (plaka == araba.Plaka)
                {
                    kiralanacakAraba = araba;
                    break;
                }
            }

            if (kiralanacakAraba != null)
            {
                Console.WriteLine("Plaka eşleşti");
                if (kiralanacakAraba.ArabaDurumu == Araba.ArabaDurum.Galeride)
                {
                    Console.Write("\nKiralanma süresi: ");
                    sbyte kiraSuresi = sbyte.Parse(Console.ReadLine());
                    Console.WriteLine($"\n{kiralanacakAraba.Plaka} plakalı araba {kiraSuresi} saatliğine kiralandı.");
                    galeri.KirayaVer(kiralanacakAraba);
                }
                else
                    Console.WriteLine("Araba şu anda kirada. Farklı araba seçiniz.");
            }
            else
                Console.WriteLine("Araba bulunamadı!");
        }

        private static void Menu()
        {
            Console.WriteLine("1 - Araba Kirala(K)");
            Console.WriteLine("2 - Araba Teslim Al(T)");
            Console.WriteLine("3 - Kiradaki Arabaları Listele(R)");
            Console.WriteLine("4 - Galerideki Arabaları Listele(M)");
            Console.WriteLine("5 - Tüm Arabaları Listele(A)");
            Console.WriteLine("6 - Kiralama İptali(I)");
            Console.WriteLine("7 - Araba Ekle(Y)");
            Console.WriteLine("8 - Araba Sil(S)");
            Console.WriteLine("9 - Bilgileri Göster(G)");
            Console.WriteLine("10 - Cikis Yap(X)");
        }
        public static string SecimAl()
        {
            string secim;
            while (true)
            {
                Console.Write("\nSeciminiz: ");
                secim = Console.ReadLine().ToUpper();
                if (secim == "1" || secim == "2" || secim == "3" || secim == "4" || secim == "5"
                    || secim == "6" || secim == "7" || secim == "8" || secim == "9" || secim == "K"
                    || secim == "T" || secim == "R" || secim == "M" || secim == "A" || secim == "I"
                    || secim == "Y" || secim == "S" || secim == "G" || secim == "X" || secim == "10")
                    break;
                else
                {
                    Console.WriteLine("\nHatalı işlem gerçekleştirildi. Tekrar deneyin.");
                    continue;
                }
            }
            return secim;
        }


    }
}