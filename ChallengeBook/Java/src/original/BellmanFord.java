package original;

import java.util.ArrayList;
import java.util.Comparator;
import java.util.PriorityQueue;

class Edge {
	int from;
	int to;
	int cost;
}

public class BellmanFord {
	private Edge[] es;
	private int[] d;
	private int V, E;

	public void shortest_path(int s) {
		for (int i = 0; i < V; i++) {
			d[i] = Integer.MAX_VALUE;
		}
		
		d[s] = 0;
		while (true) {
			boolean update = false;
			for (int i = 0; i < E; i++) {
				int f = es[i].from;
				if (d[f] != Integer.MAX_VALUE && d[f] + es[i].cost < d[es[i].to]) {
					d[es[i].to] = d[f] + es[i].to;
					update = true;
				}
			}
		}
	}
}

class Dijkstra {
	static class State {
		private int pos;
		private int cost;
		public State(int pos, int cost) {
			this.pos = pos;
			this.cost = cost;
		}
	}
	
	private int V;
	private ArrayList<Edge>[] G;
	private int[] d;
	
	void solve(int s) {
		PriorityQueue<State> queue = new PriorityQueue<State>(V, new Comparator<State>() {
			@Override
			public int compare(State s1, State s2) {
				return s1.cost - s2.cost;
			}
		});
		for (int i = 0; i < d.length; i++) {
			d[i] = Integer.MAX_VALUE;
		}
		
		queue.add(new State(s, 0));
		while(!queue.isEmpty()) {
			State state = queue.poll();
			if (d[state.pos] != Integer.MAX_VALUE) {
				continue;
			}
			d[state.pos] = state.cost;
			for (Edge e : G[state.pos]){
				queue.add(new State(e.to, state.cost + e.cost));
			}
		}
	}
}