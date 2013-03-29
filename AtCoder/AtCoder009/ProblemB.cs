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

namespace AtCoder.AtCoder009 {
	internal class ProblemB {
		//private static void Main(string[] args) {
		//    new ProblemB().Solve(Console.In);
		//}

		private void Solve(TextReader input) {
			var ns = input.ReadLine().Split(' ').ToArray();
			var ns2 = new[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j" };
			var ns3 = new[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
			var count = int.Parse(input.ReadLine());
			var vs = new List<string>();
			for (int i = 0; i < count; i++) {
				vs.Add(input.ReadLine().Trim());
			}
			var answer = vs.Select(
					v => {
						var result = v;
						foreach (var t in ns.Zip(ns2, Tuple.Create)) {
							result = result.Replace(t.Item1, t.Item2);
						}
						foreach (var t in ns2.Zip(ns3, Tuple.Create)) {
							result = result.Replace(t.Item1, t.Item2);
						}
						return Tuple.Create(v, result);
					}).Select(t => Tuple.Create(t.Item1, int.Parse(t.Item2))).OrderBy(t => t.Item2);
			foreach (var t in answer) {
				Console.WriteLine(t.Item1);
			}
		}
	}
}