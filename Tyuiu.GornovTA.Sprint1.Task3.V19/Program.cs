using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.GornovTA.Sprint1.Task3.V19.Lib;

namespace Tyuiu.GornovTA.Sprint1.Task3.V19
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт №1 | Выполнил: Горнов Т. А. | АСОиУб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт №1                                                               *");
            Console.WriteLine("* Тема: Операторы составного присваивания                                 *");
            Console.WriteLine("* Задание №3                                                              *");
            Console.WriteLine("* Вариант №19                                                             *");
            Console.WriteLine("* Выполнил: Горнов Тимофей Анатольевич | АСОиУб-23-2                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* вычесляет может ли шахматная фигура Слон с одного заданного поля        *");
            Console.WriteLine("* шахматной доски перейти за один ход на другое.                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите начальные координаты фигуры:");
            Console.Write("x1: ");
            int x1 = int.Parse(Console.ReadLine());
            Console.Write("y1: ");
            int y1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите конечные координаты фигуры:");
            Console.Write("x2: ");
            int x2 = int.Parse(Console.ReadLine());
            Console.Write("y2: ");
            int y2 = int.Parse(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            bool ElephCanMove = ds.ElephCanMove(x1, y1, x2, y2);
            Console.WriteLine(ElephCanMove ? "True" : "False");

            Console.ReadLine();
        }
    }
}
