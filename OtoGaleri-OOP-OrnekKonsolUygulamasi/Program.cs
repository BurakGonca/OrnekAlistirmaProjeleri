using System.ComponentModel.Design;

namespace OtoGaleri_OOP_OrnekKonsolUygulamasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calistir();
        }

        public static void Calistir()
        {
            Menu();
            switch (SecimAl())
            {
                case "1":
                case "K":
                    ArabaTeslimAl();
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
                default:

                    Console.WriteLine("Hatalı işlem gerçekleştirildi. Tekrar deneyin.");
                    break;
            }


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
            throw new NotImplementedException();
        }

        private static void KiralamaIptali()
        {
            throw new NotImplementedException();
        }

        private static void TümArabalariListele()
        {
            throw new NotImplementedException();
        }

        private static void GaleridekiArabalariListele()
        {
            throw new NotImplementedException();
        }

        private static void KiradakiArabalariListele()
        {
            throw new NotImplementedException();
        }

        private static void ArabaTeslimAl()
        {
            throw new NotImplementedException();
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
        }
        public static string SecimAl()
        {
            Console.Write("\nSeciminiz: ");
            string secim = Console.ReadLine();
            return secim;
        }


    }
}