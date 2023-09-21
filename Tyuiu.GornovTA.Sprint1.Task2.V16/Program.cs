using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.GornovTA.Sprint1.Task2.V16.Lib;

namespace Tyuiu.GornovTA.Sprint1.Task2.V16
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт №1 | Выполнил: Горнов Т. А. | АСОиУб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт №1                                                               *");
            Console.WriteLine("* Тема: Арифметические операторы в C#                                     *");
            Console.WriteLine("* Задание №2                                                              *");
            Console.WriteLine("* Вариант №16                                                             *");
            Console.WriteLine("* Выполнил: Горнов Тимофей Анатольевич | АСОиУб-23-2                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* вычесляет примерный периметр круга по формуле 2 * x * 3.14              *");
            Console.WriteLine("* и печатает его на экран.                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x;

            Console.WriteLine("Введите радиус круга:");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Периметр круга = " + ds.CalculatePerimetrCircle(x));

            Console.ReadLine();
        }
    }
}
