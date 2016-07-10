namespace OOPGame.ConsoleClient
{
    using System;
    using Core.Interfaces;
    using Core.Infrastructure;
    using Core.Models;

    public static class Action
    {
        public static void Attack(ICreature attacker, ICreature deffender, int answer)
        {
            //Chance of armor deflecting the attack 
            //If armor doesnt stop the attack.
            if (RandomChance.Success(100 - deffender.Armor))
            {
                //Chance of dealing damage.
                int damageDealth = attacker.Attack(attacker.AttackChance[answer], attacker.AttackPower[answer]);
                //If any damage dealth
                if (damageDealth != 0)
                {
                    deffender.Hp -= damageDealth;
                    //If defender is dead.
                    if (deffender.Hp > 0)
                    {
                        Console.WriteLine($"{attacker.Name} dealth {damageDealth} damage. {deffender.Name} now has {deffender.Hp}HP");
                    }
                    else
                    {
                        Console.WriteLine("{1} dealth {0} damage.", damageDealth, attacker.Name);
                    }
                }
                //No damage dealth.
                else
                {
                    //Attack failed
                    Console.WriteLine("{1} couldn't perform {0}.", attacker.AttackNames[answer], attacker.Name);
                }
            }
            else
            {
                //armor blocked
                Console.WriteLine("{0}'s armor stopped {1} attack.", deffender.Name, attacker.Name);
            }
        }

        public static void GetReward(IItem item, IHero hero)
        {
            if (item is Sword)
            {
                hero.Sword = (Sword)item;
                Dialoge.NewSword(hero.Sword);
            }
            else
            {
                hero.Shield = item as Shield;
                Dialoge.NewShield(hero.Shield);
            }
            hero.LevelUp();
            Dialoge.NewLevel(hero);
        }

        public static void DrinkPotion(IHero hero)
        {
            if (hero.PotionsCount > 0)
            {
                hero.UsePotion();
            }
            else
            {
                Dialoge.NoPotions();
            }
        }
    }
}
