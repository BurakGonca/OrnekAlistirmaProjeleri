namespace SinemaKonsolUygulamasi_OOP_Ornek
{
    internal class Program
    {
        static Sinema snm;
        static short bosKoltukSayisi;
        static float ciro;

        static void Main(string[] args)
        {
            Calistir();

        }

        private static void Calistir()
        {
            FilmEkleme();

            while (true)
            {
                switch (Menu())
                {
                    case "1":
                    case "S":
                        BiletSatisi();
                        break;
                    case "2":
                    case "R":
                        BiletIadesi();
                        break;
                    case "3":
                    case "D":
                        DurumBilgisi();
                        break;
                    case "4":
                    case "X":
                        CikisMethodu();
                        break;
                }
            }
        }


        private static void DurumBilgisi()
        {
            Console.WriteLine("---Durum Bilgisi---");
            Console.WriteLine($"\nFilm:                         : {snm.FilmAdi} ");
            Console.WriteLine($"Kapasite:                     : {snm.Kapasite} ");
            Console.WriteLine($"Tam Bilet Fiyatı:             : {snm.TamBiletFiyati} ");
            Console.WriteLine($"Yarım Bilet Fiyatı:           : {snm.YarimBiletFiyati} ");
            Console.WriteLine($"Toplam Tam Bilet Adeti:       : {snm.TamBiletAdeti} ");
            Console.WriteLine($"Toplam Yarım Bilet Adeti:     : {snm.YarimBiletAdeti} ");
            Console.WriteLine($"Ciro:                         : {ciro} ");
            Console.WriteLine($"Boş Koltuk Adeti:             : {bosKoltukSayisi} ");
            Console.WriteLine("\nAna menüye yonlendiriliyorsunuz");
            Thread.Sleep(5000);

        }

        private static void BiletIadesi()
        {
            Console.WriteLine("---Bilet İade---");
            Console.Write("Tam Bilet adeti: ");
            short tamBiletAdeti = short.Parse(Console.ReadLine());
            Console.Write("\nYarim Bilet adeti: ");
            short yarimBiletAdeti = short.Parse(Console.ReadLine());

            bosKoltukSayisi = (short)(snm.BosKoltukSayisi() + tamBiletAdeti + yarimBiletAdeti);
            ciro = (float)(snm.Ciro() - (tamBiletAdeti * snm.TamBiletFiyati) - (yarimBiletAdeti * snm.YarimBiletFiyati));

            Console.WriteLine("\nBilet iadesi yapildi");
            Console.WriteLine("\nAna menüye yonlendiriliyorsunuz");
            Thread.Sleep(3000);

        }

        private static void BiletSatisi()
        {
            Console.WriteLine("---Bilet Satisi---");
            Console.Write("\nTam Bilet adeti: ");
            short tamBiletAdeti = short.Parse(Console.ReadLine());
            Console.Write("\nYarim Bilet adeti: ");
            short yarimBiletAdeti = short.Parse(Console.ReadLine());

            bosKoltukSayisi = (short)(snm.BosKoltukSayisi() - tamBiletAdeti - yarimBiletAdeti);
            ciro = (float)(snm.Ciro() + (tamBiletAdeti * snm.TamBiletFiyati) + (yarimBiletAdeti * snm.YarimBiletFiyati));

            Console.WriteLine("\nBilet satisi yapildi");
            Console.WriteLine("\nAna menüye yonlendiriliyorsunuz");
            Thread.Sleep(3000);
        }

        private static void FilmEkleme()
        {
            Console.WriteLine("------Lale Sinema Salonu------");
            Console.Write("\nFilm Adi: ");
            string ad = Console.ReadLine();
            Console.Write("Kapasite: ");
            short kapasite = short.Parse(Console.ReadLine());
            Console.Write("Tam Bilet Fiyati: ");
            int tamBiletFiyati = int.Parse(Console.ReadLine());
            Console.Write("Yarim Bilet Fiyati: ");
            int yarimBiletFiyati = int.Parse(Console.ReadLine());

            Console.WriteLine();

            snm = new Sinema(ad, kapasite, tamBiletFiyati, yarimBiletFiyati);


        }

        private static string Menu()
        {
            Console.WriteLine("1 - Bilet Sat(S)        ");
            Console.WriteLine("2 - Bilet İade(R)       ");
            Console.WriteLine("3 - Durum Bilgisi(D)    ");
            Console.WriteLine("4 - Çıkış(X)            ");

            string secim = "";
            bool kontrol = true;
            while (kontrol)
            {
                Console.Write("\nSeciminiz: ");
                secim = Console.ReadLine().ToUpper();
                if (secim == "1" || secim == "S" ||
                    secim == "2" || secim == "R" ||
                    secim == "3" || secim == "D" ||
                    secim == "4" || secim == "X")
                {
                    kontrol = false;
                }

                else
                {
                    Console.WriteLine("Yanlis bir secim yaptiniz!");
                    kontrol = true;
                    continue;
                }
            }

            return secim;


        }

        private static void CikisMethodu()
        {
            Console.WriteLine("Cikis yapmak istediğinize emin misiniz?");

            bool kontrol = true;
            while (kontrol)
            {
                Console.Write("\nDevam etmek için");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(" 'ENTER' ");
                Console.ResetColor();
                Console.Write("çıkmak için ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("'ESC' ");
                Console.ResetColor();
                Console.WriteLine("tuşuna basınız: ");

                ConsoleKeyInfo tus = Console.ReadKey();

                if (tus.Key == ConsoleKey.Escape)
                {
                    Console.WriteLine("\nÇıkış yapılıyor...");
                    Thread.Sleep(5000);
                    Environment.Exit(0);
                    Console.ReadKey();
                }
                else if (tus.Key == ConsoleKey.Enter)
                {
                    Console.WriteLine("\nÇıkış işlemi iptal edildi");
                    Console.WriteLine("Ana menüye yönlendiriliyorsunuz");
                    Thread.Sleep(5000);
                    kontrol = false;
                }
            }

        }

    }
}