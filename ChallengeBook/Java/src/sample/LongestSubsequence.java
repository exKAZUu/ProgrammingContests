package sample;

public class LongestSubsequence {

	public static void main(String[] args) {
		new LongestSubsequence().solve();
	}

	int n = 4;
	int m = 4;
	String s = "abcd";
	String t = "becd";

	private void solve() {
		int[][] table = new int[n + 1][m + 1];
		for (int i = 0; i < n; i++) {
			for (int j = 0; j < m; j++) {
				if (s.charAt(i) == t.charAt(j)) {
					table[i + 1][j + 1] = table[i][j] + 1;
				} else {
					table[i + 1][j + 1] = Math.max(table[i + 1][j],
							table[i][j + 1]);
				}
			}
		}
	}
}
