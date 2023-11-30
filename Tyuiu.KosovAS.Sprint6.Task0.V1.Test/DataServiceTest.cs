using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KosovAS.Sprint6.Task0.V1.Lib;

namespace Tyuiu.KosovAS.Sprint6.Task0.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            Assert.AreEqual(0.103, ds.Calculate(3));
        }
    }
}
