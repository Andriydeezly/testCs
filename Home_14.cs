using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Program
    {   
        static void RemoveAt(ref int[]array, int index)
        {
            int [] newArray = new int[array.Length-1];

            for (int i = 0; i < index; i++)
            newArray[i] = array[i];

            for (int i = index + 1; i < array.Length; i++)
            newArray[i - 1] = array[i];

        array = newArray;
        }

        static void RemoveFirst(ref int[] array)
        {
            RemoveAt(ref array, 0);
        }

        static void RemoveLast(ref int[] array)
        {
            RemoveAt(ref array, array.Length - 1);
        }

        static void Main(string[] args) 
        {
            int []myArray = {3,32,68,568,321,2};

            RemoveAt(ref myArray, 3); // видаляэм по ындексу 3
        }

    }
}
// КАК УДАЛИТЬ ЭЛЕМЕНТ ИЗ МАССИВА | первый элемент | последний элемент | по индексу
