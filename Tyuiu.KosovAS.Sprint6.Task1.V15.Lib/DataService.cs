using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KosovAS.Sprint6.Task1.V15.Lib
{
    public class DataService : ISprint6Task1V15
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] result = new double[(stopValue - startValue) + 1];
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                y = Math.Round((Math.Cos(x) / (x - 0.7) - Math.Sin(x) * 12 * x + 2), 2);
                result[count++] = y;
            }
            return result;
        }
    }
}
