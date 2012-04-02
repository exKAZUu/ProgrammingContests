package problems;

import java.util.Scanner;

public class POJ1978 {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);

		while (true) {
			// カード枚数とカット回数の取得
			int cardCount = sc.nextInt();
			int cuttingCount = sc.nextInt();
			// プログラムの終了判定
			if (cardCount == 0 && cuttingCount == 0) {
				return;
			}

			// デッキの初期化
			int[] deck = new int[cardCount];
			for (int i = 0; i < deck.length; i++) {
				deck[i] = deck.length - i;
			}

			for (int i = 0; i < cuttingCount; i++) {
				int upperCardCount = sc.nextInt() - 1;
				int lowerCardCount = sc.nextInt();
				int[] temp = new int[lowerCardCount];
				for (int j = 0; j < temp.length; j++) {
					temp[j] = deck[upperCardCount + j];
				}
				for (int j = upperCardCount - 1; j >= 0; j--) {
					deck[j + lowerCardCount] = deck[j];
				}
				for (int j = 0; j < temp.length; j++) {
					deck[j] = temp[j];
				}
			}
			System.out.println(deck[0]);
		}
	}

}
