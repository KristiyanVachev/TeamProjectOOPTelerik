namespace OOPGame.Core.Interfaces
{
    public interface ISword : IItem , IWearable
    {
        int Damage { get; set; }

        string AttackName { get; set; }
    }
}
