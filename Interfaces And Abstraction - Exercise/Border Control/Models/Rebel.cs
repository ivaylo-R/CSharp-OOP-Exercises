namespace BorderControl
{
    public class Rebel : IBuyer
    {
        public const int STAT_FOOD_VALUE = 0;

        public Rebel(string name,int age, string group)
        {
            Age = age;
            Group = group;
            Name = name;
            this.Food= STAT_FOOD_VALUE;
        }

        public int Food { get; set; } 
        public int Age { get; }
        public string Group { get; }
        public string Name { get; }

        public void BuyFood()
        {
            this.Food += 5;
        }
    }
}
