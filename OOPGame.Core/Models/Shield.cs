namespace OOPGame.Core.Models
{
    using Interfaces;

    public class Shield : Item, IShield
    {
        public Shield(string name, int armor) : base(name)
        {
            this.Armor = armor;
        }

        public int Armor { get; set; }
    }
}
