namespace Animals.Cats
{
    public class Kitten : Cat
    {
        private const string Kitten_Gender = "Female";
        public Kitten(string name, int age) 
            : base(name, age, Kitten_Gender)
        {
        }

        
        protected override string ProduceSound()
            => "Meow";
    }
}
