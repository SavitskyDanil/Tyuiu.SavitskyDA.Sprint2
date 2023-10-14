using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.SavitskyDA.Sprint2.Task5.V1.Lib
{
    public class DataService : ISprint2Task5V1
    {
        public int FindMonthDaysCount(int value)
        {
            int res;
            switch(value)
            {
                case 1:
                    res = 31;
                    break;
                case 2:
                    res = 28;
                    break;
                case 3:
                    res = 31;
                    break;
                case 4:
                    res = 30;
                    break;
                case 5:
                    res = 31;
                    break;
                case 6:
                    res = 30;
                    break;
                case 7:
                    res = 31;
                    break;
                case 8:
                    res = 31;
                    break;
                case 9:
                    res = 30;
                    break;
                case 10:
                    res = 31;
                    break;
                case 11:
                    res = 30;
                    break;
                case 12:
                    res = 31;
                    break;
                default:
                    throw new ArgumentException($"Месяц должен быть от 1 до 12. Значение {value}");
            }
            return res;
        }
    }
}
