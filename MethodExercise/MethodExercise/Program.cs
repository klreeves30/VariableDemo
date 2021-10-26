using System;

namespace MethodExercise
{
    class Program
    {
        /// <summary>
        ///  Excercise 1
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            YourFavorites();

            myAdditon(5, 7);

            mySubtraction(10, 8);

            myMultiplication(11, 18);

            myDivision(20, 4);

            myRemainder(25, 5);

            

        }

        public static void YourFavorites()
        {
            Console.WriteLine("Hello What's your name?");
            var userName = Console.ReadLine();

            Console.WriteLine($"{userName} What's your favorite color?");
            var color = Console.ReadLine();

            Console.WriteLine($"{color} is very nice, What's your favorite animal");
            var animal = Console.ReadLine();

            Console.WriteLine($"{animal} is pretty cool. Are you into music? Who's your favorite band?");
            var band = Console.ReadLine();

            Console.WriteLine($"{band} makes really good music!!");

            Console.WriteLine($"{userName}, went into a big {color} forrest. When {userName} went " +
                $"in he saw a {animal}. The {animal} was dancing to {band}. ");
        }

        /// Exercise 2
        public static int myAdditon(int x, int y)
        {

            return x + y;
            
        }

        public static int mySubtraction(int a, int b)
        {
            return a - b;
            
        }

        public static int myMultiplication(int c, int d)
        {
            
            return c * d;
        }

        public static int myDivision(int e, int f)
        {
            
            return e / f;
        }

        public static int myRemainder(int j, int k)
        {

            return j % k;
        }



    }
}

