using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.GornovTA.Sprint1.Task6.V4.Lib
{
    public class DataService
    {
        public static bool CheckDoubleN(string value)
        {
            for (int i = 0; i < value.Length - 1; i++)
            {
                if (value[i] == 'н' && value[i + 1] == 'н')
                {
                    return true;
                }
            }
            return false;
        }
    }
}
