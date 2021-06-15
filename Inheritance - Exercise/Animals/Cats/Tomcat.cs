namespace Animals.Cats
{
    public class Tomcat : Cat
    {
        private const string TomcatGender = "Male";
        public Tomcat(string name, int age) 
            : base(name, age, TomcatGender)
        {
        }

        protected override string ProduceSound()
            => "MEOW";
    }
}
