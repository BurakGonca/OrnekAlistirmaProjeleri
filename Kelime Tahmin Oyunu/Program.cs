namespace Kelime_Tahmin_Oyunu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calistir();
        }
        private static void Calistir()
        {
            bool cikisKontrolu = true;
            while (cikisKontrolu)
            {
                string kelime = RandomKelimeSecimi("");
                char[] kelimeDizisi = new char[kelime.Length];

                for (int i = 0; i < kelimeDizisi.Length; i++)
                {
                    kelimeDizisi[i] = '_';
                }

                string yeniKelime = new string(kelimeDizisi);

                Console.WriteLine(yeniKelime);

                bool kontrol = true;

                while (kontrol)
                {
                    Console.Write("\nHarf yazin: ");

                    char harf;
                    while (!char.TryParse(Console.ReadLine().ToLower(), out harf))
                    {
                        Console.Write("Lütfen yalnizca harf giriniz:");
                    }



                    if (kelime.Contains(harf))
                    {

                        for (int i = 0; i < kelime.Length; i++)
                        {
                            if (kelime[i] == harf) kelimeDizisi[i] = harf;

                        }

                        yeniKelime = new string(kelimeDizisi);

                    }
                    else Console.WriteLine("\nMaalesef, bu harf kelimemizde bulunmuyor");

                    Console.WriteLine(yeniKelime);

                    if (yeniKelime == kelime)
                    {
                        Thread.Sleep(2000);
                        Console.Clear();
                        kontrol = false;
                    }



                }

                Console.WriteLine("\nTebrikler bildiniz");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(kelime.ToUpper()); ;
                Thread.Sleep(3000);
                Console.ResetColor();
                Console.Clear();

                
                bool secimKontrolu = true;
                while (secimKontrolu)
                {
                    Console.WriteLine("Yeniden oynamak icin 'devam' , cikis islemi icin 'cikis' yaziniz!");
                    string secim = Console.ReadLine();

                    if (secim == "devam")
                    {
                        Console.WriteLine("OYUN YENİDEN BASLATILIYOR");
                        Console.Clear();
                        secimKontrolu = false;
                        cikisKontrolu = true;
                        Console.Clear() ;
                    }
                    else if (secim == "cikis")
                    {
                        Console.WriteLine("CIKIS YAPILIYOR");
                        secimKontrolu= false;
                        cikisKontrolu = false;
                    }
                    else
                    {
                        Console.WriteLine("Lütfen gecerli bir islem yapiniz!");
                        Console.WriteLine("\nMenuye tekrar yonlendiriliyorsunuz");
                        secimKontrolu = true;

                    }

                }


            }
        }

        /// <summary>
        /// RandomKelimeSecimi methodu önceden yazilmis olan kelimelerden rasgele birini secer
        /// </summary>
        /// <param name="_kelime"></param>
        /// <returns></returns>
        private static string RandomKelimeSecimi(string _kelime)
        {

            string[] arr = { "Masa", "Kitap", "Kalem", "Lamba", "Defter", "Klavye", "Bilgisayar" };

            Random random = new Random();
            int randomIndis = random.Next(0, arr.Length);

            _kelime = arr[randomIndis].ToLower();

            // Console.WriteLine("Rasgele seçilen kelime: " + _kelime);
            int harfSayisi = _kelime.Length;
            Console.WriteLine("---Kelime oyununa hosgeldiniz---");
            Thread.Sleep(1000);
            Console.WriteLine($"\nKelimemiz {harfSayisi} harften olusmaktadir");
            Thread.Sleep(3000);
            Console.Clear();
            return _kelime;
        }

    }
}