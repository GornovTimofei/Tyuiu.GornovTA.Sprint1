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
            DataService ds = new DataService();
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
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Слова с удвоенной н: ");
            Console.WriteLine(ds.CheckDoubleN(inputtext));
            Console.ReadLine();
        }
    }
}