using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkWay
{
    public class Monster
    {
        public string Name;
        public int HpMonster;
        public int DamageMonster;

        public Monster(string name, int hpMonster, int damageMonster)
        {
            HpMonster = hpMonster;
            DamageMonster = damageMonster;
            Name = name;
        }
        public void TakeDamage(int damageHuman)
        {
            HpMonster = HpMonster - damageHuman;
        }

        public void Statistic()
        {
            Console.WriteLine($"Враг {Name} , Здоровье {HpMonster} , Сила {DamageMonster}");
        }
    }
}
