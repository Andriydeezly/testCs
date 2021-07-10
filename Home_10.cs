using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Program
    {
        static void PrintLine(string line, uint symbolCount)
        {
            for(int i= 0; i < symbolCount; i++)
            {
                Console.Write(line);

            }

        }
        
        static void PrintChar(char symbol, uint symbolCount)
        {
             for(int i= 0; i < symbolCount; i++)
            {
                Console.Write(symbol);

            }
        }


        static void Main(string[] args)
        {   
            Console.WriteLine("Введить строку");
            string line = uint.Parse(Console.ReadLine());

            Console.WriteLine("Введить символ");
            char symbol = Console.ReadKey().KeyChar;

            Console.WriteLine("Введите количество символвов");
            uint symbolCount = uint.Parse(Console.ReadLine());

            PrintLine(line, symbolCount);
            Console.WriteLine("=======================Ввивод чара===========================");
            Console.WriteLine();
            PrintChar(symbol,symbolCount );

            Console.ReadLine();
        }
    }
}