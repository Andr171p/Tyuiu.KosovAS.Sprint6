using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KosovAS.Sprint6.Task5.V9.Lib;

namespace Tyuiu.KosovAS.Sprint6.Task5.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            DataService ds = new DataService();

            string path = @"C:\Users\andre\source\repos\Tyuiu.KosovAS.Sprint6\DataTask5\TestFileTask5V9.txt";

            double[] result = new double[4];
            result = ds.LoadFromDataFile(path);

            double[] wait = new double[4] { -5, 3, 6, 5 };

            CollectionAssert.AreEqual(wait, result);
        }
    }
}
