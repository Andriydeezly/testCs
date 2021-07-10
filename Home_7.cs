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
            Console.Write("Ввывод количество елементов  масива\t ");

            int elementsCount = int.Parse(Console.ReadLine());
            int[] myArray = new int[elementsCount];

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write($"Ввывод  елементa под индексом{i}:\t");
                myArray[i] = int.Parse(Console.ReadLine());
            }


            Console.WriteLine("\nВвод масива:");

            for (int i = myArray.Length -1; i >= 0; i--)
            {
                Console.WriteLine(myArray[i]);
            }
            Console.ReadLine();
        }
    }
}
// ВЫВОД МАССИВА В ОБРАТНОМ ПОРЯДКЕ C#