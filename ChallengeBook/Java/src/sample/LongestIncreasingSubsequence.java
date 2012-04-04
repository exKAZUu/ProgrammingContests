package sample;

import java.io.InputStream;
import java.util.Arrays;
import java.util.Comparator;

public class LongestIncreasingSubsequence {

	public static void main(String[] args) {
		new LongestIncreasingSubsequence().solve();
		new LongestIncreasingSubsequence().solve2();
	}

	private int n;
	private int[] as;

	public LongestIncreasingSubsequence() {
		n = 5;
		as = new int[] { 4, 2, 3, 1, 5 };
	}

	private void solve() {
		int[] dp = new int[n + 1];
		for (int i = 0; i < dp.length; i++) {
			dp[i] = Integer.MAX_VALUE;
		}
		dp[0] = -1;

		for (int i = 0; i < as.length; i++) {
			for (int j = n - 1; j >= 0; j--) {
				if (dp[j] < as[i]) {
					dp[j + 1] = Math.min(dp[j + 1], as[i]);
				}
			}
		}

		int ans;
		for (ans = n; ans >= 0; ans--) {
			if (dp[ans] != Integer.MAX_VALUE) {
				break;
			}
		}
		System.out.println(ans);
	}

	public void solve2() {
		Integer[] dp = new Integer[n];
		Arrays.fill(dp, Integer.MAX_VALUE);
		for (int i = 0; i < n; i++) {
			int index = Arrays.binarySearch(dp, as[i],
					new Comparator<Integer>() {
						@Override
						public int compare(Integer i1, Integer i2) {
							if (i1 <= i2) {
								return -1;
							} else {
								return 1;
							}
						}
					});
			dp[-index - 1] = as[i];
		}
		int ans = Arrays.binarySearch(dp, Integer.MAX_VALUE,
				new Comparator<Integer>() {
					@Override
					public int compare(Integer i1, Integer i2) {
						if (i1 < i2) {
							return -1;
						} else {
							return 1;
						}
					}
				});
		System.out.println(-ans - 1);
	}
}
