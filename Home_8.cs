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

            int result = 0;
            for (int i = 0; i < myArray.Length;i++)
            {
                if (myArray[i]%2 ==0)
                {
                    result += myArray[i];
                }
            }
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
//НАЙТИ СУММУ ЧЕТНЫХ ЧИСЕЛ В МАССИВЕ C# |