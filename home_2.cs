using System;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            int a; 

            a = int.Parse(Console.ReadLine());

            if(a % 2)
            {
                Console.WriteLine("Число парне");
                
            }else
            {
                Console.WriteLine("Число не парне");
            }
        }
    }
}
// ПРОВЕРКА ЧИСЛА НА ЧЁТНОСТЬ В C#