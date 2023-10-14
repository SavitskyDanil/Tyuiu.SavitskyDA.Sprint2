using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.SavitskyDA.Sprint2.Task4.V19.Lib;

namespace Tyuiu.SavitskyDA.Sprint2.Task4.V19
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнил: Савицкий Д. А. | АСОиУб-23-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Тернарный оператор                                                *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #19                                                             *");
            Console.WriteLine("* Выполнил: Савицкий Данил Александрович | АСОиУб-23-1                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение функции        *");
            Console.WriteLine("* тернарного оператора, где пользователь вводит значение переменных x,y с *");
            Console.WriteLine("* клавиатуры, если: x / 2 < y - 6, то z = ( 6 + 4 / y^2)^x , иначе        *");
            Console.WriteLine("* (x^2 - cos(y^2) + 10) / (y^2 - sin(y^2) + 12)                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(" Введите значение переменной X:                                           *");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(" Введите значение переменной Y:                                           *");
            double y = Convert.ToDouble(Console.ReadLine());

            double res = ds.Calculate(x,y);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Значение функции = " + res);

            Console.ReadLine();
        }
    }
}
