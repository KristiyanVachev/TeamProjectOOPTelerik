namespace OOPGame.Core.Models
{
    using Interfaces;

    public abstract class Item : IItem
    {
        protected Item(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }
    }
}