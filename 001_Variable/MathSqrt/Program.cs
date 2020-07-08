using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// Math.Sqrt() - математична функція, яка дістає корінь квадратний

namespace MathSqrt
{
    class Program
    {
        static void Main()
        {
            double x = 256;

            double result = Math.Sqrt(x);  
    
            Console.Write("Корінь квадратний дорівнює: ");
            Console.WriteLine(result);
            
            // Delay.
            Console.ReadKey();
        }
    }
}
