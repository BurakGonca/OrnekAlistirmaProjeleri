namespace _OrnekSoruCozumleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Soru15();
            //Soru16();
            //Soru17();
            //Soru18();
            //Soru19();
            Soru20();
        }

        static void Soru15()
        {
            Console.WriteLine("--CARPIM TABLOSU--");
            int i, j;
            for (i = 1; i < 10; i++)
            {
                for (j = 1; j <= 10; j++)
                {
                    Console.WriteLine(i + " x " + j + " = " + (i * j));
                }
            }

        }
        static void Soru16()
        {
            Console.Write("Bir sayi giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            string sonuc = (sayi % 5 == 0) ? "5'in katidir" : "5'in kati degildir.";
            Console.WriteLine(sonuc);

        }
        static void Soru17()
        {
            Console.Write("Birinci sayiyi giriniz: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("İkinci sayiyi giriniz: ");
            int y = Convert.ToInt32(Console.ReadLine());
            int i;
            int xCarpan = 0, yCarpan = 0;
            i = x / 2;
            while (i > 0)
            {
                if (x % i == 0)
                {
                    xCarpan = xCarpan + i;
                    i--;
                }
            }
            i = 1;
            while (i < y)
            {
                if (y % i == 0)
                {
                    yCarpan = yCarpan + i;
                    i++;
                }
            }
            if (xCarpan == y && yCarpan == x) Console.WriteLine(x + " " + y + " dost sayilardir.");
            else Console.WriteLine(x + " " + y + " dost sayilar degildir.");



        }

        static void Soru18()
        {
            int sayi1 = 1, sayi2 = 1, sayi3;
            Console.WriteLine(sayi1);
            for (int i = 2; i <= 10; i++)
            {
                sayi3 = sayi1 + sayi2;
                Console.WriteLine(sayi3);
                sayi1 = sayi2;
                sayi2 = sayi3;


            }
        }
        static void Soru19()
        {
            Console.Write("Bir sayi giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            string sonuc = (sayi > 0) ? "pozitif" : (sayi < 0) ? "negatif" : "nötr";
            Console.WriteLine("sonuc: {0} ", sonuc);
        }
        static void Soru20()
        {
            Console.Write("Bir sayi giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int i, tamBolenToplami = 0;
            for (i = 1; i < sayi; i++)
            {
                if (sayi % i == 0) tamBolenToplami = tamBolenToplami + i;

            }
            if (tamBolenToplami == sayi) Console.WriteLine("Sayimiz mükemmel sayidir.");
            else Console.WriteLine("Sayimiz mükemmel sayi degildir.");

        }





    }
}