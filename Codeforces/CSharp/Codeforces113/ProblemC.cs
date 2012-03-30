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

namespace Codeforces {
	public class ProblemC {
		//public static void Main(string[] args) {
		//    new ProblemC().Solve(Console.In);
		//}

		private void Solve(TextReader input) {
			var nx = input.ReadLine().Split(' ').Select(int.Parse).ToList();
			var n = nx[0];
			var x = nx[1];

			var values = input.ReadLine().Split(' ').Select(int.Parse)
					.OrderBy(i => i)
					.ToList();

			var counts = new int[3];
			foreach (var value in values) {
				counts[value.CompareTo(x) + 1]++;
			}

			var mid = (values.Count - 1) / 2;
			if (values[mid] == x) {
				Console.WriteLine(0);
			} else if (values[mid] < x) {
				// 000xx2
				Console.WriteLine(counts[0] - (counts[2] + counts[1]) + 1);
			} else {
				// 0xx2222
				Console.WriteLine(counts[2] - (counts[0] + counts[1]));
			}
		}
	}
}