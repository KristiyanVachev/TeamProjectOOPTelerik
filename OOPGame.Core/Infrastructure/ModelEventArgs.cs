namespace OOPGame.Core.Infrastructure
{
    using System;
    using Interfaces;

    public class MonsterArgs : EventArgs
    {
        public IMonster Monster { get; set; }
    }

    public class HeroArgs : EventArgs
    {
        public IHero Hero { get; set; }
    }
}
