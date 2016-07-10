namespace OOPGame.Core.Models
{
    using System;
    using OOPGame.Core.Interfaces;

    public class Hero : Creature, IHero
    {
        //fields

        //Constructors
        public Hero(string name) : base(name)
        {     
            //TODO: create logic for hero initiliasation, that avoids those hardcodes bellow
            this.Experience = 0;
            this.Level = 1;
            this.MaxHp = 100;
            this.Hp = this.MaxHp;
            this.BasicArmor = 5;
            this.Shield = new Shield("Wooden Round Shield", 20);
            this.Armor = this.BasicArmor + this.Shield.Armor;
            this.BasicDamage = 20;
            this.Sword = new Sword("Short Sword", 30, "Blow");
            this.Damage = this.BasicDamage + this.Sword.Damage;
            this.PotionsCount = 3;
            this.AttackNames = new string[3];
            this.AttackNames[0] = "Punch";
            this.AttackNames[1] = Sword.AttackName;
            this.AttackNames[2] = "MEGA cool Attack";
        }

        public Hero(string name, int maxHp, int damage, int armor, int level, string weakAttackName, string strongAttackName, string ultimateAttackName) :
            base(name, maxHp, damage, armor, level, weakAttackName, strongAttackName, ultimateAttackName)
        {
           
        }

        public event EventHandler Dead;

        //properties

        public int Experience { get; set; }

        public int BasicArmor { get; set; }

        public Shield Shield { get; set; }

        public int BasicDamage { get; set; }

        public Sword Sword { get; set; }

        public int PotionsCount { get; set; }


        //Methods

        //TODO: take notice of potion count when the hero's inventory is implamented (which maybe renders this method redundant..)
        public void UsePotion()
        {
            if (this.PotionsCount > 0)
            {
                //potions restore 50% of max health
                int restoredHp = this.MaxHp / 2;
                if (this.Hp + restoredHp > this.MaxHp)
                {
                    this.Hp = this.MaxHp;
                }
                else
                {
                    this.Hp += restoredHp;
                }
                this.PotionsCount--;
            }
        }

        public override void FinalWords()
        {
            Console.WriteLine("Ahh you bastard!");
        }

        public void LevelUp()
        {
            this.Level++;
            this.MaxHp += 100;
            this.Hp = MaxHp;
            this.BasicArmor += 5;
            this.Armor = this.BasicArmor + this.Shield.Armor;
            this.BasicDamage += 15;
            this.Damage = this.BasicDamage + this.Sword.Damage;
        }

        public override bool IsDead()
        {
            if (base.IsDead())
            {
                OnDead();
                return true;
            }
            return false;
        }

        protected virtual void OnDead()
        {
            Dead?.Invoke(this,EventArgs.Empty);
        }
    }
}
