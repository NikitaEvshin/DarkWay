using System;

namespace DarkWay
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя");
            string entireName = Console.ReadLine();
            Console.Clear();
            Hero hero = new Hero(entireName, 100, 50, 2, 0);
            Monster monster = new Monster("Скелет", 135, 30);
            hero.Statistics();
            Console.WriteLine("");
            Console.WriteLine("У вас есть 30 нераспределенных очков");
            Console.WriteLine("Для распределения очков в Здоровье нажмите 1");
            Console.WriteLine("Для распределения очков в Силу нажмите 2 ");

            for (int i = 0; i < 3; i++)

            {
                string point1 = Console.ReadLine();
                int point = Convert.ToInt32(point1);

                if (point == 1)
                {
                    hero.HpHuman = hero.HpHuman + 10;
                }
                else if (point == 2)
                {
                    hero.DamageHuman = hero.DamageHuman + 10;
                }
                hero.Statistics();
            }
            Console.Clear();
            hero.Statistics();
            Console.WriteLine("");
            Console.WriteLine("Темно, непонятно: то ли закрыты глаза, то ли вокруг мрак");
            Console.ReadLine();
            Console.WriteLine("Глаза потихоньку привыкли к тьме, я находился в какой-то комнате");
            Console.WriteLine("Хотя нет, это не комната, это пещера, с едва освещающей её факелом");
            Console.ReadLine();
            Console.WriteLine("Встаю, на поясе висит мечь, в кармане пару зелий с лечебным снадобьем");
            Console.ReadLine();
            Console.WriteLine("Где интересно все остальные? Нужно найти их, последнее, что помню, как глаза заволокла тьма");
            Console.ReadLine();
            Console.WriteLine("Впереди две двери, нужно выбрать, в какую идти");
            Console.ReadLine();

            Console.WriteLine("Для входа в правую дверь нажмите 1, для входа в левую нажмите 2");
            string q1 = Console.ReadLine();
            int q = Convert.ToInt32(q1);
            if (q == 1)
            {
                Console.WriteLine("Попытки открыть дверь ни к чему не привели, придется идти во вторую");
            }

            if (q == 2)
            {
                Console.WriteLine("Входим в левую дверь");
            }
            Console.ReadLine();
            Console.Clear();
            hero.Statistics();

            Console.WriteLine("Впереди тебя сидит скелет, он весь прогнил, но еще шевелится");
            Console.WriteLine("Нажмите 1 чтобы атаковать");
            monster.Statistic();
            string start1 = Console.ReadLine();
            int start = Convert.ToInt32(start1);
            Fight fight = new Fight();
            if (start == 1)
            {
                fight.StartFight(hero, monster);
            }
            Console.Clear();
            hero.Statistics();
            Console.WriteLine("Скелет рассыпался в труху, может покопаться в останках? 1 - да, 2 - пройти мимо");
            string find1 = Console.ReadLine();
            int find = Convert.ToInt32(find1);
            if (find == 1)
            {
                hero.AmountPotion = hero.AmountPotion + 2;
                Console.WriteLine("Нашёл 2 зелья");
            }
            else if (find == 2)
            {
                Console.WriteLine("Проходишь мимо");
            }
            hero.Statistics();
            Console.WriteLine("");
            Console.WriteLine("Ты заходишь в большое помещение, посередине клетка, внутри маленький сгорбленный старик");
            Console.WriteLine("Ты подходишь ближе. *Помоги мне-слышишь ты от старика, освободи меня и я дарую тебе силу*");
            Console.WriteLine("Ежели ты меня оставишь, я прокляну тебя своей магией");
            Console.WriteLine("Нажми 1, чтобы освободить, нажми 2, чтобы пройти мимо");

            string try1 = Console.ReadLine();
            int tru = Convert.ToInt32(try1);

            if (tru == 1)
            {
                hero.Memory += 1;
                Console.WriteLine("После открытия клетки, старик проворно выпрыгнул из неё, повернулся к тебе лицом");
                Console.WriteLine("воздел руки к потолку и завел свою песню");
                Console.WriteLine("Hp -10, ОЙ-сказал колдун, не вышло, бывает, ты не серчай, развернулся и побрел в никуда");
                hero.HpHuman -= 10;
            }
            else if (tru == 2)
            {
                Console.WriteLine("Ты проходишь мимо, в след тебе доносятся грязные ругательства");
            }
            Console.ReadLine();
            Console.Clear();
            hero.Statistics();
            Console.WriteLine("");
            Console.WriteLine("Впереди 3 лаза в стене, в какой же нужно? Кто я, куда я иду, где моя цель?");
            Console.WriteLine("Единственное, что я помню, что рядом были товарищи, надеюсь, они еще живы");
            Console.WriteLine("Выберите направление, 1 левый лаз, 2 центральный, 3 правый");
            string try2 = Console.ReadLine();
            int tru3 = Convert.ToInt32(try2);
            if (tru3 == 1)
            {
                Console.WriteLine("Ты почти доходишь, но тут пол под тобой проваливается...");
            }
            else if (tru3 == 2)
            {
                Console.WriteLine("Ты почти доходишь, но тут пол под тобой проваливается...");
            }
            else if (tru3 == 3)
            {
                Console.WriteLine("Ты почти доходишь, но тут пол под тобой проваливается...");
            }
            hero.Statistics();
            Console.WriteLine("");
            Console.WriteLine("Шум в ушах наконец утих, протерев глаза от пыли, с трудом открываю их");
            Console.WriteLine("Вокруг сотни трупов и полная тишина, надо бы их обыскать");
            hero.AmountPotion += 2;
            Console.WriteLine("+ 2 зелья");
            Console.ReadLine();
            Console.Clear();
            hero.Statistics();
            Console.WriteLine("Тут один из павших воинов поднимается, кажется драки не избежать");

            Monster monster2 = new Monster("Зомби", 100, 27);
            fight.StartFight(hero, monster2);
            Console.ReadLine();
            Console.Clear();
            hero.Statistics();
            Console.WriteLine("Кажется, с такими ранами долго не живут, ты тяжело припадаешь на колено ");
            Console.WriteLine("Меч скользит в руке, долго я так не протяну");
            Console.WriteLine("Впереди только один путь...");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Ты кое-как доходишь до последний комнаты...и...видишь там Огромного монстра, а возле его ног... ");
            Console.WriteLine("Возле его ног ты видишь своих павших товарищей, кажется, пришла пора для последней битвы");
            Console.ReadLine();
            Console.Clear();
            Monster monster3 = new Monster("Смерть", 500, 50);
            if (hero.Memory == 1)
            {
                Console.WriteLine("Ты чувствуешь, как твои раны стали закрываться и ты где-то в голове слышишь старческий смешок");
                Console.WriteLine("Ты получаешь +1000хп");
                hero.HpHuman += 1000;
            }
            else if (hero.Memory == 0)
            {
                Console.WriteLine("Пришла пора умирать");
            }
            Console.ReadLine();
            Console.Clear();
            hero.Statistics();
            fight.StartFight(hero, monster3);
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Тварь повержена, покойтесь с миром, братцы");
            Console.ReadLine();
            Console.Clear();

        }
    }
}
