using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkWay
{
    public class Hero
    {
        public string Name;
        public int HpHuman;
        public int DamageHuman;
        public int AmountPotion;
        public int Memory;

        public Hero(string name, int hpHuman, int damageHuman, int amountPotion,int memory)
        {
            HpHuman = hpHuman;
            DamageHuman = damageHuman;
            AmountPotion = amountPotion;
            Name = name;
            Memory = memory;
        }
        public void Statistics()
        {
            Console.WriteLine($"Имя {Name}");
            Console.WriteLine($"Кол-во здоровья {HpHuman}");
            Console.WriteLine($"Урон {DamageHuman}");
        }

        public void Heal()
        {
            if (AmountPotion > 0)
            HpHuman = HpHuman + 10;
            AmountPotion = AmountPotion - 1;
        }

        public void TakeDamage(int damageMonster)
        {
            HpHuman = HpHuman - damageMonster;

            if (HpHuman <= 0)
            {
                while (true)
                {
                    Console.WriteLine("Ты падаешь в бездну, вокруг тьма, кажется ты мертв");
                }
            }
        }
    }
}
