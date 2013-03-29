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

// Using my library: https://github.com/exKAZUu/Paraiba

namespace GoogleCodeJam.GCJ2012.Round2 {
	public class ProblemC {
		//public static void Main(string[] args) {
		//    new ProblemC().Solve(Console.In);
		//}

		private void Solve(TextReader reader) {
			var nTestCases = int.Parse(reader.ReadLine().Trim());
			var heights = new List<int>();
			var height = 1;
			while(height <= 1000000000) {
				heights.Add(height);
				height = (height * 2) + 1;
			}

			for (int iTestCases = 0; iTestCases < nTestCases; iTestCases++) {
				var nMoutains = int.Parse(reader.ReadLine().Trim());
				var views = reader.ReadLine().Split(' ').Select(int.Parse).ToList();

				for (int highest = 0; highest < nMoutains; highest++) {
					var biggers = new List<HashSet<int>>();
					for (int i = 0; i < nMoutains; i++) {
						biggers[i] = new HashSet<int>();
						if (i != highest) {
							biggers[i].Add(highest);
						}
					}

					var last = 0;
					for (int i = 0; i < nMoutains; i++) {
						if (i != highest) {
							if (views[i] > highest)
							{
								// fail
							}
							for (int j = last; j < i; j++) {
								if (i < views[j] && views[j] < views[i]) {
									// fail
								}
							}
						}
						else {
							highest = views[i];
						}
					}
				}

				Console.WriteLine((iTestCases + 1) + ": ");
			}
		}
	}
}