using NUnit.Framework;

[TestFixture]
public class DummyTests
{
    [Test]
    public void DeadDummyShouldThrowsExceptionIfAttacked()
    {
        //Arrange
        Dummy dummy = new Dummy(0, 10);

        //Act && Arrange
        Assert.That(() => dummy.TakeAttack(1), Throws.InvalidOperationException
            .With.Message.EqualTo("Dummy is dead."));
    }

    [Test]
    public void DeadDummyShoudlGiveExp()
    {
        //Arrange
        Dummy dummy = new Dummy(1, 10);

        //Act and Arrange
        Assert.That(() =>
        dummy.GiveExperience(), Throws.InvalidOperationException
        .With.Message.EqualTo("Target is not dead."));
    }

    [Test]
    public void AliveDummyCantGiveExp()
    {
        //Arrange
        Dummy dummy = new Dummy(0, 10);

        //Act and Arrange
        Assert.That(() => dummy.GiveExperience() == 10);
    }

    [Test]
    public void DummyShouldLoseHealthIfAttacked()
    {
        //Arrange
        Dummy dummy = new Dummy(10, 15);

        //Act
        dummy.TakeAttack(1);

        //Assert
        Assert.That(dummy.Health, Is.EqualTo(9), "Dummy health doesnt change if it attacked.");
    }
}
