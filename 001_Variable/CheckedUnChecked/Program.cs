using System;

// Комбінація перевірки і заборони перевірки переповнення.

namespace CheckedUnChecked
{
    class Program
    {
        static void Main()
        {
            sbyte a = 126;
            sbyte b = 127;

            // Перевіряти переповнення.
            checked
            {
                a++;

                // Не перевіряти переповнення.
                unchecked
                {
                    b++; 
                }

                a++;
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
