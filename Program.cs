using System;

namespace MethodsWithLoopsAndConditionals
{
    internal class Program
    {
        public static void Apple()
        {
            Console.WriteLine("This method prints all numbers 1000 to -1000:");
            for (var a = 1000; a >= -1000; a--)
            {
                Console.WriteLine(a);
            }
        }

        public static void Banana()
        {
            Console.WriteLine("This method prints number 3 to 999 in increments of 3: ");
            for (var b = 3; b <= 999; b+=3)
            {
                Console.WriteLine(b);
            }
        }

        public static void Charlie()
        {
            Console.WriteLine("This method checks two integers and tests for them for equality.");

            int c;
            int d;
            
            do
            {
                Console.WriteLine("Give me the first integer: ");
                c = int.Parse(Console.ReadLine());
                Console.WriteLine("Give me another integer: ");
                d = int.Parse(Console.ReadLine());
                if (c == d)
                {
                    Console.WriteLine($"{c} is equal to {d}.");
                }
                else
                Console.WriteLine($"{c} and {d} are not equal. Try again.");
            }while (c != d);
        }

        public static void Delta()
        {
            Console.WriteLine("This method checks whether an integer is even or odd. Choose a number: ");
            int d = int.Parse(Console.ReadLine());

            if (d % 2 == 0)
            {
                Console.WriteLine($"{d} is even.");
            }
            else
                Console.WriteLine($"{d} is odd.");
        }
        
        public static void Eggplant()
        {
            bool e;
            int result;
            Console.WriteLine("This method checks whether an integer is positive or negative.");

            do
            {
                Console.WriteLine("Choose a whole number: ");
                e = int.TryParse(Console.ReadLine(), out result);
            } while (!e);

            if (result > 0)
            {
                Console.WriteLine($"{result} is a positive integer");
            }
            else if (result < 0)
                Console.WriteLine($"{result} is a negative integer");
            else
            {
                Console.WriteLine($"{result} is neither negative nor positive.");
            }
        }
        




        static void Main(string[] args)
        {
            // Create a method for each of the given challenges in the below document.
            // Constraints:
            // Use as many descriptive names as possible. I do not want to see myInt1 -100!
            // For training purposes, most if not all the data for these methods can come from user input.
            // Each one of these methods should be called from Main() and declared in the Program class.
            // Be as creative as you want, the goal is to have working methods but if you want to make them look nice,
            //      go for it.  As in Num 6 w/ age and voting method, you can say “You may vote” or
            //      “Looks like you're too young this time!” based on their age.
            // This project should work in a manner where if someone forks/clones this from GitHub, they can just
            //      press the play button and have every method run in sequence, so all interface dialogue should 
            //      be in place already. When finished, push this to GitHub!


            // ------------------------------------------------------------------------- Luke Warm Section

            // Write a method that will print to the console all numbers 1000 through - 1000

            //Apple();

            // Write a method that will print to the console numbers 3 through 999 by 3 each time

            //Banana();

            // Write a method to accept two integers as parameters and check whether they are equal or not

            //Charlie();

            // Write a method to check whether a given number is even or odd

            //Delta();

            // Write a method to check whether a given number is positive or negative

            Eggplant();


            // Write a method to read the age of a candidate and determine whether they can vote.
            // Hint: Use Parse or the safer TryParse() for an extra challenge
            // Parse()
            // TryParse()

























            // ------------------------------------------------------------------- Heatin Up Section

        }   // Write a method to check if an integer (from the user) is in the range -10 to 10
            // Write a method to display the multiplication table(from 1 to 12) of a given integer
    }
}
