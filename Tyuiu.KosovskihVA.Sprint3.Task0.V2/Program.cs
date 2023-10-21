using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KosovskihVA.Sprint3.Task0.V2.Lib;

namespace Tyuiu.KosovskihVA.Sprint3.Task0.V2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Косовских В. А. | ПКТб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("*Тема: Создания итогового решения по спринту                              *");
            Console.WriteLine("*Задание #Task0                                                           *");
            Console.WriteLine("*Вариант #2                                                               *");
            Console.WriteLine("*Выполнил: Косовских Владислав Алексеевич | ПКТб 23-2                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Написать программу, которая вычисляет произведение ряда по формуле       ");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");

            // Место решения задания
            DataService service1 = new DataService();


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");


            Console.Write("Введите начальное значение k: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Введите конечное значение: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();



            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double res = service1.GetMultiplySeries(x, y);

            Console.WriteLine("Результат выражения " + res);


            Console.ReadKey();
        }
    }
}
