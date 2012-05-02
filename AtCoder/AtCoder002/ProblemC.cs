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

namespace AtCoder.AtCoder002 {
	internal class ProblemC {
		//private static void Main(string[] args) {
		//    new ProblemC().Solve(Console.In);
		//}

		private void Solve(TextReader input) {
			var chars = "ABXY";
			var shortCommands = new List<string>();
			for (int i = 0; i < chars.Length; i++) {
				for (int j = 0; j < chars.Length; j++) {
					for (int k = 0; k < chars.Length; k++) {
						for (int l = 0; l < chars.Length; l++) {
							shortCommands.Add("" + chars[i] + chars[j] + chars[k] + chars[l]);
						}
					}
				}
			}

			input.ReadLine();
			var commands = input.ReadLine();

			var minLength = int.MaxValue;
			foreach (var shortCommand in shortCommands) {
				var length = GetLength(
						commands, shortCommand.Substring(0, 2), shortCommand.Substring(2, 2));
				minLength = Math.Min(minLength, length);
			}

			Console.WriteLine(minLength);
		}

		private int GetLength(
				string commands, string shortCommand1, string shortCommand2) {
			var count = 0;
			for (int i = 0; i < commands.Length - 1; i++) {
				if ((commands[i] == shortCommand1[0] && commands[i + 1] == shortCommand1[1]) ||
				    (commands[i] == shortCommand2[0] && commands[i + 1] == shortCommand2[1])
						) {
					count++;
					i++;
				}
			}
			return commands.Length - count;
		}
	}
}