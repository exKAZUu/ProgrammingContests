using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChallengeBook.POJ {
	public class Poj3069 {
		public int Solve(int[] xs, int radius) {
			var result = 0;

			var xlist = new List<int>(xs);
			xlist.Sort();

			var i = 0;
			while(i < xlist.Count) {
				var left = xlist[i++];
				while (i < xlist.Count && xlist[i] <= left + radius) {
					i++;
				}

				left = xlist[i - 1];
				while (i < xlist.Count && xlist[i] <= left + radius) {
					i++;
				}

				result++;
			}
			return result;
		}
	}
}
