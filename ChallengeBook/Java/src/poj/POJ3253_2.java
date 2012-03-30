package poj;

import java.io.InputStream;
import java.util.Comparator;
import java.util.PriorityQueue;
import java.util.Scanner;

public class POJ3253_2 {

	public static void main(String[] args) {
		new POJ3253_2().solve(System.in);
	}

	private void solve(InputStream in) {
		Scanner sc = new Scanner(in);
		while (true) {
			int N = sc.nextInt();
			PriorityQueue<Integer> queue = new PriorityQueue<Integer>(N,
					new Comparator<Integer>() {
						@Override
						public int compare(Integer i1, Integer i2) {
							return i2 - i1;
						}
					});
			for (int i = 0; i < N; i++) {
				queue.add(sc.nextInt());
			}

			int ans = 0;
			while (queue.size() >= 2) {
				int min = queue.poll();
				int min2 = queue.poll();
				ans += min + min2;
				queue.add(min + min2);
			}
			System.out.println(ans);
		}
	}
}
