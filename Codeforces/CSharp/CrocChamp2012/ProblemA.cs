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
	internal class ProblemA {
		//private static void Main(string[] args) {
		//    new ProblemA().Solve(Console.In);
		//}

		private void Solve(TextReader input) {
			var n = int.Parse(input.ReadLine());
			var cmds1 = input.ReadLine();
			var cmds2 = input.ReadLine();

			var ans1 = 0;
			var ans2 = 0;

			var n2 = Math.Min(cmds1.Length * cmds2.Length, n);

			for (int i = 0; i < n2; i++) {
				var c1 = cmds1[i % cmds1.Length];
				var c2 = cmds2[i % cmds2.Length];
				if (c1 != c2) {
					if (c1 == 'P' && c2 == 'S') {
						ans1++;
					}
					else if (c1 == 'R' && c2 == 'P') {
						ans1++;
					}
					else if (c1 == 'S' && c2 == 'R') {
						ans1++;
					}
					else if (c1 == 'S' && c2 == 'P') {
						ans2++;
					}
					else if (c1 == 'P' && c2 == 'R') {
						ans2++;
					}
					else if (c1 == 'R' && c2 == 'S') {
						ans2++;
					}
				}
			}
			ans1 *= (n / n2);
			ans2 *= (n / n2);

			n2 = n % n2;
			for (int i = 0; i < n2; i++) {
				var c1 = cmds1[i % cmds1.Length];
				var c2 = cmds2[i % cmds2.Length];
				if (c1 != c2) {
					if (c1 == 'P' && c2 == 'S') {
						ans1++;
					}
					else if (c1 == 'R' && c2 == 'P') {
						ans1++;
					}
					else if (c1 == 'S' && c2 == 'R') {
						ans1++;
					}
					else if (c1 == 'S' && c2 == 'P') {
						ans2++;
					}
					else if (c1 == 'P' && c2 == 'R') {
						ans2++;
					}
					else if (c1 == 'R' && c2 == 'S') {
						ans2++;
					}
				}
			}

			Console.WriteLine(ans1 + " " + ans2);
		}
	}
}