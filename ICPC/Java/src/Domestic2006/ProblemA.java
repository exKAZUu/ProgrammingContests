package Domestic2006;

import java.io.InputStream;
import java.util.Scanner;

public class ProblemA {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		new ProblemA().solve(System.in);
	}

	boolean[] notPrime = new boolean[1024 * 1024];

	private void solve(InputStream in) {
		Scanner sc = new Scanner(in);

		int max = (int) Math.sqrt(notPrime.length);
		notPrime[1] = true;
		for (int i = 2; i < max; i++) {
			for (int j = i + i; j < notPrime.length; j += i) {
				notPrime[j] = true;
			}
		}

		while (true) {
			int a = sc.nextInt();
			int d = sc.nextInt();
			int n = sc.nextInt();

			if (a == 0) {
				break;
			}

			while (true) {
				if (isPrime(a)) {
					if (--n == 0) {
						break;
					}
				}
				a += d;
			}
			System.out.println(a);
		}
	}

	private boolean isPrime(int n) {
		return !notPrime[n];
	}

}
