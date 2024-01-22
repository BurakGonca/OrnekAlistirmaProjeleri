namespace OOP_Ornek_Ogrenci_Calisma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calistir();
        }

        public static void Calistir()
        {

            Ogrenci ogrenci1 = new Ogrenci(1234, "ogr1", "Gnc", 65, 75, 50, "Gazi University");
            Ogrenci ogrenci2 = new Ogrenci(1235, "ogr2", "Gnc", 65, 57, 60, "Ege University");
            Ogrenci ogrenci3 = new Ogrenci(1236, "ogr3", "Gnc", 73, 57, 60, "Ankara University");
            Ogrenci ogrenci4 = new Ogrenci(1237, "ogr4", "Gnc", 65, 59, 80, "ODTU");
            Ogrenci ogrenci5 = new Ogrenci(1238, "ogr5", "Gnc", 65, 57, 45, "Eskisehir University");
            Ogrenci ogrenci6 = new Ogrenci(1239, "ogr6", "Gnc", 65, 57, 60, "Selcuk University");
            Ogrenci ogrenci7 = new Ogrenci(1240, "ogr7", "Gnc", 72, 62, 60, "Gazi University");
            Ogrenci ogrenci8 = new Ogrenci(1241, "ogr8", "Gnc", 65, 75, 60, "Dokuz Eylul University");
            Ogrenci ogrenci9 = new Ogrenci(1242, "ogr9", "Gnc", 65, 75, 77, "Ankara University");
            Ogrenci ogrenci10 = new Ogrenci(1243, "ogr10", "Gnc", 65, 75, 60, "Gazi University");


            Console.WriteLine("Hosgeldiniz");

            int secim = 0;
            bool kontrol = true;
            while (kontrol)
            {
                IslemSecenekleri();
                EkranTemizleme();

                try
                {
                    Console.Write("Seciminiz: ");
                    secim = int.Parse(Console.ReadLine());
                    if (secim >= 1 && secim <= 4)
                    {
                        Console.WriteLine("Yonlendirme saglaniyor");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Yanlis bir secim yaptiniz, tekrar deneyiniz");
                    kontrol = true;
                }

                switch (secim)
                {
                    case 1:
                        ogrenci1.OgrenciBilgileriGoster();
                        EkranTemizleme();
                        break;
                    case 2:
                        int ortalama = ogrenci1.OgrenciOrtalamasiBul();
                        Console.WriteLine("Ogrencinin ortalamasi: " + ortalama);
                        EkranTemizleme();
                        break;
                    case 3:
                        ogrenci1.okulGetir();
                        EkranTemizleme();
                        break;
                    case 4:
                        Console.WriteLine("Cikis Yapiliyor");
                        EkranTemizleme();
                        kontrol = false;
                        break;


                }


            }



        }

        private static void IslemSecenekleri()
        {
            Console.WriteLine("Merhaba yapmak istediginiz islemi 1-4 arasinda seciniz.");
            Console.WriteLine("\n1-Ogrenci Bilgilerini Goster");
            Console.WriteLine("2-Ogrenci Ogrenci Ortalamasini Goster");
            Console.WriteLine("3-Ogrencinin Okulunu Ogren");
            Console.WriteLine("4-Cikis");
        }

        public static void EkranTemizleme()
        {
            Thread.Sleep(2500);
            Console.Clear();
        }
    }
}