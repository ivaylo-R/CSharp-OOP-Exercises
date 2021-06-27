using NUnit.Framework;
using System;
using ExtendedDatabase1;
using System.Reflection;

namespace Tests
{
    public class ExtendedDatabaseTests
    {
        private ExtendedDatabase database;
        private Person person;
        private Person person2;
        private Person[] persons;
        [SetUp]
        public void Setup()
        {
            person = new Person(1, "Mitko");
            person2 = new Person(2, "Pesho");
            database = new ExtendedDatabase();
            persons = new Person[]
            {
                person,
                person2
            };
        }

        [Test]
        public void ConstructorsShoudlTakeOnlyTypeOfPerson()
        {
            ConstructorInfo[] constructors = database.GetType().GetConstructors();
            ParameterInfo[] parameters = constructors[0].GetParameters();
            var parameter = parameters[0].ParameterType.Name;
            
            Assert.AreEqual(parameter,typeof(Person []).Name);
        }

        [Test]
        public void ConstructorShouldReturnCorrectCount()
        {
            int expectedCount = 2;
            database = new ExtendedDatabase(persons);
            int actualCount = database.Count;
            Assert.AreEqual(expectedCount, actualCount);
        }

        [Test]
        public void ConstructorShouldReturnCorrectPersonInfo()
        {
            database = new ExtendedDatabase(person);
            string personName = person.UserName;
            long personId = person.Id;

            Assert.AreEqual(personName, database.FindByUsername(personName).UserName);
            Assert.AreEqual(personId, database.FindById(personId).Id);
        }

        [Test]
        public void IfThereAreUserWithTheSameNameThrowException()
        {
            database.Add(person);

            Assert.Throws<InvalidOperationException>(()
                =>
            { database.Add(new Person(15, "Mitko")); }, "There is already user with this username!");
        }

        [Test]
        public void IfThereAreUserWithTheSameIDThrowException()
        {
            database.Add(person);
            Person personWithTheSameId = new Person(1, "Gosho");
            //Assert.Throws<InvalidOperationException>(()
            //    =>
            //{ database.Add(new Person(1, "Pesho")); }, "There is already user with this Id!");
            Assert.That(() => database.Add(personWithTheSameId), Throws.InvalidOperationException
                .With.Message.EqualTo("There is already user with this Id!"));
        }

        [Test]
        public void IfDatabaseCountIsEqualToZeroThrowException()
        {
            Assert.Throws<InvalidOperationException>(() => database.Remove());
        }

        [Test]
        public void IfNoUserIsPresentByThisUsername()
        {
            Assert.That(()
                => database.FindByUsername(null), Throws.ArgumentNullException
                .With.Message.EqualTo("Value cannot be null. (Parameter 'Username parameter is null!')"));
        }

        
        [Test]
        public void ProvidedDataShouldBeInRangeFromZeroToSixteen()
        {
            Assert.Throws<ArgumentException>(()
             =>
                { database = new ExtendedDatabase(new Person[18]); }, "Provided data length should be in range [0..16]!");
            
        }

        [Test]
        public void ArgumentsShouldBeCaseSensitive()
        {
            string expectedName = "Name";
            string actualName = "Name";

            Assert.AreEqual(expectedName, actualName);
        }

        [Test]
        public void PersonListShouldBeExactSixteenYears()
        {
            Person[] persons = new Person[16];

            for (int i = 0; i < persons.Length; i++)
            {
                persons[i] = new Person(i, $"c{i}");
            }
            database = new ExtendedDatabase(persons);
            
            Assert.That(() => database.Add(person)
            , Throws.InvalidOperationException
            .With.Message.EqualTo("Array's capacity must be exactly 16 integers!"));
        }

        [Test]
        public void IfNoUserIsPresentedByThisNameShoudlThrowExc()
        {
            database = new ExtendedDatabase(person);
            Assert.That(()
                => database.FindByUsername(person2.UserName), Throws.InvalidOperationException
                .With.Message.EqualTo("No user is present by this username!"));
        }

        [Test]
        public void IfNoUserIsPresentedByThisIdShoudlThrowExc()
        {
            Assert.That(()
                => database.FindById(1), Throws.InvalidOperationException
                .With.Message.EqualTo("No user is present by this ID!"));
        }

        [Test]
        public void IdShoudlBePositive()
        {
            Assert.Throws<ArgumentOutOfRangeException>(()
                =>
             { database.FindById(-1); }, "Id should be a positive number!");
        }

        [Test]
        public void CountShouldIncreaseWhenPersonAdded()
        {
            int actualCount = 3;
            database = new ExtendedDatabase(persons);
            database.Add(new Person(16, "Makiaveli"));
            int expectedCount = database.Count;
            Assert.AreEqual(actualCount, expectedCount);
        }

        [Test]
        public void RemoveShouldDecreaseCount()
        {
            database = new ExtendedDatabase(persons);
            int actualCount =2;
            this.database.Remove();
            int expectedCount = 2;
            Assert.AreEqual(expectedCount,actualCount);
        }

        [Test]
        public void WhenCountIsEqualToZeroShouldThrowException()
        {
            database = new ExtendedDatabase(person2);
            database.Remove();
            Assert.That(()
                => database.Remove(), Throws.InvalidOperationException);
        }
    }
}