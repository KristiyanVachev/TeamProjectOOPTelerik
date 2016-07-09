namespace OOPGame.Core.Models
{
    using System;
    using OOPGame.Core.Interfaces;

    public class WeakMonster : Monster
    {
        public WeakMonster(string name, int maxHp, int damage, int armor, int level, string weakAttackName, string strongAttackName, string ultimateAttackName) : base(name, maxHp, damage, armor, level, weakAttackName, strongAttackName, ultimateAttackName)
        {
        }

        public override void FinalWords()
        {
            Console.WriteLine("Are your proud of yourself? This is animal brutality!");
        }
    }
}