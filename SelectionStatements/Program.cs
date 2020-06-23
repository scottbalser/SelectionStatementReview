using System;

namespace SelectionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lets Play a game.....");
            Console.WriteLine("How many fingers am I holding up behind my back?" );

            var r = new Random();
            var fingerNumber = r.Next(1, 10);

            var fingerGuess = int.Parse(Console.ReadLine());

            if (fingerNumber > fingerGuess)
            {
                Console.WriteLine("To High....Try Again");
            }
            else if(fingerNumber < fingerGuess)
            {
                Console.WriteLine("To Low....Try Again");
            }
            else
            {
                Console.WriteLine("Winner Winner Chicken Dinner!!!!!");
            }

            Console.WriteLine("Who is your favorite Beatle?");

            var beatle = Console.ReadLine().ToLower();

            switch (beatle)
            {
                case "john":
                    Console.WriteLine("John is Awesome....");
                    break;
                case "paul":
                    Console.WriteLine("Paul is Awesome....");
                    break;
                case "george":
                    Console.WriteLine("George is Awesome....");
                    break;
                case "ringo":
                    Console.WriteLine("REALLY???....");
                    break;



            }

        }
    }
}
