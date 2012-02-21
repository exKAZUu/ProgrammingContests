package sample;

import java.io.InputStream;

public class Knapsack2 {

	private int[] vs;
	private int[] ws;
	private int W;
	
	private static final int MAX_N = 100; 
	private static final int MAX_V = 100; 
	
	public static void main(String[] args) {
		new Knapsack2().solve(System.in);
	}

	private void solve(InputStream in) {
		
	}

	private void dp() {
		int[][] table = new int[vs.length + 1][MAX_N * MAX_V];
		for (int i = 0; i < table.length; i++) {
			for (int j = 0; j < table[0].length; j++) {
				table[i][j] = W + 1;
			}
		}
		table[0][0] = 0;
		
		for (int i = 0; i < table.length; i++) {
			for (int j = 0; j < table[0].length; j++) {
				if (j >= vs[i]) {
					table[i+1][j] = Math.min(table[i][j], table[i][j-vs[i]] + ws[i]);
				}
				else {
					table[i+1][j] = table[i][j];
				}
			}
		}
		
		int ans;
		for (ans = table[0].length; ans >= 0; ans--) {
			if (table[vs.length][ans] <= W) {
				break;
			}
		}
		System.out.println(ans);
	}
}
