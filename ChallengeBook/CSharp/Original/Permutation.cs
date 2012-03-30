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