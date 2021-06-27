using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Database1;
namespace Tests
{
    [TestFixture]
    public class DatabaseTests
    {
        private Database data;
        private const int maxDataLength = 16;
        private int[] initialData = new int[] { 1, 2 };

        private Random rand = new Random();

        [SetUp]
        public void Setup()
        {
            data = new Database(initialData);
        }

        [Test]
        public void ConstructorsShoudlHaveIntegersOnly()
        {
            ConstructorInfo[] constructors = data.GetType().GetConstructors();
            ParameterInfo [] parameters = constructors[0].GetParameters();
            var parameterType = parameters[0].ParameterType.Name;
            Assert.AreEqual(parameterType, initialData.GetType().Name);
            
        }

        [Test]
        public void SizeOfTheArrayShouldNotBeOver16Integers()
        {
            initialData = new int[maxDataLength];
            data = new Database(initialData);
            Assert.Throws<InvalidOperationException>(() => this.data.Add((int)rand.Next()));
        }

        [Test]
        public void AddShouldIncreaseCount()
        {
            data.Add(rand.Next());
            int expectedCount = this.initialData.Length + 1;
            int actualCount = data.Count;
            Assert.That(expectedCount, Is.EqualTo(actualCount));
        }

        [Test]
        public void RemoveShouldThrowExceptionIfDatabaseIsEmpty()
        {
            //Arrange
            data = new Database(new int[0]);
            //Act && Assert
            Assert.Throws<InvalidOperationException>(() 
                => { data.Remove(); }, "The collection is empty!");

        }

        [Test]
        public void RemoveShouldDecreaseCountOfDatabaseWhenSuccess()
        {
            data.Remove();
            int actualCount = data.Count;
            int expectedCount = 1;
            Assert.That(expectedCount, Is.EqualTo(actualCount));
        }

        [Test]
        public void FetchShouldReturnsElementAsArray()
        {
            var expectedResult = initialData;
            var actualresult = data.Fetch();
            Assert.That(expectedResult, Is.EqualTo(actualresult));
        }

        [TestCase(new int[] { 1, 2, 3 })]
        [TestCase(new int[] { })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 })]
        public void FetchShouldReturnCopyOfDatabase(int[] expectedData)
        {
            this.data = new Database(expectedData);
            int[] actualData = data.Fetch();
            CollectionAssert.AreEquivalent(expectedData, actualData);
            //Assert.AreEqual(expectedData, actualData);
        }
    }
}