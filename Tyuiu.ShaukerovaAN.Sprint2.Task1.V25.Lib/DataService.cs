using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

// Написать программу из операций сравнений (==, !=, <, >, <=, >=, последовательность можно чередовать, но использовать один раз в выражении)
// и логических операций (|, &, ||, &&, !, ^, последовательность операций не должна нарушаться), а также арифметических выражений,
// которая вернет логическую последовательность(массив):
// (True, False, True, False, True, False), при a = 247, b = 155, c = 325, d = 857

namespace Tyuiu.ShaukerovaAN.Sprint2.Task1.V25.Lib
{
    public class DataService : ISprint2Task1V25
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];

            res[0] = (a > b) | (c < d); // 247>155-false, 325<857-true, поэтому возвращается true
            res[1] = (a + 5 == b) & (c < d); // 252>155-false, 325<857-true, поэтому возвращется false
            res[2] = (a <= b) || (c < d); // 247 <=155-false, 325<857-true, поэтому возвращается true
            res[3] = (a != b) && (c >= d); // 247 !=155-true, 325<=857-false, поэтому возвращается false
            res[4] = !(!res[0]);
            res[5] = (a -92 == b) ^ (c < d); // 155==155-true, 325<857-true, поэтому возвращается false

            return res;
        }
    }
}
