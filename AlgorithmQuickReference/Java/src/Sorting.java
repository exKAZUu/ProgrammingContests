import java.util.Arrays;

public class Sorting {

	public static void main(String[] args) {
		int[] values = { 2, 1, 5, 3, 4, 6 };
		System.out.println(Arrays.toString(values));
		insertionSort(values);
		System.out.println(Arrays.toString(values));
	}

	public static void insertionSort(int[] values) {
		for (int i = 1; i < values.length; i++) {
			int v = values[i];
			int j = i - 1;
			while (j >= 0 && v < values[j]) {
				values[j + 1] = values[j];
				j--;
			}
			values[j + 1] = v;
		}
	}

	public static void quickSort(int left, int right, int[] values) {
		int pivotIndex = selectPivotIndex(left, right, values);
		int center = partition(left, right, pivotIndex, values);
		quickSort(left, center - 1, values);
		quickSort(center + 1, right, values);
	}

	private static int partition(int left, int right, int pivotIndex,
			int[] values) {
		int pivot = values[pivotIndex];
		do {
			while (values[left] < pivot) {
				left++;
			}
			while (values[right] > pivot) {
				right--;
			}
			int tmp = values[left];
			values[left] = values[right];
			values[right] = tmp;
		} while (left < right);
		return right;
	}

	private static int selectPivotIndex(int left, int right, int[] values) {
		return values[(left + right) / 2];
	}
}
