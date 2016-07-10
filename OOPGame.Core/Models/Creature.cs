namespace OOPGame.Core.Models
{
    using System;

    using Interfaces;
    using Infrastructure;

    public abstract class Creature : ICreature
    {
        #region Fields
        private string name;
        private readonly int[] attackChance = { 80, 60, 30 };
        private readonly double[] attackPower = { 0.5, 1, 2 };
        #endregion

        #region ctors
                protected Creature(string name)
                {
                    this.Name = name;
                }

                protected Creature(string name, int maxHp, int damage, int armor, int level, string weakAttackName, string strongAttackName, string ultimateAttackName) : 
                    this (name)
                {
                    this.MaxHp = maxHp;
                    this.Hp = maxHp;
                    this.Damage = damage;
                    this.Armor = armor;
                    this.Level = level;
                    this.AttackNames = new string[3];
                    this.AttackNames[0] = weakAttackName;
                    this.AttackNames[1] = strongAttackName;
                    this.AttackNames[2] = ultimateAttackName;
                }
        #endregion

        #region Properties
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                //simple validation
                this.name = string.IsNullOrEmpty(value) ? "Stamat" : value;
            }
        }

        public int MaxHp { get; set; }

        public int Hp { get; set; }

        public int Damage { get; set; }

        public int Armor { get; set; }

        public int Level { get; set; }

        public int[] AttackChance { get { return this.attackChance; } }

        public double[] AttackPower { get { return this.attackPower; } }

        public string[] AttackNames { get; set; }
        #endregion

        #region Public Methods
        public int Attack(int chance, double multiplier)
        {
            //80% chance for a strike
            if (RandomChance.Success(chance))
            {
                return Convert.ToInt32(this.Damage * multiplier);
            }

            return 0;

        }

        public int WeakAttack()
        {
            //80% chance for a strike
            if (RandomChance.Success(80))
            {
                return this.Damage / 2;
            }

            return 0;
        }

        public int StrongAttack()
        {
            //55% chance for a strike
            if (RandomChance.Success(55))
            {
                return this.Damage;
            }

            return 0;
        }

        public int UltimateAttack()
        {
            //30% chance for a strike
            if (RandomChance.Success(30))
            {
                return this.Damage * 2;
            }

            return 0;
        }

        public virtual bool IsDead()
        {
            return this.Hp <= 0;
        }

        public abstract void FinalWords();
        #endregion
    }
}
