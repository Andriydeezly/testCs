using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            uint oddNumbersCount = 0; // нечотны числа
            uint evenNumbersCount = 0; // чотны числа
            int oddNumbersSum = 0; 
            int evenNumberSum = 0;

            int currentValue = int.Parse(Console.ReadLine());
            int limit = int.Parse(Console.ReadLine());

            while (currentValue <= limit)
            {
                if (currentValue % 2 == 0)
                {
                    evenNumbersCount++;
                    evenNumberSum += currentValue; 
                }
                else
                {
                    oddNumbersCount++;
                    oddNumbersSum += currentValue;
                }
                currentValue++;
            }


            Console.WriteLine("Количество нечотних чисел  " + oddNumbersCount);
            Console.WriteLine("Количество чотних чисел  " + evenNumbersCount);
            Console.WriteLine("Cума нечотних чисел =  " + oddNumbersSum);
            Console.WriteLine("Сума чотних чисел  =  " + evenNumbersSum);
            
            Console.ReadLine();

        }
    }
}
// СУММА И КОЛИЧЕСТВО ЧЕТНЫХ И НЕЧЕТНЫХ ЧИСЕЛ В ДИАПАЗОНЕ