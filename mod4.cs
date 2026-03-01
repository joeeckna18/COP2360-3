using System;

namespace Module04_ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Division and Conversion Exception Handling");

            Console.Write("Enter the first number: ");
            string input1 = Console.ReadLine();

            Console.Write("Enter the second number: ");
            string input2 = Console.ReadLine();

            DivideStrings(input1, input2);

            Console.WriteLine("\nProgram finished. Press any key to exit.");
            Console.ReadKey();
        }

        static void DivideStrings(string s1, string s2)
        {
            try
            {
                int num1 = Convert.ToInt32(s1);
                int num2 = Convert.ToInt32(s2);

                int result = num1 / num2;
                Console.WriteLine($"Result: {num1} / {num2} = {result}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: One or both inputs were not valid integers.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Error: One of the numbers is too large or too small to process.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
            }
        }
    }
}
