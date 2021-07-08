using FakeAxeAndDummy.Contracts;

namespace FakeAxeAndDummy.Fakez
{
    public class FakeDummy : ITarget
    {
        public int GiveExperience()
            => 10;

        public bool IsDead()
            => true;

        public void TakeAttack(int AttackPoints)
        {
            
        }
    }
}
