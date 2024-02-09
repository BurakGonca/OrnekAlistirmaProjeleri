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
                        Console.WriteLine("\nCikis yapiliyor");
                        Thread.Sleep(2000);
                        kontrol = false;
                        break;
                    default:

                        Console.WriteLine("\nHatalı işlem gerçekleştirildi. Tekrar deneyin.");
                        break;
                }
            }

        }
        private static void ArabaTeslimAl()
        {
            Console.WriteLine("\n-Araba Teslim Al-");
            Console.Write("\nTeslim edilecek arabanın plakası: ");
            string plaka = Console.ReadLine();

            Araba teslimAlinacakAraba = null;
            foreach (Araba araba in galeri.tumArabaListesi)
            {
                if (plaka == araba.Plaka)
                {
                    teslimAlinacakAraba = araba;
                    break;
                }
            }
            if (teslimAlinacakAraba != null)
            {
                Console.WriteLine("\nPlaka eşleşti");
                if (teslimAlinacakAraba.ArabaDurumu == Araba.ArabaDurum.Kirada)
                {
                    Console.WriteLine($"\n{teslimAlinacakAraba.Plaka} plakalı araba teslim alındı.");
                    galeri.KiradanAl(teslimAlinacakAraba);
                }
                else
                    Console.WriteLine("\nHatalı giriş yapıldı. Araba zaten galeride.");
            }
            else
                Console.WriteLine("\nAraba bulunamadı!");
        }
        private static void BilgileriGoster()
        {
            Console.WriteLine("\n-Galeri Bilgileri-");
            Console.WriteLine($"\nToplam araba sayısı: {galeri.tumArabaListesi.Count} ");
            Console.WriteLine($"Kiradaki araba sayısı: {galeri.kiradakiArabaListesi.Count} ");
            Console.WriteLine($"Bekleyen araba sayısı: {galeri.galeridekiArabaListesi.Count} ");
            Console.WriteLine($"Toplam araba kiralama süresi: {ToplamKiralamaSuresiGetir()} ");
            Console.WriteLine($"Toplam araba kiralama adedi: {KiralamaAdetiGetir()} ");
            Console.WriteLine($"Ciro: {CiroGetir()} ");
        }
        public static int ToplamKiralamaSuresiGetir()
        {
            int toplamSure = 0;
            foreach (var item in galeri.kiradakiArabaListesi)
            {
                toplamSure += item.KiralamaSuresi;
            }
            return toplamSure;
        }
        private static decimal CiroGetir()
        {
            decimal ciro = 0;
            foreach (var item in galeri.kiradakiArabaListesi)
            {
                ciro += (item.KiralamaSuresi * item.KiralamaBedeli);
            }
            return ciro;
        }
        private static int KiralamaAdetiGetir()
        {
            int toplamKiralamaAdeti = 0;
            foreach (var item in galeri.tumArabaListesi)
            {
                toplamKiralamaAdeti += item.KiralamaSayisi;
            }
            return toplamKiralamaAdeti;
        }
        private static void ArabaSil()
        {
            Console.WriteLine("\n-Araba Sil-");
            Console.Write("Plaka: ");
            string plaka = Console.ReadLine();

            Araba silinecekAraba = null;
            foreach (Araba araba in galeri.tumArabaListesi)
            {
                if (plaka == araba.Plaka)
                {
                    silinecekAraba = araba;
                    break;
                }
            }
            if (silinecekAraba != null)
            {
                Console.WriteLine("\nPlaka eşleşti");
                if (silinecekAraba.ArabaDurumu == Araba.ArabaDurum.Galeride)
                {
                    Console.WriteLine($"\n{silinecekAraba.Plaka} plakalı araba silindi.");
                    galeri.GaleriArabaSil(silinecekAraba);
                }
                else
                    Console.WriteLine("\nAraba kirada olduğu için silme işlemi gerçekleştirilemedi.");
            }
            else
                Console.WriteLine("\nGaleriye ait bu plakada bir araba yok.");

        }
        private static void ArabaEkle()
        {
            Console.WriteLine("\n-Araba Ekle-");
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
            Console.WriteLine("\n-Kiralama İptali-");
            Console.Write("\nKiralaması iptal edilecek arabanın plakası: ");
            string plaka = Console.ReadLine();

            Araba iptalEdilecekAraba = null;
            foreach (Araba araba in galeri.tumArabaListesi)
            {
                if (plaka == araba.Plaka)
                {
                    iptalEdilecekAraba = araba;
                    break;
                }
            }
            if (iptalEdilecekAraba != null)
            {
                Console.WriteLine("\nPlaka eşleşti");
                if (iptalEdilecekAraba.ArabaDurumu == Araba.ArabaDurum.Kirada)
                {
                    Console.WriteLine($"\n{iptalEdilecekAraba.Plaka} plakalı araba icin kiralama iptali gerceklestirildi.");
                    galeri.KiralamaIptali(iptalEdilecekAraba);
                }
                else
                    Console.WriteLine("\nHatalı giriş yapıldı. Araba zaten galeride.");
            }
            else
                Console.WriteLine("\nGaleriye ait bu plakada bir araba yok. Arac bulunamadi");
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
                Console.WriteLine("\nPlaka eşleşti");
                if (kiralanacakAraba.ArabaDurumu == Araba.ArabaDurum.Galeride)
                {
                    Console.Write("\nKiralanma süresi: ");
                    sbyte kiraSuresi = sbyte.Parse(Console.ReadLine());
                    Console.WriteLine($"\n{kiralanacakAraba.Plaka} plakalı araba {kiraSuresi} saatliğine kiralandı.");
                    galeri.KirayaVer(kiralanacakAraba);
                    kiralanacakAraba.KiralamaSuresi=kiraSuresi;
                }
                else
                    Console.WriteLine("\nAraba şu anda kirada. Farklı araba seçiniz.");
            }
            else
                Console.WriteLine("\nAraba bulunamadı!");
        }
        private static void Menu()
        {
            Console.WriteLine("\n1 - Araba Kirala(K)");
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