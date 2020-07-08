using System;

// Заборона перевірки переповнення - (unchecked)

namespace UnChecked
{
    class Program
    {
        static void Main()
        {
            sbyte a = 127;

            // Перевіряти переповнення.
            unchecked
            {
                a++; // Логічна помилка
            }

            // 127 + 1 = -128
            Console.WriteLine(a);

            // Delay.
            Console.ReadKey();
        }
    }
}
