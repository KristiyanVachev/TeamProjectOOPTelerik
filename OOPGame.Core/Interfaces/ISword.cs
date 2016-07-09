namespace OOPGame.Core.Interfaces
{
    public interface ISword : IItem
    {
        int Damage { get; set; }

        string AttackName { get; set; }
    }
}
