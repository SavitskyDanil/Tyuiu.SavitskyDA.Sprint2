using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.SavitskyDA.Sprint2.Task6.V11.Lib;

namespace Tyuiu.SavitskyDA.Sprint2.Task6.V11
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнил: Савицкий Д. А. | АСОиУб-23-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Получение результата из switch                                    *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнил: Савицкий Данил Александрович | АСОиУб-23-1                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая использует оператор switch вычисляет        *");
            Console.WriteLine("* требуемое значение и возвращает результат.                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("* Введите год                                                             *");
            int g = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("* Введите порядковый номер месяца                                         *");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("* Введите число                                                           *");
            int n = Convert.ToInt32(Console.ReadLine());

            if ((m > 12) || (n > 31))
            {
                Console.WriteLine("Введены неверные данные");
            }
            else
            {
                if ((m == 2) && (n > 28))
                {
                    Console.WriteLine("Такого дня нет");
                }
                else if ((m == 4) && (n > 30))
                {
                    Console.WriteLine("Такого дня нет");
                }
                else if ((m == 6) && (n > 30))
                {
                    Console.WriteLine("Такого дня нет");
                }
                else if ((m == 9) && (n > 30))
                {
                    Console.WriteLine("Такого дня нет");
                }
                else if ((m == 11) && (n > 30))
                {
                    Console.WriteLine("Такого дня нет");
                }
                else
                {

                    Console.WriteLine("***************************************************************************");
                    Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
                    Console.WriteLine("***************************************************************************");

                    Console.WriteLine(" Дата следующего дня " + ds.FindDateOfNextDay(g, m, n));

                    Console.ReadLine();
                }
            }
        }
    }
}