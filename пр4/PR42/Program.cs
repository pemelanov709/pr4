using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR42
{
    class Ork
    {
        private static int population;
        public static int WalletOfGold;

        public Ork()
        {
            //будет ли Орк воровать
            if (population < 5)
                WalletOfGold = WalletOfGold+2;
            else
                WalletOfGold = WalletOfGold-2;
            population++;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //колличество орков
            Ork ork1 = new Ork();
            Ork ork2 = new Ork();
            Ork ork3 = new Ork();
            Ork ork4 = new Ork();
            Ork ork5 = new Ork();

            //Вывод на консоль количества золота
            Console.WriteLine($"Количество переносимого золота орками: {Ork.WalletOfGold}");
            Console.ReadKey(true);
        }
    }
}
