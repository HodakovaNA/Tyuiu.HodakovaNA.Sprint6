using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.HodakovaNA.Sprint6.Task1.V11.Lib
{
    public class DataService : ISprint6Task1V11
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] vallueArray;
            int len = (stopValue - startValue) + 1;
            vallueArray = new double[len];
            int count = 0;
            
            for (int x = startValue; x <= stopValue; x++)
            {
                if (x + 1 != 0)
                {
                    vallueArray[count] = Math.Round((5 * x + 2.5) / (Math.Sin(x) + 3) + 2 * x + Math.Cos(x), 2);
                    count++;
                }
                else
                {
                    vallueArray[count] = 0;
                    count++;
                }
            }

            return vallueArray;
        }
    }
}
