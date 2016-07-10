

namespace OOPGame.Core.Interfaces
{
    using System;
    using Models;

    public interface IHero : ICreature
    {
        event EventHandler Dead;
         
        int Experience { get; set; }

        int PotionsCount { get; set; }

        Shield Shield { get; set; }

        int BasicArmor { get; set; }

        Sword Sword { get; set; }

        int BasicDamage { get; set; }

        void UsePotion();

        void LevelUp();
    }
}
