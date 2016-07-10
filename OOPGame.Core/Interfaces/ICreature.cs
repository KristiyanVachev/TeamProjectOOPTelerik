namespace OOPGame.Core.Interfaces
{
    public interface ICreature
    {
        #region Properties
        string Name { get; set; }

        int MaxHp { get; set; }

        int Hp { get; set; }

        int Damage { get; set; }

        int Armor { get; set; }

        int Level { get; set; }

        int[] AttackChance { get; }

        double[] AttackPower { get; }

        string[] AttackNames { get; set; }
        #endregion

        #region Methods
        int Attack(int chance, double multiplier);

        int WeakAttack();

        int StrongAttack();

        int UltimateAttack();

        void FinalWords();

        bool IsDead();
        #endregion
    }
}
