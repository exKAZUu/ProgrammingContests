package poj;

import java.io.InputStream;
import java.math.BigInteger;
import java.util.Scanner;

public class POJ3253 {
	public static void main(String[] args) {
		new POJ3253().solve(System.in);
	}

	private int N;
	private int L[];

	private void solve(InputStream in) {
		Scanner sc = new Scanner(in);
		N = sc.nextInt();
		L = new int[N];

		BigInteger ans = BigInteger.valueOf(0);

		while (N > 1) {
			boolean smallerLeft = L[0] <= L[1];
			int mii1 = smallerLeft ? 0 : 1;
			int mii2 = mii1 ^ 1;

			for (int i = 2; i < N; i++) {
				if (L[i] < L[mii1]) {
					mii2 = mii1;
					mii1 = i;
				} else if (L[i] < L[mii2]) {
					mii2 = i;
				}
			}
			
			int t = L[mii1] + L[mii2];
			ans = ans.add(BigInteger.valueOf(t));
			
			if (mii1 == N -1) {
				int tmp = mii1;
				mii1 = mii2;
				mii2 = tmp;
			}
			L[mii1] = t;
			L[mii2] = L[N - 1];
			N--;
		}
		
		System.out.println(ans);
	}
}
