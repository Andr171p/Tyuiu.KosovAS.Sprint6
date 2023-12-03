using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KosovAS.Sprint6.Task3.V23.Lib
{
    public class DataService : ISprint6Task3V23
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            int[] temp = new int[rows];
            for (int i = 0; i < rows; i++)
            {
                temp[i] = matrix[i, 1];
            }
            Array.Sort(temp);
            for (int i = 0; i < rows; i++)
            {
                matrix[i, 1] = temp[i];
            }
            return matrix;
        }
    }
}
