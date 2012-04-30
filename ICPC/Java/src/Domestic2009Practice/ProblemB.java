package Domestic2009Practice;

import java.io.InputStream;
import java.util.ArrayList;
import java.util.Collections;
import java.util.Scanner;

public class ProblemB {

	public static void main(String[] args) {
		new ProblemB().solve(System.in);
	}

	private void solve(InputStream in) {

		ArrayList<Integer> primes = new ArrayList<Integer>();
		{
			boolean[] isPrime = new boolean[102000];
			for (int i = 0; i < isPrime.length; i++) {
				isPrime[i] = true;
			}
			isPrime[0] = false;
			isPrime[1] = false;

			int n = (int) Math.sqrt(isPrime.length);
			for (int i = 2; i <= n; i++) {
				if (!isPrime[i]) {
					continue;
				}
				for (int j = i + i; j < isPrime.length; j += i) {
					isPrime[j] = false;
				}
			}
			for (int i = 0; i < isPrime.length; i++) {
				if (isPrime[i]) {
					primes.add(i);
				}
			}
		}

		Scanner sc = new Scanner(in);
		while (true) {
			int N = sc.nextInt();
			int P = sc.nextInt();
			if (N == -1 && P == -1) {
				break;
			}

			ArrayList<Integer> values = new ArrayList<Integer>();
			int startIndex = 0;
			while (primes.get(startIndex) <= N) {
				startIndex++;
			}
			for (int i = 0; i < P; i++) {
				for (int j = i; j < P; j++) {
					values.add(primes.get(i + startIndex)
							+ primes.get(j + startIndex));
				}
			}

			Collections.sort(values);
			System.out.println(values.get(P - 1));
		}
	}
}
