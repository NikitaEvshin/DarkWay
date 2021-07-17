using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DarkWay
{
    public class Fight
    {
        public Hero Hero;
        public Monster Monster;
        public void  StartFight(Hero hero, Monster monster)
        {
            while (hero.HpHuman >= 0 && monster.HpMonster >= 0)
            {
                hero.TakeDamage(monster.DamageMonster);
                monster.TakeDamage(hero.DamageHuman);
                Console.WriteLine($"Здоровье {hero.Name}  {hero.HpHuman}, Здоровье {monster.Name} {monster.HpMonster}");

                
                if (hero.AmountPotion > 0)
                {
                    Console.WriteLine("Вы можете полечиться");
                    Console.WriteLine("Нажмите 1 для лечения");
                    Console.WriteLine("Нажмите 2 для пропуска");
                    string point1 = Console.ReadLine();
                    int point = Convert.ToInt32(point1);
                    if (point == 1)
                    {
                        hero.Heal();
                    }
                    else if (point == 2)

                    {
                        Console.WriteLine("");
                    }
                }
            }
        }
    }
}
