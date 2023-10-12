using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ShaukerovaAN.Sprint2.Task5.V5.Lib
{
    public class DataService : ISprint2Task5V5
    {
        public string FindCardValue(int value)
        {
            string res;
            switch(value)
            {
                case 6:
                    res = "Шестерка";
                    break;
                case 7:
                    res = "Семерка";
                    break;
                case 8:
                    res = "Восьмерка";
                    break;
                case 9:
                    res = "Девятка";
                    break;
                case 10:
                    res = "Десятка";
                    break;
                case 11:
                    res = "Валет";
                    break;
                case 12:
                    res = "Дама";
                    break;
                case 13:
                    res = "Король";
                    break;
                case 14:
                    res = "Туз";
                    break;
                default:
                    throw new ArgumentException($"Игральные карты должны быть от 1 до 9. Значение {value}");
            }
            return res;
        }
    }
}
