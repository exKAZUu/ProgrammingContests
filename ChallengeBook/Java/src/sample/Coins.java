package sample;

public class Coins {
	private static final int[] V = new int[] { 1, 5, 10, 50, 100, 500 };

	private int[] C = new int[6];
	private int A;
	
	public static void main(String[] args) {
		new Coins().solve();
	}

	private void solve() {
		int ans = 0;
		for (int i = 5; i >= 0; i--) {
			int t = Math.min(A / V[i], C[i]);
			A -= t * V[i];
			ans += t;
		}
		System.out.println(ans);
	}
}
