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
        static int Foo(int value)
        {
            if (value< 10)
            return value;

            int digit = value % 10;
            int nextValue = value /10;
            return digit + Foo(nextValue);
        }

        static int SumWhile(int value)
        {
            int sum = 0;
            while(value > 0)
            {
                sum += value %10;
                value = value /10;
            }
            return sum;
        }

        static void Main(string[] args)
        {
            int myValue =561;
            int newValue = 920;
            int result = Foo(myValue);

            Console.WriteLine();
            Console.WriteLine("Вивод суми цифр за допомогою цикла");
            SumWhile(newValue);
        }
    }
}
// Как найти сумму цифр числа

