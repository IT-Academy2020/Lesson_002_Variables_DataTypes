using System;

// Оператор sizeof - дозволяє отримати розмір значення в байтах для зазначеного типу.
// Оператор sizeof можна застосовувати тільки до типів:
// byte, sbyte, short, ushort, int, uint, long, ulong, float, double, decimal, char, bool.
// Результатом оператора sizeof є значення типу int.

namespace Sizeof
{   
    class Program
    {
        static void Main()
        {
            int doubleSize = sizeof(double);
            Console.WriteLine("Розмір типу double: {0} байт.", doubleSize);

            Console.WriteLine("Розмір типу int: {0} байт.", sizeof(int));
            Console.WriteLine("Розмір типу bool: {0} байт.", sizeof(bool));
            Console.WriteLine("Розмір типу long: {0} байт.", sizeof(long));
            Console.WriteLine("Розмір типу short: {0} байт.", sizeof(short));
            
            // Delay.
            Console.ReadKey();
        }
    }
}
