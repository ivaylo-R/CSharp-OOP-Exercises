namespace Raiding.Models
{
    public abstract class BaseHero
    {
        public  string Name { get; private set; }
        public int Power { get; protected set; }
        public BaseHero(string name)
        {
            this.Name = name;
        }

        public abstract string CastAbility();
        
    }
}
