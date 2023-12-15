using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Runtime.Remoting.Messaging;
using Tyuiu.KosovAS.Sprint6.TaskReview.V29.Lib;

namespace Tyuiu.KosovAS.Sprint6.TaskReview.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMatrix()
        {
            DataService ds = new DataService();

            int[,] arrTest = new int[3, 4] { { 1, 2, 3, 5 },
                                             {1, 2, 4, 5 },
                                             {3, 4, 5, 5 }};

            int resultTest = ds.GetMatrix(arrTest, 1, 6, 0, 1, 2);

            Assert.AreEqual(7, resultTest);
        }

        [TestMethod]
        public void ValidGetMatrix_1()
        {
            DataService ds = new DataService();
            int[,] mas = new int[3, 3] { { -4, -3, -2 },
                                         { 1, 2, 3 },
                                         { -4, -3, -2 } };

            double res = ds.GetMatrix(mas, -4, 5, 1, 2, 2);
            double wait = 0;

            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidSortColumns()
        {
            DataService ds = new DataService();

            int[,] matrixTest = new int[3, 3] { { 5, 3, 7 },
                                               {3, 1, 5 },
                                               {1, 2, 4 }};

            int[,] matrixWait = new int[3, 3] { { 1, 1, 4 },
                                                {3, 2, 5 },
                                                {5, 3, 7 } };

            CollectionAssert.AreEqual(matrixWait, ds.SortColumns(matrixTest));
        }
    }
}
