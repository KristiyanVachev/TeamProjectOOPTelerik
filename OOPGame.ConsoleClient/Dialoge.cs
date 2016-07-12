using OOPGame.Core.Infrastructure;

namespace OOPGame.ConsoleClient
{
    using System;
    using Core.Interfaces;

    public class Dialoge
    {
        public static void MeetMonster(IMonster monster)
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("There is a {0} ahead.", monster.Name);
            Console.WriteLine("0. Fight");
            Console.WriteLine("1. Flee");
        }

        public static void MeetBoss(IMonster boss)
        {
            Console.WriteLine("You have reached the mighty {0}. You must slay it to save your princess!", boss.Name);
        }

        public static void HeroAttackOptions(IHero hero)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            for (int j = 0; j < hero.AttackNames.Length; j++)
            {
                Console.WriteLine("{0}. Attack with {1}", j, hero.AttackNames[j]);
            }
            Console.WriteLine("3. Drink potion");
        }

        public static void BossDefeated(IMonster boss)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("You have defeated the ëvil {0} and have saved your princess.", boss.Name);
        }

        public static void DamageTakenOnFlee(IMonster monster, IHero hero, int damageSuffered)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("While you were fleeing {0} dealth you {1}. You now have {2}HP.", monster.Name, damageSuffered, hero.Hp);

        }

        public static void HeroDiedFleeing()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("You have died while fleeing. Shame!");
        }

        public static void NewSword(ISword sword)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("You have found a new sword: {0} with {1} damage and special attack: {2}. ", sword.Name, sword.Damage, sword.AttackName);
        }

        public static void NewShield(IShield shield)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("You have found a new shield: {0} with {1} armor. ", shield.Name, shield.Armor);
        }

        public static void NewLevel(IHero hero)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("{0} - HP: {1} - Damage: {2} - Armor: {3}", hero.Name, hero.Hp, hero.Damage, hero.Armor);
        }

        public static void NoPotions()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("You don't have any potions.");
        }

        public static void OnHeroDead(object source, EventArgs args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("You have died and have failed your princess.");
        }
        public static void OnStart(object source, EventArgs args)
        {
            string s = "LIU KANG TEAM PROJECT";
            Console.SetCursorPosition((Console.WindowWidth - s.Length) / 2, Console.CursorTop);
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(s);
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("Enter your hero's name: ");
        }
        public static void OnMonsterDefeated(object source, MonsterArgs args)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("You have defeated {0} and have reached a new level.", args.Monster.Name);
        }
        public static void OnUsedPotion(object source, HeroArgs args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("You used a potion and now have {0}HP.", args.Hero.Hp);
        }
    }
}
