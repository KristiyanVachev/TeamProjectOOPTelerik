using OOPGame.Core.Interfaces;
using OOPGame.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPGame.ConsoleClient
{
    public static class EngineMethods
    {
        public static bool CheckForFinalMonster(int i,int bossIndex)
        {
            bool finalBoss = false;
            if (i == bossIndex)
            {
                finalBoss = true;
            }
            return finalBoss;
        }
        public static void Fighting(IHero hero,IMonster[] monsters,int i, IItem[] items,bool finalBoss)
        {
            const int attackMenuOpt = 4;
            int input = 0;
            while (hero.Hp > 0 && monsters[i].Hp > 0)
            {
                Dialoge.HeroAttackOptions(hero);
                input = Utillities.ValidateAnswer(attackMenuOpt);

                //Perform action based on answer
                //If answer is an attack
                if (input >= 0 && input < attackMenuOpt - 1)
                {
                    //Hero attacks monster
                    Action.Attack(hero, monsters[i], input);
                    //If monster is dead
                    if (monsters[i].Hp <= 0)
                    {
                        //Killing a commom monster
                        if (!finalBoss)
                        {
                            Dialoge.MonsterDefeated(monsters[i]);

                            Action.GetReward(items[i], hero);
                            break;
                        }
                        //Killing the Boss
                        else
                        {
                            Dialoge.BossDefeated(monsters[i]);
                        }

                    }
                    //Monster still alive
                    else
                    {
                        Action.Attack(monsters[i], hero, 0);
                    }
                    //If hero dies
                    if (hero.Hp <= 0)
                    {
                        Dialoge.HeroDied();
                        break;
                    }
                }
                //answer left is 3, drink potion
                else
                {
                    Action.DrinkPotion(hero);
                    Action.Attack(monsters[i], hero, 0);
                    if (hero.Hp <= 0)
                    {
                        Dialoge.HeroDied();
                        break;
                    }
                }
            }
        }
        public static int Menu(int i,bool finalBoss,IMonster[] monsters)
        {
            const int meetMonsterOpt = 2;
            int input;
            if (!finalBoss)
            {
                Dialoge.MeetMonster(monsters[i]);
                input = Utillities.ValidateAnswer(meetMonsterOpt);
            }
            else //Boss dialog
            {
                Dialoge.MeetBoss(monsters[i]);
                input = 0;
            }
            return input;
        }
       
}
}
