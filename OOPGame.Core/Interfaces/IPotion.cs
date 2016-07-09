namespace OOPGame.Core.Interfaces
{
    public interface IPotion : IItem , IConsumable
    {
        int HpPercantageRestore { get; set; }
    }
}
