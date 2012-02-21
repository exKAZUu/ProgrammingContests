package sample;

public class PartialSum {

	private int[] a;
	private int n, k;
	
	public static void main(String[] args) {
		new PartialSum().dfs(0, 0);
	}

	private boolean dfs(int i, int sum) {
		if (i == n) return sum == k;
		
		if (dfs(i + 1, sum)) return true;
		
		if (dfs(i + 1, sum + a[i])) return true;
		
		return false;
	}
}
