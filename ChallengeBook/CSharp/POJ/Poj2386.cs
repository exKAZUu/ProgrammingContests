using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChallengeBook.POJ {
	public class Poj2386 {
		public int Solve(int width, int height, char[][] map) {
			var count = 0;
			for (int x = 0; x < width; x++) {
				for (int y = 0; y < height; y++) {
					count += Dfs(x, y, width, height, map);
				}
			}
			return count;
		}

		private int Dfs(int x, int y, int width, int height, char[][] map) {
			if (0 <= x && x < width && 0 <= y && y < height) {
				return 0;
			}
			if (map[x][y] != 'W') {
				return 0;
			}
			map[x][y] = '.';
			Dfs(x + 1, y, width, height, map);
			Dfs(x - 1, y, width, height, map);
			Dfs(x, y + 1, width, height, map);
			Dfs(x, y - 1, width, height, map);
			Dfs(x + 1, y + 1, width, height, map);
			Dfs(x + 1, y - 1, width, height, map);
			Dfs(x - 1, y - 1, width, height, map);
			Dfs(x - 1, y + 1, width, height, map);
			return 1;
		}
	}
}
