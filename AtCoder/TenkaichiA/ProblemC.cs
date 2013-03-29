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

namespace AtCoder.TenkaichiA {
	internal class ProblemC {
		//private static void Main(string[] args) {
		//    new ProblemC().Solve(Console.In);
		//}

		private void Solve(TextReader input) {
			var vs = input.ReadLine().Split(' ').Select(int.Parse).ToList();
			var nGroups = vs[0];
			var nRelations = vs[1];

			var fromTo = new byte[nGroups * nGroups / 8 + 1];
			var lastAnswered = new List<int>();

			for (int i = 0; i < nRelations; i++) {
				var ab = input.ReadLine().Split(' ').Select(int.Parse).ToList();
				var ft = (ab[0] - 1) * nGroups + (ab[1] - 1);
				fromTo[ft / 8] |= (byte)(1 << (ft % 8));
			}

			var msg = input.ReadLine() + '"';

			var index = msg.IndexOf("group") + 5;
			var endIndex = msg.IndexOf('"', index);
			var numberEndIndex = endIndex;
			var enemy = false;
			if (msg[endIndex - 1] == 'w') {
				enemy = true;
				numberEndIndex--;
			}
			var first = int.Parse(msg.Substring(index, numberEndIndex - index));
			for (int now = 1; now <= nGroups; now++) {
				var ft = (now - 1) * nGroups + (first - 1);
				if (((fromTo[ft / 8] & (byte)(1 << (ft % 8))) != 0) == enemy) {
					lastAnswered.Add(now);
				}
			}

			while ((endIndex = msg.IndexOf('"', endIndex + 1)) >= 0) {
				enemy = msg[endIndex - 1] == 'w';
				var nextAnswered = new List<int>();
				for (int now = 1; now <= nGroups; now++) {
					foreach (var before in lastAnswered) {
						var ft = (now - 1) * nGroups + (before - 1);
						if (((fromTo[ft / 8] & (byte)(1 << (ft % 8))) != 0) == enemy) {
							nextAnswered.Add(now);
							break;
						}
					}
				}
				lastAnswered = nextAnswered;
			}

			Console.WriteLine(lastAnswered.Count);
		}
	}
}