using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.GornovTA.Sprint1.Task5.V5.Lib
{
    public class DataService
    {
        public int Calculate(double x)
        {
            double Truncate = x - Math.Truncate(x);
            int One = (int)(Truncate * 10);
            return One;
        }
    }
}
