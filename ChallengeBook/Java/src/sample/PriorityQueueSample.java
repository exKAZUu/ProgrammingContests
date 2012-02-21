package sample;

import java.util.Comparator;
import java.util.PriorityQueue;

public class PriorityQueueSample {
	public static void main(String[] args) {
		PriorityQueue<Integer> queue = new PriorityQueue<Integer>(8,
				new Comparator<Integer>() {
					@Override
					public int compare(Integer arg0, Integer arg1) {
						return arg1 - arg0;
					}
				});
		queue.add(3);
		queue.add(2);
		queue.add(1);
		System.out.println(queue.peek());
		queue.poll();
		System.out.println(queue.peek());
		queue.poll();
		System.out.println(queue.peek());
		queue.poll();
	}
}
