namespace OOPGame.Core.Models
{
    using System;
    using Interfaces;

    public abstract class Monster : Creature, IMonster
    {
       
        protected Monster(string name, int maxHp, int damage, int armor, int level, string weakAttackName, string strongAttackName, string ultimateAttackName) :
            base(name, maxHp, damage, armor, level, weakAttackName, strongAttackName, ultimateAttackName)
        {
            this.Hp = maxHp;
        }

        public virtual int DamageOnFlee()
        {
            Random rnd = new Random();
            //Inflict a random damage between the weakest and strongest attack.
            int damageDealth = rnd.Next(this.Damage / 2, this.Damage * 2);
            return damageDealth;
        }

        //maybe remove this.
        public override void FinalWords()
        {
            Console.WriteLine("Grr myr pur, vyh kak me slay-na!");
        }
    }
}
