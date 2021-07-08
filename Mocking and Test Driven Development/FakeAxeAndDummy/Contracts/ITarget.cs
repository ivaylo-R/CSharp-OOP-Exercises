namespace FakeAxeAndDummy.Contracts
{
    public interface ITarget
    {
        public void TakeAttack(int AttackPoints);
        public bool IsDead();

        public int GiveExperience();
    }
}
