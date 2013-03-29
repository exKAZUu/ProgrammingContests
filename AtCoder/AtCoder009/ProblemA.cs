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

namespace AtCoder.AtCoder009 {
	internal class ProblemA {
		//private static void Main(string[] args) {
		//    new ProblemA().Solve(Console.In);
		//}

		private void Solve(TextReader input) {
			var sum = 0;
			var count = int.Parse(input.ReadLine());
			for (int i = 0; i < count; i++) {
				var countAndPrice = input.ReadLine().Split(' ').Select(int.Parse).ToArray();
				sum += countAndPrice[0] * countAndPrice[1];
			}

			Console.WriteLine((int)(sum * 1.05));
		}
	}
}