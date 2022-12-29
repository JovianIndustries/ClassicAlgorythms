using System;

namespace MatrixMultiplication {
	public class Matrix {
		static void Test(string[] args)
		{
			int[,] matrixA = { { 1, 2 }, { 3, 4 } };
			int[,] matrixB = { { 5, 6 }, { 7, 8 } };

			int[,] result = MultiplyMatrices(matrixA, matrixB);

			for (int i = 0; i < result.GetLength(0); i++)
			{
				for (int j = 0; j < result.GetLength(1); j++)
				{
					Console.Write(result[i, j] + " ");
				}

				Console.WriteLine();
			}
		}

		public static int[,] MultiplyMatrices(int[,] matrixA, int[,] matrixB)
		{
			int rowsA = matrixA.GetLength(0);
			int colsA = matrixA.GetLength(1);
			int rowsB = matrixB.GetLength(0);
			int colsB = matrixB.GetLength(1);

			if (colsA != rowsB)
			{
				throw new InvalidOperationException("The matrices cannot be multiplied.");
			}

			int[,] result = new int[rowsA, colsB];

			for (int i = 0; i < rowsA; i++)
			{
				for (int j = 0; j < colsB; j++)
				{
					for (int k = 0; k < colsA; k++)
					{
						result[i, j] += matrixA[i, k] * matrixB[k, j];
					}
				}
			}

			return result;
		}
		
		public static int[,] TransposeMatrix(int[,] matrix)
		{
			int rows = matrix.GetLength(0);
			int cols = matrix.GetLength(1);

			int[,] transposed = new int[cols, rows];

			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < cols; j++)
				{
					transposed[j, i] = matrix[i, j];
				}
			}

			return transposed;
		}
		
	}
}
