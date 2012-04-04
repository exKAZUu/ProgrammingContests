package Domestic2011Practice;

import java.io.InputStream;
import java.util.Scanner;

public class ProblemA {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		new ProblemA().solve(System.in);
	}

	private void solve(InputStream in) {
		Scanner sc = new Scanner(in);
		
		boolean[] isLeft = new boolean[256];
		isLeft['q'] = true;
		isLeft['w'] = true;
		isLeft['e'] = true;
		isLeft['r'] = true;
		isLeft['t'] = true;

		isLeft['a'] = true;
		isLeft['s'] = true;
		isLeft['d'] = true;
		isLeft['f'] = true;
		isLeft['g'] = true;

		isLeft['z'] = true;
		isLeft['x'] = true;
		isLeft['c'] = true;
		isLeft['v'] = true;
		isLeft['b'] = true;

		while(true) {
			String line = sc.nextLine();
			if (line.equals("#")) {
				break;
			}
			
			boolean isLastLeft = isLeft[line.charAt(0)];
			int ans = 0;
			for (int i = 1; i < line.length(); i++) {
				if (isLastLeft != isLeft[line.charAt(i)]) {
					ans++;
					isLastLeft = isLeft[line.charAt(i)];
				}
			}
			
			System.out.println(ans);
		}
	}

}
