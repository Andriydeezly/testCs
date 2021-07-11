using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace Homework
{
    class Program
    {   
        static void PrintArray(int [] myArray, int i = 0)
        {
            if (i < myArray.Length)
            {
                Console.WriteLine(myArray[i]);
                PrintArray(myArray, i +1);
            }
        }

        static void Main(string[] args)
        {
            int [] myArray = {42,214,92,2};
            PrintArray(myArray);
        }
    }
}
// Рекурсивный вывод массива C#