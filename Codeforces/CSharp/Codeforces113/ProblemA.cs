#region License

// Copyright (C) 2012 Kazunori Sakamoto
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
	internal class ProblemA {
		//private static void Main(string[] args) {
		//    new ProblemA().Solve(Console.In);
		//}

		private void Solve(TextReader input) {
			var nk = input.ReadLine().Split(' ').Select(int.Parse).ToList();
			var n = nk[0];
			var k = nk[1];

			var teams = Enumerable.Range(0, n)
					.Select(
							_ => {
								var pt = input.ReadLine().Split(' ').Select(int.Parse).ToList();
								return new { Problem = pt[0], Time = pt[1] };
							})
					.OrderByDescending(t => t.Problem * 100 - t.Time)
					.ToList();
			var target = teams[k - 1];
			Console.WriteLine(
					teams.Count(t => t.Problem == target.Problem && t.Time == target.Time));
		}
	}
}