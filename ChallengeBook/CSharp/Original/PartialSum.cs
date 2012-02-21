using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChallengeBook.Original {
	public class PartialSum {
		public bool Solve(int sum, IList<int> numbers) {
			return Dfs(0, sum, numbers);
		}

		private bool Dfs(int iNumbers, int remain, IList<int> numbers) {
			if (remain == 0) {
				return true;
			}
			if (iNumbers >= numbers.Count) {
				return false;
			}
			return Dfs(iNumbers + 1, remain - numbers[iNumbers], numbers) ||
				Dfs(iNumbers + 1, remain, numbers);
		}
	}
}
