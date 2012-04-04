package sample;

import java.io.InputStream;

public class LimittedPartialSum {

	public static void main(String[] args) {
		new LimittedPartialSum().solve(System.in);
	}

	private int[] as;
	private int[] ms;
	private int K;

	private void solve(InputStream in) {
		int[] dp = new int[K + 1];
		for (int j = 1; j < dp.length; j++) {
			dp[j] = -1;
		}
		dp[0] = 0;

		for (int i = 0; i < as.length; i++) {
			for (int j = 0; j <= K; j++) {
				if (dp[j] >= 0) {
					dp[j] = ms[i];
				} else if (as[i] <= j && dp[j - as[i]] > 0) {
					dp[j] = dp[j - as[i]] - 1;
				} else {
					dp[j] = -1;
				}
			}
		}
	}
}
