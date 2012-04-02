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
using System.Globalization;
using System.IO;
using System.Linq;

namespace Codeforces.Codeforces114 {
	internal class ProblemC {
		//private static void Main(string[] args) {
		//    new ProblemC().Solve(Console.In);
		//}

		private void Solve(TextReader input) {
			var nad = input.ReadLine().Split(' ').Select(int.Parse).ToList();
			int n = nad[0];
			double a = nad[1];
			double d = nad[2];

			var lastTime = 0.0;
			for (int i = 0; i < n; i++) {
				var tv = input.ReadLine().Split(' ').Select(int.Parse).ToList();
				double startTime = tv[0];
				double maxSpeed = tv[1];

				var maxSpeedTime = maxSpeed / a;
				var time = startTime;
				var maxSpeedDistance = maxSpeedTime * maxSpeedTime * a / 2;
				if (maxSpeedDistance >= d) {
					time += Math.Sqrt(d * 2 / a);
				} else {
					time += maxSpeedTime;
					time += (d - maxSpeedDistance) / maxSpeed;
				}

				if (lastTime <= time) {
					lastTime = time;
				}
				Console.WriteLine(
						lastTime.ToString(new CultureInfo("ja-JP", false)));
			}
		}
	}
}