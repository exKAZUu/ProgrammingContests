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

using System.Collections.Generic;

namespace ChallengeBook.Original {
	public class Lot {
		public bool Solve(int sum, IEnumerable<int> numbers) {
			var twoSums = new List<int>();
			foreach (var num1 in numbers) {
				foreach (var num2 in numbers) {
					twoSums.Add(num1 + num2);
				}
			}

			twoSums.Sort();

			foreach (var num1 in numbers) {
				foreach (var num2 in numbers) {
					var value = sum - num1 - num2;
					var index = BinarySearch(value, twoSums);
					if (twoSums[index] == value) {
						return true;
					}
				}
			}
			return false;
		}

		private int BinarySearch(int value, IList<int> values) {
			var left = -1;
			var right = values.Count - 1;
			while (right - left > 1) {
				var mid = (left + right) / 2;
				if (values[mid] <= value) {
					right = mid;
				} else {
					left = mid;
				}
			}
			return right;
		}
	}
}