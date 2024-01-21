using System.Threading.Channels;

namespace XOX_Oyunu
{
    internal class Program
    {
        private static char[] board;
        private static bool kontrol;

        static void Main(string[] args)
        {

            //XOX OYUNU
            Calistir();

        }

        private static void Calistir()
        {

            board = new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            Yazdir();

            int i = 0;
            while (i < 5)
            {
                ++i;

                //ilk hamle kullanicidan alinir

                bool oyuncuKontrol = false; 
                while (!oyuncuKontrol) // kullanıcı geçerli bir hamle yapana kadar döngü devam ediyor
                {
                    Console.Write("\nHamle yapmak istediginiz sayiyi secin: ");
                    char input;
                    while (!char.TryParse(Console.ReadLine(), out input) )
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Yanlis bir secim yaptiniz, lütfen 1-9 arasi bos bir alana hamle yapiniz");
                        Console.ResetColor();
                        Console.Write("\nHamle yapmak istediginiz sayiyi secin: ");
                    }



                    int index = input - '1'; 
                    if (board[index] == input) 
                    {
                        board[index] = 'X'; 
                        oyuncuKontrol = true; // kullanıcının geçerli bir hamle yaptığını belirtiyoruz
                    }
                    else 
                    {
                        DoluAlanUyarisi(); 
                    }
                }

                Console.WriteLine();
                Yazdir();

                if (KazananKontrolu(kontrol))
                {
                    Console.WriteLine("\nTebrikler, siz kazandiniz");
                    break;
                }

                Console.Clear();

                // bot oynasin simdi de

                bool botKontrol = false; 
                while (!botKontrol) // bot geçerli bir hamle yapana kadar döngü devam ediyor
                {
                    char inputBot = (char)(new Random().Next('1', '9' + 1)); 
                    int index = inputBot - '1'; 
                    if (board[index] == inputBot) 
                    {
                        board[index] = 'O'; 
                        botKontrol = true; // botun geçerli bir hamle yaptığını belirtiyoruz
                    }
                    
                }
                Console.WriteLine();
                Yazdir();

                if (KazananKontrolu(kontrol))
                {
                    Console.WriteLine("\nMaalesef bot Kazandi");
                    break;
                }


            }
        }

        /// <summary>
        /// DoluAlanUyarisi methodu kullanici dolu bir alana hamle yapmaya calisirsa ona uyarı vererek oynunu bozmadan tekrardan hamle yapmasini saglar
        /// </summary>
        private static void DoluAlanUyarisi()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Bu alan doludur");
            Console.ResetColor();
        }


        /// <summary>
        /// KazananKontrolu methodu oyuncunun ya da botun hamlesinden hemen sonra kazanip,kazanmadigini kontrol eder
        /// </summary>
        /// <param name="_kontrol"></param>
        /// <returns></returns>
        private static bool KazananKontrolu(bool _kontrol)
        {

            if ((board[0] == board[1] && board[1] == board[2]) ||
                    (board[3] == board[4] && board[4] == board[5]) ||
                    (board[6] == board[7] && board[7] == board[8]) ||

                    (board[0] == board[3] && board[3] == board[6]) ||
                    (board[1] == board[4] && board[4] == board[7]) ||
                    (board[2] == board[5] && board[5] == board[8]) ||


                    (board[0] == board[4] && board[4] == board[8]) ||
                    (board[2] == board[4] && board[4] == board[6]))

            {
                Console.WriteLine("---Oyun Bitti---");
                _kontrol = true;

            }
            else _kontrol = false;

            return _kontrol;
        }

        /// <summary>
        /// Yazdir methodu oyuncu ya da botun hamlesinin hemen akabinde ekrana guncel durumu yazdirir
        /// </summary>
        private static void Yazdir()
        {
            Console.WriteLine("  {0}  |  {1}  |  {2}", board[0], board[1], board[2]);
            Console.WriteLine();
            Console.WriteLine("  {0}  |  {1}  |  {2}", board[3], board[4], board[5]);
            Console.WriteLine();
            Console.WriteLine("  {0}  |  {1}  |  {2}", board[6], board[7], board[8]);
            Console.WriteLine();
        }

    }
}