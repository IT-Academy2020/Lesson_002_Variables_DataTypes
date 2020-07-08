using System;

namespace Assignment
{
    class Program
    {
        static void Main()
        {
            // ПРАВИЛО:
            // Всі арифметичні операції що здійснюються над двома значеннями типу (byte, sbyte, short, ushort)
            // в якості результату, повертають значення типу int.

            // Присвоєння з додаванням для типу byte.
            byte variable1 = 0;

            //variable1 = variable1 + 5;       // ПОМИЛКА: Спроба неявного перетворення значення результату, типу int в тип byte.
            //variable1 = (byte)variable1 + 5; // ПОМИЛКА: Відбувається перетворення типу byte в тип byte, раніше виконання операції додавання.

            variable1 = (byte)(variable1 + 5); // Громіздке рішення.

            variable1 += 5;                    // Елегантне рішення.           

            //variable1 += 5000;               // ПОМИЛКА: Так як значення правої частини виразу не повинно перевищувати діапазон допустимих значень типу змінної

            // ПРАВИЛО:
            // Для типів int, uint, long і ulong, не відбувається перетворення типу результату арифметичних операцій.

            #region Операції присвоєння з...

            // Присвоєння з додаванням.
            int variable2 = 0;
            variable2 = variable2 + 5;
            variable2 += 5;

            // Присвоєння з відніманням.
            uint variable3 = 0;
            variable3 = variable3 - 5;
            variable3 -= 5;

            // Присвоєння з множенням.
            long variable4 = 0;
            variable4 = variable4 * 5;
            variable4 *= 5;

            // Присвоєння з діленням.
            ulong variable5 = 0;
            variable5 = variable5 / 5;
            variable5 /= 5;

            // Присвоєння відсотка від ділення.
            long variable6 = 0;
            variable6 = variable6 % 5;
            variable6 %= 5;

            #endregion

            // ПРАВИЛО:
            // Для типів float и double, не відбувається перетворення типу результату арифметичних операцій.

            // Присвоєння з додаванням.
            float variable7 = 0;
            variable7 = variable7 + 5;
            variable7 += 5;

            // Присвоєння з множенням.
            double variable8 = 0;
            variable8 = variable8 * 5;
            variable8 *= 5;

            // Delay.
            Console.ReadKey();
        }
    }
}
