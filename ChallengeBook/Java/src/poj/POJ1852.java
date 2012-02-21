package poj;

import java.io.InputStream;
import java.util.Scanner;

public class POJ1852 {

	public static void main(String[] args) {
		new POJ1852().solve(System.in);
	}

	private void solve(InputStream in) {
		Scanner sc = new Scanner(in);
		int nCases = sc.nextInt();
		for (int i = 0; i < nCases; i++) {
			int length = sc.nextInt();
			int nAnts = sc.nextInt();

			int maxTime = 0, minTime = 0;
			
			for (int j = 0; j < nAnts; j++) {
				int ant = sc.nextInt();
				maxTime = Math.max(maxTime, Math.max(ant, length - ant));
				minTime = Math.max(minTime, Math.min(ant, length - ant));
			}
			
			System.out.println(minTime + " " + maxTime);
		}
	}

}
