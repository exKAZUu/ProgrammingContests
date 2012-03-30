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