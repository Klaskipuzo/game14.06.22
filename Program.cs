using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using System.Collections.Generic;
// ^ задачки
namespace MyProject2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите слово (Start)");
            
            var started = Start();
            if (!started)
                return;
            
            var character = Select();
            Game(character);
            Console.WriteLine();
        }

        static bool Start()
        {
            while (true)
            {
                var str1 = "Start";
                var starts = Console.ReadLine();

                if (starts.Contains(str1))
                {
                    Console.WriteLine("Добро пожаловать!");
                    Console.WriteLine("Вы попали в мою игру! Выберите своего героя");
                    return true;
                }
                else
                {
                    Console.WriteLine("Ошибка");
                    return false;
                }
            }
        }
        
        static Character Select()
        {
            Console.WriteLine("Вы готовы сделать свой выбор?");
            while (true)
            {
                Console.WriteLine("1 - OrcWarrior \n2 - HumanWizard \n3 - ElfRogue");
                var selects = int.Parse(Console.ReadLine());

                if (selects == 1)
                {
                    var caharter = new Character { Name = "OrcWarrior", Health = 100 };
                    Console.WriteLine($"Ваш выбор могучий орк воин, который имеет здоровья: {caharter.Health}");
                    return caharter;
                }
                if (selects == 2)
                {
                    var caharter = new Character { Name = "HumanWizard", Health = 20 };
                    Console.WriteLine($"Ваш выбор мудрый волшебник, который имеет здоровья: {caharter.Health}");
                    return caharter;
                }
                if (selects == 3)
                {
                    var caharter = new Character { Name = "ElfRogue", Health = 50 };
                    Console.WriteLine($"Ваш выбор могучий ловкий плут, который имеет здоровья: {caharter.Health}");
                    return caharter;
                }

                Console.WriteLine("Вы сделали неправильный выбор");
            }
        }
      
        static void Game(Character hero)
        {
            Console.WriteLine($"\nВы оказались в тёмной комнате, сквозь темноту видно дверь и рядом стоящий сундук.\nВаши дейтвия?");

            while (true)
            {
                Console.WriteLine($"Выберите действия:\n1 - Открыть сундук\n2 - открыть дверь\n3 - Зажечь факел");
                var select = int.Parse(Console.ReadLine());
                if (select == 1)
                {
                    Console.WriteLine("При попытке открыть сундук он взрывается и вы умираете");
                    return;
                }
                if (select == 2)
                {
                    Console.WriteLine("При попытке открыть дверь вы не замечаете ловушку и сквозь отверстия в двери  вылетают ядовитые дротики и протыкают вас, вы медленно умираете");
                    return;
                }
                if (select == 3)
                {
                    Console.WriteLine("Вы зажгли факел и увидели ловушку на двери и на сундуке. При хорошем освещении вы избавились от ловушек и открыли сундук");
                    Chess(hero);
                    return;
                }
            }
        }

        static void Chess(Character hero)
        {
            string[] waepon = new string[] { "Axe", "Knife", "Staff" };
            while (true)
            {
                Console.WriteLine($"Вы открыли сундук и выдите слудующее " +
                                  $"(1){waepon[0]} (2){waepon[1]} (3){waepon[2]} " +
                                  $"Что вы выберите?");
                var take = int.Parse(Console.ReadLine());
                if (take > 0 || take <= waepon.Length - 1)
                {
                    break;
                }
                hero.Waepon = waepon[take];
            }

            Console.WriteLine($"Вы выбрали ({hero.Waepon})");
            Console.WriteLine("Взяв свое первое оружие вы  вы слышите шум позади себя\nНА ВАС НАПАЛ МОНСТР, ЗАЩИЩАЙТЕСЬ! ");

            FightOrc(hero);
        }

        static void FightOrc(Character hero)
        {
            var Monster = 100;
            var hits = Roll.Next();
            hero.Damage(hits);
            
            Console.WriteLine($"Монстр бьет вас уроном в размере {hits} у вас остается {hero.Health}");
            Console.WriteLine("На данный момент все");
        }
    }
}