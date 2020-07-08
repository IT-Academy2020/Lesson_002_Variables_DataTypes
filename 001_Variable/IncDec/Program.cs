using System;

// Оператори Інкремента та Декремента (Increment and Decrement Operators)

namespace IncDec
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("----- Постфіксний інкремент"); // Post-increment
            
            byte number1 = 0;            
            Console.WriteLine(number1++); // Спочатку виводимо на екран, потім збільшуємо на 1.
            Console.WriteLine(number1);

            Console.WriteLine("----- Префіксний інкремент"); // Pre-increment

            byte number2 = 0;
            Console.WriteLine(++number2); // Спочатку збільшуємо на 1, потім виводимо на екран.

            Console.WriteLine("----- Постфіксний декремент"); // Post-decrement

            sbyte number3 = 0;
            Console.WriteLine(number3--); // Спочатку виводимо на екран, потім зменшуємо на 1.
            Console.WriteLine(number3);

            Console.WriteLine("----- Префіксний декремент"); // Pre-decrement

            sbyte number4 = 0;
            Console.WriteLine(--number4); // Спочатку зменшуємо на 1, потім виводимо на екран.

            // Delay.
            Console.ReadKey();
        }
    }
}
