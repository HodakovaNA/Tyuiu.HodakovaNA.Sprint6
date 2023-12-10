using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.HodakovaNA.Sprint6.Task4.V15.Lib;

namespace Tyuiu.HodakovaNA.Sprint6.Task4.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;

            int len = stopValue - startValue + 1;

            double[] wait = new double[len];

            wait[0] = 3.3; //
            wait[1] = 13.22;
            wait[2] = 9.93;
            wait[3] = 6.63;
            wait[4] = 3.32;
            wait[5] = 0;
            wait[6] = -3.32;
            wait[7] = -6.63;
            wait[8] = -9.93;
            wait[9] = -13.22;
            wait[10] = -16.5;

            double[] res = new double[len];

            res = ds.GetMassFunction(startValue, stopValue);
            
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
