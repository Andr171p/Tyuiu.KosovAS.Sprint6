using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KosovAS.Sprint6.Task7.V20.Lib
{
    public class DataService : ISprint6Task7V20
    {
        public int[,] GetMatrix(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;

            int countX = 2;

            for (int i = 0; i < rows; i++)
            {
                for (int  j = countX; j <= countX; j++)
                {
                    if ((matrix[i, j] >= 1) && (matrix[i, j] <= 20))
                    {
                        matrix[i, j] = 111;
                    }
                }
            }
            return matrix;
        }
    }
}
