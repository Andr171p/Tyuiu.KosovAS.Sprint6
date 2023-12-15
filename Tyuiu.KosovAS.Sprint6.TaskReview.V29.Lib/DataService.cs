using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.KosovAS.Sprint6.TaskReview.V29.Lib
{
    public class DataService
    {
        public int GetMatrix(int[,] array, int n1, int n2, int k, int l, int r)
        {
            int n = array.GetLength(0);
            int m = array.Length / n;

            if (n <= 1 || m <= 1 || n1 >= n2 || k >= 1 || r  >= n)
            {
                return 0;
            }
            int result = 0;

            for (int i = k; i <= l; i++)
            {
                result += array[r, i];
            }
            return result;
        }

        public int[,] SortColumns(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            for (int column = 0; column < columns; column++)
            {
                for (int i = 0; i < rows - 1; i++)
                {
                    for (int j = i + 1; j < rows;  j++)
                    {
                        if (matrix[i, column] > matrix[j, column])
                        {
                            int temp = matrix[i, column];
                            matrix[i, column] = matrix[j, column];
                            matrix[j, column] = temp;
                        }
                    }
                }
            }
            return matrix;
        }
    }
}
