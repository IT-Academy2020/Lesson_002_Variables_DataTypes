using System;

// Зчеплення рядків. (Конкатенація)

namespace Concatenation
{
    class Program
    {
        static void Main()
        {
            // 1 варіант.
            string word1 = "Привіт ";
            string word2 = "Світ!";            
            string phrase = word1 + word2;
            Console.WriteLine(phrase);
            
            // 2 варіант.
            Console.WriteLine("Hello " + "World!");

            // Delay.
            Console.ReadKey();
        }
    }
}
