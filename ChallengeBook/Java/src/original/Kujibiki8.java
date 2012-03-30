package original;

import java.util.ArrayList;

public class Kujibiki8 {

	public static void main(String[] args) {
		ArrayList<Integer> numbers = new ArrayList<Integer>();
		int m = 10;
		boolean ans = solve(numbers, m);
		System.out.println(ans ? "Yes" : "No");
	}

	private static boolean solve(ArrayList<Integer> numbers, int m) {
		for (int n1 : numbers) {
			for (int n2 : numbers) {
				for (int n3 : numbers) {
					for (int n4 : numbers) {
						if (n1 + n2 + n3 + n4 == m) {
							return true;
						}
					}
				}
			}
		}
		return false;
	}
}
