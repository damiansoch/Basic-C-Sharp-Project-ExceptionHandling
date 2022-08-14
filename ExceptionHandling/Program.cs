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
                Console.WriteLine("Write the number");
                double userInput = Convert.ToDouble(Console.ReadLine());

                if (userInput == 0)
                {
                    Console.WriteLine("Can't divide by 0!");
                    return;
                }

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
