using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPGame.Core.Interfaces;

namespace OOPGame.Core.Models
{
    public abstract class Monster : Creature, IMonster
    {
        //constructor
        protected Monster(string name, int maxHp, int damage, int armor, int level, string weakAttackName, string strongAttackName, string ultimateAttackName) :
            base(name, maxHp, damage, armor, level, weakAttackName, strongAttackName, ultimateAttackName)
        {
            this.Hp = maxHp;
        }

        //public Monster(string name, int maxHp, int damage, int armor, int level,  string weakAttack, string strongAttack, string UltAttack)
        //    : base()
        //{
        //}
        //public Monster(string name, int maxHp, int damage, int armor, int level,  string weakAttack, string strongAttack, string UltAttack) : base(name)
        //{
        //    this.MaxHp = maxHp;
        //    this.Hp = maxHp;
        //    this.Damage = damage;
        //    this.Armor = armor;
        //    this.Level = level;
        //    this.AttackNames = new string[3];
        //    this.AttackNames[0] = weakAttack;
        //    this.AttackNames[1] = strongAttack;
        //    this.AttackNames[2] = UltAttack;
        //}

        //methods
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
