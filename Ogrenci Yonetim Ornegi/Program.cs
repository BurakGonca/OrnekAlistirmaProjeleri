namespace Ogrenci_Yonetim_Ornegi
{
    internal class Program
    {
        static List<Ogrenci> ogrenciler = new List<Ogrenci>();

        static void Main(string[] args)
        {

            Uygulama();

        }
        static void Uygulama()
        {
            SahteVeriEkle();

            while (true)
            {
                Menu();
                string giris = SecimAl();

                switch (giris)
                {
                    case "E":
                    case "1":
                        OgrenciEkle();
                        break;
                    case "L":
                    case "2":
                        OgrenciListele();
                        break;
                    case "S":
                    case "3":
                        OgrenciSil();
                        break;
                    case "X":
                    case "4":
                        Cikis();
                        break;
                    default:
                        Console.WriteLine("Hatalı giriş yapıldı, tekrar deneyin!");
                        break;

                }

                Console.WriteLine();
                Thread.Sleep(5000);
                Console.Clear();
            }



        }
        static void OgrenciEkle()
        {
            Console.WriteLine("1- Öğrenci Ekle ----------");
            Console.WriteLine("Öğrencinin");

            Console.Write("Adı: ");
            string ad = Console.ReadLine();

            Console.Write("Soyadı: ");
            string soyad = Console.ReadLine();

            Console.Write("Şubesi: ");
            string sube = Console.ReadLine();

            Console.Write("No: ");
            int no = int.Parse(Console.ReadLine());

            Ogrenci o = new Ogrenci(ad, soyad, sube, no);

            Console.WriteLine();

            Console.Write("Öğrenciyi kaydetmek istediğinize emin misiniz? (E/H)  ");
            string secim = Console.ReadLine().ToUpper();

            if (secim == "E")
            {
                ogrenciler.Add(o);
                Console.WriteLine("Öğrenci eklendi.");
            }
            else
            {
                Console.WriteLine("Öğrenci eklenmedi.");
            }

            Console.WriteLine();

        }
        static void OgrenciListele()
        {
            Console.WriteLine("2- Öğrenci Listele-----------");
            Console.WriteLine();
            Console.WriteLine("Şube    No    Ad Soyad");
            Console.WriteLine("---------------------------------- ");

            foreach (Ogrenci item in ogrenciler)
            {
                Console.WriteLine(item.Sube + "       " + item.No + "     " + item.Ad + " " + item.Soyad);
            }


        }
        static void OgrenciSil()
        {
            Console.WriteLine("3- Öğrenci Sil ----------");

            if (ogrenciler.Count == 0)
            {
                Console.WriteLine("Listede silinecek öğrenci yok.");
                return; // .Count ile item sayısını ölçerek 0'a eşit ise 
                        // listede silinecek öğrenci yok dedik
            }
            Console.WriteLine("Silmek istediğiniz öğrencinin");

            Console.Write("No: ");
            int no = int.Parse(Console.ReadLine());


            Ogrenci ogr = null; //bos,temsili bir ogrenci yarattık

            foreach (Ogrenci item in ogrenciler)
            {
                if (item.No == no)
                {
                    ogr = item; //girilen no listede varsa dogrudan eslestirme yapiliyor
                    break;
                }

            }

            if (ogr != null)
            {
                Console.WriteLine("Adı: " + ogr.Ad);
                Console.WriteLine("Soyadı: " + ogr.Soyad);
                Console.WriteLine("Şubesi: " + ogr.Sube);
                Console.WriteLine();
                Console.Write("Öğrenciyi silmek istediğinize emin misiniz? (E/H)  ");

                string secim = Console.ReadLine();

                if (secim == "E")
                {
                    ogrenciler.Remove(ogr);
                    Console.WriteLine("Öğrenci silindi");
                }
                else
                {
                    Console.WriteLine("Oğrenci silinemedi, tekrar deneyiniz.");
                }
            }
            else
            {
                Console.WriteLine("Böyle bir öğrenci bulunamadı.");
            }



        }
        static void Menu()
        {
            Console.WriteLine("Öğrenci Yönetim Uygulaması");
            Console.WriteLine("1 - Öğrenci Ekle(E)       ");
            Console.WriteLine("2 - Öğrenci Listele(L)    ");
            Console.WriteLine("3 - Öğrenci Sil(S)        ");
            Console.WriteLine("4 - Çıkış(X)              ");
            Console.WriteLine();
        }
        static void SahteVeriEkle()
        {
            Ogrenci o1 = new Ogrenci("Ali", "Veli", "A", 1234);
            Ogrenci o2 = new Ogrenci("Ayşe", "Yilmaz", "B", 1235);
            Ogrenci o3 = new Ogrenci("Mehmet", "Ozturk", "C", 1236);

            ogrenciler.Add(o1);
            ogrenciler.Add(o2);
            ogrenciler.Add(o3);
        }
        /// <summary>
        /// SecimAl methodu kullanicidan menu icim secim yapmasini ister ve 5 defadan fazla yanlis secim olursa oturumu sonlandirir
        /// </summary>
        /// <returns></returns>
        static string SecimAl()
        {
            int denemeSayisi = 0;

            do
            {

                Console.Write("Seçiminiz: ");
                string giris = Console.ReadLine().ToUpper();


                if (giris == "E" || giris == "1" ||
                    giris == "L" || giris == "2" ||
                    giris == "S" || giris == "3" ||
                    giris == "X" || giris == "4")
                {
                    return giris;
                }
                else Console.WriteLine("\nLütfen 1-4 arasinda secim yapiniz");

                denemeSayisi++;

            } while (denemeSayisi < 5);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Üzgünüm, sizi anlayamıyorum. Program sonlandırılıyor.");
            Console.ResetColor();
            Thread.Sleep(2000);

            Environment.Exit(0);

            return null;
        }
        /// <summary>
        /// Cikis methodu kullanicinin cikis yapmak isteyip istemediginin sorgulamasini yaparak enter ya da esc tuslarına basması halinde devam etmeyi ya da oturumun sonlandirilmasini saglar.
        /// </summary>
        private static void Cikis()
        {
            Console.WriteLine("Cikmak istediginize emin misiniz?");

            while (true)
            {
                Console.Write("\nDevam etmek istiyorsaniz");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("  'ENTER'  ");
                Console.ResetColor();

                Console.Write("cikmak icin ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("'ESC' ");
                Console.ResetColor();

                Console.Write("tusuna basiniz.");

                ConsoleKey tus = Console.ReadKey().Key;

                if (tus == ConsoleKey.Escape)
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nCikis yapiliyor, iyi günler dileriz.");
                    Console.ResetColor();
                    Thread.Sleep(2000);

                    Environment.Exit(0);
                }
                else if (tus == ConsoleKey.Enter)
                {
                    Console.WriteLine();
                    Console.WriteLine("\nAna menuye yonlendiriliyorsunuz");
                    break;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("\nGecerli bir secim yapmadiniz");
                    // Bu kısımda, Enter veya ESC dışındaki tuşa basıldığında döngü başına gitmesi sağlanır.
                    continue;
                }
            }


        }
    }
}