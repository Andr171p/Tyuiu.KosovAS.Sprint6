using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KosovAS.Sprint6.Task4.V27.Lib
{
    public class DataService : ISprint6Task4V27
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] result = new double[(stopValue - startValue) + 1];
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (x == -1)
                {
                    y = 0;
                }
                else
                {
                    y = Math.Round((Math.Cos(x) / (x + 1) - Math.Cos(x) * 1.3 + 3 * x), 2);
                }
                
                result[count++] = y;
            }
            return result;
        }
    }
}
