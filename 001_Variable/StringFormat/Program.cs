using System;

namespace StringFormat
{
    class Program
    {
        static void Main()
        {
            int a = 1;
            Console.WriteLine("Це число {0}", a);

            int b = 2, c = 3;
            Console.WriteLine("Це числа {0} і {1}", b, c);
            Console.WriteLine("Це числа наоборот {1} і {0}", b, c);

            // Delay.
            Console.ReadKey();
        }
    }
}
