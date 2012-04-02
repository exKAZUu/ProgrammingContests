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

namespace TimeOfHumanLife {
	internal class TimeOfHumanLife {
		private static void Main(string[] args) {
			Solve(2000, 1, 1, 2003, 1, 1, 200);
		}

		public static void Solve(
				int year, int month, int day, int currentYear, int currentMonth,
				int currentDay, int age) {
			var startTime = new DateTime(year, month, day);
			var nowTime = new DateTime(currentYear, currentMonth, currentDay);
			var endTime = new DateTime(year + age, month, day);
			var allSpan = endTime - startTime;
			var span = nowTime - startTime;
			var daySpan = new TimeSpan(1, 0, 0, 0);
			var answerSpan = new TimeSpan(
					0, 0, 0,
					(int)(span.TotalSeconds * daySpan.TotalSeconds / allSpan.TotalSeconds));
			Console.WriteLine(
					answerSpan.Hours + "hours, " + answerSpan.Minutes + "mins, "
					+ answerSpan.Seconds + "secs");
		}
	}
}