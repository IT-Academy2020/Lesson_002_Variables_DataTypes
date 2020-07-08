using System;

// Використання ключових слів мови C # в якості ідентифікаторів.

namespace At
{
    class Program
    {
        static void Main()
        {
            //int bool = 5;      // Illegal
            int @bool = 7;       // Legal
            Console.WriteLine(@bool);


            // Символ @ не є частиною ідентифікатора, тому, @myVariable - це те ж саме, що і myVariable.
            string @myVariable = "Hello";
            Console.WriteLine(myVariable);


            // Delay.
            Console.ReadKey();
        }
    }
}
