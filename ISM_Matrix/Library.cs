using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixLibrary
{
    public class Library
    {
        public int Task1(int[,] matrix)
        {
            int maxModNumber = int.MinValue;

            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (Math.Abs(matrix[i, j]) > maxModNumber)
                    {
                        maxModNumber = Math.Abs(matrix[i, j]);
                    }
                }

            return maxModNumber;
        }

        public int[,] Task2(int[,] matrix)
        {
            int[,] matrix2 = new int[matrix.GetLength(1), matrix.GetLength(0)];

            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix2[j, i] = matrix[i, j];
                }

            return matrix2;
        }

        public int Task3(int[,] matrix)
        {
            int sumTask3 = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] > 0)
                    {
                        sumTask3++;
                    }
                }

            return sumTask3;
        }

        public int Task4(int[,] matrix)
        {
            int linesWithoutZero = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == 0)
                    {
                        linesWithoutZero--;
                        break;
                        
                    }

                }
                linesWithoutZero++;
            }

            return linesWithoutZero;
        }

        public int Task5(int[,] matrix)
        {
            int columnsWithZero = 0;

            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    if (matrix[i, j] == 0)
                    {
                        columnsWithZero++;
                        break;
                    }
                }

            }

            return columnsWithZero;
        }

        public int Task6(int[,] matrix)
        {
            int countSameElements = 0;
            int lineIndex = -1;
            int maxSeria = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                {
                    if (matrix[i, j] == matrix[i, j + 1])
                    {
                        countSameElements++;
                    }

                    if (countSameElements > maxSeria)
                    {
                        maxSeria = countSameElements;
                        lineIndex = i;
                    }
                }
            }

            return lineIndex;
        }


        public int Task7(int[,] matrix)
        {
            int mainDiagonalSum = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        mainDiagonalSum += matrix[i, j];
                    }
                }
            return mainDiagonalSum;
        }

        public int Task8(int[,] matrix)
        {
            int additionalDiagonalSum = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i + j == matrix.GetLength(0) - 1)
                    {
                        additionalDiagonalSum += matrix[i, j];
                    }
                }
            return additionalDiagonalSum;
        }

        public int Task9(int[,] matrix)
        {
            int sumTask9 = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        sumTask9 += matrix[i, j];
                    }
                }
            return sumTask9;
        }
    }
}
