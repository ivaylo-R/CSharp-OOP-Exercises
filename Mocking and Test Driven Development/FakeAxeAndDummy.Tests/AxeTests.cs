using FakeAxeAndDummy.Contracts;
using FakeAxeAndDummy.Fakez;
using Moq;
using NUnit.Framework;

[TestFixture]
public class AxeTests
{
    private ITarget target;
    private IWeapon weapon;
    private Hero hero;
    

    [SetUp]
    public void SetUp()
    {
        this.target = new FakeDummy();
        this.weapon = new FakeWeapon();
        this.hero = new Hero("Pesho", weapon);
    }

    [Test]
    public void GivenHero_WhenAttackedTargetDies_ThenHeroReceivesExp()
    {
        this.hero.Attack(target);
        Assert.AreEqual(10, hero.Experience);
    }

    [Test]
    public void HeroShoudlReceiveExperienceWhenItAttackTarget()
    {
        Mock<ITarget> target = new Mock<ITarget>();
        Mock<IWeapon> weapon = new Mock<IWeapon>();
        Mock<IHero> hero = new Mock<IHero>();
        hero.Setup(w=>w.Weapon).
        hero.Object.Attack(target.Object);
        Assert.AreEqual(10, hero.Object.Experience);
    }



}