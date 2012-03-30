#region License

// Copyright (C) 2011-2012 Kazunori Sakamoto
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

#endregion

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