using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.GornovTA.Sprint1.Task7.V26.Lib
{
    public class DataService : ISprint1Task7V26
    {
        public double Calculate(double x, double y)
        {
            double result1 = (Math.Sin(Math.Pow(x, 2)) + y) / (y + 1);
            double result2 = (x * y - 12) / (34 + Math.Pow(x, 2));
            return Math.Round(result1 - result2, 3);
        }
    }
}
