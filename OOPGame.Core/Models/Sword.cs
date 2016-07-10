namespace OOPGame.Core.Models
{
    using Interfaces;

    public class Sword : Item, ISword
    {
        public Sword(string name, int damage, string attackName) : base(name)
        {
            this.Damage = damage;
            this.AttackName = attackName;
        }

        public int Damage { get; set; }

        public string AttackName { get; set; }
    }
}
