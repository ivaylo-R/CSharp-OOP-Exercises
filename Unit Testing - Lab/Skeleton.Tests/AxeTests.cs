using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System;
using Assert = NUnit.Framework.Assert;

[TestFixture]
public class AxeTests
{
    private Axe axe;
    private Dummy dummy;
    private const int BROKEN_AXE_DURABILITY = 0;
    private const int DEFAULT_AXE_ATTACKPOINTS = 10;
    private const int DEFAULT_AXE_DURABILITY = 10;
    private const int DEFAULT_DUMMY_HEALTH = 10;
    private const int DEFAULT_DUMMY_EXP = 10;

    [SetUp]
    public void Initialize()
    {
        axe = new Axe(DEFAULT_AXE_ATTACKPOINTS,DEFAULT_AXE_DURABILITY);
        dummy = new Dummy(DEFAULT_DUMMY_HEALTH, DEFAULT_DUMMY_EXP);
    }

    [Test]
    public void CheckIfWeaponLosesDurabilityAfterEachAttack()
    {
        //Act
        axe.Attack(dummy);

        //Assert
        Assert.That(axe.DurabilityPoints, Is.EqualTo(DEFAULT_AXE_DURABILITY-1), "Axe durabillity doesnt change after attack");
    }

    [Test]
    public void TestAttackingWithABrokenWeapon()
    {
        //Arrange
        axe = new Axe(DEFAULT_AXE_ATTACKPOINTS, BROKEN_AXE_DURABILITY);

        //Act && Assert

        var ex = Assert.Throws<InvalidOperationException>(() => axe.Attack(dummy));
        Assert.That(ex.Message, Is.EqualTo("Axe is broken."));
    }

    

    


}