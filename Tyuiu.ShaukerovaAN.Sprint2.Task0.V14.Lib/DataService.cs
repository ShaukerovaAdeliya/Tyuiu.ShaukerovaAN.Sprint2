using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

// ЗАДАНИЕ
// Написать программу из операций сравнений (==, !=, <, >, <=, >=, последовательность операций не должна нарушаться)
// и арифметических выражений, которая вернет логическую последовательность(массив): (true, false, true, false, true, false),
// при x = 1075, y = 754

namespace Tyuiu.ShaukerovaAN.Sprint2.Task0.V14.Lib
{
    public class DataService : ISprint2Task0V14
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];

            res[0] = x - 321 == y;
            res[1] = x - 321 != y;
            res[2] = x - 1000 < y;
            res[3] = x - 500 > y;
            res[4] = x - 500 <= y;
            res[5] = x - 421 >= y;

            return res;
        }
    }
}
