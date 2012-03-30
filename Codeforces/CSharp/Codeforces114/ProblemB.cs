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

namespace Codeforces.Codeforces114 {
	internal class ProblemB {
		//private static void Main(string[] args) {
		//    new ProblemB().Solve(Console.In);
		//}

		private void Solve(TextReader input) {
			string line;
			var firstSharp = false;
			var firstNonSharp = false;
			while ((line = input.ReadLine()) != null) {
				if (line.TrimStart().StartsWith("#")) {
					if (firstSharp) {
						Console.WriteLine();
					}
					Console.Write(line);
					firstNonSharp = true;
				} else {
					if (firstNonSharp) {
						Console.WriteLine();
					}
					foreach (var ch in line.Trim()) {
						if (ch != ' ') {
							Console.Write(ch);
						}
					}
					firstNonSharp = false;
				}
				firstSharp = true;
			}
			Console.WriteLine();
		}
	}
}