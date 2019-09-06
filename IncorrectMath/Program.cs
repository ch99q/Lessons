using System;

namespace IncorrectMath
{
    class Program
    {
        static void Main(string[] args)
        {
            // Don't always expect floats and doubles to be correct.
            // Due to the algorigthm behind float a float will not always be precise.

            // Read more here: https://docs.oracle.com/cd/E19957-01/806-3568/ncg_goldberg.html

            Console.WriteLine("Hello World! Let's begin our lesson.");

            Console.WriteLine("Testing float numbers...");

            Console.WriteLine();

            float f1 = 1.0f;
            Console.WriteLine($"float f1 = {f1}");

            float f2 = 0.01f;
            Console.WriteLine($"float f2 = {f2}");

            Console.WriteLine();

            for (int i = 0; i < 10; i++)
            {
                f1 -= f2;

                Console.WriteLine($"{i}: f1 - f2 == {f1}");
            }

            Console.WriteLine();

            Console.WriteLine($"Expected result for f1 is 0.9 and matched result for f1 is {f1}");
        }
    }
}
