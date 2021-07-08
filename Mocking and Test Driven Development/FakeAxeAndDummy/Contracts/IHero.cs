namespace FakeAxeAndDummy.Contracts
{
    public interface IHero
    {
        public string Name { get; }


        public int Experience { get; }


        public IWeapon Weapon { get; }


        public void Attack(ITarget target);

    }
}
