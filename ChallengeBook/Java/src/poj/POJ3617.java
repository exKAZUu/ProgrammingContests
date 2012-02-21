package poj;

import java.io.InputStream;
import java.util.Scanner;

public class POJ3617 {
	public static void main(String[] args) {
		new POJ3617().solve(System.in);
	}

	private void solve(InputStream in) {
		Scanner sc = new Scanner(in);
		while (true) {
			String s = sc.next();
			String t = "";
			int l = 0, r = s.length() - 1;
			while (l <= r) {
				boolean left = false;
				for (int i = 0; l + i <= r; i++) {
					if (s.charAt(l + i) < s.charAt(r - i)) {
						left = true;
						break;
					}
					if (s.charAt(l + i) > s.charAt(r - i)) {
						left = false;
						break;
					}
				}
				if (left) {
					t += s.charAt(l++);
				} else {
					t += s.charAt(r--);
				}
			}
			System.out.println(t);
		}
	}
}
