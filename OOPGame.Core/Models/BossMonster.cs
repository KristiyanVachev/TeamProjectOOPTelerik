namespace OOPGame.Core.Models
{
    using System;
    using OOPGame.Core.Interfaces;

    public class BossMonster : Monster
    {
        public BossMonster(string name, int maxHp, int damage, int armor, int level, string weakAttackName, string strongAttackName, string ultimateAttackName) : base(name, maxHp, damage, armor, level, weakAttackName, strongAttackName, ultimateAttackName)
        {
        }

        public override int DamageOnFlee()
        {
            return base.DamageOnFlee() * 65535; //If you flee the boss you lose.
        }

        public override void FinalWords()
        {
            Console.WriteLine("Puny programmer! How did you kill me?.. C# must be a powerful weapon!");
        }
    }
}