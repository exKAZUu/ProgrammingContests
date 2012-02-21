package sample;

import java.util.ArrayList;
import java.util.Collections;
import java.util.Comparator;

class Task {
	public int start, end;

	public Task(int start, int end) {
		this.start = start;
		this.end = end;
	}
}

public class Schedule {
	public static void main(String[] args) {
		new Schedule().solve();
	}

	private void solve() {
		ArrayList<Task> tasks = new ArrayList<Task>();
		tasks.add(new Task(0, 2));
		tasks.add(new Task(1, 3));
		tasks.add(new Task(3, 5));
		tasks.add(new Task(4, 6));
		tasks.add(new Task(6, 8));
		
		Collections.sort(tasks, new Comparator<Task>() {
			@Override
			public int compare(Task t1, Task t2) {
				return t1.end - t2.end;
			}
		});
		
		int ans = 0;
		int time = -1;
		for (Task task : tasks) {
			if (time < task.start) {
				time = task.end;
				ans++;
			}
		}
		System.out.println(ans);
	}
}
