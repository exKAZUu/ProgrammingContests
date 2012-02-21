package sample;

import java.io.InputStream;
import java.util.Scanner;

public class Napzak {

	private int n;
	private int w;
	private int[] weights;
	private int[] values;

	public static void main(String[] args) {
		new Napzak().solve(System.in);
	}

	private void solve(InputStream in) {
		Scanner sc = new Scanner(in);
		while (true) {
			n = sc.nextInt();
			w = sc.nextInt();
			weights = new int[n];
			values = new int[n];
			for (int i = 0; i < n; i++) {
				weights[i] = sc.nextInt();
				values[i] = sc.nextInt();
			}

			int ans = solveSimple(0, 0);

			dp = new int[n + 1][w + 1];
			for (int i = 0; i < dp.length; i++) {
				for (int j = 0; j < dp[0].length; j++) {
					dp[i][j] = -1;
				}
			}
			ans = solveMemowise(0, 0);

			dp = new int[n + 1][w + 1];
			ans = solveDp1();
		}
	}

	private int solveSimple(int i, int w) {
		int res;
		if (i == n) {
			res = 0;
		} else if (w < weights[i]) {
			res = solveSimple(i + 1, w);
		} else {
			res = Math.max(solveSimple(i + 1, w),
					solveSimple(i + 1, w - weights[i]) + values[i]);
		}
		return res;
	}

	private int[][] dp;

	private int solveMemowise(int i, int w) {
		int res;
		if (dp[i][w] >= 0) {
			return dp[i][w];
		}

		if (i == n) {
			res = 0;
		} else if (w < weights[i]) {
			res = solveSimple(i + 1, w);
		} else {
			res = Math.max(solveSimple(i + 1, w),
					solveSimple(i + 1, w - weights[i]) + values[i]);
		}
		return dp[i][w] = res;
	}

	private int solveDp1() {
		for (int i = n - 1; i >= 0; i--) {
			for (int j = 0; j <= w; j++) {
				if (j >= weights[i]) {
					dp[i][j] = Math.max(dp[i + 1][j], dp[i + 1][j - weights[i]]
							+ values[i]);
				} else {
					dp[i][j] = dp[i + 1][j];
				}
			}
		}
		return dp[0][w];
	}

	private int solveDp2() {
		for (int i = 0; i < n; i++) {
			for (int j = 0; j <= w; j++) {
				if (j < weights[i]) {
					dp[i + 1][j] = dp[i][j];
				} else {
					dp[i + 1][j] = Math.max(dp[i][j], dp[i][j - weights[i]]
							+ values[i]);
				}
			}
		}
		return dp[n][w];
	}

	private int solveDp3() {
		for (int i = 0; i < n; i++) {
			for (int j = 0; j <= w; j++) {
				dp[i + 1][j] = Math.max(dp[i][j], dp[i + 1][j]);
				if (j + weights[i] <= w) {
					dp[i + 1][j + weights[j]] = Math.max(dp[i + 1][j
							+ weights[j]], dp[i][j] + values[i]);
				}
			}
		}
		return dp[n][w];
	}

	private int solveDp4() {
		int[] dp2 = new int[w + 1];
		for (int i = 0; i < n; i++) {
			for (int j = w; j >= weights[i]; j++) {
				dp2[j] = Math.max(dp2[j], dp2[j - weights[i]] + values[i]);
			}
		}
		return dp2[w];
	}

	private int solveDp5() {
		int[][] dp2 = new int[2][w + 1];
		for (int i = 0; i < n; i++) {
			for (int j = 0; j <= w; j++) {
				if (j < weights[i]) {
					dp[(i + 1) & 1][j] = dp[i & 1][j];
				} else {
					dp[(i + 1) & 1][j] = Math.max(dp[i & 1][j],
							dp[(i + 1) & 1][j - weights[i]] + values[i]);
				}
			}
		}
		return dp[n & 1][w];
	}
}
