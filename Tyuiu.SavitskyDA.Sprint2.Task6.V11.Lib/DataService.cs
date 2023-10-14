using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.SavitskyDA.Sprint2.Task6.V11.Lib
{
    public class DataService : ISprint2Task6V11
    {
        public string FindDateOfNextDay(int g, int m, int n)
        {
            if ((n == 31) && (m == 12))
            {
                m -= 11;
                n -= 30;
                g += 1;
            }
            else if (n == 31)
            {
                m += 1;
                n -= 30;
            }
            else if (n < 31)
            {
                if ((m == 2) && (n == 28))
                {
                    m += 1;
                    n -= 27;
                }
                else if ((m == 4) && (n == 30))
                {
                    m += 1;
                    n -= 29;
                }
                else if ((m == 6) && (n == 30))
                {
                    m += 1;
                    n -= 29;
                }
                else if ((m == 9) && (n == 30))
                {
                    m += 1;
                    n -= 29;
                }
                else if ((m == 11) && (n == 30))
                {
                    m += 1;
                    n -= 29;
                }
                else
                {
                    n += 1;
                }
            }

            string res;
            switch (m)
            {
                case 1: res = "1"; break;
                case 2: res = "2"; break;
                case 3: res = "3"; break;
                case 4: res = "4"; break;
                case 5: res = "5"; break;
                case 6: res = "6"; break;
                case 7: res = "7"; break;
                case 8: res = "8"; break;
                case 9: res = "9"; break;
                case 10: res = "10"; break;
                case 11: res = "11"; break;
                case 12: res = "12"; break;
                default: throw new ArgumentException($"Месяц должен быть от 1 до 12. Значение {m}");
            }
            string o;
            o = n + " " + res + " " + g + "";
            return o;
        }
    }
}
