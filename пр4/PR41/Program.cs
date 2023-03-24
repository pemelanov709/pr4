using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR41
{
    class poshta
    {
        public string AboutParcel { get;  private set; }
        public static double MassParcel { get; private set; }
        public string To { get; private set; }
        public string Name { get; private set; }

        public poshta(double mass, string about, string to, string name)
        {
            AboutParcel = about;
            MassParcel = mass + MassParcel;
            To = to;
            Name = name;
        }

    }

    class dostavka
    {
        private int limitMass = 60;

        public void sendParcel(poshta parcel)
        {

           //Проверка посылки
          if(poshta.MassParcel > limitMass)
          {
            Console.WriteLine($"Невозможно отправить посылку, так как её вес больше на: {poshta.MassParcel - limitMass}");
          }
          else
          {
             Console.WriteLine($"Послыка {parcel.Name}, успешно отправлена в {parcel.To}");
          }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            dostavka Pochta = new dostavka();

            //Приветствие
            Console.Write($"Мы отправим посылку если она не превышает вес" +
                $"\nВведите данные (Название/Описание/Вес/предназначение): ");

            string corrInf = Console.ReadLine();
            string[] correspodentInf = corrInf.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries); ;
            
            poshta bander = new poshta(Convert.ToDouble(correspodentInf[2]),correspodentInf[1],correspodentInf[3],correspodentInf[0]);

            //Отправка
            Pochta.sendParcel(bander);
            Console.ReadKey(true);
        }
    }
}
