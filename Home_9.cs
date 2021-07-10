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
            int[] myArray = {35,325,75,7,3,35,89,66,70,422,2};
            int minValue = myArray[0];

            for(int i =1; i < myArray.Length; i++)
            {
                if (myArray[i] < minValue)
                //if (myArray[i] > maxValue)  найде найбыльший елемент масива
                {
                    minValue = myArray[i];
                }
                Console.WriteLine(minValue);
                Console.ReadLine();

            }

        }
    }
}
// МЕТОДЫ И ФУНКЦИИ В C#