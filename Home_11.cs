using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Program
    {
        static int IndexOf(int [] array, int value)
        {
            for (int i= 0; i < array.Length; i++)
            {
                if (array[i] == value)
                {
                return i;
                }
            }
            return -1;
        }

        static int[] GetRandomArray(uint length, int minValue, int maxValue) // генеруєм масив рандомних чисел
        {
            int[] myArray = new int[length];
            Random random = new Random();
            for (int i = 0; i< myArray.Length; i++)
            {
            myArray[i] = random.Next(minValue,maxValue);
            }

            return myArray;
        }
        static void Main(string[] args)
        {
            //int[] myArray = {34,632,6,7,56,9,45234,2};
            int result = IndexOf(myArray, 9);
            Console.WriteLine(result);
        }
    }
}
// НАЙТИ ИНДЕКС ЭЛЕМЕНТА В МАССИВЕ C# 