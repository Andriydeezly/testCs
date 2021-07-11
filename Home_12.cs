using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Program
    {
        static void Resize<T>(ref T [] array, int newSize)
        {
            T[] newArray = new T[newSize];
            for (int i = 0; i< array.Length && i < newArray.Length; i++)
            {
                newArray[i] = array[i];

            }
            array = newArray;
        }

        static void Main(string[] args)
        {
            int[] myArray = {434,68,465,42,87};
            Resize(ref myArray, 10);
        }
    }
}
// ИЗМЕНИТЬ РАЗМЕР МАССИВА | увеличить массив C# | уменьшить массив 