using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KosovAS.Sprint6.Task0.V1.Lib
{
    public class DataService : ISprint6Task0V1
    {
        public double Calculate(int x)
        {
            return Math.Round((x / (Math.Pow(x, 3) + 2)), 3);
        }
    }
}
