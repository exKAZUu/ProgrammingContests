package poj;

import java.io.InputStream;
import java.util.Map.Entry;
import java.util.PriorityQueue;
import java.util.Scanner;
import java.util.TreeMap;

public class POJ2431 {
	public static void main(String[] args) {
		new POJ2431().solve(System.in);
	}

	private void solve(InputStream in) {
		TreeMap<Integer, Integer> treeMap = new TreeMap<Integer, Integer>();
		for (Entry<Integer, Integer> e : treeMap.entrySet()) {
			e.getKey();
			e.getValue();
		}

		Scanner sc = new Scanner(in);
		while (true) {
			int L = sc.nextInt();
			int P = sc.nextInt();
			int N = sc.nextInt();

			int[] as = new int[N + 1];
			for (int i = 0; i < N; i++) {
				as[i] = sc.nextInt();
			}
			as[N] = L;

			int[] bs = new int[N + 1];
			for (int i = 0; i < N; i++) {
				bs[i] = sc.nextInt();
			}
			bs[N] = 0;

			int ans = getCount(P, as, bs);
			System.out.println(ans);
		}
	}

	private int getCount(int P, int[] as, int[] bs) {
		PriorityQueue<Integer> queue = new PriorityQueue<Integer>();
		int count = 0;
		int last = 0;
		for (int i = 0; i < as.length; i++) {
			int consume = as[i] - last;
			while (P < consume) {
				if (queue.isEmpty()) {
					return -1;
				}
				P += queue.poll();
				count++;
			}
			queue.add(bs[i]);
			last = as[i];
		}
		return count;
	}

}
