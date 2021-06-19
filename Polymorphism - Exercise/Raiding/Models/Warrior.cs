namespace Raiding.Models
{
    public class Warrior : BaseHero
    {
        private const int power = 100;
        public Warrior(string name)
            : base(name)
        {
            this.Power = power;
        }
        public override string CastAbility()
        => $"{this.GetType().Name} - {this.Name} hit for {this.Power} damage";
    }
}
