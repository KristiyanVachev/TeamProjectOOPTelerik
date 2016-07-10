namespace OOPGame.Core.Interfaces
{
    using System;
    using Models;
    using Infrastructure;

    public interface IHero : ICreature
    {
        #region Events
        event EventHandler Dead;
        event EventHandler<HeroArgs> DrinkPotion;
        #endregion
        
        #region Properties
        int Experience { get; set; }

        int PotionsCount { get; set; }

        Shield Shield { get; set; }

        int BasicArmor { get; set; }

        Sword Sword { get; set; }

        int BasicDamage { get; set; }
        #endregion

        #region Methods
        void UsePotion();
        void LevelUp();
        #endregion
    }
}
