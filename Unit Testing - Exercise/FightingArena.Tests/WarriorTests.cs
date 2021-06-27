//using FightingArena;
using NUnit.Framework;
using System;

namespace Tests
{
    public class WarriorTests
    {
        private Warrior fighter;
        private Warrior defender;
        [SetUp]
        public void Setup()
        {
            //fighter = new Warrior("Gosho", 50, 50);
            //defender = new Warrior("Pesho", 50, 50);
        }

        [TestCase("Gosho", 50, 50)]
        [TestCase("Pesho", 63, 58)]
        public void ConstructorShouldReturnCorrectValues(
            string name, int damage, int hp)
        {
            fighter = new Warrior(name, damage, hp);
            Assert.AreEqual(name, fighter.Name);
            Assert.AreEqual(damage, fighter.Damage);
            Assert.AreEqual(hp, fighter.HP);
        }

        [TestCase(null, 50, 60)]
        [TestCase(" ", 35, 46)]
        [TestCase("", 100, 100)]
        [TestCase("Mitko", 0, 100)]
        [TestCase("Gosho", -1, 100)]
        [TestCase("Test", 40, -16)]
        public void NameShoudlBeCorrectAsExpected(string name,
            int dmg, int hp)
            => Assert.Throws<ArgumentException>(()
                 => new Warrior(name, dmg, hp));

        [TestCase("Mitko", 10, 20, "Test", 10, 35)]
        [TestCase("Mitko", 10, 35, "Test", 10, 29)]
        [TestCase("Mitko", 10, 50, "Test", 59, 60)]
        //[TestCase("Mitko", 50, 100, "Test", 45, 60)]
        public void AttackShouldReturnResultAsExpected(string fighterName,int fighterDmg,
            int fighterHp,string defenderName,int defenderDmg,int defenderHp)
        {
            fighter = new Warrior(fighterName, fighterDmg, fighterHp);
            defender = new Warrior(defenderName, defenderDmg, defenderHp);
            Assert.That(() => fighter.Attack(defender), Throws
                .InvalidOperationException);
        }

        [TestCase("Mitko", 50, 100,"Test",45,45)]
        public void DefenderHpShouldBeEqualToZeroWhenHeWasAttackedWithMoreDmgThanhisHp(string fighterName,
            int fighterDmg,int fighterHp, string defenderName, int defenderDmg, int defenderHp)
        {
            fighter = new Warrior(fighterName, fighterDmg, fighterHp);
            defender = new Warrior(defenderName, defenderDmg, defenderHp);
            fighter.Attack(defender);
            int expectedHp = 0;
            Assert.AreEqual(expectedHp,defender.HP);
        }


    }
}