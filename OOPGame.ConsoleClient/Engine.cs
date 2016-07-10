namespace OOPGame.ConsoleClient
{
    using System;

    using Core.Interfaces;
    using Core.Models;

    public static class Engine
    {
        private static event EventHandler Start;

        public static void Initialize()
        {            
            Start += Dialoge.OnStart;

            OnStart();

            string name = Console.ReadLine();
            IHero hero = new Hero(name);

            hero.Dead += Dialoge.OnHeroDead;


            IMonster[] monsters = Seed.SeedMonsters();
            IItem[] items = Seed.SeedRewards();

            bool finalBoss = false;
            int bossIndex = monsters.Length - 1;
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            
            //Meet every monster.
            for (int i = 0; i < monsters.Length; i++)
            {
                //If you are up against the final monster -> special boss dialog.
                finalBoss = EngineMethods.CheckForFinalMonster(i, bossIndex);

                //Hero attack or flee menu
                int input = EngineMethods.Menu(i, finalBoss, monsters);
                
                //Option fight
                if (input == 0)
                {
                    //Fight until one is dead
                    EngineMethods.Fighting(hero, monsters, i, items, finalBoss);
                }
                //Option left - 1. flee
                else
                {
                    int damageSuffered = monsters[i].DamageOnFlee();
                    hero.Hp -= damageSuffered;
                    if (hero.IsDead())
                    {
                        Dialoge.HeroDiedFleeing();
                        break;
                    }

                    Dialoge.DamageTakenOnFlee(monsters[i], hero, damageSuffered);
                }
            }
        }

        private static void OnStart()
        {
            Start?.Invoke(null,EventArgs.Empty);
        }
    }

}
