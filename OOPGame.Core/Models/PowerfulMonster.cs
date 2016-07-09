namespace OOPGame.Core.Models
{
    using System;

    public class PowerfulMonster : Monster
    {
        public PowerfulMonster(string name, int maxHp, int damage, int armor, int level, string weakAttackName, string strongAttackName, string ultimateAttackName) : 
            base(name, maxHp, damage, armor, level, weakAttackName, strongAttackName, ultimateAttackName)
        {
        }

        public override int DamageOnFlee()
        {
            return base.DamageOnFlee() * 2;
        }

        public override void FinalWords()
        {
            Console.WriteLine("Ohhhrghrh *drowns in own blood*");
        }
    }
}