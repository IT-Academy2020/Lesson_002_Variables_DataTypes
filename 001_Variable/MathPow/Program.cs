using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// Math.Pow() - приведення числа в степінь (1-ий аргумент - число, яке приводимо в степінь, 2-ий - степінь, у який приводимо число)

namespace MathPow
{
    class Program
    {
        static void Main()
        {
            double x = 2, y = 8;

            double result = Math.Pow(x, y);  
     
            Console.WriteLine(result);

            // Delay.
            Console.ReadKey();
        }
    }
}
