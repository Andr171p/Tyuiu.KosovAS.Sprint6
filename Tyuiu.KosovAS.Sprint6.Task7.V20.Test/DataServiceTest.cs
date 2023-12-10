using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KosovAS.Sprint6.Task7.V20.Lib;

namespace Tyuiu.KosovAS.Sprint6.Task7.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMatrix()
        {
            DataService ds = new DataService();

            int[,] matrix = new int[3, 3] { {1, 2, 3 },
                                         {2, 3, 22 },
                                         {2, 4, 7 } };

            int[,] wait = new int[3, 3] { { 1, 2, 111 },
                                          {2, 3, 22 },
                                          {2, 4, 111 } };

            CollectionAssert.AreEqual(wait, ds.GetMatrix(matrix));
        }
    }
}
