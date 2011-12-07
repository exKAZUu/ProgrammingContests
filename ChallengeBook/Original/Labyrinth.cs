using System;
using System.Collections.Generic;

namespace ChallengeBook.Original {
	public class Labyrinth {
		public int Solve(int width, int height, char[][] map) {
			int sx = 0, sy = 0, gx = 0, gy = 0;
			for (int x = 0; x < width; x++) {
				for (int y = 0; y < height; y++) {
					if (map[x][y] == 'S') {
						sx = x;
						sy = y;
					} else if (map[x][y] == 'G') {
						gx = x;
						gy = y;
					}
				}
			}

			var dxs = new[] { 1, -1, 0, 0 };
			var dys = new[] { 0, 0, 1, -1 };

			var que = new List<Tuple<int, int>>();
			que.Add(Tuple.Create(sx, sy));
			var count = 0;
			while (true) {
				var newQue = new List<Tuple<int, int>>();
				foreach (var xy in que) {
					if (xy.Item1 == gx && xy.Item2 == gy) {
						return count;
					}
					for (int i = 0; i < dxs.Length; i++) {
						var x = xy.Item1 + dxs[i];
						var y = xy.Item2 + dys[i];
						if (0 <= x && x < width && 0 <= y && y < height && map[x][y] != '#') {
							map[x][y] = '#';
							newQue.Add(Tuple.Create(x, y));
						}
					}
				}
				que = newQue;
				count++;
			}
		}
	}
}