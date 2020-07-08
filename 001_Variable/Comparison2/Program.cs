using System;

// Порівняння значень різних типів.

namespace Comparison
{
    class Program
    {
        static void Main()
        {
            bool result = false;

            int a = 1;
            float b = 2.0f;
            result = a < b;   // Порівняння значення типу int, зі значенням типу float - допустимо.

            string c = "Hello";
            //result = c < a; // Порівняння значення типу int, зі значенням типу string - не допустимо.

            // Delay.
            Console.ReadKey();
        }
    }
}
