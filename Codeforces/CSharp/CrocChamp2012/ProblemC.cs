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
using System.IO;
using System.Linq;

namespace Codeforces.CrocChamp2012 {
	internal class ProblemC {
		private List<List<int>> _lines;

		private static void Main(string[] args) {
			new ProblemC().Solve(Console.In);
		}

		private int GetSum(int k, int x, int y) {
			var sum = 0;
			var maxi = Math.Min(k, w);
			for (int i = 0; i < k; i++) {
				x++;
				sum += _lines[y][x];
			}
			k--;
			var dy = new[] { 1, -1 };
			var dx = new[] { -1, 1 };
			var count = 0;
			while (k > 0) {
				for (int i = 0; i < k; i++) {
					y += dy[count];
					sum += _lines[y][x];
				}
				for (int i = 0; i < k; i++) {
					x += dx[count];
					sum += _lines[y][x];
				}
				count ^= 1;
				k -= 2;
			}
			return sum;
		}

		private int h, w;

		private void Solve(TextReader input) {
			var hw = input.ReadLine().Split(' ').Select(int.Parse).ToList();
			h = hw[0];
			w = hw[1];

			_lines = Enumerable.Range(0, h)
					.Select(s => input.ReadLine().Split(' ').Select(int.Parse).ToList())
					.ToList();

			var maxk = Math.Min(h, w);
			maxk = (maxk & 1) == 1 ? maxk : maxk - 1;
			var ans = 0;
			for (int k = 3; k <= maxk; k += 2) {
				for (int y = 0; y + k <= h; y++) {
					ans = Math.Max(ans, GetSum(k, -1, y));
				}
			}
			Console.WriteLine(ans);
		}
	}
}