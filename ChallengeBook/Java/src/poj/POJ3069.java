package poj;

import java.io.InputStream;
import java.util.Scanner;

public class POJ3069 {
	public static void main(String[] args) {
		new POJ3069().solve(System.in);
	}

	private void solve(InputStream in) {
		Scanner sc = new Scanner(in);
		while (true) {
			int N = sc.nextInt();
			int R = sc.nextInt();
			int[] xs = new int[N + 2];
			for (int i = 0; i < N; i++) {
				xs[i] = sc.nextInt();
			}
			xs[N] = Integer.MAX_VALUE / 2;
			xs[N + 1] = Integer.MAX_VALUE;

			int i = 0;
			int ans = 0;
			while (i < N) {
				int left = xs[i];
				while (left + R >= xs[++i]) {
				}
				left = xs[i - 1];
				while (left + R >= xs[++i]) {
				}
				ans++;
			}
			System.out.println(ans);
		}
	}
}
