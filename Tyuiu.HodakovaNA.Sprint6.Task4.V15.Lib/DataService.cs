using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.HodakovaNA.Sprint6.Task4.V15.Lib
{
    public class DataService : ISprint6Task4V15
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = (stopValue - startValue) + 1;
            double[] res = new double[len];
            int count = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                if (Math.Sin(x) + (2 * x) / 3 - Math.Cos(x) * (4 * x) != 0)
                {
                    res[count] = Math.Round(Math.Sin(x) + (2 * x) / 3 - Math.Cos(x) * (4 * x), 2);
                    count++;
                }
                else
                {
                    res[count] = 0;
                    count++;
                }
            }

            return res;
        }
    }
}
