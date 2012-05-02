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

namespace AtCoder.AtCoder002 {
	internal class ProblemB {
		//private static void Main(string[] args) {
		//    new ProblemB().Solve(Console.In);
		//}

		private void Solve(TextReader input) {
			var ymd = input.ReadLine().Split('/').Select(int.Parse).ToList();
			var date = new DateTime(ymd[0], ymd[1], ymd[2]);
			while (date.Year % (date.Month * date.Day) != 0) {
				date = date.AddDays(1);
			}

			Console.WriteLine(date.ToString("yyyy/MM/dd"));
		}
	}
}