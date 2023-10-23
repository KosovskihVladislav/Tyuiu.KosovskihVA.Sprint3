using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KosovskihVA.Sprint3.Task7.V28.Lib;

namespace Tyuiu.KosovskihVA.Sprint3.Task7.V28
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Косовских В. А. | ПКТб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("*Тема: Создания итогового решения по спринту                              *");
            Console.WriteLine("*Задание #Task7                                                           *");
            Console.WriteLine("*Вариант #28                                                              *");
            Console.WriteLine("*Выполнил: Косовских Владислав Алексеевич | ПКТб 23-2                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Написать программу, которая выводит таблицу значений функций             ");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");

            // Место решения задания
            DataService service1 = new DataService();


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");


            int x = -5;
            int y = 5;
            int len = service1.GetMassFunction(x, y).Length;
            double[] v;
            v = new double[len];
            v = service1.GetMassFunction(x, y);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("+----------+----------+");
            Console.WriteLine("|    X     |   f(x)   |");
            Console.WriteLine("+----------+----------+");
            for (int i = 0; i <= len-1; i++)
            {
                Console.WriteLine("|{0,5:d}    |  {1, 5:f2}", x, v[i]);
                x++;
            }

            Console.WriteLine("+----------+----------+");
            Console.ReadKey();
        }
    }
}
