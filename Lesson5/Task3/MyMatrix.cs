using System;

namespace Lesson5
{
    public class MyMatrix
    {
        public MyMatrix(int columns, int rows)
        {
            int[,] matrix = new int[columns, rows];
            
            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    matrix[i,j] = j;
   
                    Console.Write(matrix[i,j] + ", ");
                }

                Console.WriteLine();
            }
        }
    }
}
