using System;

namespace ClassicAlgorithms {
	public static class Sort {
		public static void QuickSort(int[] array, int left, int right) {
			if (left < right) {
				int pivotIndex = Partition(array, left, right);

				QuickSort(array, left, pivotIndex - 1);
				QuickSort(array, pivotIndex + 1, right);
			}
		}

		private static int Partition(int[] array, int left, int right) {
			int pivot = array[right];
			int i = left;

			for (int j = left; j < right; j++) {
				if (array[j] <= pivot) {
					Swap(array, i, j);
					i++;
				}
			}

			Swap(array, i, right);

			return i;
		}

		private static void Swap(int[] array, int i, int j) {
			(array[i], array[j]) = (array[j], array[i]);
		}


		public static void MergeSort(int[] array) {
			if (array.Length > 1) {
				int mid = array.Length / 2;
				int[] left = new int[mid];
				int[] right = new int[array.Length - mid];

				Array.Copy(array, left, mid);
				Array.Copy(array, mid, right, 0, right.Length);

				MergeSort(left);
				MergeSort(right);

				Merge(array, left, right);
			}
		}

		private static void Merge(int[] array, int[] left, int[] right) {
			int i = 0;
			int j = 0;
			int k = 0;

			while (i < left.Length && j < right.Length) {
				if (left[i] <= right[j]) {
					array[k] = left[i];
					i++;
				}
				else {
					array[k] = right[j];
					j++;
				}

				k++;
			}

			while (i < left.Length) {
				array[k] = left[i];
				i++;
				k++;
			}

			while (j < right.Length) {
				array[k] = right[j];
				j++;
				k++;
			}
		}
	}
}