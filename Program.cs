using System;

namespace MethodsWithLoopsAndConditionals
{
    internal class Program
    {
        public static void IncrementByOne()
        {
            Console.WriteLine("This method prints all numbers 1000 to -1000:");
            for (var a = 1000; a >= -1000; a--)
            {
                Console.WriteLine(a);
            }
        }

        public static void IncrementByThree()
        {
            Console.WriteLine("This method prints number 3 to 999 in increments of 3: ");
            for (var b = 3; b <= 999; b+=3)
            {
                Console.WriteLine(b);
            }
        }

        public static void IntegerCompare()
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
                Console.WriteLine($"{c} and {d} are not equal. Pick two equal numbers to continue. Try again.");
            }while (c != d);
        }

        public static void EvenOrOdd()
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
        
        public static void PositiveOrNegative()
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
        
        public static void VotingAge()
        {
            bool userAge;
            int result;
            Console.WriteLine("This method determines whether you're old enough to vote in federal elections.");

            do
            {
                Console.WriteLine("Enter your age: ");
                userAge = int.TryParse(Console.ReadLine(), out result);
            } while (!userAge);

            if (result < 18)
            {
                Console.WriteLine($"You can't vote unless you turn 18 on or before Election Day.");
            }
            else
            {
                Console.WriteLine($"You are old enough to vote in a federal election.");
            }

        }

        public static void BetweenTheTens()
        {
            bool userResponse;
            int result;
            Console.WriteLine("This method checks if your integer is between -10 and 10.");

            do
            {
                Console.WriteLine("What is your integer?");
                userResponse = int.TryParse(Console.ReadLine(), out result);
            }while (!userResponse);
            if (result >= -10 && result <= 10)
            {
                Console.WriteLine($"{result} is between -10 and 10.");
            }
            else
            {
                Console.WriteLine($"{result} is not between -10 and 10.");
            }

        }

        public static void MultTable()
        {
            bool userInteger;
            int result;
            Console.WriteLine("This method will display the multiplication table for a given number.");

            do
            {
                Console.WriteLine("Pick an integer: ");
                userInteger = int.TryParse(Console.ReadLine(), out result);
            }while(!userInteger);

            for (int x = 1; x <=12; x++)
            {
                Console.WriteLine($"{result} x {x} = {x * result}");
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

            IncrementByOne();

            //Write a method that will print to the console numbers 3 through 999 by 3 each time

            IncrementByThree();

            //Write a method to accept two integers as parameters and check whether they are equal or not

            IntegerCompare();

            // Write a method to check whether a given number is even or odd

            EvenOrOdd();

            // Write a method to check whether a given number is positive or negative

            PositiveOrNegative();

            // Write a method to read the age of a candidate and determine whether they can vote.

            VotingAge();

            // Hint: Use Parse or the safer TryParse() for an extra challenge
            // Parse()
            // TryParse()


            // ------------------------------------------------------------------- Heatin Up Section

            // Write a method to check if an integer (from the user) is in the range -10 to 10

            BetweenTheTens();

            // Write a method to display the multiplication table(from 1 to 12) of a given integer

            MultTable();

        }   
        
    }
}
