namespace OOPGame.Core.Models
{
    using System;
    using System.Collections.Generic;

    using Interfaces;

    public class Inventory : IInventory
    {
        #region Fields
        private readonly ICollection<IItem> itemsCollection;

        //private IHero ownerHero;
        #endregion

        #region ctors
        public Inventory()
        {
            this.itemsCollection = new List<IItem>();
            // this.ownerHero = hero;
        }
        #endregion

        #region Public Methods
        public void AddItem(IItem item)
        {
            this.itemsCollection.Add(item);
        }

        public void RemoveItem(IItem item)
        {
            if (CheckIfItemExist(item))
            {
                this.itemsCollection.Remove(item);
            }
            Console.WriteLine("No such item to remove!");
        }

        public bool CheckIfItemExist(IItem item)
        {
            var contains = this.itemsCollection.Contains(item);
            return contains;
        }
        #endregion
    }
}