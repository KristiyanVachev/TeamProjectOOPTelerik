namespace OOPGame.Core.Interfaces
{
    public interface IInventory
    {
        void AddItem(IItem item);
        void RemoveItem(IItem item);
        bool CheckIfItemExist(IItem item);
    }
}