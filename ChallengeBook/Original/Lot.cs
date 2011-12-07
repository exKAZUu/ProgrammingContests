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