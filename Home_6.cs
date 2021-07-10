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
            int[] myArray = {10, 2,4,46,42};

            Console.Write("Ввывод количество елементов  масива\t ");

            int elementsCount = int.Parse(Console.ReadLine());
            int[] newArray = new int[elementsCount];
            //// Заповняэм масив
            for (int i = 0; i < newArray.Length; i++)
            {
                Console.Write($"Ввывод  елементa под индексом{i}:\t");
                newArray[i] = int.Parse(Console.ReadLine());
            }



            Console.WriteLine("Ввывод масива");
            for(int i = 0; i < newArray.Length; i++)
            {
                Console.WriteLine(newArray[i]);

            }
               Console.ReadLine();
        }
    }    
}
// ЗАПОЛНИТЬ МАССИВ С КЛАВИАТУРЫ | ВВОД МАССИВА С КОНСОЛИ