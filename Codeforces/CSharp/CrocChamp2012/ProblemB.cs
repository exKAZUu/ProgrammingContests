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
using System.IO;
using System.Linq;

namespace Codeforces.CrocChamp2012 {
	internal class ProblemB {
		//private static void Main(string[] args) {
		//    new ProblemB().Solve(Console.In);
		//}

		private void Solve(TextReader input) {
			var hw = input.ReadLine().Split(' ').Select(int.Parse).ToList();
			var h = hw[0];
			var w = hw[1];

			var lines = Enumerable.Range(0, h)
					.Select(s => input.ReadLine().ToList())
					.ToList();

			var row = new bool[w];
			var column = new bool[h];
			var row2 = new bool[w];
			var column2 = new bool[h];
			for (int i = 0; i < row2.Length; i++) {
				row2[i] = true;
			}
			for (int i = 0; i < column2.Length; i++) {
				column2[i] = true;
			}
			column[0] = true;

			var ans = 0;

			while (true) {
				ans++;
				for (int y = 0; y < h; y++) {
					if (column[y]) {
						column2[y] = false;
						for (int x = 0; x < w; x++) {
							if (lines[y][x] == '#') {
								row[x] = true & row2[x];
							}
						}
					}
				}
				ans++;
				for (int x = 0; x < w; x++) {
					if (row[x]) {
						row2[x] = false;
						for (int y = 0; y < h; y++) {
							if (lines[y][x] == '#') {
								column[y] = true & column2[y];
								if (y == h - 1) {
									Console.WriteLine(ans);
									return;
								}
							}
						}
					}
				}
				if (w + h < ans) {
					Console.WriteLine(-1);
					return;
				}
			}
		}
	}
}