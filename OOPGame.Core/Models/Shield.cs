namespace OOPGame.Core.Models
{
    using OOPGame.Core.Interfaces;

    public class Shield : Item, IShield
    {
        public Shield(string name, int armor) : base(name)
        {
            this.Armor = armor;
        }

        public int Armor { get; set; }
    }
}
