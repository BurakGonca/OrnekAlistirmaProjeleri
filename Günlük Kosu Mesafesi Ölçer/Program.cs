namespace Günlük_Kosu_Mesafesi_Ölçer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calistir();
        }

        private static void Calistir()
        {
            Console.WriteLine("-----Gunluk Kosu Mesafesi Olcer Uygulamasina Hosgeldiniz-----");
            Thread.Sleep(1500);

            Console.Write("\nOrtalama bir adiminiz kaç cm'dir: ");
            int adim = Kontrol(0, 100);

            Console.Write("Kosunuzu bolumlere ayirmak istesek kac bolum olurdu: ");
            short bolumSayisi = (short)Kontrol(0, 5);
            //bolum sayisi kucuk bir deger oldugundan bilincli tur degisimi yapildi

            float toplamMesafeCm = 0;
            float toplamSureDakika = 0;

            for (int i = 0; i < bolumSayisi; i++)
            {
                Console.WriteLine($"\n{i + 1}. bolum icin asagidaki sorulari cevaplayiniz!");
                Thread.Sleep(1000);

                Console.Write("\nBir dakikada kac adim kosmaktasiniz: ");
                int bolumAdimSayisi = Kontrol(0, 250);

                Console.Write("\nKosu sürenizi saat olarak giriniz: ");
                int kosuSaati = Kontrol(0, 3);

                Console.Write("\nKosu sürenizi dakika olarak giriniz: ");
                int kosuDakikasi = Kontrol(0, 60);



                float bolumMesafeCm = bolumAdimSayisi * adim * ((kosuSaati * 60) + kosuDakikasi);

                toplamMesafeCm += bolumMesafeCm;
                toplamSureDakika += (kosuSaati * 60) + kosuDakikasi;
            }

            float toplamMesafeKm = toplamMesafeCm / 100000; // 1 km = 100000 cm

            Console.WriteLine($"\nGünlük Koşu Mesafesi: {toplamMesafeKm} km 'dir.");
            Console.WriteLine($"Toplam Koşu Süresi: {toplamSureDakika / 60} saat {toplamSureDakika % 60} dakikadır.");
        }

        /// <summary>
        /// Kontrol Metodu, girilen bir integer degerin pozitif bir tamsayı olmasini ve
        /// belirli bir aralikta olmasini kontrol eder.
        /// </summary>
        private static int Kontrol(int enAz, int enCok)
        {
            int sayi;
            while (!int.TryParse(Console.ReadLine(), out sayi) || sayi <= 0 || sayi < enAz || sayi > enCok)
            {
                Console.Clear();
                Console.Write($"Lütfen {enAz}-{enCok} arasinda pozitif bir tam sayi giriniz: ");
            }
            Thread.Sleep(1000);
            return sayi;
        }
    }
}