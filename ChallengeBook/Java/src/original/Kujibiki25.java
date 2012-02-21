package original;

import java.io.InputStream;
import java.util.Arrays;
import java.util.Scanner;

public class Kujibiki25 {

	public static void main(String[] args) {
		new Kujibiki25().solve(System.in);
	}

	private void solve(InputStream in) {
		Scanner sc = new Scanner(in);
		int nCases = sc.nextInt();
		for (int i = 0; i < nCases; i++) {
			int m = sc.nextInt();
			int nIntegers = sc.nextInt();
			int[] integers = new int[nIntegers];
			for (int j = 0; j < integers.length; j++) {
				integers[j] = sc.nextInt();
			}

			int[] integers2 = new int[integers.length * integers.length];
			for (int j = 0; j < integers.length; j++) {
				int integer = integers[j];
				for (int k = 0; k < integers.length; k++) {
					integers2[j * integers.length + k] = integer + integers[k];
				}
			}

			Arrays.sort(integers2);

			boolean ans = search(m, integers, integers2);
			System.out.println(ans ? "Yes" : "No");
		}
	}

	private boolean search(int m, int[] integers, int[] integers2) {
		for (int integer : integers2) {
			if (Arrays.binarySearch(integers, m - integer) >= 0) {
				return true;
			}
		}
		return false;
	}
}
