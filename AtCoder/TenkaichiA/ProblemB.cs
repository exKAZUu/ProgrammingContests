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
using System.Text;

namespace AtCoder.TenkaichiA {
	internal class ProblemB {
		//private static void Main(string[] args) {
		//    new ProblemB().Solve(Console.In);
		//}

		private void Solve(TextReader input) {
			var text = input.ReadLine();
			var words = text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
			var ans = new StringBuilder();
			var delimiter = "";
			foreach (var word in words) {
				ans.Append(delimiter);
				ans.Append(word);
				delimiter = ",";
			}
			Console.WriteLine(ans);
		}
	}
}