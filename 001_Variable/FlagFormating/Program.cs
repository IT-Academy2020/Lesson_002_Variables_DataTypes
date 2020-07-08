using System;

// Прапори форматування рядків.

namespace FlagFormating
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("C format: {0:C}", 99.9);      // Вивід в грошовому форматі..
            Console.WriteLine("F format: {0:##}", 99.935);   // Вивід значень з фіксованою точністю.
            Console.WriteLine("N format: {0:N}", 99999);     // Стандартне числове форматування.
            Console.WriteLine("X format: {0:X}", 255);       // Вивід в шістнадцятковій форматі.
            Console.WriteLine("D format: {0:D}", 0xFF);      // Вивід в десятковому форматі.
            Console.WriteLine("E format: {0:E}", 9999);      // Вивід в експонентційному форматі.
            Console.WriteLine("G format: {0:G}", 99.9);      // Вивід в загальному форматі.
            Console.WriteLine("P format: {0:P}", 99.9);      // Вивід в процентному форматі.

            // Delay.
            Console.ReadKey();
        }
    }
}
