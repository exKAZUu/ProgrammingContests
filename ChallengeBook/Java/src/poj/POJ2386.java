package poj;

import java.io.InputStream;
import java.util.Scanner;

public class POJ2386 {

	public static void main(String[] args) {
		new POJ2386().solve(System.in);
	}

	private void solve(InputStream in) {
		Scanner sc = new Scanner(in);
		while (true) {
			int w = sc.nextInt();
			int h = sc.nextInt();
			if (w == 0 && h == 0) {
				return;
			}
			sc.nextLine();

			char[][] table = new char[w][h];
			for (int y = 0; y < h; y++) {
				String line = sc.nextLine();
				for (int x = 0; x < w; x++) {
					table[x][y] = line.charAt(x);
				}
			}

			int ans = 0;
			for (int y = 0; y < h; y++) {
				for (int x = 0; x < w; x++) {
					ans += removePool(x, y, w, h, table) ? 1 : 0;
				}
			}
			System.out.println(ans);
		}
	}

	private boolean removePool(int x, int y, int w, int h, char[][] table) {
		if (0 <= x && x < w && 0 <= y && y < h && table[x][y] == 'W') {
			table[x][y] = '.';
			for (int dx = -1; dx < 1; dx++) {
				for (int dy = -1; dy < 1; dy++) {
					removePool(x + dx, y + dy, w, h, table);
				}
			}
			return true;
		}
		return false;
	}
}
