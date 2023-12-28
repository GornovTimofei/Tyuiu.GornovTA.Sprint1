using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.GornovTA.Sprint1.Task6.V4.Lib
{
    public class DataService : ISprint1Task6V4
    {
        public string CheckDoubleN(string value)
        {
            string[] words = value.Split(new char[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            string result = "";
            foreach (string word in words)
            {
                if (word.Contains("нн"))
                {
                    result += word + " ";
                }
                else
                {
                    result += "";
                }
            }
            return result.Trim();
        }
    }
}
