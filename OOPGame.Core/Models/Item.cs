namespace OOPGame.Core.Models
{
    using OOPGame.Core.Interfaces;

    public abstract class Item : IItem
    {
        protected Item(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }
    }
}