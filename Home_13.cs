using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Program
    {   
        static void Insert(ref int[] array, int value, int index) // додаэм по вказаному ындексу масива
        {
            int[] newArray = new int[array.Length + 1];
            newArray[index] = value;

            for (int i = 0; i < index; i++)
            newArray[i] = array[i];

            for (int i =index; i < array.Length; i++)
            {
                newArray[i + 1] = array[i];
            }
            array = newArray;
        }

        static void AddFirt(ref int[] array, int value)  // додаэм в початок масива
        {
            Insert(ref array, value, 0);
        }    

        static void AddLast(ref int[] array,int value) // додаэм в кынец масива
        {
            Insert(ref array, value, array.Length);
        }

        static void Main(string[] args)
        {
            int[] myArray = {35,46,54,3,463,3,333};

            Console.WriteLine("Виводим початковий масив ");
            Console.WriteLine(myArray);

            Console.WriteLine();

            Console.WriteLine($"Виводим масив і вставляєм по індексу:\t{index}\t  число - {value}");
            Insert(ref myArray, 0, 4);

            Console.WriteLine();

            Console.WriteLine($"Виводим масив і вставляєм в початок масивучисло -\t {value}");
            AddFirt(ref myArray, 0);

            Console.WriteLine();

            Console.WriteLine($"Виводим масив і вставляєм в початок масивучисло -\t {value}");
            AddLast(ref myArray, 0);
        }
    }
}
//КАК ДОБАВИТЬ ЭЛЕМЕНТ В МАССИВ | в конец массива | в начало массива | по индексу
