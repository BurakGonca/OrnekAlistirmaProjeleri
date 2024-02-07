namespace OkulYonetim_OOP_Ornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IlkOkulOgrencisi burak = new IlkOkulOgrencisi("Burak", "Gonca", 9, 80, 90);

            var result = burak.NotOrtalama();
            Console.WriteLine(result);

            burak.IlkOkulOgrenciCinsiyeti = IKisi.Cinsiyeti.Erkek;

            Console.WriteLine(burak.IlkOkulOgrenciCinsiyeti);

            Ogretmen ogretmen = new Ogretmen("Bur", "Gon", 20, Brans.Türkce);

            Console.WriteLine(ogretmen.OgretmenTecrube);

            Ders ders = new Ders("Turkce", 45, Brans.Türkce);

            Console.WriteLine(ders.DersOlusabilirMi(ders, ogretmen));
        }
    }
}