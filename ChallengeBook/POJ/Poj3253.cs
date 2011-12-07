using System.Collections.Generic;

namespace ChallengeBook.POJ {
	public class Poj3253 {
		public int Solve(int[] lens) {
			var result = 0;

			var lenList = new List<int>(lens);
			lenList.Sort();
			for (int i = 1; i < lenList.Count; i++) {
				var newLen = lenList[i - 1] + lenList[i];
				result += newLen;
				var j = i + 1;
				for (; j < lenList.Count && lenList[j] < newLen; j++) {
					lenList[j - 1] = lenList[j];
				}
				lenList[j - 1] = newLen;
			}
			return result;
		}
	}
}