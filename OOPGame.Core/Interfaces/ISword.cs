namespace OOPGame.Core.Interfaces
{
    public interface ISword : IWearable
    {
        int Damage { get; set; }

        string AttackName { get; set; }
    }
}
