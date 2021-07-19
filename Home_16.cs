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
        static int Sum(int [] myArray, int i = 0)
    {
        if (i>= myArray.Length)
        return 0;

        int result = Sum(myArray, i + 1);

        return myArray[i] + result;
    }

        static void Main(string[] args)
        {
            int [] myArray = {42,214,92,2};
            int result = Sum(myArray);
        }
    }
}
// Сумма элементов массива РЕКУРСИЯ C#