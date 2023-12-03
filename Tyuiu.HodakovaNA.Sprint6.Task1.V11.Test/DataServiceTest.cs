using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.HodakovaNA.Sprint6.Task1.V11.Lib;

namespace Tyuiu.HodakovaNA.Sprint6.Task1.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;
            double[] array = new double[-startValue + stopValue + 1];

            array[0] = ;
            array[1] = ;
            array[2] = ;
            array[3] = ;
            array[4] = ;
            array[5] = 0;
            array[6] = ;
            array[7] = ;
            array[8] = ;
            array[9] = ;
            array[10] = ;

            double[] checkArray = ds.GetMassFunction(startValue, stopValue);

            CollectionAssert.AreEqual(checkArray, array);
        }
    }
}
