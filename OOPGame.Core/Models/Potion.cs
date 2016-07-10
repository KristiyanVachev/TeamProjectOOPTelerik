namespace OOPGame.Core.Models
{
    using Interfaces;

    public class Potion : Item, IPotion
    {
        public Potion(string name, int hpPercantageRestore) : base(name)
        {
            this.HpPercantageRestore = hpPercantageRestore;
        }

        public int HpPercantageRestore { get; set; }
    }
}