/*
 * Author:  Anthony Alvarez
 * Course:  COMP-003A-L01
 * Purpose: Code for Assignment 4
 */
namespace COMP003A.Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // For Loop Section (Right Triangle)
            Console.Write("Enter a positive whole number: ");
            int limit = Convert.ToInt32(Console.ReadLine());
            string output = "#";

            for (int i = 0; i < limit; i++)
            {
                Console.WriteLine(output);
                output += "#";
            }

            // For Each Section (Friends)
            string[] friends = new string[] { "Rachel", "Joey", "Chandler", "Ross", "Monica", "Phoebe" };
            Console.WriteLine("\nFriends:");

            foreach (var friend in friends)
            {
                Console.WriteLine(friend);
            }

            // Do-While Loop Section (Counting by 5s)
            int counter = 0;
            Console.WriteLine("\nCounting by 5s:");

            do
            {
                Console.WriteLine(counter);
                counter += 5;
            } while (counter <= 50);

            // While Loop Section (FooBar)
            int counter2 = 1;
            Console.WriteLine("\nFooBar:");

            while (counter2 <= 20)
            {
                if (counter2 % 2 == 0 && counter2 % 5 == 0)
                    Console.WriteLine("FooBar");
                else if (counter2 % 2 == 0)
                    Console.WriteLine("Foo");
                else if (counter2 % 5 == 0)
                    Console.WriteLine("Bar");
                else
                    Console.WriteLine(counter2);

                counter2++;
            }
        }
    }
}