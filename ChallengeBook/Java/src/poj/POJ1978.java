package poj;

import java.io.InputStream;
import java.util.Scanner;

public class POJ1978 {
	public static void main(String[] args) {
		new POJ1978().solve(System.in);
	}

	private void solve(InputStream in) {
		Scanner sc = new Scanner(in);
		while (true) {
			int nCards = sc.nextInt();
			int nCutting = sc.nextInt();
			if (nCards == 0 && nCutting == 0) {
				break;
			}

			int[] cards = new int[nCards];
			for (int i = 0; i < cards.length; i++) {
				cards[i] = cards.length - i;
			}

			for (int i = 0; i < nCutting; i++) {
				int nTop = sc.nextInt() - 1;
				int nMove = sc.nextInt();
				int[] tmp = new int[nTop];

				for (int j = 0; j < tmp.length; j++) {
					tmp[j] = cards[j];
				}
				for (int j = 0; j < nMove; j++) {
					cards[j] = cards[j + nTop];
				}
				for (int j = 0; j < tmp.length; j++) {
					cards[j + nMove] = tmp[j];
				}
			}
			System.out.println(cards[0]);

			// List<Integer> list = new ArrayList<Integer>();
			// for (int i = 0; i < nCards; i++) {
			// list.add(nCards - i);
			// }
			//
			// for (int i = 0; i < nCutting; i++) {
			// int nTop = sc.nextInt() - 1;
			// int nMove = sc.nextInt();
			// List<Integer> subList = list.subList(0, nTop + nMove);
			// Collections.rotate(subList, -nTop);
			// }
			// System.out.println(list.get(0));
		}
	}
}
