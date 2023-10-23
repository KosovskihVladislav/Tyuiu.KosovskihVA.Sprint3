using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KosovskihVA.Sprint3.Task7.V28.Lib
{
    public class DataService : ISprint3Task7V28
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] v;
            int len = (stopValue - startValue) + 1;
            v = new double[len];
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                y = Math.Round((Math.Cos(2 * x) + (Math.Sin(x) / (x + 2.5)) + 2 * x), 2);
                v[count] = y;
                count++;
            }
            return v;
        }
    }
}
