using System;

namespace AuthorProblem
{
    [Author("Pesho")]
    public class StartUp
    {
        [Author("Dido")]
        public static void Main()
        {

            var tracker = new Tracker();
            Tracker.PrintMethodsByAuthor();

        }
        [Author("Pesho")]
        public void Print()
        {

        }

    }
}
