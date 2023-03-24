using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR4
{ 
    class mag
    {
        public int Mana { get; private set; }
        private string Effect { get; set; }
        public string Name { get; private set; }

        public mag (int mana, string effect, string name)
        {
            Mana = mana;
            Effect = effect;
            Name = name;
        }
        
        public string Use()
        {
            return Effect;
        }
    }

    class Magician
    {
        public string Name { get; private set; }
        public int Mana { get; private set; }

        public Magician(string name, int mana)
        {
            Name = name;
            Mana = mana;
        }

        //Колдовство (проверка маны)
        public void CastSpell(mag spell)
        {
            if(Mana >= spell.Mana)
            {
                Console.WriteLine($"{Name} колдует! {spell.Use()}");
                Mana -= spell.Mana;
            }
            else
            {
                Console.WriteLine($"Для использования \"{spell.Name}\" не хватает {spell.Mana-Mana} единиц маны.Хлебни зелья!");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //заклинания
            mag alohomora = new mag(60, "Замок открывается!","Алохомора");
            mag vingardiumLeviosa = new mag(60, "Предмет поднимается в воздух!","Вингардиум-Левиоса");

            //Маг
            Magician garryPotter = new Magician("Мерлин", 100);

            //магия
            garryPotter.CastSpell(alohomora);
            garryPotter.CastSpell(vingardiumLeviosa);
            
            Console.ReadKey(true);
        }
    }
}
