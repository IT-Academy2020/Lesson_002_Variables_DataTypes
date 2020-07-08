﻿using System;

// Використання локальних областей і локальних змінних.

namespace LocalVariables
{
    class Program
    {
        static void Main()
        {
            // ПРАВИЛО:
            // У коді можна створювати локальні області і в двох різних локальних областях зберігати однойменні змінні.
            
            // Локальна область 1
            {
                int a = 1;
                Console.WriteLine(a);
            }

            // Локальна область 2
            {
                int a = 2;
                Console.WriteLine(a);
            }


            // ПРАВИЛО:
            // Якщо в коді є локальні області, то забороняється зберігати однойменні змінні за межами локальних областей.
            //int a = 3; // ПОМИЛКА: Змінна з таким ім'ям вже існує в локальній області.

            // Delay.
            Console.ReadKey();
        }
    }
}
