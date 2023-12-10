using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;

using Tyuiu.HodakovaNA.Sprint6.Task5.V8.Lib;

namespace Tyuiu.HodakovaNA.Sprint6.Task5.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestLoadFromDataFile()
        {
            DataService ds = new DataService();
            
            string path = @"C:\DataSprint5\InPutFileTask5V8.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            
            Assert.AreEqual(true, fileExists);
        }
    }
}
