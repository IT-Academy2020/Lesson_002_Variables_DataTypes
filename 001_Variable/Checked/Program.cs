using System;

// Перевірка переповнення - (checked)

namespace Checked
{
    class Program
    {
        static void Main()
        {
            sbyte a = 127;

            // Перевіряти переповнення.
            checked
            {
                a++; // ПОМИЛКА рівня компіляції
            }

            // 127 + 1 = -128
            Console.WriteLine(a);

            // Delay.
            Console.ReadKey();
        }
    }
}
