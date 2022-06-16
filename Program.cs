using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using System.Collections.Generic;

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
                    var caharter = new Character { Name = "OrcWarrior", Health = 1000, Strange = 25, Dextery = 10,Wisdom = 5, Armor = 15, Throw = 50 , Torch = "Способность зажечь факел и осветить путь" };
                    Console.WriteLine($"Ваш выбор могучий орк воин, который имеет данные характеристики:\nЗдоровье - {caharter.Health}\nСила - {caharter.Strange}\nЛовкость - {caharter.Dextery}\nМудрость - {caharter.Wisdom}\nЗащита - {caharter.Armor}");
                    return caharter;
                    
                    
                }
                if (selects == 2)
                {
                    var caharter = new Character { Name = "HumanWizard", Health = 200, Strange = 5, Dextery = 5,Wisdom = 25, Armor = 5, Fire_ball = 100, Firefly = "Вазвать волшебного светлячка который осветит вам путь", Alohomora = "Вскроет любой замок" };
                    Console.WriteLine($"Ваш выбор мудрый волшебник, который имеет данные характеристики:\nЗдоровье - {caharter.Health}\nСила - {caharter.Strange}\nЛовкость - {caharter.Dextery}\nМудрость - {caharter.Wisdom}\nЗащита - {caharter.Armor}");
                    return caharter;
                }
                if (selects == 3)
                {
                    var caharter = new Character { Name = "ElfRogue", Health = 500, Strange = 10, Dextery = 25, Wisdom = 10, Armor = 10, Cat_s_eyes = "Использовать кошачьи глаза для ночого зрения", Breaking = "Вскрыть любой замок"};
                    Console.WriteLine($"Ваш выбор могучий ловкий плут, который имеет данные характеристики:\nЗдоровье - {caharter.Health}\nСила - {caharter.Strange}\nЛовкость - {caharter.Dextery}\nМудрость - {caharter.Wisdom}\nЗащита - {caharter.Armor}");
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
                Console.WriteLine($"Выберите действия:\n1 - Открыть сундук\n2 - открыть дверь\n3 - Использовать свособность освещения");
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
                    if(hero)
                    
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

            
            Console.WriteLine("Взяв свое первое оружие вы  вы слышите шум позади себя\nНА ВАС НАПАЛ МОНСТР, ЗАЩИЩАЙТЕСЬ! ");

            Fight(hero);
        }
        /// <summary>
        /// Метод боя
        /// </summary>
        /// <param name="hero"></param>
        static void Fight(Character hero)
        {

            var rolls = Roll.Next();
            var hit = Roll.Next();
            Console.WriteLine("Что-бы победить монстра, вам нужно бросить игральные кости два раза.");
            Console.WriteLine("У каждого монстра имеется броня, поэтому первый бросок должен дать в сумму равную броне или выше");
            Console.WriteLine("А вторрой бросок сумма урона");
            Console.WriteLine("Вы готовы бросить кости ?");
            Console.WriteLine($"Ваши действия : \n 1) Бросить игральные кости.");
            var Trolls = new Monsters { Name = "Fat Troll", Health = 800, Strange = 25, Dextery = 2, Wisdom = 1, Armor = 10 };

            var action = int.Parse(Console.ReadLine());
            
                if (action == 1)
                {
                    Console.WriteLine($"Ваши кости выдали {rolls}");
                    if (rolls > Trolls.Armor)
                    {
                        Console.WriteLine($"Вы пробили Жирного троля и нанесли ему {hit} урона. Теперь у него ({Trolls.Health - hit}) здоровья");
                    }
                    else if (rolls < Trolls.Armor)
                    {
                        Console.WriteLine("Увы, вы не пробили Жирного троля");
                    }
                    Console.WriteLine("Троль дождался своей очереди и замахивается своим топором");
                    if (rolls > hero.Armor)
                    {
                        Console.WriteLine($"Тролль пробил вас и оставил вам ( {hero.Health - hit}) здоровья");
                    }
                    else if (rolls < hero.Armor)
                    {
                        Console.WriteLine("Поздравляю, вас не пробили");
                    }

                }
                             
                /// 
            
        }

        static Monsters Monster(Monsters Troll)
        {
            var Trolls = new Monsters { Name = "Fat Troll", Health = 800, Strange = 25, Dextery = 2, Wisdom = 1, Armor = 10 };
            return Trolls;
        }
    }
}