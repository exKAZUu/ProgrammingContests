package sample;

import java.io.InputStream;
import java.util.Scanner;

public class UnlimittedNapzak {

	public static void main(String[] args) {
		new UnlimittedNapzak().solve(System.in);
	}

	private int n;
	private int W;
	private int[] weights;
	private int[] values;

	private void solve(InputStream in) {
		Scanner sc = new Scanner(in);
		n = sc.nextInt();
		W = sc.nextInt();
		int[][] dp = new int[n + 1][W + 1];
		weights = new int[0];
		values = new int[0];

		solveDp1(dp);
	}

	private void solveDp1(int[][] dp) {
		for (int i = 0; i < n; i++) {
			for (int j = 0; j < W; j++) {
				if (j + weights[i] <= W) {
					dp[i + 1][j] = Math.max(dp[i][j], dp[i + 1][j - weights[i]]
							+ values[i]);
				} else {
					dp[i + 1][j] = dp[i][j];
				}
			}
		}
	}

	private int solveDp2() {
		int[] dp2 = new int[W + 1];
		for (int i = 0; i < n; i++) {
			for (int j = weights[i]; j <= W; j++) {
				dp2[j] = Math.max(dp2[j], dp2[j - weights[i]] + values[i]);
			}
		}
		return dp2[W];
	}
}
