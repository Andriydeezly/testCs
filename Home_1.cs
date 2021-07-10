using System;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstValue, secondValue, thirdValue;

            Console.WriteLine("Введыть число 1");

            firstValue = double.Parse(Console.ReadLine());

            Console.WriteLine("Введыть число 2");

            secondValue = double.Parse(Console.ReadLine());

            double result = (firstValue + secondValue)/ 2;

            Console.WriteLine("Среднэ арифметичне двох чисел " + result);


            //==========================================Homework 2===========
            Console.WriteLine("=================Завдання 2========================================");

            Console.WriteLine();
            double firstValue, secondValue;

            Console.WriteLine("Введыть число 1");

            firstValue = double.Parse(Console.ReadLine());

            Console.WriteLine("Введыть число 2");

            thirdValue = double.Parse(Console.ReadLine()); 

            Console.WriteLine("Введыть число 3");

            secondValue = double.Parse(Console.ReadLine());

            double sumResult = firstValue + secondValue + thirdValue;

            Console.WriteLine("Сума трьох чисел = " + sumResult);
        
        //==========================================Homework 1===========
            Console.WriteLine();
            Console.WriteLine("=================Завдання 3========================================");
            Console.WriteLine();

            Convertor();
        }

        static void Convertor()
        {
            double UsdToRub = 66.29;
            double UsdToUah = 27.24;
            double USD;

            Console.WriteLine("Сума в USD");
            USD = double.Parse(Console.ReadLine());

            Console.WriteLine(USD + "  Usd в Руб"+ USD * UsdToRub);
            Console.WriteLine(USD + "  Usd в Грн" + USD * UsdToUah);
        }

    }
}
// СРЕДНЕЕ АРИФМЕТИЧЕСКОЕ ЧИСЕЛ | КОНВЕРТЕР ВАЛЮТ 