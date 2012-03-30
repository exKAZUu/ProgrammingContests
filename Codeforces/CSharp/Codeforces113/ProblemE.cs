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

namespace Codeforces {
	public class ProblemE {
		//public static void Main(string[] args) {
		//    new ProblemE().Solve(Console.In);
		//}

		private void Solve(TextReader input) {
			//1:  0,  1
			//2:  3,  2 = 1 * 3, 0 + 1 * 2
			//3:  6,  7 = 2 * 3, 3 + 2 * 2
			//4: 21, 20 = 7 * 3, 6 + 7 * 2
			var n = int.Parse(input.ReadLine()) - 1;
			var d = 0L;
			var notD = 1L;
			for (int i = 0; i < n; i++) {
				var newD = notD * 3 % 1000000007;
				notD = (d + notD * 2) % 1000000007;
				d = newD;
			}
			Console.WriteLine(d);
		}
	}
}