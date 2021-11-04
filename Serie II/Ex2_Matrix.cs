using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie_II
{
    public static class Matrix
    {
        public static int[][] BuildingMatrix(int[] leftVector, int[] rightVector)
        {
            if (leftVector.Length != rightVector.Length)
            {
                return new int[0][];
            }
            int[][] res = new int[leftVector.Length][];
            for (int i = 0; i < res.Length; i++)
            {
                res[i] = new int[rightVector.Length];
                for (int j = 0; j < res[i].Length; j++)
                {
                    res[i][j] = leftVector[i] * rightVector[j];
                }
            }
            return res;
        }

        public static int[][] Addition(int[][] leftMatrix, int[][] rightMatrix)
        {
            if (leftMatrix.Length != rightMatrix.Length)
            {
                return new int[0][];
            }
            int[][] res = new int[leftMatrix.Length][];
            for (int i = 0; i < res.Length; i++)
            {
                res[i] = new int[rightMatrix[i].Length];
                for (int j = 0; j < res[i].Length; j++)
                {
                    res[i][j] = leftMatrix[i][j] + rightMatrix[i][j];
                }
            }
            return res;
        }

        public static int[][] Substraction(int[][] leftMatrix, int[][] rightMatrix)
        {
            if (leftMatrix.Length != rightMatrix.Length)
            {
                return new int[0][];
            }
            int[][] res = new int[leftMatrix.Length][];
            for (int i = 0; i < res.Length; i++)
            {
                res[i] = new int[rightMatrix[i].Length];
                for (int j = 0; j < res[i].Length; j++)
                {
                    res[i][j] = leftMatrix[i][j] - rightMatrix[i][j];
                }
            }
            return res;
        }
        ///
        public static int[][] Multiplication(int[][] leftMatrix, int[][] rightMatrix)
        {
            if (leftMatrix.Length != rightMatrix.Length)
            {
                return new int[0][];
            }
            int[][] res = new int[leftMatrix.Length][];
            for (int i = 0; i < res.Length; i++)
            {
                res[i] = new int[rightMatrix[i].Length];
                for (int j = 0; j < res[i].Length; j++)
                {
                    res[i][j] = (leftMatrix[i][j] * rightMatrix[i][j]);
                }
            }
            
            return res;
        }

        public static void DisplayMatrix(int[][] matrix)
        {
            string s = string.Empty;
            for (int i = 0; i < matrix.Length; ++i)
            {
                for (int j = 0; j < matrix[i].Length; ++j)
                {
                    s += matrix[i][j].ToString().PadLeft(5) + " ";
                }
                s += Environment.NewLine;
            }
            Console.WriteLine(s);
        }
    }
}
