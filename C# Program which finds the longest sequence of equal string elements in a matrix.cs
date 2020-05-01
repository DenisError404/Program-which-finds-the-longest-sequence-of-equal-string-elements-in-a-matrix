using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("By Denis Rafi");
            Console.WriteLine("-----------------");
            string[,] matrix ={
                              {"2","2","3","4"},
                              {"5","2","6","7"},
                              {"8","9","2","10"},
                          };
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    maxLenght = GetLongestSequence(matrix, i, j);
                }
            }
            for (int i = 0; i < maxLenght - 1; i++)
            {
                Console.Write(word + ", ");
            }
            Console.WriteLine(word);
        }
        static string word = "";
        static int maxLenght = 0;
        static int GetLongestSequence(string[,] matrix, int row, int col)
        {
            int max = GetColumn(matrix, row, col);
            maxLenght = GetMaxLenght(matrix, row, col, maxLenght, max);
            max = GetRow(matrix, row, col, max);
            maxLenght = GetMaxLenght(matrix, row, col, maxLenght, max);
            max = GerDiagonal(matrix, row, col, max);
            maxLenght = GetMaxLenght(matrix, row, col, maxLenght, max);
            return maxLenght;
        }
        private static int GerDiagonal(string[,] matrix, int row, int col, int max)
        {
            max = 0;
            for (int i = row; i < matrix.GetLength(0) - 1; i++)
            {
                for (int j = col; j < matrix.GetLength(1) - 1; j++)
                {
                    if (matrix[i, j] == matrix[i + 1, j + 1])
                    {
                        max++;
                        if (i == matrix.GetLength(0) - 2 || j == matrix.GetLength(1) - 2)
                        {
                            max++;
                        }
                    }
                }
            }
            return max;
        }
        private static int GetRow(string[,] matrix, int row, int col, int max)
        {
            max = 0;
            for (int j = col; j < matrix.GetLength(1) - 1; j++)
            {
                if (matrix[row, j] == matrix[row, j + 1])
                {
                    max++;
                    if (j == matrix.GetLength(1) - 2)
                    {
                        max++;
                    }
                }
            }
            return max;
        }
        private static int GetColumn(string[,] matrix, int row, int col)
        {
            int max = 0;
            for (int i = row; i < matrix.GetLength(0) - 1; i++)
            {
                if (matrix[i, col] == matrix[i + 1, col])
                {
                    max++;
                    if (i == matrix.GetLength(0) - 2)
                    {
                        max++;
                    }
                }
            }
            return max;
        }
        private static int GetMaxLenght(string[,] matrix, int row, int col, int maxLenght, int max)
        {
            if (max > maxLenght)
            {
                maxLenght = max;
                word = matrix[row, col];
            }
            return maxLenght;
        }
    }
}
    

