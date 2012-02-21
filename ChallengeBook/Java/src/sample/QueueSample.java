package sample;

import java.util.LinkedList;

public class QueueSample {

	public static void main(String[] args) {
		LinkedList<Integer> queue = new LinkedList<Integer>();
		queue.add(1);
		queue.add(2);
		queue.add(3);
		System.out.println(queue.peek());
		queue.poll();
		System.out.println(queue.peek());
		queue.poll();
		System.out.println(queue.peek());
		queue.poll();
	}

}
