using System;
using System.Collections.Generic;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> numbers = new List<int> { 81, 54, 76, 52, 43, 75, 92, 20, 43, 51 };
                Console.WriteLine("Write the whole number");
                int userInput = Convert.ToInt32(Console.ReadLine());

                foreach (int number in numbers)
                {
                    Console.WriteLine(number + " divided by " + userInput + " = " + number / userInput);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            finally
            {
                Console.ReadLine();
            }
        }
    }
}
