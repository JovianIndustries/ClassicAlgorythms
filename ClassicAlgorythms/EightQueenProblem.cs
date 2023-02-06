using System;

namespace ClassicAlgorithms {
	public class EightQueenProblem {
		public EightQueenProblem(int N) {
			n = N;
		}

		private int n;
		private int[,] board;

		public static void Backtracking() {
			//TODO: Add input for number of rows and collumns

			EightQueenProblem eightQueenProblem = new EightQueenProblem(8);
			eightQueenProblem.Initialize();
			eightQueenProblem.DisplaySolution();
			Console.ReadLine();

			IMenuController alg = new Algorithms() as IMenuController;
			alg.MainMenu(0);
		}

		private void Initialize() {
			board = new int[n, n];

			for (int i = 0; i < n; i++) {
				for (int j = 0; j < n; j++) {
					board[i, j] = 0;
				}
			}
		}

		private void DisplaySolution() {
			for (int s = 0; s < n; s++) {
				if (!SolutionFinder(s, 0))
					Console.WriteLine();
				Console.WriteLine("Solution not found");

				Console.WriteLine(" Solution " + s + " is:");
				for (int i = 0; i < n; i++) {
					for (int j = 0; j < n; j++) {
						Console.Write(board[i, j] + (j < n - 1 ? ", " : ""));
					}

					Console.WriteLine();
				}
			}
		}

		private bool CheckPlacement(int row, int col) {
			int i, j;
			for (i = 0; i < col; i++) {
				if (board[row, i] == 1) return false;
			}

			for (i = row, j = col; i >= 0 && j >= 0; i--, j--) {
				if (board[i, j] == 1) return false;
			}

			for (i = row, j = col; j >= 0 && i < n; i++, j--) {
				if (board[i, j] == 1) return false;
			}

			return true;
		}


		private bool SolutionFinder(int row, int col) {
			if (col >= n) return true;

			for (int i = row; i < n; i++) {
				if (CheckPlacement(i, col)) {
					board[i, col] = 1;
					if (SolutionFinder(row, col + 1)) return true;
					board[i, col] = 0;
				}
			}

			return false;
		}
	}
}