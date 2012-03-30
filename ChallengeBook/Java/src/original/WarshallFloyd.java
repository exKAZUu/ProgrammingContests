package original;

public class WarshallFloyd {
	private int[][] d;
	private int V;

	public void solve() {
		for (int k = 0; k < V; k++) {
			for (int i = 0; i < V; i++) {
				for (int j = 0; j < V; j++) {
					d[i][j] = Math.min(d[i][j], d[i][k] + d[k][j]);
				}
			}
		}
	}
}
