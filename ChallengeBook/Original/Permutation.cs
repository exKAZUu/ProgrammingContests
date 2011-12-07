using System.Collections.Generic;

namespace ChallengeBook.Original {
	public class Permutation {
		private readonly bool[] used;
		private readonly int[] numbers;

		public Permutation(int n) {
			used = new bool[n];
			numbers = new int[n];
		}

		public IEnumerable<int[]> GetPermutations() {
			return GetPermutations(0);
		}

		private IEnumerable<int[]> GetPermutations(int iNumbers) {
			if (iNumbers == numbers.Length) {
				yield return numbers;
				yield break;
			}
			for (int i = 0; i < numbers.Length; i++) {
				if (used[i]) {
					continue;
				}
				used[i] = true;
				numbers[iNumbers] = i;
				foreach (var result in GetPermutations(iNumbers + 1)) {
					yield return result;
				}
				used[i] = false;
			}
		}
	}
}