using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int array and populate it with numbers 1-10
            int[] intArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };   

            /* Create a list of type int
             * Name the list "evens"
             */List<int> evens = new List<int>();

            
            /* Create another list of type int
             * Name the list "odds"
             */List<int> odds = new List<int>();
            

             /* Using either a foreach or for loop,
             * iterate through the array you populated with 10 numbers.
             * Inside the scope of the loop,
             * check to see if each number in the array is even or odd.
             * If the number is even, add it to the evens list.
             * If the number is odd, add it to the odds list.
             */
             for (int i = 0; i < intArray.Length; i++)
             {
                if (intArray[i] % 2 == 0)
                {
                    evens.Add(intArray[i]);
                }
                else
                {
                    odds.Add(intArray[i]);
                }
             }



            /* Using a foreach loop,
             * display the numbers in your "evens" list
             */
             Console.WriteLine("Even Numbers:");
             foreach (int i in evens)
             {
                Console.WriteLine(i);
             }


            /* Using a for loop,
             * display the numbers in your "odds" list
             */
            Console.WriteLine("Odd Numbers:");
            for (int i = 0; i < odds.Count ; i++)
            {
                Console.WriteLine(odds[i]);
            }
        }
    }
}
