using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.GornovTA.Sprint1.Task6.V4.Lib;

namespace Tyuiu.GornovTA.Sprint1.Task6.V4
{
    class Program
    {
        static void Main()
        {
            Console.Title = "Спринт №1 | Выполнил: Горнов Т. А. | АСОиУб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт №1                                                               *");
            Console.WriteLine("* Тема: Преобразование типов и класс Convert                              *");
            Console.WriteLine("* Задание №6                                                              *");
            Console.WriteLine("* Вариант №4                                                              *");
            Console.WriteLine("* Выполнил: Горнов Тимофей Анатольевич | АСОиУб-23-2                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя текст,           *");
            Console.WriteLine("* и выводит все словаа с удвоенной н.                                     *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите текст: ");
            string inputtext = Console.ReadLine();

            string[] text = inputtext.Split(new char[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Слова с удвоенной н: ");
            foreach (string word in text)
            {
                if (CheckDoubleN(word))
                {
                    Console.WriteLine(word);
                }
            }
            Console.ReadLine();
        }
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