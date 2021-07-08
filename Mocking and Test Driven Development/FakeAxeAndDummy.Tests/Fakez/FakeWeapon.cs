using FakeAxeAndDummy.Contracts;

namespace FakeAxeAndDummy.Fakez
{
    class FakeWeapon : IWeapon
    {
        public int AttackPoints => 10;

        public int DurabilityPoints => 10;

        public void Attack(ITarget target)
        {
            
        }
    }
}
