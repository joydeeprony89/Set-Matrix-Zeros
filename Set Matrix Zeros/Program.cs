using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set_Matrix_Zeros
{
    class Program
    {
        static void Main(string[] args)
        {
            var matrix = new int[3][] 
            { 
                new int[] { 0, 1, 1 }, 
                new int[] { 1, 0, 1 }, 
                new int[] { 1, 1, 1 } 
            };

            SetZeroes(matrix);
            foreach(var res in matrix)
            {
                Console.WriteLine(string.Join(",", res));
            }
        }

        static void SetZeroes(int[][] matrix)
        {
            if (matrix == null || matrix.Length == 0) return;
            int rows = matrix.Length;
            int cols = matrix[0].Length;
            int cell = 1;
            for(int i = 0; i < rows; i++)
            {
                if (matrix[i][0] == 0) cell = 0;
                for (int j = 1; j < cols; j++)
                {
                    if (matrix[i][j] == 0)
                        matrix[i][0] = matrix[0][j] = 0;
                }
            }

            for (int i = rows - 1; i >= 0; i--)
            {
                for (int j = cols - 1; j >= 0; j--)
                {
                    if (matrix[i][0] == 0 || matrix[0][j] == 0)
                        matrix[i][j] = 0;
                    if (cell == 0) matrix[i][0] = 0;
                }
            }
        }
    }
}
