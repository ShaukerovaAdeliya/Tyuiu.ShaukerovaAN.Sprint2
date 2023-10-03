using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ShaukerovaAN.Sprint2.Task1.V25.Lib;

namespace Tyuiu.ShaukerovaAN.Sprint2.Task1.V25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #2 | Выполнила: Шаукерова А.Н. | ИСТНб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт#2                                                                *");
            Console.WriteLine("* Тема: Логические операции                                               *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #25                                                             *");
            Console.WriteLine("* Выполнила: Шаукерова Аделия Нуржановна | ИСТНб-23-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=,         *");
            Console.WriteLine("* последовательность можно чередовать, но использовать один раз           *");
            Console.WriteLine("* в выражении)  и логических операций (|, &, ||, &&, !, ^,                *");
            Console.WriteLine("* последовательность операций не должна нарушаться),                      *");
            Console.WriteLine("* а также арифметических выражений, которая вернет логическую             *");
            Console.WriteLine("* последовательность(массив)                                              *");
            Console.WriteLine("*                                                                         *");

            DataService ds = new DataService();

            int a = 247;
            int b = 155;
            int c = 325;
            int d = 857;
            
            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);
            
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("c = " + c);
            Console.WriteLine("d = " + d);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }
            Console.ReadKey();
        }
    }
}
