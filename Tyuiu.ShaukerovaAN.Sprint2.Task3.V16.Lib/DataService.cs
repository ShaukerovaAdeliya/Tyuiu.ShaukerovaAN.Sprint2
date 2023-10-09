using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ShaukerovaAN.Sprint2.Task3.V16.Lib
{
    public class DataService : ISprint2Task3V16
    {
        public double Calculate(double x)
        {
            double y = 0;
            if (x > 1)
            {
               y = x + (Math.Pow(3, (x + 1) / (x - 1))); 
            }
            else
            {
                if (x == 0) 
                {
                    y = (((2 * (Math.Pow(2, x))) - (Math.Cos(Math.Pow(2, x))) + 10) / ((5 * (Math.Pow(2, x))) - (Math.Sin(Math.Pow(2, x))) + 12));   
                }
                else
                {
                    if ((x > -20) && (x < 2))
                    {
                        y = Math.Pow(7, (1 + (1 / (Math.Pow(2, x)))));
                    }
                    else
                    {
                        if (x < -20)
                        {
                            y = x + 10 * x - (1 / x);
                        }
                    }
                }
            }
            return Math.Round(y, 3);
        }
    }
}
