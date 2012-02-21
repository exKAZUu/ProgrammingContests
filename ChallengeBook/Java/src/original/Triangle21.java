package original;

import java.util.ArrayList;
import java.util.Collections;
import java.util.Scanner;

public class Triangle21 {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		while(true) {
			int n = sc.nextInt();
			if (n == 0) {
				break;
			}
			
			ArrayList<Integer> lengths = new ArrayList<Integer>();
			for (int i = 0; i < n; i++) {
				lengths.add(sc.nextInt());
			}
			
			Collections.sort(lengths);
			
			int ans = solve(lengths);
			System.out.println(ans);
		}
	}

	private static int solve(ArrayList<Integer> lengths) {
		for (int i = lengths.size() - 1; i >= 2; i--) {
			int big = lengths.get(i);
			int s1 = lengths.get(i-1), s2 = lengths.get(i-2);
			if (s1 + s2 > big) {
				return s1 + s2 + big;
			}
		}
		return 0;
	}

}
