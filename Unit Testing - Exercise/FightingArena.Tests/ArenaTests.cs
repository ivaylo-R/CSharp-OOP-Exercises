//using FightingArena;
using NUnit.Framework;
using System.Collections.Generic;
using System.Reflection;

namespace Tests
{
    public class ArenaTests
    {
        Arena arena;
        Warrior warrior;
        Warrior secondWarrior;

        [SetUp]
        public void Setup()
        {
            arena = new Arena();
            warrior = new Warrior("Mitko", 50, 50);
            secondWarrior = new Warrior("Pesho", 50, 60);
        }

        [Test]
        public void ArenaShouldNotBeAbbleAddTheSameWarrior()
        {
            arena.Enroll(warrior);
            Assert.That(() => arena.Enroll(warrior), Throws.InvalidOperationException
                .With.Message.EqualTo("Warrior is already enrolled for the fights!"));
        }

        [TestCase("Pesho",null)]
        [TestCase(null,"Gosho")]
        [TestCase(null,null)]
        public void FightShouldNotBeDoneWhenOneOfTheFightersIsNotEnrolled(string firstWarriorName
            , string secondWarriorName)
        {
            arena.Enroll(warrior);
            Assert.That(() => arena.Fight(firstWarriorName, secondWarriorName)
                , Throws.InvalidOperationException);
                
        }

        [Test]
        public void ArenaShouldReturnCountAsExpected()
        {
            arena.Enroll(secondWarrior);
            int expectedCount = 1;
            int actualCount = arena.Count;
            Assert.AreEqual(expectedCount, actualCount);
        }

        [Test]
        public void ConstructorShouldReturnNewCollection()
        {
            Assert.IsNotNull(arena.Warriors);
        }

        
    }
}
