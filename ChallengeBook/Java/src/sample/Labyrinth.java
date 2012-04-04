package sample;

import java.awt.Point;
import java.io.InputStream;
import java.util.LinkedList;

public class Labyrinth {

	private char[][] maze;
	private int N, M;
	private int sx, sy;
	private int gx, gy;
	private int[] dx = { 1, 0, -1, 0 };
	private int[] dy = { 0, 1, 0, -1 };
	private int[][] d;

	public static void main(String[] args) {
		new Labyrinth().solve(System.in);
	}

	private void solve(InputStream in) {
		while (true) {
			for (int x = 0; x < N; x++) {
				for (int y = 0; y < M; y++) {
					d[x][y] = Integer.MAX_VALUE / 2;
				}
			}
			int ans = bfs();
			System.out.println(ans);
		}
	}

	private int bfs() {
		LinkedList<Point> queue = new LinkedList<Point>();
		queue.push(new Point(sx, sy));
		d[sx][sy] = 0;

		while (!queue.isEmpty()) {
			Point p = queue.poll();
			if (p.x == gx && p.y == gy)
				break;

			for (int i = 0; i < 4; i++) {
				int nx = p.x + dx[i];
				int ny = p.y + dy[i];

				if (0 <= nx && nx < N && 0 <= ny && ny < M
						&& maze[nx][ny] != '#'
						&& d[nx][ny] == Integer.MAX_VALUE / 2) {
					queue.push(new Point(nx, ny));
					d[nx][ny] = d[p.x][p.y] + 1;
				}
			}
		}
		return d[sx][sy];
	}
}
