package problems;

import java.io.*;
import java.util.*;

public class POJ1978_Ohnishi {
	public static void main(String args[]) throws Exception {
		Scanner cin = new Scanner(System.in);
		while (true) {
			int n = cin.nextInt();
			int r = cin.nextInt();
			if (n == 0 && r == 0) {
				return;
			}
			ArrayList<Integer> cards = new ArrayList<Integer>();
			for (int i = n; i > 0; i--) {
				cards.add(i);
			}
			for (int i = 0; i < r; i++) {
				int p = cin.nextInt();
				int c = cin.nextInt();
				Collections.rotate(cards.subList(0, p - 1 + c), c);
			}
			System.out.println(cards.get(0));
		}
	}
}
