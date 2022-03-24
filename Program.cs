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

            Apple();

            // Write a method that will print to the console numbers 3 through 999 by 3 each time

            


            // Write a method to accept two integers as parameters and check whether they are equal or not
            // Write a method to check whether a given number is even or odd
            // Write a method to check whether a given number is positive or negative
            // Write a method to read the age of a candidate and determine whether they can vote.
            // Hint: Use Parse or the safer TryParse() for an extra challenge
            // Parse()
            // TryParse()

























            // ------------------------------------------------------------------- Heatin Up Section

        }   // Write a method to check if an integer (from the user) is in the range -10 to 10
            // Write a method to display the multiplication table(from 1 to 12) of a given integer
    }
}
