using System;

// Неявно типізовані локальні змінні.

namespace Var
{
    class Program
    {
        static void Main()
        {
            // Неявно типізована локальна змінна.
            var myVar = 7;

            Console.WriteLine(myVar);

            // Неявно типізовані локальні змінні не допускають множинного оголошення.
            // var a = 1, b = 2, c = 3;

            // Неявно типізовані локальні змінні повинні бути ініціалізовані.
            // var a; 

            // Константа не може бути неявно типизированная.
            // const var myVar = 3.14; 

            // Delay.
            Console.ReadKey();
        }
    }
}
