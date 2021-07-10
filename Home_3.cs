using System;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                double 
                firstValue, secondValue;
                string action;

                try
                {
                Console.WriteLine("Введыть число 1 ");
                firstValue = double.Parse(Console.ReadLine());

                Console.WriteLine("Введыть число 2 ");
                secondValue = double.Parse(Console.ReadLine());
                }
                catch(Exception)
                {
                    Console.WriteLine("Не удалось преобразавать число");
                    Console.ReadLine();
                    continue;
                }
                Console.WriteLine("Виберіть операцію");
                action = Console.ReadLine();

                switch (action)
                {
                    case "+":
                        Console.WriteLine(firstValue + secondValue);
                        brake;

                    case "-":
                        Console.WriteLine(firstValue - secondValue);
                        brake;

                    case "*":
                        Console.WriteLine(firstValue * secondValue);
                        brake;

                    case "/":
                        if (secondValue = 0)
                            Console.WriteLine(0);
                        else
                            Console.WriteLine(firstValue + secondValue);
                        brake;

                    default:
                        Console.WriteLine("Ошибка ! невыдомима операцыя");
                }
                Console.ReadLine();
            }
        }
    }
}
// ПИШЕМ КАЛЬКУЛЯТОР НА C# 