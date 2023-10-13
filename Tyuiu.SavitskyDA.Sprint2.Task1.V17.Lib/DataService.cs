using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.SavitskyDA.Sprint2.Task1.V17.Lib
{
    public class DataService : ISprint2Task1V17
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            //==, !=, <, >, <=, >=, последовательность можно чередовать, но использовать один раз в выражении
            //|, &, ||, &&, !, ^, последовательность операций не должна нарушаться
            //a = 135, b = 123, c = 455, d = 321 
            // 0True, 1False, 2True, 3True, 4True, 5False
            bool[] res = new bool[6];
            res[0] = (a > b) | (c < d);
            res[1] = (a < b) & (c > d);
            res[2] = (a > b) || (c < d);
            res[3] = (a > b) && (c > d);
            res[4] = !(!res[0]);
            res[5] = (a > b) ^ (c > d);

            return res;
        }
    }
}
